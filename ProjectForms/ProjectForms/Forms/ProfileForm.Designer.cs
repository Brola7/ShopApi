namespace ProjectForms {
	partial class ProfileForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			label3 = new Label();
			Products = new DataGridView();
			UsernameBox = new Label();
			TypeBox = new Label();
			((System.ComponentModel.ISupportInitialize)Products).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(57, 43, 88);
			label1.Location = new Point(26, 26);
			label1.Name = "label1";
			label1.Size = new Size(74, 19);
			label1.TabIndex = 1;
			label1.Text = "Username:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(57, 43, 88);
			label2.Location = new Point(26, 66);
			label2.Name = "label2";
			label2.Size = new Size(97, 19);
			label2.TabIndex = 1;
			label2.Text = "Account Type:";
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.BackColor = Color.FromArgb(214, 209, 205);
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			button1.ForeColor = Color.FromArgb(57, 43, 88);
			button1.Location = new Point(624, 60);
			button1.Name = "button1";
			button1.Size = new Size(139, 28);
			button1.TabIndex = 3;
			button1.Text = "Change Password";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button2.BackColor = Color.FromArgb(214, 209, 205);
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
			button2.ForeColor = Color.FromArgb(57, 43, 88);
			button2.Location = new Point(687, 20);
			button2.Name = "button2";
			button2.Size = new Size(76, 28);
			button2.TabIndex = 3;
			button2.Text = "Log Out";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(57, 43, 88);
			label3.Location = new Point(26, 121);
			label3.Name = "label3";
			label3.Size = new Size(115, 19);
			label3.TabIndex = 1;
			label3.Text = "Purchase History";
			// 
			// Products
			// 
			Products.AllowUserToAddRows = false;
			Products.AllowUserToDeleteRows = false;
			Products.AllowUserToResizeColumns = false;
			Products.AllowUserToResizeRows = false;
			Products.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			Products.BackgroundColor = SystemColors.ControlLight;
			Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Products.Location = new Point(26, 158);
			Products.Name = "Products";
			Products.ReadOnly = true;
			Products.Size = new Size(737, 315);
			Products.TabIndex = 6;
			Products.CellContentClick += products_CellContentClick;
			// 
			// UsernameBox
			// 
			UsernameBox.AutoSize = true;
			UsernameBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			UsernameBox.ForeColor = Color.FromArgb(57, 43, 88);
			UsernameBox.Location = new Point(157, 26);
			UsernameBox.Name = "UsernameBox";
			UsernameBox.Size = new Size(94, 19);
			UsernameBox.TabIndex = 1;
			UsernameBox.Text = "UsernameBox";
			UsernameBox.Click += UsernameBox_Click;
			// 
			// TypeBox
			// 
			TypeBox.AutoSize = true;
			TypeBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			TypeBox.ForeColor = Color.FromArgb(57, 43, 88);
			TypeBox.Location = new Point(157, 66);
			TypeBox.Name = "TypeBox";
			TypeBox.Size = new Size(61, 19);
			TypeBox.TabIndex = 1;
			TypeBox.Text = "TypeBox";
			// 
			// ProfileForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(214, 209, 205);
			ClientSize = new Size(796, 485);
			Controls.Add(Products);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(TypeBox);
			Controls.Add(label2);
			Controls.Add(UsernameBox);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "ProfileForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Profile";
			((System.ComponentModel.ISupportInitialize)Products).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
		private Label label3;
		private DataGridView Products;
		private Label UsernameBox;
		private Label TypeBox;
	}
}