
namespace PortfolioPortal
{
	partial class Signup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.radioButtonFemale = new System.Windows.Forms.RadioButton();
			this.radioButtonMale = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxCPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.labelSignin = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.buttonLogin);
			this.panel1.Controls.Add(this.textBoxPhone);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.radioButtonFemale);
			this.panel1.Controls.Add(this.radioButtonMale);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.textBoxAddress);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.textBoxEmail);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.textBoxCPassword);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.labelSignin);
			this.panel1.Controls.Add(this.textBoxPassword);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBoxName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(80, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(641, 436);
			this.panel1.TabIndex = 30;
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.WhiteSmoke;
			this.buttonLogin.FlatAppearance.BorderSize = 0;
			this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
			this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.ForeColor = System.Drawing.Color.Black;
			this.buttonLogin.Location = new System.Drawing.Point(242, 341);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(181, 27);
			this.buttonLogin.TabIndex = 55;
			this.buttonLogin.Text = "SignUp";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.buttonSignup_Click);
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(242, 240);
			this.textBoxPhone.MaxLength = 11;
			this.textBoxPhone.Multiline = true;
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(181, 20);
			this.textBoxPhone.TabIndex = 54;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(196, 243);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 13);
			this.label12.TabIndex = 53;
			this.label12.Text = "Phone";
			// 
			// radioButtonFemale
			// 
			this.radioButtonFemale.AutoSize = true;
			this.radioButtonFemale.BackColor = System.Drawing.Color.Transparent;
			this.radioButtonFemale.ForeColor = System.Drawing.Color.White;
			this.radioButtonFemale.Location = new System.Drawing.Point(322, 217);
			this.radioButtonFemale.Name = "radioButtonFemale";
			this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
			this.radioButtonFemale.TabIndex = 51;
			this.radioButtonFemale.TabStop = true;
			this.radioButtonFemale.Text = "Female";
			this.radioButtonFemale.UseVisualStyleBackColor = false;
			// 
			// radioButtonMale
			// 
			this.radioButtonMale.AutoSize = true;
			this.radioButtonMale.BackColor = System.Drawing.Color.Transparent;
			this.radioButtonMale.ForeColor = System.Drawing.Color.White;
			this.radioButtonMale.Location = new System.Drawing.Point(243, 217);
			this.radioButtonMale.Name = "radioButtonMale";
			this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
			this.radioButtonMale.TabIndex = 50;
			this.radioButtonMale.TabStop = true;
			this.radioButtonMale.Text = "Male";
			this.radioButtonMale.UseVisualStyleBackColor = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(192, 219);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(42, 13);
			this.label11.TabIndex = 49;
			this.label11.Text = "Gender";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(243, 266);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(180, 69);
			this.textBoxAddress.TabIndex = 44;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(189, 269);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 43;
			this.label7.Text = "Address";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(242, 139);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(181, 20);
			this.textBoxEmail.TabIndex = 41;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(202, 142);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 13);
			this.label9.TabIndex = 40;
			this.label9.Text = "Email*";
			// 
			// textBoxCPassword
			// 
			this.textBoxCPassword.Location = new System.Drawing.Point(242, 191);
			this.textBoxCPassword.Name = "textBoxCPassword";
			this.textBoxCPassword.PasswordChar = '*';
			this.textBoxCPassword.Size = new System.Drawing.Size(181, 20);
			this.textBoxCPassword.TabIndex = 39;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(147, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 13);
			this.label5.TabIndex = 38;
			this.label5.Text = "Confirm Password*";
			// 
			// labelSignin
			// 
			this.labelSignin.AutoSize = true;
			this.labelSignin.BackColor = System.Drawing.Color.Transparent;
			this.labelSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSignin.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.labelSignin.Location = new System.Drawing.Point(239, 371);
			this.labelSignin.Name = "labelSignin";
			this.labelSignin.Size = new System.Drawing.Size(183, 15);
			this.labelSignin.TabIndex = 37;
			this.labelSignin.Text = " Already have an account? Login";
			this.labelSignin.Click += new System.EventHandler(this.labelSignin_Click);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(242, 165);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(181, 20);
			this.textBoxPassword.TabIndex = 35;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(181, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 34;
			this.label3.Text = "Password*";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(167, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(297, 32);
			this.label4.TabIndex = 31;
			this.label4.Text = "CREATE ACCOUNT";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(242, 113);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(181, 20);
			this.textBoxName.TabIndex = 30;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(185, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "Full Name*";
			// 
			// Signup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "Signup";
			this.Text = "Signup";
			this.Load += new System.EventHandler(this.Signup_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RadioButton radioButtonFemale;
		private System.Windows.Forms.RadioButton radioButtonMale;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxCPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelSignin;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
    }
}

