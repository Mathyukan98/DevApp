namespace DepApp
{
    partial class Employee_Form
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
            this.dgvViewEmp = new System.Windows.Forms.DataGridView();
            this.btnViewEmp = new System.Windows.Forms.Button();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewEmp
            // 
            this.dgvViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewEmp.Location = new System.Drawing.Point(29, 360);
            this.dgvViewEmp.Name = "dgvViewEmp";
            this.dgvViewEmp.Size = new System.Drawing.Size(802, 118);
            this.dgvViewEmp.TabIndex = 23;
            // 
            // btnViewEmp
            // 
            this.btnViewEmp.Location = new System.Drawing.Point(756, 287);
            this.btnViewEmp.Name = "btnViewEmp";
            this.btnViewEmp.Size = new System.Drawing.Size(75, 23);
            this.btnViewEmp.TabIndex = 21;
            this.btnViewEmp.Text = "View Details";
            this.btnViewEmp.UseVisualStyleBackColor = true;
            this.btnViewEmp.Click += new System.EventHandler(this.btnViewEmp_Click);
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.Location = new System.Drawing.Point(756, 316);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(75, 23);
            this.btnAddDetails.TabIndex = 20;
            this.btnAddDetails.Text = "Add Details";
            this.btnAddDetails.UseVisualStyleBackColor = true;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(227, 239);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(258, 20);
            this.txtPhone.TabIndex = 19;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(227, 102);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(258, 82);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 20);
            this.txtName.TabIndex = 16;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(159, 247);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(159, 212);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(159, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(159, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(227, 270);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(258, 20);
            this.txtBoxEmail.TabIndex = 25;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.txtBoxEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Employee";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGender
            // 
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(227, 209);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(258, 21);
            this.txtGender.TabIndex = 27;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogout.Location = new System.Drawing.Point(789, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Items.AddRange(new object[] {
            "ICT",
            "Bio Science",
            "Physical Science"});
            this.comboBoxDep.Location = new System.Drawing.Point(227, 313);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(153, 21);
            this.comboBoxDep.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Department";
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(885, 490);
            this.Controls.Add(this.comboBoxDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewEmp);
            this.Controls.Add(this.btnViewEmp);
            this.Controls.Add(this.btnAddDetails);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Name = "Employee_Form";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Employee_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewEmp;
        private System.Windows.Forms.Button btnViewEmp;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.Label label3;
    }
}