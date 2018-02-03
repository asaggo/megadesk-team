namespace MegaDesk_4_JessieJi
{
    partial class SearchQuotes
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
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listQuotes = new System.Windows.Forms.ListView();
            this.customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deskWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deskDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numDrawers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rushOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 228);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(96, 43);
            this.btnBackToMenu.TabIndex = 15;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(141, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 24);
            this.searchBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search by Material";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(400, 228);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 43);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search Quote";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listQuotes
            // 
            this.listQuotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customer,
            this.deskWidth,
            this.deskDepth,
            this.numDrawers,
            this.mtrl,
            this.rushOrder,
            this.date});
            this.listQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQuotes.FullRowSelect = true;
            this.listQuotes.GridLines = true;
            this.listQuotes.Location = new System.Drawing.Point(12, 38);
            this.listQuotes.MultiSelect = false;
            this.listQuotes.Name = "listQuotes";
            this.listQuotes.Size = new System.Drawing.Size(484, 184);
            this.listQuotes.TabIndex = 19;
            this.listQuotes.UseCompatibleStateImageBehavior = false;
            this.listQuotes.View = System.Windows.Forms.View.Details;
            // 
            // customer
            // 
            this.customer.Text = "Customer";
            // 
            // deskWidth
            // 
            this.deskWidth.Text = "Width";
            this.deskWidth.Width = 47;
            // 
            // deskDepth
            // 
            this.deskDepth.Text = "Depth";
            this.deskDepth.Width = 50;
            // 
            // numDrawers
            // 
            this.numDrawers.Text = "# Drawer";
            this.numDrawers.Width = 66;
            // 
            // mtrl
            // 
            this.mtrl.Text = "Material";
            // 
            // rushOrder
            // 
            this.rushOrder.Text = "In Rush?";
            this.rushOrder.Width = 63;
            // 
            // date
            // 
            this.date.Text = "Date";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 283);
            this.Controls.Add(this.listQuotes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnBackToMenu);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listQuotes;
        private System.Windows.Forms.ColumnHeader customer;
        private System.Windows.Forms.ColumnHeader deskWidth;
        private System.Windows.Forms.ColumnHeader deskDepth;
        private System.Windows.Forms.ColumnHeader numDrawers;
        private System.Windows.Forms.ColumnHeader mtrl;
        private System.Windows.Forms.ColumnHeader rushOrder;
        private System.Windows.Forms.ColumnHeader date;
    }
}