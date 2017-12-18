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
    public partial class Form2 : Form
    {
        OracleConnection CON1;
        OracleDataReader RDR;
        OracleCommand cmd;
        string query;
        public Form2()
        {
            InitializeComponent();
            CON1 = new OracleConnection("Data source = localhost;User Id = DBMS;Password = nh");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "select sn.title from SONG sn, RELATIONSHIP r where sn.song_id = r.song_id and r.year =2017";
            
            cmd = new OracleCommand(query,CON1);
            CON1.Open();
            RDR = cmd.ExecuteReader();
            while (RDR.Read())
            {
                ListViewItem ls = new ListViewItem(RDR["TITLE"].ToString());
                listView1.Items.Add(ls);
            }
            RDR.Close();
            CON1.Close();
        }
    }
}
