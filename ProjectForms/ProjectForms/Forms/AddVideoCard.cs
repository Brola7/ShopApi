using ProjectForms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectForms
{
    public partial class AddVideoCard : Form
    {
        public AddVideoCard()
        {
            InitializeComponent();
        }

        private async void Addbtn_Click(object sender, EventArgs e)
        {
            var c = new VideoCard();
            c.Brand = Brandbox.Text;
            c.Model = Modelbox.Text;
            c.MemoryType = MemoryTypebox.Text;
            c.MemorySize = Convert.ToInt32(MemorySizebox.Text);
            c.Price = Convert.ToDecimal(Pricebox.Text);
            c.Stock = Convert.ToInt32(Stockbox.Text);

            var json = JsonSerializer.Serialize(c);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);

                try
                {
                    var response = await client.PostAsync("https://localhost:7035/api/VC", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Videocard added successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to add Viceocard. Status Code: {response.StatusCode}. Response: {responseString}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private async void AddVCInStock_Click(object sender, EventArgs e)
        {
            int id, quantity;

            id = Convert.ToInt32(Idbox.Text);
            quantity = Convert.ToInt32(Quantitybox.Text);

            var url = $"https://localhost:7035/api/VC";

            using (var client = new HttpClient())
            {
                string token = MainForm.token;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var dto = new PutDto { Id = id, Stock = quantity };

                var json = JsonSerializer.Serialize(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage(HttpMethod.Put, url) { Content = content };

                try
                {
                    var response = await client.SendAsync(request);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Videocard added succesfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to update Videocard stock. Status Code: {response.StatusCode}. Response: {responseString}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                catch
                {
                    MessageBox.Show("Id or Quantity is in incorrect format!");
                }
            }
        }
    }
}
