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

        private void ButDo_Click(object sender, EventArgs e)
        {
            try
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
                        txtOutput.Text = result.Content.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
