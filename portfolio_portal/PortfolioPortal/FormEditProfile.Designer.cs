
namespace PortfolioPortal
{
    partial class FormEditProfile
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
			this.label5 = new System.Windows.Forms.Label();
			this.buttonUpdateProfile = new System.Windows.Forms.Button();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.radioButtonFemale = new System.Windows.Forms.RadioButton();
			this.radioButtonMale = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(315, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 24);
			this.label5.TabIndex = 9;
			this.label5.Text = "Enter New Details";
			// 
			// buttonUpdateProfile
			// 
			this.buttonUpdateProfile.BackColor = System.Drawing.Color.MediumPurple;
			this.buttonUpdateProfile.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.buttonUpdateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BlueViolet;
			this.buttonUpdateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
			this.buttonUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpdateProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdateProfile.ForeColor = System.Drawing.Color.White;
			this.buttonUpdateProfile.Location = new System.Drawing.Point(307, 304);
			this.buttonUpdateProfile.Name = "buttonUpdateProfile";
			this.buttonUpdateProfile.Size = new System.Drawing.Size(181, 31);
			this.buttonUpdateProfile.TabIndex = 10;
			this.buttonUpdateProfile.Text = "UPDATE";
			this.buttonUpdateProfile.UseVisualStyleBackColor = false;
			this.buttonUpdateProfile.Click += new System.EventHandler(this.buttonUpdateProfile_Click);
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.ForeColor = System.Drawing.Color.Black;
			this.textBoxPhone.Location = new System.Drawing.Point(307, 203);
			this.textBoxPhone.MaxLength = 11;
			this.textBoxPhone.Multiline = true;
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(181, 20);
			this.textBoxPhone.TabIndex = 69;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(261, 206);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 13);
			this.label12.TabIndex = 68;
			this.label12.Text = "Phone";
			// 
			// radioButtonFemale
			// 
			this.radioButtonFemale.AutoSize = true;
			this.radioButtonFemale.BackColor = System.Drawing.Color.Transparent;
			this.radioButtonFemale.ForeColor = System.Drawing.Color.Black;
			this.radioButtonFemale.Location = new System.Drawing.Point(389, 179);
			this.radioButtonFemale.Name = "radioButtonFemale";
			this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
			this.radioButtonFemale.TabIndex = 67;
			this.radioButtonFemale.TabStop = true;
			this.radioButtonFemale.Text = "Female";
			this.radioButtonFemale.UseVisualStyleBackColor = false;
			// 
			// radioButtonMale
			// 
			this.radioButtonMale.AutoSize = true;
			this.radioButtonMale.BackColor = System.Drawing.Color.Transparent;
			this.radioButtonMale.ForeColor = System.Drawing.Color.Black;
			this.radioButtonMale.Location = new System.Drawing.Point(310, 179);
			this.radioButtonMale.Name = "radioButtonMale";
			this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
			this.radioButtonMale.TabIndex = 66;
			this.radioButtonMale.TabStop = true;
			this.radioButtonMale.Text = "Male";
			this.radioButtonMale.UseVisualStyleBackColor = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(259, 181);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(42, 13);
			this.label11.TabIndex = 65;
			this.label11.Text = "Gender";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.ForeColor = System.Drawing.Color.Black;
			this.textBoxAddress.Location = new System.Drawing.Point(308, 229);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(180, 69);
			this.textBoxAddress.TabIndex = 64;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(254, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 63;
			this.label7.Text = "Address";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
			this.textBoxEmail.Location = new System.Drawing.Point(308, 127);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(181, 20);
			this.textBoxEmail.TabIndex = 62;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(268, 130);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 13);
			this.label9.TabIndex = 61;
			this.label9.Text = "Email";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
			this.textBoxPassword.Location = new System.Drawing.Point(308, 153);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(181, 20);
			this.textBoxPassword.TabIndex = 58;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(247, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 57;
			this.label3.Text = "Password";
			// 
			// textBoxName
			// 
			this.textBoxName.ForeColor = System.Drawing.Color.Black;
			this.textBoxName.Location = new System.Drawing.Point(308, 101);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(181, 20);
			this.textBoxName.TabIndex = 56;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(251, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 55;
			this.label2.Text = "Full Name";
			// 
			// FormEditProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.radioButtonFemale);
			this.Controls.Add(this.radioButtonMale);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonUpdateProfile);
			this.Controls.Add(this.label5);
			this.Name = "FormEditProfile";
			this.Text = "FormEditProfile";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdateProfile;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RadioButton radioButtonFemale;
		private System.Windows.Forms.RadioButton radioButtonMale;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label2;
	}
}