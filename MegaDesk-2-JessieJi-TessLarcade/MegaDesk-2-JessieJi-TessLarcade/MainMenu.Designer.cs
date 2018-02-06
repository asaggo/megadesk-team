namespace MegaDesk_4_JessieJi
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddNewQuotesStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchQuotesStart = new System.Windows.Forms.Button();
            this.btnViewQuotesStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewQuotesStart
            // 
            this.btnAddNewQuotesStart.Location = new System.Drawing.Point(12, 12);
            this.btnAddNewQuotesStart.Name = "btnAddNewQuotesStart";
            this.btnAddNewQuotesStart.Size = new System.Drawing.Size(120, 30);
            this.btnAddNewQuotesStart.TabIndex = 0;
            this.btnAddNewQuotesStart.Text = "Add New Quotes";
            this.btnAddNewQuotesStart.UseVisualStyleBackColor = true;
            this.btnAddNewQuotesStart.Click += new System.EventHandler(this.addNewQuotesButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchQuotesStart
            // 
            this.btnSearchQuotesStart.Location = new System.Drawing.Point(12, 84);
            this.btnSearchQuotesStart.Name = "btnSearchQuotesStart";
            this.btnSearchQuotesStart.Size = new System.Drawing.Size(120, 30);
            this.btnSearchQuotesStart.TabIndex = 2;
            this.btnSearchQuotesStart.Text = "Search Quotes";
            this.btnSearchQuotesStart.UseVisualStyleBackColor = true;
            this.btnSearchQuotesStart.Click += new System.EventHandler(this.btnSearchQuotesStart_Click);
            // 
            // btnViewQuotesStart
            // 
            this.btnViewQuotesStart.Location = new System.Drawing.Point(12, 48);
            this.btnViewQuotesStart.Name = "btnViewQuotesStart";
            this.btnViewQuotesStart.Size = new System.Drawing.Size(120, 30);
            this.btnViewQuotesStart.TabIndex = 3;
            this.btnViewQuotesStart.Text = "View Quotes";
            this.btnViewQuotesStart.UseVisualStyleBackColor = true;
            this.btnViewQuotesStart.Click += new System.EventHandler(this.btnViewQuotesStart_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnViewQuotesStart);
            this.Controls.Add(this.btnSearchQuotesStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNewQuotesStart);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewQuotesStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchQuotesStart;
        private System.Windows.Forms.Button btnViewQuotesStart;
    }
}

