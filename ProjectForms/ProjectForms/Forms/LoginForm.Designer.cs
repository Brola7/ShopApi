namespace ProjectForms {
	partial class LoginForm {
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(57, 43, 88);
            label1.Location = new Point(45, 60);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(57, 43, 88);
            label2.Location = new Point(45, 120);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // UsernameBox
            // 
            UsernameBox.Anchor = AnchorStyles.None;
            UsernameBox.HideSelection = false;
            UsernameBox.Location = new Point(184, 60);
            UsernameBox.MaximumSize = new Size(134, 23);
            UsernameBox.MinimumSize = new Size(134, 23);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.RightToLeft = RightToLeft.No;
            UsernameBox.Size = new Size(134, 23);
            UsernameBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = AnchorStyles.None;
            PasswordBox.Location = new Point(184, 120);
            PasswordBox.MaximumSize = new Size(134, 23);
            PasswordBox.MinimumSize = new Size(134, 23);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(134, 23);
            PasswordBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(214, 209, 205);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(57, 43, 88);
            button1.Location = new Point(212, 180);
            button1.Name = "button1";
            button1.Size = new Size(76, 28);
            button1.TabIndex = 2;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(214, 209, 205);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(57, 43, 88);
            button2.Location = new Point(200, 240);
            button2.Name = "button2";
            button2.Size = new Size(100, 28);
            button2.TabIndex = 2;
            button2.Text = "Registration";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 209, 205);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(484, 311);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(57, 43, 88);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(500, 350);
            MinimumSize = new Size(500, 350);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private TextBox UsernameBox;
		private TextBox PasswordBox;
		private Button button1;
		private Button button2;
	}
}