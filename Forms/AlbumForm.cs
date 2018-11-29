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
    public partial class AlbumForm : Form
    {
        public AlbumForm()
        {
            InitializeComponent();
        }
        private async void AlbumForm_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/albums");
            List<Album> albums = JsonConvert.DeserializeObject<List<Album>>(result);
            this.dataGridView1.DataSource = albums;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
