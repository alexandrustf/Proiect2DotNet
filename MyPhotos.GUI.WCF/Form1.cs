using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos.Persistence;

namespace MyPhotos.GUI.WCF
{
    public partial class Form1 : Form
    {
        List<Photo> photos = new List<Photo>();
        public Form1()
        {
            InitializeComponent();
            Form1_Load(new object(), EventArgs.Empty);
        }
        // Handler pentru evenimentul Load al ferestrei principale
        private void Form1_Load(object sender, EventArgs e)
        {
            photos = LoadPosts().ToList<Photo>();
            dataGridView1.DataSource = photos;
            dataGridView1.Columns[0].Width = 0;
            if (dataGridView1.Rows.Count > 0)
                dataGridView2.DataSource = photos[0].Properties;
        }
        private static Photo[] LoadPosts()
        {
            var pc = new MyPhotosWcfClient();
            return pc.GetAllPhotos();
        }
        // Handler pentru evenimentul CellMouseClick din DatagridView numit dgp
        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Se afiseaza Comment-urile pentru Post-ul selectat
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = photos[e.RowIndex].Properties;
        }
    }
}

