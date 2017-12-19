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
    public partial class Form4 : Form
    {
        OracleConnection CON;
        OracleCommand CMD;
        OracleDataReader RDR;
        string QUERY;
        public Form4()
        {
            InitializeComponent();
            CON = new OracleConnection("Data Source = localhost;User ID = dbms;Password=nh");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QUERY = "select count(distinct sn.song_id) as total from song sn, relationship r where sn.song_id=r.song_id and r.year=2017";
            CMD = new OracleCommand(QUERY, CON);
            CON.Open();
            RDR = CMD.ExecuteReader();
            while (RDR.Read())
            {
                ListViewItem ls = new ListViewItem(RDR["total"].ToString());
                listView1.Items.Add(ls);
            }
            RDR.Close();
            CON.Close();
        }
    }
}
