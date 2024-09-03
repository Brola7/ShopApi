using System.Text.Json;
using ProjectForms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjectForms
{
    public partial class BuyForm : Form
    {
        private MainForm.Category category;
        public BuyForm(MainForm.Category category)
        {
            InitializeComponent();
            this.category = category;
        }
        bool CardCheck()
        {
            string CardNum = Cardbox.Text;
            string CVVNum = CVVbox.Text;
            string Year = Yearbox.Text;
            string Month = Monthbox.Text;

            if (CardNum.Length != 16)
                return false;

            if (CVVNum.Length != 3)
                return false;

            if (Year.Length != 4)
                return false;

            if (Month.Length != 1 && Month.Length != 2)
                return false;

            foreach (var a in CardNum)
            {
                if (!char.IsDigit(a))
                    return false;
            }
            foreach (var a in CVVNum)
            {
                if (!char.IsDigit(a))
                    return false;
            }
            foreach (var a in Year)
            {
                if (!char.IsDigit(a))
                    return false;
            }
            foreach (var a in Month)
            {
                if (!char.IsDigit(a))
                    return false;
            }
            int year = Convert.ToInt32(Year);
            int month = Convert.ToInt32(Month);

            if (month < 1 || month > 12)
                return false;

            if (year < DateTime.Now.Year)
                return false;
            if (year == DateTime.Now.Year && month < DateTime.Now.Month)
                return false;

            return true;
        }
        private async void Buybtn_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);

                int Id = Convert.ToInt32(Idbox.Text);

                switch (category)
                {
                    case MainForm.Category.CPUs:
                        await HandleCpuPurchaseAsync(client, Id);
                        break;

                    case MainForm.Category.VideoCards:
                        await HandleVideoCardPurchaseAsync(client, Id);
                        break;

                    case MainForm.Category.MotherBoards:
                        await HandleMotherBoardPurchaseAsync(client, Id);
                        break;

                    case MainForm.Category.RAMs:
                        await HandleRamPurchaseAsync(client, Id);
                        break;

                    default:
                        MessageBox.Show("Invalid category!");
                        break;
                }
            }
        }
        private async Task HandleCpuPurchaseAsync(HttpClient client, int Id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);
            if (CardCheck())
            {
                try
                {
                    var response = await client.GetAsync($"https://localhost:7035/api/CPU/{Id}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var cpu = JsonConvert.DeserializeObject<Cpu>(responseBody);

                    if (cpu != null)
                    {
                        var purchase = new PurchaseHistory
                        {
                            UserId = MainForm.CurrentUser.Id,
                            Category = "CPU",
                            Brand = cpu.Brand,
                            Model = cpu.Model,
                            Price = cpu.Price
                        };

                        var purchaseJson = JsonConvert.SerializeObject(purchase);
                        var purchaseContent = new StringContent(purchaseJson, Encoding.UTF8, "application/json");
                        var purchaseResponse = await client.PostAsync("https://localhost:7035/api/Purchase", purchaseContent);

                        if (!purchaseResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Error occurred! {purchaseResponse.StatusCode}");
                            return;
                        }

                        var updateDto = new PutDto { Id = Id, Stock = -1 };

                        var updateJson = JsonConvert.SerializeObject(updateDto);
                        var updateContent = new StringContent(updateJson, Encoding.UTF8, "application/json");
                        var updateRequest = new HttpRequestMessage(HttpMethod.Put, $"https://localhost:7035/api/CPU") { Content = updateContent };

                        var updateResponse = await client.SendAsync(updateRequest);
                        var updateResponseString = await updateResponse.Content.ReadAsStringAsync();

                        if (updateResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("CPU bought successfully!");
                        }
                        else
                        {
                            MessageBox.Show($"Failed to buy CPU. Status Code: {updateResponse.StatusCode}. Response: {updateResponseString}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPU not found or out of stock!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Incorrect card details!");
            }
        }
        private async Task HandleVideoCardPurchaseAsync(HttpClient client, int Id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);
            if (CardCheck())
            {
                try
                {
                    var response = await client.GetAsync($"https://localhost:7035/api/VC/{Id}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var videoCard = JsonConvert.DeserializeObject<VideoCard>(responseBody);

                    if (videoCard != null)
                    {
                        var purchase = new PurchaseHistory
                        {
                            UserId = MainForm.CurrentUser.Id,
                            Category = "Video Card",
                            Brand = videoCard.Brand,
                            Model = videoCard.Model,
                            Price = videoCard.Price
                        };

                        var purchaseJson = JsonConvert.SerializeObject(purchase);
                        var purchaseContent = new StringContent(purchaseJson, Encoding.UTF8, "application/json");
                        var purchaseResponse = await client.PostAsync("https://localhost:7035/api/Purchase", purchaseContent);

                        if (!purchaseResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Error occurred! {purchaseResponse.StatusCode}");
                            return;
                        }

                        var updateDto = new PutDto { Id = Id, Stock = -1 };

                        var updateJson = JsonConvert.SerializeObject(updateDto);
                        var updateContent = new StringContent(updateJson, Encoding.UTF8, "application/json");
                        var updateRequest = new HttpRequestMessage(HttpMethod.Put, $"https://localhost:7035/api/VC") { Content = updateContent };

                        var updateResponse = await client.SendAsync(updateRequest);
                        var updateResponseString = await updateResponse.Content.ReadAsStringAsync();

                        if (updateResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Video Card bought successfully!");
                        }
                        else
                        {
                            MessageBox.Show($"Failed to buy Video Card. Status Code: {updateResponse.StatusCode}. Response: {updateResponseString}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Video Card not found or out of stock!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Incorrect card details!");
            }
        }
        private async Task HandleMotherBoardPurchaseAsync(HttpClient client, int Id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);
            if (CardCheck())
            {
                try
                {
                    var response = await client.GetAsync($"https://localhost:7035/api/MB/{Id}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var motherboard = JsonConvert.DeserializeObject<Motherboard>(responseBody);

                    if (motherboard != null)
                    {
                        var purchase = new PurchaseHistory
                        {
                            UserId = MainForm.CurrentUser.Id,
                            Category = "MotherBoard",
                            Brand = motherboard.Brand,
                            Model = motherboard.Model,
                            Price = motherboard.Price
                        };

                        var purchaseJson = JsonConvert.SerializeObject(purchase);
                        var purchaseContent = new StringContent(purchaseJson, Encoding.UTF8, "application/json");
                        var purchaseResponse = await client.PostAsync("https://localhost:7035/api/Purchase", purchaseContent);

                        if (!purchaseResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Error occurred! {purchaseResponse.StatusCode}");
                            return;
                        }

                        var updateDto = new PutDto { Id = Id, Stock = -1 };

                        var updateJson = JsonConvert.SerializeObject(updateDto);
                        var updateContent = new StringContent(updateJson, Encoding.UTF8, "application/json");
                        var updateRequest = new HttpRequestMessage(HttpMethod.Put, $"https://localhost:7035/api/MB") { Content = updateContent };

                        var updateResponse = await client.SendAsync(updateRequest);
                        var updateResponseString = await updateResponse.Content.ReadAsStringAsync();

                        if (updateResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("MotherBoard bought successfully!");
                        }
                        else
                        {
                            MessageBox.Show($"Failed to buy MotherBoard. Status Code: {updateResponse.StatusCode}. Response: {updateResponseString}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("MotherBoard not found or out of stock!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Incorrect card details!");
            }
        }
        private async Task HandleRamPurchaseAsync(HttpClient client, int Id)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MainForm.token);
            if (CardCheck())
            {
                try
                {
                    var response = await client.GetAsync($"https://localhost:7035/api/Ram/{Id}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var ram = JsonConvert.DeserializeObject<Ram>(responseBody);

                    if (ram != null)
                    {
                        var purchase = new PurchaseHistory
                        {
                            UserId = MainForm.CurrentUser.Id,
                            Category = "Ram",
                            Brand = ram.Brand,
                            Model = ram.Model,
                            Price = ram.Price
                        };

                        var purchaseJson = JsonConvert.SerializeObject(purchase);
                        var purchaseContent = new StringContent(purchaseJson, Encoding.UTF8, "application/json");
                        var purchaseResponse = await client.PostAsync("https://localhost:7035/api/Purchase", purchaseContent);

                        if (!purchaseResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Error occurred! {purchaseResponse.StatusCode}");
                            return;
                        }

                        var updateDto = new PutDto { Id = Id, Stock = -1 };

                        var updateJson = JsonConvert.SerializeObject(updateDto);
                        var updateContent = new StringContent(updateJson, Encoding.UTF8, "application/json");
                        var updateRequest = new HttpRequestMessage(HttpMethod.Put, $"https://localhost:7035/api/Ram") { Content = updateContent };

                        var updateResponse = await client.SendAsync(updateRequest);
                        var updateResponseString = await updateResponse.Content.ReadAsStringAsync();

                        if (updateResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("RAM bought successfully!");
                        }
                        else
                        {
                            MessageBox.Show($"Failed to buy RAM. Status Code: {updateResponse.StatusCode}. Response: {updateResponseString}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("RAM not found or out of stock!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Incorrect card details!");
            }
        }
    }
}
