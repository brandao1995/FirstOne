using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace FINAL
{
    public partial class Form1 : Form{
    
        public Form1()
        {
            InitializeComponent();
        }

        
       
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage4;
        }  

        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable programists = new DataTable();
            programists.Columns.Add("Race_ID", typeof(int));
            programists.Columns.Add("Name_of_Country", typeof(string));
            programists.Columns.Add("Name_of_City", typeof(string));
            programists.Columns.Add("Start_Data", typeof(double));
            programists.Columns.Add("End_Data", typeof(double));
            programists.Columns.Add("Time_in_Air(hours)", typeof(int));
            programists.Columns.Add("Price($)", typeof(int));
            programists.PrimaryKey = new DataColumn[] { programists.Columns["ID"] };

            programists.Rows.Add(1, "Turkey","Ankara", 17.11,28.12,7,1000);
            programists.Rows.Add(2, "Egypt", "Kair", 2.11, 28.12, 7, 2000);
            programists.Rows.Add(3, "Brazil", "Brazil", 4.11, 28.12, 7, 3000);
            programists.Rows.Add(4, "Italy", "Roma", 7.11, 28.12, 7,4000);
            programists.Rows.Add(5, "Germany", "Berlin", 27.11, 28.12, 7, 5000);
            programists.Rows.Add(6, "Russia", "Moscow", 23.11, 28.12, 7, 6000);

          


            
            DataSet WW = new DataSet("RELATIONSHIPS");
            DataTable techo = WW.Tables.Add();
            techo.Columns.Add("Race_ID", typeof(int));
            techo.Columns.Add("Name_of_Country", typeof(string));
            techo.Columns.Add("Name_of_City", typeof(string));
            techo.Columns.Add("Start_Data", typeof(double));
            techo.Columns.Add("End_Data", typeof(double));
            techo.Columns.Add("Time_in_Air(hours)", typeof(int));
            techo.Columns.Add("Price($)", typeof(int));
            techo.PrimaryKey = new DataColumn[] { techo.Columns["ID"] };



            techo.Rows.Add(1, "Turkey", "Ankara", 17.11, 28.12, 7, 1000);
            techo.Rows.Add(2, "Egypt", "Kair", 2.11, 28.12, 7, 2000);



            
            DataTable skill = WW.Tables.Add();
            skill.Columns.Add("Race_ID", typeof(int));
            skill.Columns.Add("Name_of_Country", typeof(string));
            skill.Columns.Add("Name_of_City", typeof(string));
            skill.Columns.Add("Start_Data", typeof(double));
            skill.Columns.Add("End_Data", typeof(double));
            skill.Columns.Add("Time_in_Air(hours)", typeof(int));
            skill.Columns.Add("Price($)", typeof(int));
            skill.PrimaryKey = new DataColumn[] { skill.Columns["ID"] };

            




            skill.Rows.Add(1, "dsafsf", "fdsfsdf", 200);
            skill.Rows.Add(2, "fsfdsf", "fdsfs", 404);
            skill.Rows.Add(3, "gfdgdf", "fdsfdf", 600);
            




            //виводжу на екран
            dataGridView1.DataSource = programists;
            dataGridView2.DataSource = techo;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage4;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage7;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage8;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage1;
        }

       
       

       

        
    }
}
