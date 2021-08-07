using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApi.BE;

namespace WinTestConsumeWebApi
{
    public partial class FrmPrinc : Form
    {
        public FrmPrinc()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CallWithHttpClientAsync()
        {
            StudentBE student = new StudentBE
            {
                Codigo = 1,
                Nombre = "stud1"
            };

            using (var client = new HttpClient())
            {
                var url = ConfigurationManager.AppSettings["urlConn"];
                client.BaseAddress = new Uri(url);
                //HTTP POST
                var postTask = client.PostAsJsonAsync<StudentBE>("student", student);
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    // var jsonPuro = result.Content.ToString();
                    string jsonPuro = result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    txtOutput.Text = jsonPuro;
                    // var objStudent = JsonConvert.DeserializeObject<ResponseMyApi>(jsonPuro);
                    // txtOutput.Text += Environment.NewLine + objStudent.ToString();
                    // txtOutput.Text += Environment.NewLine + objStudent.ToString();
                }
            }
        }

        private void ButDo_Click(object sender, EventArgs e)
        {
            try
            {
                CallWithHttpClientAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
