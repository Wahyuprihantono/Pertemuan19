using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
        (@"Data Source=DESKTOP-SH1QONQ\WahyuPH(56))*;Initial Catalog=kantinamikom;Integrated Security=True");

        private void resetdata()
        {
            txtid.Text = "";
            txtnama.Text = "";
            txtvoucher.Text = "";
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "customer");
            dgvcustomer.DataSource = ds;
            dgvcustomer.DataMember = "customer";
            dgvcustomer.ReadOnly = true;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer where namacustomer like '%" + txtcaridata.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "customer");
            dgvcustomer.DataSource = ds;
            dgvcustomer.DataMember = "customer";
            dgvcustomer.ReadOnly = true;
        }

        }

    }
}
