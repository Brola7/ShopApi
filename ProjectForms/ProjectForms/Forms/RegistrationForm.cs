using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using FinalProject.Entities;
using FinalProject.DTOs;
using System.Text.Json;

namespace ProjectForms {
	public partial class RegistrationForm : Form {

		public RegistrationForm() {
			InitializeComponent();
		}
		private async void Registrationbtn_Click(object sender, EventArgs e) {
			if (Passwordbox.Text.Length < 8) {
				MessageBox.Show("Password must contain at least 8 symbols!");
			}
			else if (Passwordbox.Text == PasswordRptbox.Text) {
				string UserName = UserNamebox.Text;
				string Password = Passwordbox.Text;

				var u = new UserDto {Username = UserName, Password = Password };

				using(var client = new HttpClient())
				{
                    var json = JsonSerializer.Serialize(u);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    try
                    {
                        var response = await client.PostAsync("https://localhost:7035/api/Auth/register", content);
                        var responseString = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Account created successfully!");
                        }
                        else
                        {
                            MessageBox.Show($"Failed to create account. Status Code: {response.StatusCode}. Response: {responseString}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
			}
			else {
				MessageBox.Show("Passwords does not match!");
			}
		}

		private void UserNamebox_TextChanged(object sender, EventArgs e) {

		}
	}
}
