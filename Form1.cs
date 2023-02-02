using static WinFormsApp1.DataFrame;
using System.Data;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using FastMember;
using System.Data.Common;
using Newtonsoft.Json.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var table = await MakeRequest();
            dataGridView1.DataSource = table;
        }

        static async Task<DataTable> MakeRequest()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.CacheControl = CacheControlHeaderValue.Parse("no-cache");

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "put your key here");
            var uri = "https://comtradeapi.un.org/data/v1/get/C/A/HS?reporterCode=392&period=2022&partnerCode=643&flowCode=M&breakdownMode=plus&includeDesc=false"; //your request uri

            var response = await client.GetAsync(uri);
            Console.WriteLine(response);

            StringBuilder stringBuilder = new StringBuilder();

            // асинхронное чтение
            using (StreamReader reader = new StreamReader(response.Content.ReadAsStream()))
            {
                string? line;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    stringBuilder.Append(line.ToString());
                }
            }
            Root apiData = JsonConvert.DeserializeObject<Root>(stringBuilder.ToString());

            DataTable table = new DataTable();

            if (apiData != null)
            {

                using (var reader = ObjectReader.Create(apiData.data))
                {

                    table.Load(reader);
                }
            }
            return table;
        }
    }
}