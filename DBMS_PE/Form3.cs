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
    public partial class Form3 : Form
    {
        OracleConnection CON1;
        OracleDataReader RDR;
        OracleCommand cmd;
        string QUERY;
        public Form3()
        {
            InitializeComponent();
            CON1 = new OracleConnection("Data source = localhost;User ID=DBMS;Password = nh");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QUERY = "select so.title, r.year from SONG so,SINGER sn, RELATIONSHIP r where so.song_id=r.song_id and sn.singer_id=r.singer_id and sn.singer_id='ZE1'";
            cmd = new OracleCommand(QUERY, CON1);
            CON1.Open();
            RDR = cmd.ExecuteReader();
            
            while(RDR.Read())
            {
                ListViewItem ls = new ListViewItem(RDR["TITLE"].ToString());
                ls.SubItems.Add(RDR["YEAR"].ToString());
                listView1.Items.Add(ls);
            }
            RDR.Close();
            CON1.Close();

        }
    }
}
