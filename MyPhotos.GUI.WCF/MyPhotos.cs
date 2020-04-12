using MyPhotos.Persistence;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotos.GUI
{
    public partial class MyPhotos : Form
    {
        MyPhotosWcfClient api = new MyPhotosWcfClient();

        public MyPhotos()
        {
            InitializeComponent();
            InitializeSelect();
        }

        private void InitializeSelect()
        {
            comboBox1.Items.Clear();
            listView1.Scrollable = true;
            listView1.View = View.Details;
            var properties = api.GetAllPropertiesAsStrings();
            foreach (var prop in properties)
            {
                comboBox1.Items.Add(prop);
            }
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            nameTextBox.Text = "ceva";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Add Image/Video",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "jpg",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|;*.MP4" +
"All files (*.*)|*.*",
            ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter =
"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
"All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select Photos";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    ShowImage(file);
                }
            }
        }
        public bool ThumbnailCallback()
        {
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var place = placeTextBox.Text;
            var @event = eventTextBox.Text;
            var people = peopleTextBox.Text.Split(',').ToList();
            var path = pathTextBox.Text;

            var id = api.CreatePhoto(path, name, @event, place, people.ToArray());
            textBox1.Text = id.ToString();
            label10.Text = "Photo " + name + " added!";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowAllPhotos();
        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            var selected = listView1.SelectedItems.GetEnumerator();
            string id ="Not Found";
            if (selected.MoveNext())
            {
                id = selected.Current.ToString().Split(':')[1].Substring(2);
                var photo = api.GetAllPhotos().FirstOrDefault(p => p.Id == Guid.Parse(id));
                var path = photo.Path;
                textBox1.Text = id;
                pathTextBox.Text = path;
                Path.GetFullPath(path);
                ShowImage(path);
            }
            else 
                selected.Reset();
        }

        private void ShowImage(string file)
        {
            try
            {
                pictureBox1.Controls.Clear();
                PictureBox imageControl = new PictureBox();
                imageControl.Height = 600;
                imageControl.Width = 900;

                Image.GetThumbnailImageAbort myCallback =
                    new Image.GetThumbnailImageAbort(ThumbnailCallback);
                Bitmap myBitmap = new Bitmap(file);
                Image myThumbnail = myBitmap.GetThumbnailImage(300, 300,
                    myCallback, IntPtr.Zero);
                imageControl.Image = myThumbnail;

                pictureBox1.Controls.Add(imageControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowAllPhotos()
        {
            var photos = api.GetAllPhotos();
            ShowPhotos(photos);
        }

        private void ShowPhotos(IEnumerable<Photo> photos)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            var names = photos.Select(p => p.Id.ToString() + ": Name: " + p.Name).ToArray();

            names.ToList().ForEach(n => listView1.Items.Add(new ListViewItem(n)));
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Id Photo Name";
            columnHeader1.Width = 500;
            this.listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            this.listView1.View = View.Details;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void showFiltered_Click(object sender, EventArgs e)
        {
            var property = comboBox1.Text;
            var value = textBox2.Text;
            pathTextBox.Text = property + value;
            IEnumerable<Photo> filteredPhotos= api.GetFilteredPhotos(property, value);
            ShowPhotos(filteredPhotos);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PropertyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var idPhoto = textBox1.Text;
            var customPropertyName = PropertyName.Text;
            var customPropertyValue = PropertyValue.Text;

            api.AddCustomProperty(idPhoto, customPropertyName, customPropertyValue);
            label9.Text = "Property added!";
            InitializeSelect();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //api.SendResultsToEmail(new List<string>{"id1", "id2"}, textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //api.ConfirmPhotoDeleted("id1");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
