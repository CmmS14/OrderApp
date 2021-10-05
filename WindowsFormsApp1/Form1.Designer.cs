namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.BarButtonItem btn_update;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_customers = new DevExpress.XtraBars.BarButtonItem();
            this.btn_suppliers = new DevExpress.XtraBars.BarButtonItem();
            this.btn_shippers = new DevExpress.XtraBars.BarButtonItem();
            this.btn_products = new DevExpress.XtraBars.BarButtonItem();
            this.btn_categories = new DevExpress.XtraBars.BarButtonItem();
            this.btn_orders = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_refresh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbon_Users = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_Orders = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_Edit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            btn_update = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.Caption = "Update";
            btn_update.Id = 19;
            btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            btn_update.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.LargeImage")));
            btn_update.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            btn_update.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            btn_update.ItemAppearance.Hovered.Options.UseBackColor = true;
            btn_update.ItemAppearance.Hovered.Options.UseForeColor = true;
            btn_update.Name = "btn_update";
            btn_update.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btn_update.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_update_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem4,
            this.btn_customers,
            this.btn_suppliers,
            this.btn_shippers,
            this.btn_products,
            this.btn_categories,
            this.btn_orders,
            btn_update,
            this.btn_delete,
            this.btn_refresh,
            this.btn_Add});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 26;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(880, 158);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btn_customers
            // 
            this.btn_customers.AccessibleName = "btn_customers";
            this.btn_customers.Caption = "Customers";
            this.btn_customers.Id = 11;
            this.btn_customers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_customers.ImageOptions.Image")));
            this.btn_customers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_customers.ImageOptions.LargeImage")));
            this.btn_customers.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_customers.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_customers.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_customers.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_customers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_customers_ItemClick);
            // 
            // btn_suppliers
            // 
            this.btn_suppliers.Caption = "Suppliers";
            this.btn_suppliers.Id = 12;
            this.btn_suppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_suppliers.ImageOptions.Image")));
            this.btn_suppliers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_suppliers.ImageOptions.LargeImage")));
            this.btn_suppliers.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_suppliers.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_suppliers.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_suppliers.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_suppliers.Name = "btn_suppliers";
            this.btn_suppliers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_suppliers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_suppliers_ItemClick);
            // 
            // btn_shippers
            // 
            this.btn_shippers.Caption = "Shippers";
            this.btn_shippers.Id = 13;
            this.btn_shippers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_shippers.ImageOptions.Image")));
            this.btn_shippers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_shippers.ImageOptions.LargeImage")));
            this.btn_shippers.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_shippers.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_shippers.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_shippers.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_shippers.Name = "btn_shippers";
            this.btn_shippers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_shippers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_shippers_ItemClick);
            // 
            // btn_products
            // 
            this.btn_products.Caption = "Products";
            this.btn_products.Id = 15;
            this.btn_products.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_products.ImageOptions.Image")));
            this.btn_products.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_products.ImageOptions.LargeImage")));
            this.btn_products.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_products.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_products.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_products.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_products.Name = "btn_products";
            this.btn_products.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_products.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_products_ItemClick);
            // 
            // btn_categories
            // 
            this.btn_categories.Caption = "Categories";
            this.btn_categories.Id = 16;
            this.btn_categories.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_categories.ImageOptions.Image")));
            this.btn_categories.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_categories.ImageOptions.LargeImage")));
            this.btn_categories.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_categories.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_categories.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_categories.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_categories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_categories_ItemClick);
            // 
            // btn_orders
            // 
            this.btn_orders.Caption = "Orders";
            this.btn_orders.Id = 17;
            this.btn_orders.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_orders.ImageOptions.Image")));
            this.btn_orders.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_orders.ImageOptions.LargeImage")));
            this.btn_orders.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_orders.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_orders.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_orders.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_delete
            // 
            this.btn_delete.Caption = "Delete";
            this.btn_delete.Id = 20;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.LargeImage")));
            this.btn_delete.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_delete.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_delete.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_delete.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_delete_ItemClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Caption = "Refresh";
            this.btn_refresh.Id = 21;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.Image")));
            this.btn_refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.LargeImage")));
            this.btn_refresh.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_refresh.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_refresh.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_refresh_ItemClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Caption = "Add";
            this.btn_Add.Id = 22;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.LargeImage")));
            this.btn_Add.ItemAppearance.Hovered.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Add.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.btn_Add.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.btn_Add.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Add_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbon_Users,
            this.ribbon_Orders,
            this.ribbon_Edit});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbon_Users
            // 
            this.ribbon_Users.ItemLinks.Add(this.btn_customers);
            this.ribbon_Users.ItemLinks.Add(this.btn_suppliers);
            this.ribbon_Users.ItemLinks.Add(this.btn_shippers);
            this.ribbon_Users.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbon_Users.Name = "ribbon_Users";
            this.ribbon_Users.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // ribbon_Orders
            // 
            this.ribbon_Orders.ItemLinks.Add(this.btn_products);
            this.ribbon_Orders.ItemLinks.Add(this.btn_categories);
            this.ribbon_Orders.ItemLinks.Add(this.btn_orders);
            this.ribbon_Orders.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbon_Orders.Name = "ribbon_Orders";
            this.ribbon_Orders.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // ribbon_Edit
            // 
            this.ribbon_Edit.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon_Edit.ItemLinks.Add(this.btn_Add);
            this.ribbon_Edit.ItemLinks.Add(this.btn_delete);
            this.ribbon_Edit.ItemLinks.Add(btn_update);
            this.ribbon_Edit.ItemLinks.Add(this.btn_refresh);
            this.ribbon_Edit.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbon_Edit.MergeOrder = 1;
            this.ribbon_Edit.Name = "ribbon_Edit";
            this.ribbon_Edit.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.AllowDragDrop = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.Never;
            this.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabbedMdiManager1.FloatPageDragMode = DevExpress.XtraTabbedMdi.FloatPageDragMode.Preview;
            this.xtraTabbedMdiManager1.HeaderButtons = DevExpress.XtraTab.TabButtons.None;
            this.xtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 561);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Shop App Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_Users;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btn_customers;
        private DevExpress.XtraBars.BarButtonItem btn_suppliers;
        private DevExpress.XtraBars.BarButtonItem btn_shippers;
        private DevExpress.XtraBars.BarButtonItem btn_products;
        private DevExpress.XtraBars.BarButtonItem btn_categories;
        private DevExpress.XtraBars.BarButtonItem btn_orders;
        private DevExpress.XtraBars.BarButtonItem btn_delete;
        private DevExpress.XtraBars.BarButtonItem btn_refresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_Orders;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbon_Edit;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btn_Add;
    }
}

