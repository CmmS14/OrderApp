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
    public partial class Suppliers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Get Database
        SqlConnection CommerceDb = new SqlConnection(@"Data Source=DESKTOP-PRSHKS5\SQLEXPRESS;Initial Catalog=CommerceDb;Integrated Security=True");

        public Suppliers()
        {
            InitializeComponent();
        }

        //Get Table
        public void makeSupplierList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Update Suppliers set Rate = 0 where Rate is null; Select u.Id, s.TaxNumber as 'Tax Number', s.Name as 'Company Name', u.Email, u.Username, s.Rate as 'Rate%' From Users as u inner join Suppliers as s on u.Id=s.Id where u.isDeleted = 0;", CommerceDb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            //Load Table
            makeSupplierList();
        }


        //Get Inputs
        public string taxNumber, compName, email, username, Id;

        private void textbox_email_TextChanged(object sender, EventArgs e)
        {
            email = textbox_email.Text;
        }

        private void textbox_taxno_TextChanged(object sender, EventArgs e)
        {
            taxNumber = textbox_taxno.Text;
        }

        private void textbox_uname_TextChanged(object sender, EventArgs e)
        {
            username = textbox_uname.Text;
        }

        private void textbox_Id_TextChanged(object sender, EventArgs e)
        {
            Id = textbox_Id.Text;
        }

        private void textbox_name_TextChanged(object sender, EventArgs e)
        {
            compName = textbox_name.Text;
        }


        //Get Info From Table
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textbox_Id.Text = dr[0].ToString();
                textbox_taxno.Text = dr[1].ToString();
                textbox_name.Text = dr[2].ToString();
                textbox_email.Text = dr[3].ToString();
                textbox_uname.Text = dr[4].ToString();
                textbox_rate.Text = dr[5].ToString()+"%";

                int rate = Convert.ToInt32(dr[5].ToString());                
                if (rate <= 25)
                {
                    ratingControl1.EditValue = 0;
                }
                else if (rate <= 50 && rate > 25)
                {
                    ratingControl1.EditValue = 1;
                }
                else if (rate <= 70 && rate > 50)
                {
                    ratingControl1.EditValue = 2;
                }
                else if (rate <= 85 && rate > 70)
                {
                    ratingControl1.EditValue = 3;
                }
                else if (rate <= 95 && rate > 85)
                {
                    ratingControl1.EditValue = 4;
                }
                else if (rate > 95)
                {
                    ratingControl1.EditValue = 5;
                }
                else
                {
                    ratingControl1.EditValue = 0;
                }

            }
        }


        //In tab Buttons
        //Clear Button
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            textbox_Id.Text = "";
            textbox_taxno.Text = "";
            textbox_name.Text = "";
            textbox_email.Text = "";
            textbox_uname.Text = "";
            textbox_rate.Text = "";
            ratingControl1.EditValue = 0;
        }

        //Export To PDF
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string pdfExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Suppliers_" + DateTime.Now.ToShortDateString() + ".pdf";
            gridControl1.ExportToPdf(pdfExportFile);
        }

        //Export To XLS
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string xlsExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Suppliers_" + DateTime.Now.ToShortDateString() + ".xls";
            gridControl1.ExportToXls(xlsExportFile);
        }
    }
}
