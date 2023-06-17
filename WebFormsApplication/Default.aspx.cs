using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace WebFormsApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static readonly HttpClient client = new HttpClient();

        protected void LoadUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var response = client.GetAsync("https://dummyjson.com/users").Result;
                response.EnsureSuccessStatusCode();

                var content =  response.Content.ReadAsStringAsync().Result;
                string trimmedString = "["+ ExtractContentBetweenBrackets(content)[0] + "]";
                IEnumerable<User> users = JsonConvert.DeserializeObject<IEnumerable<User>>(trimmedString);
                DisplayUsers(users);

            }
            catch (Exception ex)
            {
                // Handle any errors here
                throw ex;
            }
        }

        static string[] ExtractContentBetweenBrackets(string inputString)
        {
            string pattern = @"\[(.*?)\]";
            MatchCollection matches = Regex.Matches(inputString, pattern);

            string[] extractedContent = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                extractedContent[i] = matches[i].Groups[1].Value;
            }

            return extractedContent;
        }

        private void DisplayUsers(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                var row = new HtmlTableRow();
                row.Cells.Add(new HtmlTableCell() { InnerHtml = user.firstName });
                row.Cells.Add(new HtmlTableCell() { InnerHtml = user.Email });
                row.Cells.Add(new HtmlTableCell() { InnerHtml = user.Phone });
                usersTable.Rows.Add(row);
            }
        }
    }

    public class User
    {
        public string firstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // Add more properties as needed
    }
}