using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
namespace LoginPassword
{
    public partial class Form1 : Form
    {
        public HttpClient http = new HttpClient();
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            HttpResponseMessage response = await http.GetAsync(new Uri("https://free.currconv.com/api/v7/convert?q=USD_PHP&compact=ultra&apiKey=a0115f69bd71c7635a86"));
            var result = await response.Content.ReadAsStringAsync();
            Currency a = new Currency();
            a = JsonConvert.DeserializeObject<Currency>(result);
            label2.Text = a.course.ToString();
        }
    }
}
