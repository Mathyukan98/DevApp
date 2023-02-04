namespace DepApp
{
    partial class Register
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
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.comboBoxDesignation = new System.Windows.Forms.ComboBox();
            this.txtBoxCnfrmPWord = new System.Windows.Forms.TextBox();
            this.lblCnfrmPWord = new System.Windows.Forms.Label();
            this.lnklblLogin = new System.Windows.Forms.LinkLabel();
            this.lblRegister = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(205, 309);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(149, 20);
            this.txtBoxEmail.TabIndex = 53;
            this.txtBoxEmail.Validated += new System.EventHandler(this.txtBoxEmail_Validated);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(87, 316);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Email";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(87, 269);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 51;
            this.lblDesignation.Text = "Designation";
            // 
            // comboBoxDesignation
            // 
            this.comboBoxDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDesignation.FormattingEnabled = true;
            this.comboBoxDesignation.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.comboBoxDesignation.Location = new System.Drawing.Point(205, 261);
            this.comboBoxDesignation.Name = "comboBoxDesignation";
            this.comboBoxDesignation.Size = new System.Drawing.Size(149, 21);
            this.comboBoxDesignation.TabIndex = 50;
            // 
            // txtBoxCnfrmPWord
            // 
            this.txtBoxCnfrmPWord.Location = new System.Drawing.Point(205, 217);
            this.txtBoxCnfrmPWord.Name = "txtBoxCnfrmPWord";
            this.txtBoxCnfrmPWord.Size = new System.Drawing.Size(149, 20);
            this.txtBoxCnfrmPWord.TabIndex = 48;
            // 
            // lblCnfrmPWord
            // 
            this.lblCnfrmPWord.AutoSize = true;
            this.lblCnfrmPWord.Location = new System.Drawing.Point(87, 224);
            this.lblCnfrmPWord.Name = "lblCnfrmPWord";
            this.lblCnfrmPWord.Size = new System.Drawing.Size(91, 13);
            this.lblCnfrmPWord.TabIndex = 47;
            this.lblCnfrmPWord.Text = "Confirm Password";
            // 
            // lnklblLogin
            // 
            this.lnklblLogin.AutoSize = true;
            this.lnklblLogin.Location = new System.Drawing.Point(75, 406);
            this.lnklblLogin.Name = "lnklblLogin";
            this.lnklblLogin.Size = new System.Drawing.Size(33, 13);
            this.lnklblLogin.TabIndex = 46;
            this.lnklblLogin.TabStop = true;
            this.lnklblLogin.Text = "Login";
            this.lnklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLogin_LinkClicked);
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblRegister.Location = new System.Drawing.Point(363, 398);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(83, 29);
            this.lblRegister.TabIndex = 45;
            this.lblRegister.Text = "Register";
            this.lblRegister.UseVisualStyleBackColor = false;
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(205, 177);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(149, 20);
            this.txtBoxPassword.TabIndex = 44;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(205, 129);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(149, 20);
            this.txtBoxUserName.TabIndex = 43;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(205, 89);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(149, 20);
            this.txtBoxName.TabIndex = 42;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(87, 184);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Password";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(87, 132);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(60, 13);
            this.lblUName.TabIndex = 40;
            this.lblUName.Text = "User Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(87, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(185, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Registration";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Age";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(205, 356);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(149, 20);
            this.textBoxAge.TabIndex = 56;
            this.textBoxAge.Validated += new System.EventHandler(this.textBoxAge_Validated);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(525, 452);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.comboBoxDesignation);
            this.Controls.Add(this.txtBoxCnfrmPWord);
            this.Controls.Add(this.lblCnfrmPWord);
            this.Controls.Add(this.lnklblLogin);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUName);
            this.Controls.Add(this.lblName);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.ComboBox comboBoxDesignation;
        private System.Windows.Forms.TextBox txtBoxCnfrmPWord;
        private System.Windows.Forms.Label lblCnfrmPWord;
        private System.Windows.Forms.LinkLabel lnklblLogin;
        private System.Windows.Forms.Button lblRegister;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label2;
    }
}