namespace MegaDesk_3_JessieJi
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
            this.surfMaterialBox = new System.Windows.Forms.TextBox();
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
            this.rushOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.rbtnSevenDays = new System.Windows.Forms.RadioButton();
            this.rbtnFiveDays = new System.Windows.Forms.RadioButton();
            this.rbtnThreeDays = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rushOrderGroupBox.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rush Order Option";
            // 
            // surfMaterialBox
            // 
            this.surfMaterialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfMaterialBox.Location = new System.Drawing.Point(151, 115);
            this.surfMaterialBox.Name = "surfMaterialBox";
            this.surfMaterialBox.Size = new System.Drawing.Size(110, 23);
            this.surfMaterialBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 115);
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
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of Drawer:";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(15, 206);
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
            this.btnAddNewQuote.Location = new System.Drawing.Point(160, 206);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(112, 43);
            this.btnAddNewQuote.TabIndex = 14;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = true;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // rushOrderGroupBox
            // 
            this.rushOrderGroupBox.Controls.Add(this.rbtnSevenDays);
            this.rushOrderGroupBox.Controls.Add(this.rbtnFiveDays);
            this.rushOrderGroupBox.Controls.Add(this.rbtnThreeDays);
            this.rushOrderGroupBox.Location = new System.Drawing.Point(26, 163);
            this.rushOrderGroupBox.Name = "rushOrderGroupBox";
            this.rushOrderGroupBox.Size = new System.Drawing.Size(235, 37);
            this.rushOrderGroupBox.TabIndex = 15;
            this.rushOrderGroupBox.TabStop = false;
            // 
            // rbtnSevenDays
            // 
            this.rbtnSevenDays.AutoSize = true;
            this.rbtnSevenDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSevenDays.Location = new System.Drawing.Point(161, 14);
            this.rbtnSevenDays.Name = "rbtnSevenDays";
            this.rbtnSevenDays.Size = new System.Drawing.Size(68, 21);
            this.rbtnSevenDays.TabIndex = 2;
            this.rbtnSevenDays.TabStop = true;
            this.rbtnSevenDays.Text = "7 days";
            this.rbtnSevenDays.UseVisualStyleBackColor = true;
            // 
            // rbtnFiveDays
            // 
            this.rbtnFiveDays.AutoSize = true;
            this.rbtnFiveDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiveDays.Location = new System.Drawing.Point(84, 14);
            this.rbtnFiveDays.Name = "rbtnFiveDays";
            this.rbtnFiveDays.Size = new System.Drawing.Size(68, 21);
            this.rbtnFiveDays.TabIndex = 1;
            this.rbtnFiveDays.TabStop = true;
            this.rbtnFiveDays.Text = "5 days";
            this.rbtnFiveDays.UseVisualStyleBackColor = true;
            // 
            // rbtnThreeDays
            // 
            this.rbtnThreeDays.AutoSize = true;
            this.rbtnThreeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnThreeDays.Location = new System.Drawing.Point(10, 14);
            this.rbtnThreeDays.Name = "rbtnThreeDays";
            this.rbtnThreeDays.Size = new System.Drawing.Size(68, 21);
            this.rbtnThreeDays.TabIndex = 0;
            this.rbtnThreeDays.TabStop = true;
            this.rbtnThreeDays.Text = "3 days";
            this.rbtnThreeDays.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rushOrderGroupBox);
            this.Controls.Add(this.btnAddNewQuote);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deskDepthBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deskWidthBox);
            this.Controls.Add(this.numDrawerBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surfMaterialBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.rushOrderGroupBox.ResumeLayout(false);
            this.rushOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surfMaterialBox;
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
        private System.Windows.Forms.GroupBox rushOrderGroupBox;
        private System.Windows.Forms.RadioButton rbtnSevenDays;
        private System.Windows.Forms.RadioButton rbtnFiveDays;
        private System.Windows.Forms.RadioButton rbtnThreeDays;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}