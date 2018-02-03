namespace MegaDesk_4_JessieJi
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDrawerBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deskWidthBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deskDepthBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnAddNewQuote = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.surfMtrlBox = new System.Windows.Forms.ComboBox();
            this.rushOrderBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSizePrice = new System.Windows.Forms.Label();
            this.lblNumDrawerPrice = new System.Windows.Forms.Label();
            this.lblSurfMtrlPrice = new System.Windows.Forms.Label();
            this.lblRushOrderPrice = new System.Windows.Forms.Label();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // custNameBox
            // 
            this.custNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameBox.Location = new System.Drawing.Point(131, 12);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(141, 23);
            this.custNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rush Order Option:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surface Material:";
            // 
            // numDrawerBox
            // 
            this.numDrawerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawerBox.Location = new System.Drawing.Point(202, 89);
            this.numDrawerBox.Name = "numDrawerBox";
            this.numDrawerBox.Size = new System.Drawing.Size(59, 23);
            this.numDrawerBox.TabIndex = 7;
            this.numDrawerBox.Validating += new System.ComponentModel.CancelEventHandler(this.numDrawerBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desk Information";
            // 
            // deskWidthBox
            // 
            this.deskWidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthBox.Location = new System.Drawing.Point(77, 62);
            this.deskWidthBox.Name = "deskWidthBox";
            this.deskWidthBox.Size = new System.Drawing.Size(59, 23);
            this.deskWidthBox.TabIndex = 8;
            this.deskWidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.deskWidthBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Depth:";
            // 
            // deskDepthBox
            // 
            this.deskDepthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthBox.Location = new System.Drawing.Point(202, 62);
            this.deskDepthBox.Name = "deskDepthBox";
            this.deskDepthBox.Size = new System.Drawing.Size(59, 23);
            this.deskDepthBox.TabIndex = 10;
            this.deskDepthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deskDepthBox_Validating);
            this.deskDepthBox.Leave += new System.EventHandler(this.checkDeskDepthValue);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of Drawer:  x $50";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(15, 215);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(96, 43);
            this.btnBackToMenu.TabIndex = 13;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuote.Location = new System.Drawing.Point(117, 215);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(112, 43);
            this.btnAddNewQuote.TabIndex = 14;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = true;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // surfMtrlBox
            // 
            this.surfMtrlBox.FormattingEnabled = true;
            this.surfMtrlBox.Location = new System.Drawing.Point(151, 118);
            this.surfMtrlBox.Name = "surfMtrlBox";
            this.surfMtrlBox.Size = new System.Drawing.Size(121, 21);
            this.surfMtrlBox.TabIndex = 17;
            // 
            // rushOrderBox
            // 
            this.rushOrderBox.FormattingEnabled = true;
            this.rushOrderBox.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days",
            "No rush (14 days)"});
            this.rushOrderBox.Location = new System.Drawing.Point(151, 146);
            this.rushOrderBox.Name = "rushOrderBox";
            this.rushOrderBox.Size = new System.Drawing.Size(121, 21);
            this.rushOrderBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Price:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(129, 176);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(24, 25);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Price";
            // 
            // lblSizePrice
            // 
            this.lblSizePrice.AutoSize = true;
            this.lblSizePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizePrice.Location = new System.Drawing.Point(285, 62);
            this.lblSizePrice.Name = "lblSizePrice";
            this.lblSizePrice.Size = new System.Drawing.Size(16, 17);
            this.lblSizePrice.TabIndex = 22;
            this.lblSizePrice.Text = "$";
            // 
            // lblNumDrawerPrice
            // 
            this.lblNumDrawerPrice.AutoSize = true;
            this.lblNumDrawerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDrawerPrice.Location = new System.Drawing.Point(285, 89);
            this.lblNumDrawerPrice.Name = "lblNumDrawerPrice";
            this.lblNumDrawerPrice.Size = new System.Drawing.Size(16, 17);
            this.lblNumDrawerPrice.TabIndex = 23;
            this.lblNumDrawerPrice.Text = "$";
            // 
            // lblSurfMtrlPrice
            // 
            this.lblSurfMtrlPrice.AutoSize = true;
            this.lblSurfMtrlPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurfMtrlPrice.Location = new System.Drawing.Point(285, 118);
            this.lblSurfMtrlPrice.Name = "lblSurfMtrlPrice";
            this.lblSurfMtrlPrice.Size = new System.Drawing.Size(16, 17);
            this.lblSurfMtrlPrice.TabIndex = 24;
            this.lblSurfMtrlPrice.Text = "$";
            // 
            // lblRushOrderPrice
            // 
            this.lblRushOrderPrice.AutoSize = true;
            this.lblRushOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRushOrderPrice.Location = new System.Drawing.Point(285, 150);
            this.lblRushOrderPrice.Name = "lblRushOrderPrice";
            this.lblRushOrderPrice.Size = new System.Drawing.Size(16, 17);
            this.lblRushOrderPrice.TabIndex = 25;
            this.lblRushOrderPrice.Text = "$";
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPrice.Location = new System.Drawing.Point(235, 215);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(112, 43);
            this.btnGetPrice.TabIndex = 26;
            this.btnGetPrice.Text = "Get Price";
            this.btnGetPrice.UseVisualStyleBackColor = true;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(213, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Base Price $200";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 266);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGetPrice);
            this.Controls.Add(this.lblRushOrderPrice);
            this.Controls.Add(this.lblSurfMtrlPrice);
            this.Controls.Add(this.lblNumDrawerPrice);
            this.Controls.Add(this.lblSizePrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rushOrderBox);
            this.Controls.Add(this.surfMtrlBox);
            this.Controls.Add(this.btnAddNewQuote);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deskDepthBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deskWidthBox);
            this.Controls.Add(this.numDrawerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numDrawerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deskWidthBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deskDepthBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnAddNewQuote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox surfMtrlBox;
        private System.Windows.Forms.ComboBox rushOrderBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblRushOrderPrice;
        private System.Windows.Forms.Label lblSurfMtrlPrice;
        private System.Windows.Forms.Label lblNumDrawerPrice;
        private System.Windows.Forms.Label lblSizePrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.Label label10;
    }
}