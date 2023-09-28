namespace MegaDesk_JuliaLassig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.mainMenu = new System.Windows.Forms.Button();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custNameInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.numDrawersInput = new System.Windows.Forms.ComboBox();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.rushOrderInput = new System.Windows.Forms.ComboBox();
            this.addQuoteTitle = new System.Windows.Forms.Label();
            this.submitQuoteButton = new System.Windows.Forms.Button();
            this.addQuoteGroupBox = new System.Windows.Forms.GroupBox();
            this.depthError = new System.Windows.Forms.Label();
            this.widthError = new System.Windows.Forms.Label();
            this.quoteDate = new System.Windows.Forms.Label();
            this.quoteDateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addQuoteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(209)))), ((int)(((byte)(216)))));
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(81, 694);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(182, 60);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "&Main Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameLabel.Location = new System.Drawing.Point(41, 46);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(182, 24);
            this.custNameLabel.TabIndex = 3;
            this.custNameLabel.Text = "Customer full name: ";
            // 
            // custNameInput
            // 
            this.custNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameInput.Location = new System.Drawing.Point(353, 41);
            this.custNameInput.Name = "custNameInput";
            this.custNameInput.Size = new System.Drawing.Size(100, 29);
            this.custNameInput.TabIndex = 4;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(85, 104);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(138, 24);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Desk width (in):";
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.Location = new System.Drawing.Point(353, 99);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 29);
            this.widthInput.TabIndex = 6;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderLabel.Location = new System.Drawing.Point(49, 356);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(174, 24);
            this.rushOrderLabel.TabIndex = 7;
            this.rushOrderLabel.Text = "Rush Order (days): ";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(65, 292);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(158, 24);
            this.materialLabel.TabIndex = 8;
            this.materialLabel.Text = "Desktop material: ";
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersLabel.Location = new System.Drawing.Point(40, 223);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(183, 24);
            this.numDrawersLabel.TabIndex = 9;
            this.numDrawersLabel.Text = "Number of Drawers: ";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(81, 164);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(142, 24);
            this.depthLabel.TabIndex = 10;
            this.depthLabel.Text = "Desk depth (in):";
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthInput.Location = new System.Drawing.Point(353, 159);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(100, 29);
            this.depthInput.TabIndex = 11;
            this.depthInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.depthInput_KeyUp);
            // 
            // numDrawersInput
            // 
            this.numDrawersInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numDrawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersInput.FormattingEnabled = true;
            this.numDrawersInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numDrawersInput.Location = new System.Drawing.Point(353, 215);
            this.numDrawersInput.Name = "numDrawersInput";
            this.numDrawersInput.Size = new System.Drawing.Size(121, 32);
            this.numDrawersInput.TabIndex = 12;
            // 
            // materialInput
            // 
            this.materialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.materialInput.Location = new System.Drawing.Point(353, 284);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(121, 32);
            this.materialInput.TabIndex = 13;
            // 
            // rushOrderInput
            // 
            this.rushOrderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderInput.FormattingEnabled = true;
            this.rushOrderInput.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.rushOrderInput.Location = new System.Drawing.Point(353, 348);
            this.rushOrderInput.Name = "rushOrderInput";
            this.rushOrderInput.Size = new System.Drawing.Size(121, 32);
            this.rushOrderInput.TabIndex = 14;
            // 
            // addQuoteTitle
            // 
            this.addQuoteTitle.AutoSize = true;
            this.addQuoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteTitle.Location = new System.Drawing.Point(235, 150);
            this.addQuoteTitle.Name = "addQuoteTitle";
            this.addQuoteTitle.Size = new System.Drawing.Size(166, 26);
            this.addQuoteTitle.TabIndex = 15;
            this.addQuoteTitle.Text = "Create a Quote:";
            // 
            // submitQuoteButton
            // 
            this.submitQuoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(209)))), ((int)(((byte)(216)))));
            this.submitQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitQuoteButton.Location = new System.Drawing.Point(434, 694);
            this.submitQuoteButton.Name = "submitQuoteButton";
            this.submitQuoteButton.Size = new System.Drawing.Size(182, 60);
            this.submitQuoteButton.TabIndex = 16;
            this.submitQuoteButton.Text = "Submit Quote";
            this.submitQuoteButton.UseVisualStyleBackColor = false;
            this.submitQuoteButton.Click += new System.EventHandler(this.submitQuoteButton_Click);
            // 
            // addQuoteGroupBox
            // 
            this.addQuoteGroupBox.Controls.Add(this.depthError);
            this.addQuoteGroupBox.Controls.Add(this.widthError);
            this.addQuoteGroupBox.Controls.Add(this.quoteDate);
            this.addQuoteGroupBox.Controls.Add(this.quoteDateLabel);
            this.addQuoteGroupBox.Controls.Add(this.custNameLabel);
            this.addQuoteGroupBox.Controls.Add(this.custNameInput);
            this.addQuoteGroupBox.Controls.Add(this.widthInput);
            this.addQuoteGroupBox.Controls.Add(this.rushOrderLabel);
            this.addQuoteGroupBox.Controls.Add(this.rushOrderInput);
            this.addQuoteGroupBox.Controls.Add(this.widthLabel);
            this.addQuoteGroupBox.Controls.Add(this.materialLabel);
            this.addQuoteGroupBox.Controls.Add(this.materialInput);
            this.addQuoteGroupBox.Controls.Add(this.depthLabel);
            this.addQuoteGroupBox.Controls.Add(this.numDrawersInput);
            this.addQuoteGroupBox.Controls.Add(this.depthInput);
            this.addQuoteGroupBox.Controls.Add(this.numDrawersLabel);
            this.addQuoteGroupBox.Location = new System.Drawing.Point(81, 179);
            this.addQuoteGroupBox.Name = "addQuoteGroupBox";
            this.addQuoteGroupBox.Size = new System.Drawing.Size(535, 486);
            this.addQuoteGroupBox.TabIndex = 17;
            this.addQuoteGroupBox.TabStop = false;
            // 
            // depthError
            // 
            this.depthError.AutoSize = true;
            this.depthError.ForeColor = System.Drawing.Color.IndianRed;
            this.depthError.Location = new System.Drawing.Point(300, 191);
            this.depthError.Name = "depthError";
            this.depthError.Size = new System.Drawing.Size(56, 13);
            this.depthError.TabIndex = 18;
            this.depthError.Text = "depthError";
            // 
            // widthError
            // 
            this.widthError.AutoSize = true;
            this.widthError.ForeColor = System.Drawing.Color.IndianRed;
            this.widthError.Location = new System.Drawing.Point(302, 131);
            this.widthError.Name = "widthError";
            this.widthError.Size = new System.Drawing.Size(54, 13);
            this.widthError.TabIndex = 17;
            this.widthError.Text = "widthError";
            this.widthError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quoteDate
            // 
            this.quoteDate.AutoSize = true;
            this.quoteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteDate.Location = new System.Drawing.Point(349, 419);
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.Size = new System.Drawing.Size(60, 24);
            this.quoteDate.TabIndex = 16;
            this.quoteDate.Text = "label1";
            // 
            // quoteDateLabel
            // 
            this.quoteDateLabel.AutoSize = true;
            this.quoteDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteDateLabel.Location = new System.Drawing.Point(108, 419);
            this.quoteDateLabel.Name = "quoteDateLabel";
            this.quoteDateLabel.Size = new System.Drawing.Size(115, 24);
            this.quoteDateLabel.TabIndex = 15;
            this.quoteDateLabel.Text = "Quote Date: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(684, 791);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addQuoteGroupBox);
            this.Controls.Add(this.submitQuoteButton);
            this.Controls.Add(this.addQuoteTitle);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.ShowInTaskbar = false;
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.addQuoteGroupBox.ResumeLayout(false);
            this.addQuoteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.TextBox custNameInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label numDrawersLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.ComboBox numDrawersInput;

        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.ComboBox rushOrderInput;
        private System.Windows.Forms.Label addQuoteTitle;
        private System.Windows.Forms.Button submitQuoteButton;
        private System.Windows.Forms.GroupBox addQuoteGroupBox;
        private System.Windows.Forms.Label quoteDateLabel;
        private System.Windows.Forms.Label quoteDate;
        private System.Windows.Forms.Label widthError;
        private System.Windows.Forms.Label depthError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}