namespace MyPhotos.GUI
{
    partial class MyPhotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.place = new System.Windows.Forms.Label();
            this.PropertyName = new System.Windows.Forms.TextBox();
            this.CustomProperty = new System.Windows.Forms.Label();
            this.peopleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PropertyValue = new System.Windows.Forms.TextBox();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.showFiltered = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(584, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(329, 50);
            this.title.TabIndex = 0;
            this.title.Text = "My Photos";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(60, 134);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name: ";
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(60, 187);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(100, 20);
            this.placeTextBox.TabIndex = 6;
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(57, 171);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(40, 13);
            this.place.TabIndex = 5;
            this.place.Text = "Place: ";
            // 
            // PropertyName
            // 
            this.PropertyName.Location = new System.Drawing.Point(63, 554);
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.Size = new System.Drawing.Size(75, 20);
            this.PropertyName.TabIndex = 10;
            this.PropertyName.TextChanged += new System.EventHandler(this.PropertyName_TextChanged);
            // 
            // CustomProperty
            // 
            this.CustomProperty.AutoSize = true;
            this.CustomProperty.Location = new System.Drawing.Point(60, 538);
            this.CustomProperty.Name = "CustomProperty";
            this.CustomProperty.Size = new System.Drawing.Size(87, 13);
            this.CustomProperty.TabIndex = 9;
            this.CustomProperty.Text = "CustomProperty: ";
            // 
            // peopleTextBox
            // 
            this.peopleTextBox.Location = new System.Drawing.Point(60, 296);
            this.peopleTextBox.Name = "peopleTextBox";
            this.peopleTextBox.Size = new System.Drawing.Size(100, 20);
            this.peopleTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "People(separated by , ): ";
            // 
            // eventTextBox
            // 
            this.eventTextBox.Location = new System.Drawing.Point(60, 242);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(100, 20);
            this.eventTextBox.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "AddPhoto";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(208, 326);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 22);
            this.browseButton.TabIndex = 16;
            this.browseButton.Text = "Browse Photo";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(63, 354);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(245, 20);
            this.pathTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Path: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(907, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 271);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PropertyValue
            // 
            this.PropertyValue.Location = new System.Drawing.Point(144, 554);
            this.PropertyValue.Name = "PropertyValue";
            this.PropertyValue.Size = new System.Drawing.Size(81, 20);
            this.PropertyValue.TabIndex = 21;
            // 
            // AddPhoto
            // 
            this.AddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPhoto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddPhoto.Location = new System.Drawing.Point(104, 399);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(176, 50);
            this.AddPhoto.TabIndex = 22;
            this.AddPhoto.Text = "Add Photo/Video";
            this.AddPhoto.UseVisualStyleBackColor = true;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(645, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 35);
            this.button2.TabIndex = 24;
            this.button2.Text = "See All Your Photos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(363, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 271);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Event";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(509, 399);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Property:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Value:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(381, 398);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "Select Property";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // showFiltered
            // 
            this.showFiltered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFiltered.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showFiltered.Location = new System.Drawing.Point(393, 435);
            this.showFiltered.Name = "showFiltered";
            this.showFiltered.Size = new System.Drawing.Size(202, 35);
            this.showFiltered.TabIndex = 34;
            this.showFiltered.Text = "See Your Filtered Photos";
            this.showFiltered.UseVisualStyleBackColor = true;
            this.showFiltered.Click += new System.EventHandler(this.showFiltered_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 515);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID photo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 34);
            this.button3.TabIndex = 37;
            this.button3.Text = "Add Custom Property";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(222, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 39;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 40;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(512, 489);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 41;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(378, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Save result to emai Email:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 20);
            this.button1.TabIndex = 43;
            this.button1.Text = "Send to my email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 538);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(314, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "This photo/video has been moved/deleted. Confirma deleted file!";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(700, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 33);
            this.button4.TabIndex = 45;
            this.button4.Text = "Confirm deleted photo/video!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(665, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "Save results to your computer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MyPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1423, 689);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showFiltered);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddPhoto);
            this.Controls.Add(this.PropertyValue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.eventTextBox);
            this.Controls.Add(this.peopleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PropertyName);
            this.Controls.Add(this.CustomProperty);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.place);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "MyPhotos";
            this.Text = "My Photos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.TextBox PropertyName;
        private System.Windows.Forms.Label CustomProperty;
        private System.Windows.Forms.TextBox peopleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PropertyValue;
        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button showFiltered;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

