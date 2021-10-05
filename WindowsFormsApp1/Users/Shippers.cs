using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Users
{
    public partial class Shippers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Get Database
        SqlConnection CommerceDb = new SqlConnection(@"Data Source=DESKTOP-PRSHKS5\SQLEXPRESS;Initial Catalog=CommerceDb;Integrated Security=True");

        public Shippers()
        {
            InitializeComponent();
        }

        //Get Table
        public void makeShipperList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select u.Id, sh.Name as 'Company Name', u.Email, u.Username From Users as u inner join Shippers as sh on u.Id=sh.Id where u.isDeleted = 0;", CommerceDb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Shippers_Load(object sender, EventArgs e)
        {
            //Load Table
            makeShipperList();
        }


        //Get Inputs
        public string compName, email, username, Id;

        private void textbox_uname_TextChanged(object sender, EventArgs e)
        {
            username = textbox_uname.Text;
        }

        private void textbox_email_TextChanged(object sender, EventArgs e)
        {
            email = textbox_email.Text;
        }        

        private void textbox_name_TextChanged(object sender, EventArgs e)
        {
            compName = textbox_name.Text;
        }

        private void textbox_Id_TextChanged(object sender, EventArgs e)
        {
            Id = textbox_Id.Text;
        }


        //Get Info From Table
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textbox_Id.Text = dr[0].ToString();
                textbox_name.Text = dr[1].ToString();
                textbox_email.Text = dr[2].ToString();
                textbox_uname.Text = dr[3].ToString();
            }
        }


        //In tab Buttons
        //Clear Button
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            textbox_Id.Text = "";
            textbox_name.Text = "";
            textbox_email.Text = "";
            textbox_uname.Text = "";
        }

        //Export To PDF
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string pdfExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Shippers_" + DateTime.Now.ToShortDateString() + ".pdf";
            gridControl1.ExportToPdf(pdfExportFile);
        }

        //Export To XLS
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string xlsExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Shippers_" + DateTime.Now.ToShortDateString() + ".xls";
            gridControl1.ExportToXls(xlsExportFile);
        }
    }
}
