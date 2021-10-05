using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Users;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Security.Cryptography;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Products;
using DevExpress.XtraBars.Ribbon;

namespace WindowsFormsApp1
{

    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Get Database
        SqlConnection CommerceDb = new SqlConnection(@"Data Source=DESKTOP-PRSHKS5\SQLEXPRESS;Initial Catalog=CommerceDb;Integrated Security=True");

        //Get Tabs
        Customers frmcustomers = new Customers();
        Suppliers frmsuppliers = new Suppliers();
        Shippers frmshippers = new Shippers();

        Categories frmcategories = new Categories();
        WindowsFormsApp1.Products.Products frmproducts = new WindowsFormsApp1.Products.Products();

        //To get which tab in we are
        bool customers, suppliers, shippers, categories, products;

        public Form1()
        {
            InitializeComponent();
        }


        //Setting tabs for mdi
        private void btn_customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (suppliers)
                frmsuppliers.Hide();
            if (shippers)
                frmshippers.Hide();
            if (categories)
                frmcategories.Hide();
            if (products)
                frmproducts.Hide();
            customers = true;
            suppliers = false;
            shippers = false;
            categories = false;
            products = false;
            frmcustomers.MdiParent = this;
            frmcustomers.Show();
        }

        private void btn_suppliers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customers)
                frmcustomers.Hide();
            if (shippers)
                frmshippers.Hide();
            if (categories)
                frmcategories.Hide();
            if (products)
                frmproducts.Hide();
            customers = false;
            suppliers = true;
            shippers = false;
            categories = false;
            products = false;
            frmsuppliers.MdiParent = this;
            frmsuppliers.Show();
        }

        private void btn_shippers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customers)
                frmcustomers.Hide();
            if (suppliers)
                frmsuppliers.Hide();
            if (categories)
                frmcategories.Hide();
            if (products)
                frmproducts.Hide();
            customers = false;
            suppliers = false;
            shippers = true;
            categories = false;
            products = false;
            frmshippers.MdiParent = this;
            frmshippers.Show();
        }

        private void btn_categories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customers)
                frmcustomers.Hide();
            if (suppliers)
                frmsuppliers.Hide();
            if (shippers)
                frmshippers.Hide();
            if (products)
                frmproducts.Hide();
            customers = false;
            suppliers = false;
            shippers = false;
            categories = true;
            products = false;
            frmcategories.MdiParent = this;
            frmcategories.Show();
        }

        private void btn_products_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customers)
                frmcustomers.Hide();
            if (suppliers)
                frmsuppliers.Hide();
            if (shippers)
                frmshippers.Hide();
            if (categories)
                frmcategories.Hide();
            customers = false;
            suppliers = false;
            shippers = false;
            categories = false;
            products = true;
            frmproducts.MdiParent = this;
            frmproducts.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Buttons
        //Update Item Button
        private void btn_update_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CommerceDb.Open();
            int Id, msg;
            if (customers)
            {
                if (frmcustomers.Id == null || frmcustomers.Id == "" || frmcustomers.Username == null || frmcustomers.Email == null || frmcustomers.FirstName == null || frmcustomers.LastName == null || frmcustomers.Identitynumber == null || frmcustomers.Username == "" || frmcustomers.Email == "" || frmcustomers.FirstName == "" || frmcustomers.LastName == "" || frmcustomers.Identitynumber == "")
                {
                    if (frmcustomers.Id == null || frmcustomers.Id == "")
                    {
                        msg = 55;
                    }
                    else
                    {
                        msg = 56;
                    }
                }
                else
                {
                    Id = Convert.ToInt32(frmcustomers.Id);
                    SqlCommand sqlCommand = new SqlCommand(@"update Users set Username=@p2,Email=@p3 where Id=@p1; update Customers set FirstName=@p4,LastName=@p5,Gender=@p6,IdentityNumber=@p7 where Id=@p1;", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", Id);
                    sqlCommand.Parameters.AddWithValue("@p2", frmcustomers.Username);
                    sqlCommand.Parameters.AddWithValue("@p3", frmcustomers.Email);
                    sqlCommand.Parameters.AddWithValue("@p4", frmcustomers.FirstName);
                    sqlCommand.Parameters.AddWithValue("@p5", frmcustomers.LastName);
                    sqlCommand.Parameters.AddWithValue("@p6", frmcustomers.Gender == "Male");
                    sqlCommand.Parameters.AddWithValue("@p7", frmcustomers.Identitynumber);
                    sqlCommand.ExecuteNonQuery();
                    msg = 1;
                    frmcustomers.makeCustomerList();
                }
            }
            else if (suppliers)
            {
                if (frmsuppliers.Id == null || frmsuppliers.Id == "" || frmsuppliers.username == null || frmsuppliers.email == null || frmsuppliers.taxNumber == null || frmsuppliers.compName == null || frmsuppliers.username == "" || frmsuppliers.email == "" || frmsuppliers.taxNumber == "" || frmsuppliers.compName == "")
                {
                    if (frmsuppliers.Id == null || frmsuppliers.Id == "")
                    {
                        msg = 55;
                    }
                    else
                    {
                        msg = 56;
                    }
                }
                else
                {
                    Id = Convert.ToInt32(frmsuppliers.Id);
                    SqlCommand sqlCommand = new SqlCommand(@"update Users set Username=@p2,Email=@p3 where Id=@p1; update Suppliers set TaxNumber=@p4,Name=@p5 where Id=@p1;", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", Id);
                    sqlCommand.Parameters.AddWithValue("@p2", frmsuppliers.username);
                    sqlCommand.Parameters.AddWithValue("@p3", frmsuppliers.email);
                    sqlCommand.Parameters.AddWithValue("@p4", frmsuppliers.taxNumber);
                    sqlCommand.Parameters.AddWithValue("@p5", frmsuppliers.compName);
                    sqlCommand.ExecuteNonQuery();
                    msg = 2;
                    frmsuppliers.makeSupplierList();
                }
            }
            else if (shippers)
            {
                if (frmshippers.Id == null || frmshippers.Id == "" || frmshippers.username == null || frmshippers.email == null || frmshippers.compName == null || frmshippers.username == "" || frmshippers.email == "" || frmshippers.compName == "")
                {
                    if (frmshippers.Id == null || frmshippers.Id == "")
                    {
                        msg = 55;
                    }
                    else
                    {
                        msg = 56;
                    }
                }
                else
                {
                    Id = Convert.ToInt32(frmshippers.Id);
                    SqlCommand sqlCommand = new SqlCommand(@"update Users set Username=@p2,Email=@p3 where Id=@p1; update Shippers set Name=@p4 where Id=@p1;", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", Id);
                    sqlCommand.Parameters.AddWithValue("@p2", frmshippers.username);
                    sqlCommand.Parameters.AddWithValue("@p3", frmshippers.email);
                    sqlCommand.Parameters.AddWithValue("@p4", frmshippers.compName);
                    sqlCommand.ExecuteNonQuery();
                    msg = 3;
                    frmshippers.makeShipperList();
                }
            }
            else if (categories)
            {
                if (frmcategories.Id == null || frmcategories.Id == "" || frmcategories.ctgName == null || frmcategories.ctgName == "")
                {
                    if (frmcategories.Id == null || frmcategories.Id == "")
                    {
                        msg = 55;
                    }
                    else
                    {
                        msg = 56;
                    }
                }
                else
                {
                    if (frmcategories.ParentName == null || frmcategories.ParentName == "")
                    {
                        Id = Convert.ToInt32(frmcategories.Id);
                        SqlCommand sqlCommand = new SqlCommand(@"update Categories set Name=@p2 where Id=@p1;", CommerceDb);
                        sqlCommand.Parameters.AddWithValue("@p1", Id);
                        sqlCommand.Parameters.AddWithValue("@p2", frmcategories.ctgName);
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        Id = Convert.ToInt32(frmcategories.Id);
                        SqlCommand sqlCommand = new SqlCommand(@"update Categories set Name=@p2, ParentId=(select Id from Categories where Name=@p3) where Id=@p1;", CommerceDb);
                        sqlCommand.Parameters.AddWithValue("@p1", Id);
                        sqlCommand.Parameters.AddWithValue("@p2", frmcategories.ctgName);
                        sqlCommand.Parameters.AddWithValue("@p3", frmcategories.ParentName);
                        sqlCommand.ExecuteNonQuery();
                    }
                    msg = 4;
                    frmshippers.makeShipperList();
                }
            }
            else if (products)
            {
                if (frmproducts.prdName == null || frmproducts.prdName == "" || frmproducts.price == null || frmproducts.price == "" || frmproducts.description == null || frmproducts.description == "" || frmproducts.suppliername == null || frmproducts.suppliername == "" || frmproducts.categoryname == null || frmproducts.categoryname == "")
                {
                    if (frmproducts.Id == null || frmproducts.Id == "")
                    {
                        msg = 55;
                    }
                    else
                    {
                        msg = 56;
                    }
                }
                else
                {
                    Id = Convert.ToInt32(frmproducts.Id);
                    SqlCommand sqlCommand = new SqlCommand(@"update Products set Name=@p2, Description=@p3, Price=@p4, SupplierId=(select Id from Suppliers where Name=@p5) where Id=@p1;", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", Id);
                    sqlCommand.Parameters.AddWithValue("@p2", frmproducts.prdName);
                    sqlCommand.Parameters.AddWithValue("@p3", frmproducts.description);
                    sqlCommand.Parameters.AddWithValue("@p4", frmproducts.price);
                    sqlCommand.Parameters.AddWithValue("@p5", frmproducts.suppliername);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand = new SqlCommand(@"update ProductCategories set CategoryId=(select Id From Categories where Name =@p2) where Id=(select Id from ProductCategories where ProductId=@p1);", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", Id);
                    sqlCommand.Parameters.AddWithValue("@p2", frmproducts.categoryname);
                    sqlCommand.ExecuteNonQuery();
                    msg = 5;
                    frmproducts.makeProductsList();
                }
            }
            else
            {
                msg = 0;
            }
            CommerceDb.Close();

            switch (msg)
            {
                case 1:
                    {
                        XtraMessageBox.Show("Customer info updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 2:
                    {
                        XtraMessageBox.Show("Supplier info updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 3:
                    {
                        XtraMessageBox.Show("Shipper info updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 4:
                    {
                        XtraMessageBox.Show("Product Category info updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 5:
                    {
                        XtraMessageBox.Show("Product info updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 55:
                    {
                        XtraMessageBox.Show("Please select an item from table", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                case 56:
                    {
                        XtraMessageBox.Show("Please fill the required spaces!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                default:
                    {
                        XtraMessageBox.Show("Couldn't update info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        //Refresh List Button
        private void btn_refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customers)
            {
                frmcustomers.makeCustomerList();
            }
            else if (suppliers)
            {
                frmsuppliers.makeSupplierList();
            }
            else if (shippers)
            {
                frmshippers.makeShipperList();
            }
            else if (categories)
            {
                frmcategories.makeCategoriesList();
            }
            else if (products)
            {
                frmproducts.makeProductsList();
            }
        }

        //Add New Item Button
        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var bytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }
            string hash1 = BitConverter.ToString(bytes);

            int msg = 0;

            CommerceDb.Open();
            if (customers)
            {
                if (frmcustomers.Username == null || frmcustomers.Email == null || frmcustomers.FirstName == null || frmcustomers.LastName == null || frmcustomers.Identitynumber == null || frmcustomers.Username == "" || frmcustomers.Email == "" || frmcustomers.FirstName == "" || frmcustomers.LastName == "" || frmcustomers.Identitynumber == "")
                {
                    msg = 55;
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand(@"insert into Users(Username,Email,PasswordHash,isDeleted) values(@p1,@p2,@p3,@p8);", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", frmcustomers.Username);
                    sqlCommand.Parameters.AddWithValue("@p2", frmcustomers.Email);
                    sqlCommand.Parameters.AddWithValue("@p3", hash1);
                    sqlCommand.Parameters.AddWithValue("@p8", 0);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand = new SqlCommand(@"SET IDENTITY_INSERT Customers ON insert into Customers(IdentityNumber,FirstName,LastName,Gender,Id) values(@p4,@p5,@p6,@p7,(select Id from Users where Username= @p1 and Email=@p2));SET IDENTITY_INSERT Customers OFF", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", frmcustomers.Username);
                    sqlCommand.Parameters.AddWithValue("@p2", frmcustomers.Email);
                    sqlCommand.Parameters.AddWithValue("@p4", frmcustomers.Identitynumber);
                    sqlCommand.Parameters.AddWithValue("@p5", frmcustomers.FirstName);
                    sqlCommand.Parameters.AddWithValue("@p6", frmcustomers.LastName);
                    sqlCommand.Parameters.AddWithValue("@p7", frmcustomers.Gender == "Male");
                    sqlCommand.ExecuteNonQuery();
                    msg = 1;
                    frmcustomers.makeCustomerList();
                }
            }
            else if (suppliers)
            {
                if (frmsuppliers.username == null || frmsuppliers.email == null || frmsuppliers.taxNumber == null || frmsuppliers.compName == null || frmsuppliers.username == "" || frmsuppliers.email == "" || frmsuppliers.taxNumber == "" || frmsuppliers.compName == "")
                {
                    msg = 55;
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand(@"insert into Users(Username,Email,PasswordHash,isDeleted) values(@p1,@p2,@p3,@p6);", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", frmsuppliers.username);
                    sqlCommand.Parameters.AddWithValue("@p2", frmsuppliers.email);
                    sqlCommand.Parameters.AddWithValue("@p3", hash1);
                    sqlCommand.Parameters.AddWithValue("@p6", 0);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand = new SqlCommand(@"SET IDENTITY_INSERT Suppliers ON insert into Suppliers(TaxNumber, Name, Id) values(@p4, @p5, (select Id from Users where Username = @p1 and Email = @p2)); SET IDENTITY_INSERT Suppliers OFF", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", frmsuppliers.username);
                    sqlCommand.Parameters.AddWithValue("@p2", frmsuppliers.email);
                    sqlCommand.Parameters.AddWithValue("@p4", frmsuppliers.taxNumber);
                    sqlCommand.Parameters.AddWithValue("@p5", frmsuppliers.compName);
                    sqlCommand.ExecuteNonQuery();
                    msg = 2;
                    frmsuppliers.makeSupplierList();
                }
            }
            else if (shippers)
            {
                if (frmshippers.username == null || frmshippers.email == null || frmshippers.compName == null || frmshippers.username == "" || frmshippers.email == "" || frmshippers.compName == "")
                {
                    msg = 55;
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand(@"insert into Users(Username,Email,PasswordHash,isDeleted) values(@p1,@p2,@p3,@p5);", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", frmshippers.username);
                    sqlCommand.Parameters.AddWithValue("@p2", frmshippers.email);
                    sqlCommand.Parameters.AddWithValue("@p3", hash1);
                    sqlCommand.Parameters.AddWithValue("@p4", frmshippers.compName);
                    sqlCommand.Parameters.AddWithValue("@p5", 0);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand = new SqlCommand(@"SET IDENTITY_INSERT Shippers ON insert into Shippers(Name,Id) values(@p4,(select Id from Users where Username= @p1 and Email=@p2));SET IDENTITY_INSERT Suppliers OFF", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", frmshippers.username);
                    sqlCommand.Parameters.AddWithValue("@p2", frmshippers.email);
                    sqlCommand.Parameters.AddWithValue("@p4", frmshippers.compName);
                    sqlCommand.ExecuteNonQuery();
                    msg = 3;
                    frmshippers.makeShipperList();
                }
            }
            else if (categories)
            {
                if (frmcategories.ctgName == null || frmcategories.ctgName == "")
                {
                    msg = 55;
                }
                else
                {
                    if (frmcategories.ParentName == null || frmcategories.ParentName == "")
                    {
                        SqlCommand sqlCommand = new SqlCommand(@"insert into Categories(IsActive,IsPopular,Name) values(@p1,@p2,@p3);", CommerceDb);
                        sqlCommand.Parameters.AddWithValue("@p1", true);
                        sqlCommand.Parameters.AddWithValue("@p2", false);
                        sqlCommand.Parameters.AddWithValue("@p3", frmcategories.ctgName);
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand sqlCommand = new SqlCommand(@"insert into Categories(ParentId,IsActive,IsPopular,Name) values((Select Id from Categories Where Name=@p1),@p2,@p3,@p4);", CommerceDb);
                        sqlCommand.Parameters.AddWithValue("@p1", frmcategories.ParentName);
                        sqlCommand.Parameters.AddWithValue("@p2", true);
                        sqlCommand.Parameters.AddWithValue("@p3", false);
                        sqlCommand.Parameters.AddWithValue("@p4", frmcategories.ctgName);
                        sqlCommand.ExecuteNonQuery();
                    }


                    msg = 4;
                    frmcategories.makeCategoriesList();
                }
            }
            else if (products)
            {
                if (frmproducts.prdName == null || frmproducts.prdName == "" || frmproducts.price == null || frmproducts.price == "" || frmproducts.description == null || frmproducts.description == "" || frmproducts.suppliername == null || frmproducts.suppliername == "" || frmproducts.categoryname == null || frmproducts.categoryname == "")
                {
                    msg = 55;
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand(@"insert into Products(Name,IsActive,IsDeleted,Description,Price,SupplierId) values(@p1,@p2,@p3,@p4,@p5,(select Id from Suppliers where Name=@p6));", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", frmproducts.prdName);
                    sqlCommand.Parameters.AddWithValue("@p2", true);
                    sqlCommand.Parameters.AddWithValue("@p3", false);
                    sqlCommand.Parameters.AddWithValue("@p4", frmproducts.description);
                    sqlCommand.Parameters.AddWithValue("@p5", frmproducts.price);
                    sqlCommand.Parameters.AddWithValue("@p6", frmproducts.suppliername);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand = new SqlCommand(@"insert into ProductCategories(ProductId,CategoryId) values((Select Id from Products where Name=@p1 and Description=@p2 and SupplierId=(select Id from Suppliers where Name=@p3)),(select Id From Categories where Name =@p4));", CommerceDb);
                    sqlCommand.Parameters.AddWithValue("@p1", frmproducts.prdName);
                    sqlCommand.Parameters.AddWithValue("@p2", frmproducts.description);
                    sqlCommand.Parameters.AddWithValue("@p3", frmproducts.suppliername);
                    sqlCommand.Parameters.AddWithValue("@p4", frmproducts.categoryname);
                    sqlCommand.ExecuteNonQuery();

                    msg = 5;
                    frmproducts.makeProductsList();
                }
            }
            CommerceDb.Close();

            switch (msg)
            {
                case 1:
                    {
                        XtraMessageBox.Show("Customer added to system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 2:
                    {
                        XtraMessageBox.Show("Supplier added to system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 3:
                    {
                        XtraMessageBox.Show("Shipper added to system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 4:
                    {
                        XtraMessageBox.Show("Product Category added to system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 5:
                    {
                        XtraMessageBox.Show("Product added to system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 55:
                    {
                        XtraMessageBox.Show("Please fill the required spaces!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                default:
                    {
                        XtraMessageBox.Show("Nothing added to system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }

            //frprog.Close();

        }

        //Delete Item Button
        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CommerceDb.Open();
            int Id = 0;
            int msg = 0;
            if (customers)
            {
                if (frmcustomers.Id == null || frmcustomers.Id == "")
                {
                    msg = 55;
                }
                else
                {
                    Id = Convert.ToInt32(frmcustomers.Id);
                    msg = 1;
                }
            }
            else if (suppliers)
            {
                if (frmsuppliers.Id == null || frmsuppliers.Id == "")
                {
                    msg = 55;
                }
                else
                {
                    Id = Convert.ToInt32(frmsuppliers.Id);
                    msg = 2;
                }
            }
            else if (shippers)
            {
                if (frmshippers.Id == null || frmshippers.Id == "")
                {
                    msg = 55;
                }
                else
                {
                    Id = Convert.ToInt32(frmshippers.Id);
                    msg = 3;
                }
            }
            else if (categories)
            {
                msg = 4;
            }
            else if (products)
            {
                if (frmproducts.Id == null || frmproducts.Id == "")
                {
                    msg = 55;
                }
                else
                {
                    Id = Convert.ToInt32(frmproducts.Id);
                    msg = 5;
                }
            }
            else
            {
                Id = 0;
                msg = 0;
            }

            if (msg != 4 || msg != 5)
            {
                SqlCommand sqlCommand = new SqlCommand(@"update Users set isDeleted = 1 where Id=@p1", CommerceDb);
                sqlCommand.Parameters.AddWithValue("@p1", Id);
                sqlCommand.ExecuteNonQuery();
            }
            if (msg == 5)
            {
                SqlCommand sqlCommand = new SqlCommand(@"update Products set IsDeleted = 1 where Id=@p1", CommerceDb);
                sqlCommand.Parameters.AddWithValue("@p1", Id);
                sqlCommand.ExecuteNonQuery();
            }

            CommerceDb.Close();

            switch (msg)
            {

                case 1:
                    {
                        XtraMessageBox.Show("Customer deleted from system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmcustomers.makeCustomerList();
                        break;
                    }

                case 2:
                    {
                        XtraMessageBox.Show("Supplier deleted from system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmsuppliers.makeSupplierList();
                        break;
                    }

                case 3:
                    {
                        XtraMessageBox.Show("Shipper deleted from system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmshippers.makeShipperList();
                        break;
                    }

                case 4:
                    {
                        XtraMessageBox.Show("You cant delete categories!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        frmcategories.makeCategoriesList();
                        break;
                    }

                case 5:
                    {
                        XtraMessageBox.Show("Product deleted from system!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmproducts.makeProductsList();
                        break;
                    }

                case 55:
                    {
                        XtraMessageBox.Show("Please select an item from table", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                default:
                    {
                        XtraMessageBox.Show("Couldn't delete anything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

    }
}
