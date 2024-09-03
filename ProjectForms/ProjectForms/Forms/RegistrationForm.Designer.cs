namespace ProjectForms {
	partial class RegistrationForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			Registrationbtn = new Button();
			UserNamebox = new TextBox();
			Passwordbox = new TextBox();
			PasswordRptbox = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(57, 43, 88);
			label1.Location = new Point(32, 50);
			label1.Name = "label1";
			label1.Size = new Size(74, 19);
			label1.TabIndex = 0;
			label1.Text = "UserName";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(57, 43, 88);
			label2.Location = new Point(32, 110);
			label2.Name = "label2";
			label2.Size = new Size(68, 19);
			label2.TabIndex = 0;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(57, 43, 88);
			label3.Location = new Point(32, 170);
			label3.Name = "label3";
			label3.Size = new Size(122, 19);
			label3.TabIndex = 0;
			label3.Text = "Repeate Password";
			// 
			// Registrationbtn
			// 
			Registrationbtn.BackColor = Color.FromArgb(214, 209, 205);
			Registrationbtn.Cursor = Cursors.Hand;
			Registrationbtn.FlatAppearance.BorderSize = 0;
			Registrationbtn.FlatStyle = FlatStyle.Flat;
			Registrationbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			Registrationbtn.ForeColor = Color.FromArgb(57, 43, 88);
			Registrationbtn.Location = new Point(200, 220);
			Registrationbtn.Name = "Registrationbtn";
			Registrationbtn.Size = new Size(100, 28);
			Registrationbtn.TabIndex = 1;
			Registrationbtn.Text = "Registration";
			Registrationbtn.UseVisualStyleBackColor = false;
			Registrationbtn.Click += Registrationbtn_Click;
			// 
			// UserNamebox
			// 
			UserNamebox.Location = new Point(184, 50);
			UserNamebox.Name = "UserNamebox";
			UserNamebox.Size = new Size(134, 23);
			UserNamebox.TabIndex = 2;
			UserNamebox.TextChanged += UserNamebox_TextChanged;
			// 
			// Passwordbox
			// 
			Passwordbox.Location = new Point(184, 110);
			Passwordbox.Name = "Passwordbox";
			Passwordbox.PasswordChar = '*';
			Passwordbox.Size = new Size(134, 23);
			Passwordbox.TabIndex = 2;
			// 
			// PasswordRptbox
			// 
			PasswordRptbox.Location = new Point(184, 170);
			PasswordRptbox.Name = "PasswordRptbox";
			PasswordRptbox.PasswordChar = '*';
			PasswordRptbox.Size = new Size(134, 23);
			PasswordRptbox.TabIndex = 2;
			// 
			// RegistrationForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(214, 209, 205);
			ClientSize = new Size(484, 311);
			Controls.Add(PasswordRptbox);
			Controls.Add(Passwordbox);
			Controls.Add(UserNamebox);
			Controls.Add(Registrationbtn);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(500, 350);
			MinimumSize = new Size(500, 350);
			Name = "RegistrationForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "RegistrationForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Button Registrationbtn;
		private TextBox UserNamebox;
		private TextBox Passwordbox;
		private TextBox PasswordRptbox;
	}
}