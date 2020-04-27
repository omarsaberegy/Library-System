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

namespace project
{
    public partial class Form1 : Form
    {

        int h, z = 0, test,hh,nn,zz,tt=0;
        string amr,tata;

        int[] arr = new int[10];
        OpenFileDialog ofd = new OpenFileDialog();
        
        public TextBox[] buttonArray = new TextBox[15];
        public TextBox[] buttonArray1 = new TextBox[15];
        public Label[] LabelArray = new Label[15];
        public Label[] LabelArray1 = new Label[15];
        public Label[] LabelArray_table = new Label[15];
        public CheckedListBox table_attribute = new CheckedListBox();
        
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
                buttonArray[i].Location = new Point (320, 75 + (i * 30));
                LabelArray[i].Location = new Point(260, 78 + (i * 30));
                LabelArray[i].Text = "file rqm " + (i + 1);
               
                ofd.ShowDialog();
                buttonArray[i].Text = ofd.SafeFileName;
                this.Controls.Add(buttonArray[i]);
                this.Controls.Add(LabelArray[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Label lab = new Label();
            lab.Location = new Point(15, 13);
            lab.Text = "AsMa2 L files -->" ;
            this.Controls.Add(lab);
            for (int i = 0; i < h; i++)
            {
                buttonArray1[i] = new TextBox();
                buttonArray1[i].Location = new Point((40 + (i * 120)),40 );

                buttonArray1[i].Text = buttonArray[i].Text;
                this.Controls.Add(buttonArray1[i]);
               
            }
                    table_attribute = new CheckedListBox();
            
            
            for (int i=0 ; i < h; i++)
            {
                var readXML = new DataSet();
                readXML.ReadXml(buttonArray[i].Text);
                z = 0;
                foreach (DataTable table in readXML.Tables)
                {
                    LabelArray_table  = new Label[15];
              //      LabelArray_table[i].Location = new Point(190, 85 );
                    table_attribute.Location = new Point(250, 85  );
                //    LabelArray_table[i].Size=new Size(60, 20);
                    table_attribute.Size = new Size(300,100);
                 //   LabelArray_table[i].Text = "join wz:";
                    table_attribute.Name = "table_attribute";
                    // MessageBox.Show(table.TableName);
                    foreach (DataColumn column in table.Columns)
                    {
                        table_attribute.Items.Add( column.ColumnName + "  #  "+buttonArray[i].Text );
                        z++;
                        //MessageBox.Show(column.ColumnName);
                        // Console.Write("{0}\t", column.ColumnName);
                    }
                    
                    this.Controls.Add(table_attribute);
                    /* foreach (DataRow row in table.Rows)
                     {
                         foreach (DataColumn column in table.Columns)
                         {
                            // Console.Write("{0}\t", row[column]);// ------ here are the Values of the Attributes --------- 
                         }
                     }*/
                   // this.Controls.Add(LabelArray_table[i]);
                   
                }
                arr[i] = z;
                //if (i==0)
                //{
                //    arr[i] = z;
                //}
                //else
                //{
                //    arr[i] = z - arr[i];
                //}
                
            }

            table_attribute.Click += new EventHandler(table_attribute_click);
            Button btn = new Button();
            btn = new Button();
            btn.Location = new Point(604, 259);
            btn.Text = "Join..!";
            btn.Name = "btn";
            btn.Click += new EventHandler(buttonclick);
            this.Controls.Add(btn); 
            
        }
        public void table_attribute_click (object sender , EventArgs e)
        {

        }

        public void buttonclick(object sender, EventArgs e)
        {

            DataGridView dt = new DataGridView();
             
            dt = new DataGridView();
            
             
            foreach (object item in table_attribute.CheckedItems)

            {
                tata = "";

                nn = 0;
                test = table_attribute.Items.IndexOf(item)+1;
                
                for (int j = 0; j < h; j++)
                    {
                    if (test>=arr[j])
                    {
                        zz = test - arr[j];
                    }
                        else
                    {
                        zz = 0; 
                    }

                        if (zz > 0)
                        {
                            nn++;
                        }
                        test = zz;

                    } 
                amr = item.ToString(); 

                    for (int g=0; g< amr.Length;g++)
                {
                    if (amr[g].ToString() == " ")
                    {
                        break;
                    }
                    tata   += amr[g].ToString();
                 
                } 

                XmlDocument doc1 = new XmlDocument();
               
                doc1.Load(buttonArray[nn].Text);
                this.Controls.Clear();
                dt.Size = new Size(832, 384);
                this.Controls.Add(dt);
              
                List<string> row = new List<string>();
                XmlNodeList list = doc1.GetElementsByTagName(tata);
                for (int o = 0; o < list.Count; o++)
                {

                    XmlNodeList child = list[o].ChildNodes;
                    string ch = child[0].Name;
                    string ch1 = child[0].InnerText;
                    if (dt.ColumnCount == tt)
                    {
                        dt.Columns.Add(tata, amr);

                       
                    }

                    dt.Rows.Add(new string[] { ch1 });

                }
                tt++; 

            } 
               

            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
