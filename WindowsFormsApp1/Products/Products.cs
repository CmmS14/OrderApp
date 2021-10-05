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
    public partial class Products : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Get Database
        SqlConnection CommerceDb = new SqlConnection(@"Data Source=DESKTOP-PRSHKS5\SQLEXPRESS;Initial Catalog=CommerceDb;Integrated Security=True");

        public Products()
        {
            InitializeComponent();
        }

        //Get Table
        public void makeProductsList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select p.Id, p.Name, p.Description, p.Price, s.Name as 'Suplier', c.Name as 'Category', ct.Name as '< Category', ctg.Name as '< Category' From Products as p inner join Suppliers as s on p.SupplierId = s.Id inner join ProductCategories as pc on pc.ProductId = p.Id inner join Categories as c on c.Id = pc.CategoryId left join Categories as ct on c.ParentId = ct.Id left join Categories as ctg on ct.ParentId = ctg.Id where p.IsDeleted = 0", CommerceDb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            //Get Categories to Combobox
            this.categoriesTableAdapter.Fill(this.commerceDbDataSet5.Categories);
            //Get Suppliers to Combobox
            this.suppliersTableAdapter.Fill(this.commerceDbDataSet5.Suppliers);
            
            //Load Table
            makeProductsList();
        }

        //Get Inputs
        public string Id, prdName, description, price, suppliername, categoryname;
        private void textbox_Id_TextChanged(object sender, EventArgs e)
        {
            Id = textbox_Id.Text;
        }

        private void textbox_Name_TextChanged(object sender, EventArgs e)
        {
            prdName = textbox_Name.Text;
        }

        private void TextBox_description_TextChanged(object sender, EventArgs e)
        {
            description = TextBox_description.Text;
        }

        private void textbox_price_TextChanged(object sender, EventArgs e)
        {
            price = textbox_price.Text;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            suppliername = comboBox1.Text;
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            categoryname = comboBox2.Text;
        }


        //Get Info From Table
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textbox_Id.Text = dr[0].ToString();
                textbox_Name.Text = dr[1].ToString();
                TextBox_description.Text = dr[2].ToString();
                textbox_price.Text = dr[3].ToString();
                comboBox1.Text = dr[4].ToString();
                comboBox2.Text = dr[5].ToString();
            }
        }


        //In tab Buttons
        //Clear Button
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            textbox_Id.Text = "";
            textbox_Name.Text = "";
            TextBox_description.Text = "";
            textbox_price.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        //Export To PDF
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string xlsExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Products_" + DateTime.Now.ToShortDateString() + ".xls";
            gridControl1.ExportToXls(xlsExportFile);
        }
        //Export To XLS
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string pdfExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\" + "Products_" + DateTime.Now.ToShortDateString() + ".pdf";
            gridControl1.ExportToPdf(pdfExportFile);
        }

       
    }
}
