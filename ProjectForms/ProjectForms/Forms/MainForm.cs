using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using FinalProject.Controllers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ProjectForms.Entities;

namespace ProjectForms
{
    public partial class MainForm : Form
    {
        public static bool IsAdmin = false;
        public static bool IsLogged = false;
        public static string token { get; set; }

        public enum Category
        {
            CPUs,
            MotherBoards,
            VideoCards,
            RAMs
        }

        public static User CurrentUser { get; set; }

        public static Category category;

        public MainForm(bool isAdmin, bool isLogged)
        {
            InitializeComponent();
            IsAdmin = isAdmin;
            IsLogged = isLogged;

            category = Category.CPUs;

            Addbtn.Visible = (IsLogged && IsAdmin);
            Buybtn.Visible = LogOutbtn.Visible = Profilebtn.Visible = IsLogged;
            Loginbtn.Visible = !IsLogged;

            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7035/api/CPU");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var Cpus = JsonConvert.DeserializeObject<List<Cpu>>(responseBody);
                products.DataSource = Cpus;
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            switch (category)
            {
                case Category.VideoCards:
                    var vcf = new AddVideoCard();
                    vcf.Show();
                    break;
                case Category.CPUs:
                    var cf = new AddCPU();
                    cf.Show();
                    break;
                case Category.MotherBoards:
                    var mbf = new AddMotherBoard();
                    mbf.Show();
                    break;
                case Category.RAMs:
                    var rf = new AddRamForm();
                    rf.Show();
                    break;

                default: break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var BF = new BuyForm(category);
            BF.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            LoginForm.FormClosed += (p, args) => this.Close();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            category = Category.CPUs;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7035/api/CPU");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var Cpus = JsonConvert.DeserializeObject<List<Cpu>>(responseBody);
                products.DataSource = Cpus;
            }
        }

        private async void Videobtn_Click(object sender, EventArgs e)
        {
            category = Category.VideoCards;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7035/api/VC");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var Cpus = JsonConvert.DeserializeObject<List<VideoCard>>(responseBody);
                products.DataSource = Cpus;
            }
        }

        private async void MBbtn_Click(object sender, EventArgs e)
        {
            category = Category.MotherBoards;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7035/api/MB");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var Cpus = JsonConvert.DeserializeObject<List<Motherboard>>(responseBody);
                products.DataSource = Cpus;
            }
        }

        private async void RAMbtn_Click(object sender, EventArgs e)
        {
            category = Category.RAMs;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7035/api/RAM");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var Cpus = JsonConvert.DeserializeObject<List<Ram>>(responseBody);
                products.DataSource = Cpus;
            }
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {
            var pf = new ProfileForm();
            pf.Show();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            foreach (Form f in Application.OpenForms)
            {
                f.Hide();
                lf.FormClosed += (s, args) => f.Close();
            }
            lf.Show();
        }

        private void products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
