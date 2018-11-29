using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonComrades.Forms
{
    public partial class FormComments : Form
    {
        public FormComments()
        {
            InitializeComponent();
        }

        private async void FormComments_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/comments");
            List<Comments> posts = JsonConvert.DeserializeObject<List<Comments>>(result);
            dataGV_Comments.DataSource = posts;
        }

        private void dataGV_Comments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
