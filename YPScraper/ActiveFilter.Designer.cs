using System;
namespace YPScraper
{
    partial class ActiveFilter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterNameLbl = new System.Windows.Forms.Label();
            this.filterValueLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter Value";
            // 
            // filterNameLbl
            // 
            this.filterNameLbl.AutoSize = true;
            this.filterNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterNameLbl.Location = new System.Drawing.Point(14, 24);
            this.filterNameLbl.Name = "filterNameLbl";
            this.filterNameLbl.Size = new System.Drawing.Size(58, 13);
            this.filterNameLbl.TabIndex = 2;
            this.filterNameLbl.Text = "unknown";
            // 
            // filterValueLbl
            // 
            this.filterValueLbl.AutoSize = true;
            this.filterValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterValueLbl.Location = new System.Drawing.Point(213, 24);
            this.filterValueLbl.Name = "filterValueLbl";
            this.filterValueLbl.Size = new System.Drawing.Size(58, 13);
            this.filterValueLbl.TabIndex = 3;
            this.filterValueLbl.Text = "unknown";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActiveFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterValueLbl);
            this.Controls.Add(this.filterNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActiveFilter";
            this.Size = new System.Drawing.Size(649, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filterNameLbl;
        private System.Windows.Forms.Label filterValueLbl;
        private System.Windows.Forms.Button button1;
    }
}
