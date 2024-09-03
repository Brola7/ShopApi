namespace ProjectForms {
	partial class BuyForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyForm));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			Idbox = new TextBox();
			Cardbox = new TextBox();
			CVVbox = new TextBox();
			label5 = new Label();
			label6 = new Label();
			Monthbox = new TextBox();
			Yearbox = new TextBox();
			Buybtn = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(57, 43, 88);
			label1.Location = new Point(49, 40);
			label1.Name = "label1";
			label1.Size = new Size(21, 19);
			label1.TabIndex = 0;
			label1.Text = "Id";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(57, 43, 88);
			label2.Location = new Point(49, 100);
			label2.Name = "label2";
			label2.Size = new Size(93, 19);
			label2.TabIndex = 0;
			label2.Text = "Card Number";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label3.ForeColor = Color.FromArgb(57, 43, 88);
			label3.Location = new Point(49, 160);
			label3.Name = "label3";
			label3.Size = new Size(72, 19);
			label3.TabIndex = 0;
			label3.Text = "CVV Code";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label4.ForeColor = Color.FromArgb(57, 43, 88);
			label4.Location = new Point(49, 210);
			label4.Name = "label4";
			label4.Size = new Size(38, 19);
			label4.TabIndex = 0;
			label4.Text = "Date";
			// 
			// Idbox
			// 
			Idbox.Location = new Point(214, 40);
			Idbox.Name = "Idbox";
			Idbox.Size = new Size(42, 23);
			Idbox.TabIndex = 1;
			// 
			// Cardbox
			// 
			Cardbox.Location = new Point(214, 100);
			Cardbox.Name = "Cardbox";
			Cardbox.Size = new Size(172, 23);
			Cardbox.TabIndex = 1;
			// 
			// CVVbox
			// 
			CVVbox.Location = new Point(214, 160);
			CVVbox.Name = "CVVbox";
			CVVbox.Size = new Size(42, 23);
			CVVbox.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label5.ForeColor = Color.FromArgb(57, 43, 88);
			label5.Location = new Point(49, 250);
			label5.Name = "label5";
			label5.Size = new Size(51, 19);
			label5.TabIndex = 0;
			label5.Text = "Month";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
			label6.ForeColor = Color.FromArgb(57, 43, 88);
			label6.Location = new Point(303, 251);
			label6.Name = "label6";
			label6.Size = new Size(35, 19);
			label6.TabIndex = 0;
			label6.Text = "Year";
			// 
			// Monthbox
			// 
			Monthbox.Location = new Point(214, 250);
			Monthbox.Name = "Monthbox";
			Monthbox.Size = new Size(42, 23);
			Monthbox.TabIndex = 1;
			// 
			// Yearbox
			// 
			Yearbox.Location = new Point(362, 250);
			Yearbox.Name = "Yearbox";
			Yearbox.Size = new Size(60, 23);
			Yearbox.TabIndex = 1;
			// 
			// Buybtn
			// 
			Buybtn.BackColor = Color.FromArgb(214, 209, 205);
			Buybtn.Cursor = Cursors.Hand;
			Buybtn.FlatAppearance.BorderColor = Color.Black;
			Buybtn.FlatAppearance.BorderSize = 0;
			Buybtn.FlatStyle = FlatStyle.Flat;
			Buybtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
			Buybtn.ForeColor = Color.FromArgb(57, 43, 88);
			Buybtn.Location = new Point(262, 310);
			Buybtn.Name = "Buybtn";
			Buybtn.Size = new Size(75, 28);
			Buybtn.TabIndex = 2;
			Buybtn.Text = "Buy";
			Buybtn.UseVisualStyleBackColor = false;
			Buybtn.Click += Buybtn_Click;
			// 
			// BuyForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(214, 209, 205);
			ClientSize = new Size(584, 361);
			Controls.Add(Buybtn);
			Controls.Add(Cardbox);
			Controls.Add(Yearbox);
			Controls.Add(Monthbox);
			Controls.Add(CVVbox);
			Controls.Add(Idbox);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			ForeColor = Color.FromArgb(57, 43, 88);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "BuyForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BuyForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox Idbox;
		private TextBox Cardbox;
		private TextBox CVVbox;
		private Label label5;
		private Label label6;
		private TextBox Monthbox;
		private TextBox Yearbox;
		private Button Buybtn;
	}
}