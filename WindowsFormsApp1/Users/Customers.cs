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
using DevExpress.XtraEditors;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Users
{
    public partial class Customers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Get Database
        SqlConnection CommerceDb = new SqlConnection(@"Data Source=DESKTOP-PRSHKS5\SQLEXPRESS;Initial Catalog=CommerceDb;Integrated Security=True");        
        
        public Customers()
        {
            InitializeComponent();
        }

        //Get Table
        public void makeCustomerList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select u.Id, c.IdentityNumber as 'Identity No', c.FirstName as 'First Name', c.LastName as 'Last Name', u.Username, u.Email From users as u inner join customers as c on u.Id=c.Id where u.isDeleted = 0;", CommerceDb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            //Load Table
            makeCustomerList();
        }


        //Get Inputs
        public string Identitynumber, FirstName, LastName, Username, Email, Gender, Id;

        private void text_email_TextChanged(object sender, EventArgs e)
        {
            Email = textbox_email.Text;
        }        

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Gender = comboBox1.Text;
        }       

        private void text_uname_TextChanged(object sender, EventArgs e)
        {
            Username = textbox_uname.Text;
        }

        private void textbox_Id_TextChanged(object sender, EventArgs e)
        {
            Id = textbox_Id.Text;
        }

        private void text_lname_TextChanged(object sender, EventArgs e)
        {
            LastName = textbox_lname.Text;
        }

        private void text_fname_TextChanged(object sender, EventArgs e)
        {
            FirstName = textbox_fname.Text;
        }

        private void textbox_Identity_TextChanged(object sender, EventArgs e)
        {
            Identitynumber = textbox_Identity.Text;
        }


        //Get Info From Table
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textbox_Id.Text = dr[0].ToString();
                textbox_Identity.Text = dr[1].ToString();
                textbox_fname.Text = dr[2].ToString();
                textbox_lname.Text = dr[3].ToString();
                textbox_uname.Text = dr[4].ToString();
                textbox_email.Text = dr[5].ToString();

            }
        }

        //In tab Buttons
        //Clear Button
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            textbox_Id.Text = "";
            textbox_Identity.Text = "";
            textbox_fname.Text = "";
            textbox_lname.Text = "";
            textbox_uname.Text = "";
            textbox_email.Text = "";
        }
        
        //Export To PDF
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string pdfExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Customers_" + DateTime.Now.ToShortDateString() + ".pdf";
            gridControl1.ExportToPdf(pdfExportFile);
        }
        
        //Export To XLS
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string xlsExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Customers_" + DateTime.Now.ToShortDateString() + ".xls";
            gridControl1.ExportToXls(xlsExportFile);
        }


    }
}
