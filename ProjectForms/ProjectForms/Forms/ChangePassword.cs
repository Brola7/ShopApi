using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using FinalProject.Entities;
using ProjectForms.Entities;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text.Json;

namespace ProjectForms {
	public partial class ChangePassword : Form {
		public ChangePassword() {
			InitializeComponent();
		}

		public static string ComputeSHA256Hash(string input) {

			byte[] inputData = Encoding.UTF8.GetBytes(input);

			using (SHA256 sha256 = SHA256.Create()) {

				byte[] hashData = sha256.ComputeHash(inputData);

				string hashedString = BitConverter.ToString(hashData).Replace("-", "");
				hashedString = hashedString.ToLower();

				return hashedString;
			}
		}

		private async void Changebtn_Click(object sender, EventArgs e) {
			string OldPass = OldPasswordBox.Text;
			string NewPass = NewPasswordBox.Text;
			string RptPass = RptPasswordBox.Text;

			if (NewPass.Length >= 8)
			{
				if (NewPass == RptPass)
				{
					var pass = new ChangePass
					{
						Username = MainForm.CurrentUser.UserName,
						OldPassword = OldPass,
						NewPassword = NewPass
					};
					using(var client = new HttpClient())
					{
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);

                        var json = JsonSerializer.Serialize(pass);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");

                        var request = new HttpRequestMessage(HttpMethod.Put, "https://localhost:7035/api/Auth/changepassword") { Content = content };

                        try
                        {
                            var response = await client.SendAsync(request);
                            var responseString = await response.Content.ReadAsStringAsync();

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show($"Password Changed Succesfully!");
                            }
                            else
                            {
                                MessageBox.Show($"Failed to update RAM stock. Status Code: {response.StatusCode}. Response: {responseString}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
				}
				else
					{
						MessageBox.Show("Passwords does not match!");
					}
				}
				else
				{
					MessageBox.Show("Password must be at least 8 symbols long!");
				}
			}
	}
}
