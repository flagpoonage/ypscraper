using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YPScraper
{
    public partial class BusinessDialog : Form
    {
        public BusinessDialog(YellowPagesBusinessListing listing)
        {
            InitializeComponent();

            this.Text = listing.BusinessName;
            this.nameLbl.Text = listing.BusinessName;
            this.addressLbl.Text = listing.StreetAddress;
            this.localityLbl.Text = listing.Locality;
            this.regionLbl.Text = listing.Region;
            this.countryLbl.Text = listing.Country;
            this.phoneLbl.Text = listing.Phone;
            this.faxLbl.Text = listing.FaxNumber;
            this.websiteLink.Text = listing.Website;
            this.emailLbl.Text = listing.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
