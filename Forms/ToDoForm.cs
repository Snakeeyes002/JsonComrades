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
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
        }

        private void dgToDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ToDoForm_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/posts");
            List<ToDo> toDos = JsonConvert.DeserializeObject<List<ToDo>>(result);
            dgToDo.DataSource = toDos;
         
        }
    }
}
