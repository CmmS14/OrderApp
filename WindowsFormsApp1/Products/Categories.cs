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

namespace WindowsFormsApp1.Products
{
    public partial class Categories : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Get Database
        SqlConnection CommerceDb = new SqlConnection(@"Data Source=DESKTOP-PRSHKS5\SQLEXPRESS;Initial Catalog=CommerceDb;Integrated Security=True");

        public Categories()
        {
            InitializeComponent();
        }
         
        //Get Table
        public void makeCategoriesList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select c.Id, c.Name, c.ParentId as 'Parent Id', ct.Name as 'Parent Name' From Categories as c left join Categories as ct on c.ParentId=ct.ID;", CommerceDb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            //Get Categories to Combobox
            this.categoriesTableAdapter.Fill(this.commerceDbDataSet3.Categories);

            //Load Table
            makeCategoriesList();

        }


        //Get Inputs
        public string ctgName, ParentName, Id;

        private void textbox_Name_TextChanged(object sender, EventArgs e)
        {
            ctgName = textbox_Name.Text;
        } 

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ParentName = comboBox1.Text;
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
                textbox_Name.Text = dr[1].ToString();
            }
        }


        //In tab Buttons
        //Clear Button
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            textbox_Name.Text = "";
            comboBox1.Text = "";
        }

        //Export To XLS
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string pdfExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Categories_" + DateTime.Now.ToShortDateString() + ".pdf";
            gridControl1.ExportToPdf(pdfExportFile);
        }

        //Export To PDF
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string xlsExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Categories_" + DateTime.Now.ToShortDateString() + ".xls";
            gridControl1.ExportToXls(xlsExportFile);
        }

    }
}
