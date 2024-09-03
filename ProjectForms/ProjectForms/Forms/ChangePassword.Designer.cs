namespace ProjectForms {
	partial class ChangePassword {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
			RptPasswordBox = new TextBox();
			NewPasswordBox = new TextBox();
			OldPasswordBox = new TextBox();
			Changebtn = new Button();
			dfhjtdymj = new Label();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// RptPasswordBox
			// 
			RptPasswordBox.Location = new Point(184, 170);
			RptPasswordBox.Name = "RptPasswordBox";
			RptPasswordBox.PasswordChar = '*';
			RptPasswordBox.Size = new Size(134, 23);
			RptPasswordBox.TabIndex = 7;
			// 
			// NewPasswordBox
			// 
			NewPasswordBox.Location = new Point(184, 110);
			NewPasswordBox.Name = "NewPasswordBox";
			NewPasswordBox.PasswordChar = '*';
			NewPasswordBox.Size = new Size(134, 23);
			NewPasswordBox.TabIndex = 8;
			// 
			// OldPasswordBox
			// 
			OldPasswordBox.Location = new Point(184, 50);
			OldPasswordBox.Name = "OldPasswordBox";
			OldPasswordBox.PasswordChar = '*';
			OldPasswordBox.Size = new Size(134, 23);
			OldPasswordBox.TabIndex = 9;
			// 
			// Changebtn
			// 
			Changebtn.BackColor = Color.FromArgb(214, 209, 205);
			Changebtn.Cursor = Cursors.Hand;
			Changebtn.FlatAppearance.BorderSize = 0;
			Changebtn.FlatStyle = FlatStyle.Flat;
			Changebtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			Changebtn.ForeColor = Color.FromArgb(57, 43, 88);
			Changebtn.Location = new Point(200, 220);
			Changebtn.Name = "Changebtn";
			Changebtn.Size = new Size(100, 28);
			Changebtn.TabIndex = 6;
			Changebtn.Text = "Change";
			Changebtn.UseVisualStyleBackColor = false;
			Changebtn.Click += Changebtn_Click;
			// 
			// dfhjtdymj
			// 
			dfhjtdymj.AutoSize = true;
			dfhjtdymj.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			dfhjtdymj.ForeColor = Color.FromArgb(57, 43, 88);
			dfhjtdymj.Location = new Point(32, 170);
			dfhjtdymj.Name = "dfhjtdymj";
			dfhjtdymj.Size = new Size(115, 19);
			dfhjtdymj.TabIndex = 3;
			dfhjtdymj.Text = "Repeat Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(57, 43, 88);
			label2.Location = new Point(32, 110);
			label2.Name = "label2";
			label2.Size = new Size(101, 19);
			label2.TabIndex = 4;
			label2.Text = "New Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(57, 43, 88);
			label1.Location = new Point(32, 50);
			label1.Name = "label1";
			label1.Size = new Size(95, 19);
			label1.TabIndex = 5;
			label1.Text = "Old Password";
			// 
			// ChangePassword
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(214, 209, 205);
			ClientSize = new Size(484, 311);
			Controls.Add(RptPasswordBox);
			Controls.Add(NewPasswordBox);
			Controls.Add(OldPasswordBox);
			Controls.Add(Changebtn);
			Controls.Add(dfhjtdymj);
			Controls.Add(label2);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(500, 350);
			MinimumSize = new Size(500, 350);
			Name = "ChangePassword";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Change Password";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox RptPasswordBox;
		private TextBox NewPasswordBox;
		private TextBox OldPasswordBox;
		private Button Changebtn;
		private Label dfhjtdymj;
		private Label label2;
		private Label label1;
	}
}