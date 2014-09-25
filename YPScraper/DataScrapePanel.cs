using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace YPScraper
{
    public partial class DataScrapePanel : UserControl
    {
        public bool IsScraped { get; set; }

        public string FilterString { get; set; }

        public YellowPagesInfoResults InfoScrape { get; set; }

        public YellowPagesDataScraper DataScraper { get; set; }

        private List<YellowPagesBusinessListing> listings;

        public BusinessDialog Dialog { get; set; }

        public List<YellowPagesBusinessListing> Listings
        {
            get
            {
                lock (locker)
                {
                    return this.listings;
                }
            }
            set
            {
                lock (locker)
                {
                    this.listings = value;
                }
            }
        }

        public object locker = new object();

        private int pagesScraped;
        public int PagesScraped
        {
            get
            {
                lock (locker)
                {
                    return this.pagesScraped;
                }
            }
            set
            {
                lock (locker)
                {
                    this.pagesScraped = value;
                }
            }
        }

        private int pagesRemain;
        public int PagesRemain
        {
            get
            {
                lock (locker)
                {
                    return this.pagesRemain;
                }
            }
            set
            {
                lock (locker)
                {
                    this.pagesRemain = value;
                }
            }
        }

        private int listingsFound;
        public int ListingsFound
        {
            get
            {
                lock (locker)
                {
                    return this.listingsFound;
                }
            }
            set
            {
                lock (locker)
                {
                    this.listingsFound = value;
                }
            }
        }

        private int listingsScraped;
        public int ListingsScraped
        {
            get
            {
                lock (locker)
                {
                    return this.listingsScraped;
                }
            }
            set
            {
                lock (locker)
                {
                    this.listingsScraped = value;
                }
            }
        }

        public DataScrapePanel()
        {
            InitializeComponent();

            this.businessList.DisplayMember = "BusinessName";
            this.businessList.ValueMember = "BusinessName";

            this.listings = new List<YellowPagesBusinessListing>();
        }

        public void SetInvalidInfoScrape()
        {
            this.InfoScrape = null;

            this.pSearchedTb.DSetText("0");
            this.pRemainTb.DSetText("0");
            this.tResultsTb.DSetText("0");
            this.lFoundTb.DSetText("0");
            this.lScrapedTb.DSetText("0");

            this.statusLbl.DSetText("No valid information could be scraped.");

            this.button1.DDisable();

            this.Restart();
        }

        public void LoadInfoScrape(YellowPagesInfoResults results)
        {
            this.InfoScrape = results;
            this.PagesRemain = this.InfoScrape.SearchPages.Count;

            this.pSearchedTb.DSetText("0");
            this.pRemainTb.DSetText(this.InfoScrape.SearchPages.Count.ToString());
            this.tResultsTb.DSetText(this.InfoScrape.Results.ToString());
            this.lFoundTb.DSetText("0");
            this.lScrapedTb.DSetText("0");

            this.statusLbl.DSetText("No data has been scraped.");

            this.button1.DEnable();

            this.Restart();
        }

        private void Restart()
        {
            this.PagesScraped = 0;
            this.ListingsFound = 0;
            this.listingsScraped = 0;
            this.listings = new List<YellowPagesBusinessListing>();
            this.businessList.DClearItems();
            this.IsScraped = false;
            this.button2.DDisable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Scraping data may take some time. Are you sure you want to continue?",
                "Confirm Scrape",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.DataScraper = new YellowPagesDataScraper(this.InfoScrape);

                this.DataScraper.ListingScraped += DataScraper_ListingScraped;
                this.DataScraper.ListingsFound += DataScraper_ListingsFound;
                this.DataScraper.Message += DataScraper_Message;
                this.DataScraper.PageAdded += DataScraper_PageAdded;
                this.DataScraper.PageScraped += DataScraper_PageScraped;

                this.button1.Enabled = false;
                this.button2.Enabled = false;

                this.DataScraper.FilterString = this.FilterString;

                Task.Factory.StartNew(() =>
                {
                    this.DataScraper.Begin();
                }).ContinueWith((t) =>
                {
                    button1.DEnable();
                    button2.DEnable();
                });
            }
        }

        void DataScraper_PageScraped()
        {
            this.PagesScraped = this.PagesScraped + 1;
            this.PagesRemain = this.PagesRemain - 1;

            this.pRemainTb.DSetText(this.PagesRemain.ToString());
            this.pSearchedTb.DSetText(this.PagesScraped.ToString());
        }

        void DataScraper_PageAdded(int amount)
        {
            this.PagesRemain = this.PagesRemain + 1;

            this.pRemainTb.DSetText(this.PagesRemain.ToString());
        }

        void DataScraper_Message(string message)
        {
            this.statusLbl.DSetText(message);
        }

        void DataScraper_ListingsFound(int amount)
        {
            this.ListingsFound = this.ListingsFound + amount;

            this.lFoundTb.DSetText(this.ListingsFound.ToString());
        }

        void DataScraper_ListingScraped(YellowPagesBusinessListing listing)
        {
            this.ListingsScraped = this.ListingsScraped + 1;

            this.Listings.Add(listing);

            this.businessList.DAddItem(listing);

            this.lScrapedTb.DSetText(this.listingsScraped.ToString());
        }

        private void businessList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = (YellowPagesBusinessListing)this.businessList.SelectedItem;

            if(item == null)
            {
                return;
            }

            var bd = new BusinessDialog(item);

            bd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var currentPath = new FileInfo(Assembly.GetEntryAssembly().Location).Directory.FullName;

                var currentTime = DateTime.Now.ToString("HH-mm-ss_dd-MM-yyyy");

                var dName = string.Format("ypscrape_{0}", currentTime);

                var path = Path.Combine(currentPath, dName);

                Directory.CreateDirectory(path);

                var csv = new CSVBuilder().CreateCSVFile(this.Listings);

                var file = Path.Combine(path, "scrape_data.csv");

                using (var sw = new StreamWriter(file, false))
                {
                    sw.Write(csv);
                }

                MessageBox.Show(string.Format("Exported to folder: \r\n\r\n{0}", dName), "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed!\r\n\r\n" + ex.Message, "Export failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
