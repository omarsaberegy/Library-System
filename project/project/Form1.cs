using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace project
{
    public partial class Form1 : Form
    {
        int h;
        OpenFileDialog ofd = new OpenFileDialog();
        
        public TextBox[] buttonArray = new TextBox[15];
        public Label[] LabelArray = new Label[15];
        
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {


            this.Controls.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            h = Int32.Parse(comboBox1.SelectedItem.ToString());
            for (int i = 0; i < h; i++)
            {
                buttonArray[i] = new TextBox();
                LabelArray[i] = new Label();
                buttonArray[i].Location = new Point (470, 85 + (i * 30));
                LabelArray[i].Location = new Point(400, 88 + (i * 30));
                LabelArray[i].Text = "file rqm " + (i + 1);
               
                ofd.ShowDialog();
                buttonArray[i].Text = ofd.SafeFileName;
                this.Controls.Add(buttonArray[i]);
                this.Controls.Add(LabelArray[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(buttonArray[0].Text);
            XmlNodeList list = doc.GetElementsByTagName(buttonArray[0].Text);
            this.Controls.Clear();
            CheckBox Check_box = new CheckBox();
            Check_box.Text = lost.Count.ToString();
            Check_box.Location = new Point(470, 85 + (0 * 30));
            dataGridView1.
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var xml1 = XDocument.Load(buttonArray[0].Text);
            var xml2 = XDocument.Load(buttonArray[1].Text);

            //Combine and remove duplicates
            var combinedUnique = xml1.Descendants("AllNodes")
                                      .Union(xml2.Descendants("AllNodes"));
        }
    }
}
