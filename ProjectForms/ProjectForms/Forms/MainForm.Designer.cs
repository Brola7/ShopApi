namespace ProjectForms {
	partial class MainForm {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CPUbtn = new Button();
            MBbtn = new Button();
            Videobtn = new Button();
            RAMbtn = new Button();
            Loginbtn = new Button();
            products = new DataGridView();
            Addbtn = new Button();
            Buybtn = new Button();
            Profilebtn = new Button();
            LogOutbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)products).BeginInit();
            SuspendLayout();
            // 
            // CPUbtn
            // 
            CPUbtn.BackColor = Color.FromArgb(214, 209, 205);
            CPUbtn.Cursor = Cursors.Hand;
            CPUbtn.FlatAppearance.BorderSize = 0;
            CPUbtn.FlatStyle = FlatStyle.Flat;
            CPUbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            CPUbtn.ForeColor = Color.FromArgb(57, 43, 88);
            CPUbtn.Location = new Point(12, 10);
            CPUbtn.Name = "CPUbtn";
            CPUbtn.Size = new Size(87, 34);
            CPUbtn.TabIndex = 0;
            CPUbtn.Text = "CPUs";
            CPUbtn.UseVisualStyleBackColor = false;
            CPUbtn.Click += button1_Click;
            // 
            // MBbtn
            // 
            MBbtn.BackColor = Color.FromArgb(214, 209, 205);
            MBbtn.Cursor = Cursors.Hand;
            MBbtn.FlatAppearance.BorderSize = 0;
            MBbtn.FlatStyle = FlatStyle.Flat;
            MBbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MBbtn.ForeColor = Color.FromArgb(57, 43, 88);
            MBbtn.Location = new Point(105, 10);
            MBbtn.Name = "MBbtn";
            MBbtn.Size = new Size(124, 34);
            MBbtn.TabIndex = 1;
            MBbtn.Text = "Motherboards";
            MBbtn.UseVisualStyleBackColor = false;
            MBbtn.Click += MBbtn_Click;
            // 
            // Videobtn
            // 
            Videobtn.BackColor = Color.FromArgb(214, 209, 205);
            Videobtn.Cursor = Cursors.Hand;
            Videobtn.FlatAppearance.BorderSize = 0;
            Videobtn.FlatStyle = FlatStyle.Flat;
            Videobtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Videobtn.ForeColor = Color.FromArgb(57, 43, 88);
            Videobtn.Location = new Point(235, 10);
            Videobtn.Name = "Videobtn";
            Videobtn.Size = new Size(103, 34);
            Videobtn.TabIndex = 2;
            Videobtn.Text = "Video Cards";
            Videobtn.UseVisualStyleBackColor = false;
            Videobtn.Click += Videobtn_Click;
            // 
            // RAMbtn
            // 
            RAMbtn.BackColor = Color.FromArgb(214, 209, 205);
            RAMbtn.Cursor = Cursors.Hand;
            RAMbtn.FlatAppearance.BorderSize = 0;
            RAMbtn.FlatStyle = FlatStyle.Flat;
            RAMbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            RAMbtn.ForeColor = Color.FromArgb(57, 43, 88);
            RAMbtn.Location = new Point(344, 10);
            RAMbtn.Name = "RAMbtn";
            RAMbtn.Size = new Size(91, 34);
            RAMbtn.TabIndex = 2;
            RAMbtn.Text = "RAMs";
            RAMbtn.UseVisualStyleBackColor = false;
            RAMbtn.Click += RAMbtn_Click;
            // 
            // Loginbtn
            // 
            Loginbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Loginbtn.BackColor = Color.FromArgb(214, 209, 205);
            Loginbtn.Cursor = Cursors.Hand;
            Loginbtn.FlatAppearance.BorderSize = 0;
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Loginbtn.ForeColor = Color.FromArgb(57, 43, 88);
            Loginbtn.Location = new Point(773, 10);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(75, 34);
            Loginbtn.TabIndex = 4;
            Loginbtn.Text = "Log in";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += button5_Click;
            // 
            // products
            // 
            products.AllowUserToAddRows = false;
            products.AllowUserToDeleteRows = false;
            products.AllowUserToResizeColumns = false;
            products.AllowUserToResizeRows = false;
            products.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            products.BackgroundColor = SystemColors.ControlLight;
            products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            products.Location = new Point(12, 90);
            products.Name = "products";
            products.ReadOnly = true;
            products.Size = new Size(836, 388);
            products.TabIndex = 5;
            products.CellContentClick += products_CellContentClick;
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Addbtn.Cursor = Cursors.Hand;
            Addbtn.FlatAppearance.BorderSize = 0;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Addbtn.ForeColor = Color.FromArgb(57, 43, 88);
            Addbtn.Location = new Point(692, 10);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 34);
            Addbtn.TabIndex = 2;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Buybtn
            // 
            Buybtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Buybtn.BackColor = Color.FromArgb(214, 209, 205);
            Buybtn.Cursor = Cursors.Hand;
            Buybtn.FlatAppearance.BorderSize = 0;
            Buybtn.FlatStyle = FlatStyle.Flat;
            Buybtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Buybtn.ForeColor = Color.FromArgb(57, 43, 88);
            Buybtn.Location = new Point(773, 10);
            Buybtn.Name = "Buybtn";
            Buybtn.Size = new Size(75, 34);
            Buybtn.TabIndex = 2;
            Buybtn.Text = "Buy";
            Buybtn.UseVisualStyleBackColor = false;
            Buybtn.Click += button1_Click_1;
            // 
            // Profilebtn
            // 
            Profilebtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Profilebtn.BackColor = Color.FromArgb(214, 209, 205);
            Profilebtn.Cursor = Cursors.Hand;
            Profilebtn.FlatAppearance.BorderSize = 0;
            Profilebtn.FlatStyle = FlatStyle.Flat;
            Profilebtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            Profilebtn.ForeColor = Color.FromArgb(57, 43, 88);
            Profilebtn.Location = new Point(773, 50);
            Profilebtn.Name = "Profilebtn";
            Profilebtn.Size = new Size(75, 34);
            Profilebtn.TabIndex = 4;
            Profilebtn.Text = "Profile";
            Profilebtn.UseVisualStyleBackColor = false;
            Profilebtn.Click += Profilebtn_Click;
            // 
            // LogOutbtn
            // 
            LogOutbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogOutbtn.Cursor = Cursors.Hand;
            LogOutbtn.FlatAppearance.BorderSize = 0;
            LogOutbtn.FlatStyle = FlatStyle.Flat;
            LogOutbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            LogOutbtn.ForeColor = Color.FromArgb(57, 43, 88);
            LogOutbtn.Location = new Point(692, 50);
            LogOutbtn.Name = "LogOutbtn";
            LogOutbtn.Size = new Size(75, 34);
            LogOutbtn.TabIndex = 2;
            LogOutbtn.Text = "Log out";
            LogOutbtn.UseVisualStyleBackColor = true;
            LogOutbtn.Click += LogOutbtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(214, 209, 205);
            ClientSize = new Size(860, 490);
            Controls.Add(products);
            Controls.Add(RAMbtn);
            Controls.Add(Videobtn);
            Controls.Add(MBbtn);
            Controls.Add(CPUbtn);
            Controls.Add(Profilebtn);
            Controls.Add(LogOutbtn);
            Controls.Add(Addbtn);
            Controls.Add(Buybtn);
            Controls.Add(Loginbtn);
            ForeColor = Color.FromArgb(57, 43, 88);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)products).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CPUbtn;
		private Button MBbtn;
		private Button Videobtn;
		private Button RAMbtn;
		private Button Loginbtn;
		private DataGridView products;
		private Button Addbtn;
		private Button Buybtn;
		private Button Profilebtn;
		private Button LogOutbtn;
	}
}
