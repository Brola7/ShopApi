using ProjectForms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForms {
	public partial class AddCPU : Form {
		public AddCPU() {
			InitializeComponent();
		}

		private async void Addbtn_Click(object sender, EventArgs e) {
			var c = new Cpu();
			c.Brand = Brandbox.Text;
			c.Model = Modelbox.Text;
			c.Cores = Convert.ToInt32(Coresbox.Text);
			c.ClockSpeed = Clockbox.Text + "GHz";
			c.Price = Convert.ToDecimal(Pricebox.Text);
			c.Stock = Convert.ToInt32(Stockbox.Text);

			var json = JsonSerializer.Serialize(c);
		    var content = new StringContent(json, Encoding.UTF8, "application/json");

			using (var client = new HttpClient())
			{
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);

                try
                {
                    var response = await client.PostAsync("https://localhost:7035/api/CPU", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("CPU added successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to add CPU. Status Code: {response.StatusCode}. Response: {responseString}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
		}

		private async void AddVCInStock_Click(object sender, EventArgs e) {
			int id, quantity;

			id = Convert.ToInt32(Idbox.Text);
			quantity = Convert.ToInt32(Quantitybox.Text);

            var url = $"https://localhost:7035/api/CPU";

            using (var client = new HttpClient())
            {
                string token = MainForm.token;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var dto = new PutDto {Id = id, Stock = quantity };

                var json = JsonSerializer.Serialize(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage(HttpMethod.Put, url) { Content = content };

                try
                {
                    var response = await client.SendAsync(request);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Cpu added succesfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to update CPU stock. Status Code: {response.StatusCode}. Response: {responseString}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
	}
}
