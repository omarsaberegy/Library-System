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
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace project
{
    public partial class Form1 : Form
    {
     

        int h; // the number of xml files that the user choiced them to work on.
        int z = 0; //counter contains the number of all columns in all xml what i work on them .
        int test, nn, zz;
        int jj = 0; // the same thing as z and i may delete it 
        string[] All_Xml_Files_Attribues =new string [100]; // the array which will contain all attributes of all xml files without repeating
        string[] Repetition_Atrributes = new string[100];  // an array contain the repetition attributes

        int[] arr = new int[10];  // which contain variable (z)

        string[] amr = new string[100];
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

                    int y = 0; // index of tat array which contain the attributes of all tables
                    int q = 0;  // index of tat array which contain the repetition attributes of all tables
            for (int i=0 ; i < h; i++)
            {

                DataSet readXML = new DataSet();
                readXML.ReadXml(buttonArray[i].Text);
                z = 0;
                foreach (DataTable table in readXML.Tables)
                { 

                    table_attribute.Location = new Point(300, 250  ); 
                    table_attribute.Size = new Size(300,100); 
                    table_attribute.Name = "table_attribute"; 
                    foreach (DataColumn column in table.Columns)
                    {
                        bool is_there = false;
                        for (int a = 0; a < All_Xml_Files_Attribues.Length; a++)
                        {
                            if (All_Xml_Files_Attribues[a] == column.ColumnName)
                            {
                                is_there = true;
                                Repetition_Atrributes[q]=column.ColumnName;
                                q++;
                                break;
                            }
                            else
                                is_there = false;
                        }
                        if (is_there == false)
                        {
                            All_Xml_Files_Attribues[y] = column.ColumnName;
                            y++;
                        }

                        table_attribute.Items.Add( column.ColumnName  );
                        z++;
                        jj++;
                       
                    }
                    
                    this.Controls.Add(table_attribute);
                  
                }
                arr[i] = z;
              
                
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
            this.Controls.Clear();
            dt.Size = new Size(800, 200);
            this.Controls.Add(dt);


            List<DataSet> AllTables = new List<DataSet>();

            // ** Reading the other xml files **//
            for (int i = 0; i < h; i++)
            {
                bool Founded = false;
                DataSet Dt = new DataSet();
                Dt.ReadXml(buttonArray[i].Text);
                foreach (DataTable table in Dt.Tables)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        for (int K = 0; K < Repetition_Atrributes.Length; K++)
                        {

                            if (column.ColumnName == Repetition_Atrributes[K])
                            {
                                AllTables.Add(Dt);
                                Founded = true;
                                break;
                            }
                        }

                        if (Founded == true)
                            break;
                    }
                    if (Founded == true)
                        break;
                }
                AllTables.Add(Dt);
            }






            DataTable Merged_Table = AllTables[0].Tables[0];
            for (int i = 1; i < AllTables.Count; i++)
            {
                Merged_Table.Merge(AllTables[i].Tables[0]);

            }

            dt.DataSource = Merged_Table;

            // To modify table shape
            MessageBox.Show(Repetition_Atrributes.Length.ToString());

            for (int D = 0; D < Repetition_Atrributes.Length; D++)
            {
                if (Repetition_Atrributes[D] == null)
                    break;
                else
                {
                    string primaryKeyColumn = Repetition_Atrributes[D];         // need to update it soon 
                    var pkGroups = Merged_Table.AsEnumerable()
                   .GroupBy(r => r[primaryKeyColumn]);
                    var dupGroups = pkGroups.Where(g => g.Count() > 1);
                    foreach (var grpDup in dupGroups)
                    {
                        // use first row and modify it
                        DataRow firstRow = grpDup.First();
                        foreach (DataColumn c in Merged_Table.Columns)
                        {
                            if (firstRow.IsNull(c))
                            {
                                DataRow firstNotNullRow = grpDup.Skip(1).FirstOrDefault(r => !r.IsNull(c));
                                if (firstNotNullRow != null)
                                    firstRow[c] = firstNotNullRow[c];
                            }
                        }
                        // remove all but first row
                        var rowsToRemove = grpDup.Skip(1);
                        foreach (DataRow rowToRemove in rowsToRemove)
                            Merged_Table.Rows.Remove(rowToRemove);
                    }

                }
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
