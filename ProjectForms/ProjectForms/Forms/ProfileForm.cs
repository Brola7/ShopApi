using Newtonsoft.Json;
using ProjectForms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForms {
	public partial class ProfileForm : Form {
		public ProfileForm() {
			InitializeComponent();
			UsernameBox.Text = MainForm.CurrentUser.UserName;
			if (MainForm.IsAdmin)
			{
				TypeBox.Text = "Admin";
			}
			else
			{
				TypeBox.Text = "User";
			}
			GetHistory();
		}

		private async Task GetHistory()
		{
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);
                try
                {
                    var response = await client.GetAsync($"https://localhost:7035/api/Purchase/{MainForm.CurrentUser.Id}");

                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    var pur = JsonConvert.DeserializeObject<List<PurchaseHistory>>(responseBody);

                    Products.DataSource = pur;
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Request error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (JsonException e)
                {
                    MessageBox.Show($"JSON error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Unexpected error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

		private void button2_Click(object sender, EventArgs e) {
			LoginForm lf = new LoginForm();
			foreach (Form f in Application.OpenForms) {
				f.Hide();
				lf.FormClosed += (s, args) => f.Close();
			}
			lf.Show();
		}

		private void products_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			var cf = new ChangePassword();
			cf.Show();
		}

		private void UsernameBox_Click(object sender, EventArgs e) {

		}
	}
}
