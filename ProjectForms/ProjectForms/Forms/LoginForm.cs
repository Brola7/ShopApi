using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using ProjectForms.Entities;

namespace ProjectForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            string token;
            bool isAdmin;
            User currentUser = null;

            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(new { Username = UsernameBox.Text, Password = PasswordBox.Text }), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7035/api/Auth/login", content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Login failed");
                }

                var responseString = await response.Content.ReadAsStringAsync();
                var responseJson = JObject.Parse(responseString);

                token = responseJson["token"].ToString();
                var userFromRepoJson = responseJson["userFromRepo"].ToString();
                currentUser = JsonConvert.DeserializeObject<User>(userFromRepoJson);
            }

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            var role = jwtToken.Claims
                                .Where(c => c.Type == "role" || c.Type == ClaimTypes.Role)
                                .Select(c => c.Value)
                                .ToList();

            isAdmin = role.Contains("Admin");

            var mf = new MainForm(isAdmin, true);
            MainForm.token = token;
            MainForm.CurrentUser = currentUser;

            foreach (Form f in Application.OpenForms)
            {
                f.Hide();
                mf.FormClosed += (s, args) => f.Close();
            }

            mf.Show();
        }
    }
}

