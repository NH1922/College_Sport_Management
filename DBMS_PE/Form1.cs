using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DBMS_PE
{
    public partial class Form1 : Form
    {
        OracleConnection CON1;
        OracleDataReader RDR;
        OracleCommand cmd;
        string QUERY;
        Form3 f3 = new Form3();
        Form2 f2 = new Form2();
        Form4 f4 = new Form4();
        public Form1()
        {
            InitializeComponent();
            CON1 = new OracleConnection("Data source = localhost; User ID = DBMS;Password = nh");
        }
        


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                f2.Show();

            if (radioButton2.Checked == true)
                f3.Show();
            if (radioButton3.Checked == true)
                f4.Show();
        }
    }
}
