namespace Задание
{
    partial class Form1
    {
  
        private System.ComponentModel.IContainer components = null;

      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet_CarsInfo = new Задание.DataSet_CarsInfo();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new Задание.DataSet_CarsInfoTableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new Задание.DataSet_CarsInfoTableAdapters.TableAdapterManager();
            this.carsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Delete_all = new System.Windows.Forms.Button();
            this.View_all = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet_CarsInfo1 = new Задание.DataSet_CarsInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.button_deleteUser = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_myProfile = new System.Windows.Forms.Button();
            this.label_Brand = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.label_hello = new System.Windows.Forms.Label();
            this.label_users = new System.Windows.Forms.Label();
            this.button_makeAdmin = new System.Windows.Forms.Button();
            this.button_removeAdmin = new System.Windows.Forms.Button();
            this.button_addToFavorites = new System.Windows.Forms.Button();
            this.button_myFavorites = new System.Windows.Forms.Button();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYearFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYearTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CarsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).BeginInit();
            this.carsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CarsInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            imageLabel.Location = new System.Drawing.Point(147, 303);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(0, 20);
            imageLabel.TabIndex = 9;
            imageLabel.Click += new System.EventHandler(this.imageLabel_Click);
            // 
            // dataSet_CarsInfo
            // 
            this.dataSet_CarsInfo.DataSetName = "DataSet_CarsInfo";
            this.dataSet_CarsInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.dataSet_CarsInfo;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Задание.DataSet_CarsInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carsBindingNavigator
            // 
            this.carsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carsBindingNavigator.BindingSource = this.carsBindingSource;
            this.carsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.carsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carsBindingNavigatorSaveItem});
            this.carsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carsBindingNavigator.Name = "carsBindingNavigator";
            this.carsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carsBindingNavigator.Size = new System.Drawing.Size(1715, 27);
            this.carsBindingNavigator.TabIndex = 0;
            this.carsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // carsBindingNavigatorSaveItem
            // 
            this.carsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carsBindingNavigatorSaveItem.Image")));
            this.carsBindingNavigatorSaveItem.Name = "carsBindingNavigatorSaveItem";
            this.carsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.carsBindingNavigatorSaveItem.Text = "Save Data";
            this.carsBindingNavigatorSaveItem.Click += new System.EventHandler(this.carsBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(122, 87);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(377, 27);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Brand", true));
            this.brandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandTextBox.Location = new System.Drawing.Point(122, 120);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(377, 27);
            this.brandTextBox.TabIndex = 4;
            this.brandTextBox.TextChanged += new System.EventHandler(this.brandTextBox_TextChanged);
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Model", true));
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.Location = new System.Drawing.Point(122, 153);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(377, 27);
            this.modelTextBox.TabIndex = 6;
            this.modelTextBox.TextChanged += new System.EventHandler(this.modelTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(122, 220);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(377, 27);
            this.priceTextBox.TabIndex = 8;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Add.Location = new System.Drawing.Point(26, 451);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(139, 49);
            this.Add.TabIndex = 11;
            this.Add.Text = "ДОБАВИ";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Delete.Location = new System.Drawing.Point(337, 506);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(162, 49);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "ИЗТРИЙ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.edit.Location = new System.Drawing.Point(171, 561);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(161, 49);
            this.edit.TabIndex = 13;
            this.edit.Text = "РЕДАКТИРАЙ";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Delete_all
            // 
            this.Delete_all.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Delete_all.Location = new System.Drawing.Point(338, 561);
            this.Delete_all.Name = "Delete_all";
            this.Delete_all.Size = new System.Drawing.Size(161, 49);
            this.Delete_all.TabIndex = 14;
            this.Delete_all.Text = "ИЗТРИЙ ВСИЧКО";
            this.Delete_all.UseVisualStyleBackColor = false;
            this.Delete_all.Click += new System.EventHandler(this.Delete_all_Click);
            // 
            // View_all
            // 
            this.View_all.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.View_all.Location = new System.Drawing.Point(171, 506);
            this.View_all.Name = "View_all";
            this.View_all.Size = new System.Drawing.Size(160, 49);
            this.View_all.TabIndex = 15;
            this.View_all.Text = "ПРЕГЛЕДАЙ ВСИЧКО";
            this.View_all.UseVisualStyleBackColor = false;
            this.View_all.Click += new System.EventHandler(this.View_all_Click);
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Filter.Location = new System.Drawing.Point(26, 351);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(139, 41);
            this.Filter.TabIndex = 16;
            this.Filter.Text = "ФИЛТРИРАЙ";
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Image", true));
            this.imageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageTextBox.Location = new System.Drawing.Point(122, 253);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(377, 27);
            this.imageTextBox.TabIndex = 10;
            this.imageTextBox.TextChanged += new System.EventHandler(this.imageTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1238, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 509);
            this.dataGridView1.TabIndex = 18;
            // 
            // dataSet_CarsInfo1
            // 
            this.dataSet_CarsInfo1.DataSetName = "DataSet_CarsInfo";
            this.dataSet_CarsInfo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Insert image:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.View.Location = new System.Drawing.Point(171, 451);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(160, 49);
            this.View.TabIndex = 20;
            this.View.Text = "ПРЕГЛЕДАЙ";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.exit.Location = new System.Drawing.Point(26, 725);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 53);
            this.exit.TabIndex = 21;
            this.exit.Text = "ИЗХОД";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(532, 656);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(667, 533);
            this.dataGridViewUsers.TabIndex = 22;
            // 
            // button_deleteUser
            // 
            this.button_deleteUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_deleteUser.Location = new System.Drawing.Point(366, 658);
            this.button_deleteUser.Name = "button_deleteUser";
            this.button_deleteUser.Size = new System.Drawing.Size(160, 49);
            this.button_deleteUser.TabIndex = 23;
            this.button_deleteUser.Text = "ИЗТРИЙ ПОТРЕБИТЕЛ";
            this.button_deleteUser.UseVisualStyleBackColor = false;
            this.button_deleteUser.Click += new System.EventHandler(this.button_deleteUser_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button_Previous.Location = new System.Drawing.Point(171, 284);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(55, 49);
            this.button_Previous.TabIndex = 24;
            this.button_Previous.Text = "<";
            this.button_Previous.UseVisualStyleBackColor = false;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button_Next.Location = new System.Drawing.Point(276, 284);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(55, 49);
            this.button_Next.TabIndex = 25;
            this.button_Next.Text = ">";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(532, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 509);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_myProfile
            // 
            this.button_myProfile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_myProfile.Location = new System.Drawing.Point(26, 658);
            this.button_myProfile.Name = "button_myProfile";
            this.button_myProfile.Size = new System.Drawing.Size(161, 49);
            this.button_myProfile.TabIndex = 26;
            this.button_myProfile.Text = "МОЯТ ПРОФИЛ";
            this.button_myProfile.UseVisualStyleBackColor = false;
            this.button_myProfile.Click += new System.EventHandler(this.button_myProfile_Click);
            // 
            // label_Brand
            // 
            this.label_Brand.AutoSize = true;
            this.label_Brand.BackColor = System.Drawing.Color.Transparent;
            this.label_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Brand.Location = new System.Drawing.Point(31, 122);
            this.label_Brand.Name = "label_Brand";
            this.label_Brand.Size = new System.Drawing.Size(75, 25);
            this.label_Brand.TabIndex = 27;
            this.label_Brand.Text = "Марка:";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID.Location = new System.Drawing.Point(69, 89);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(37, 25);
            this.label_ID.TabIndex = 28;
            this.label_ID.Text = "ID:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.BackColor = System.Drawing.Color.Transparent;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price.Location = new System.Drawing.Point(42, 222);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(64, 25);
            this.label_Price.TabIndex = 29;
            this.label_Price.Text = "Цена:";
            this.label_Price.Click += new System.EventHandler(this.label_Price_Click);
            // 
            // label_Model
            // 
            this.label_Model.AutoSize = true;
            this.label_Model.BackColor = System.Drawing.Color.Transparent;
            this.label_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Model.Location = new System.Drawing.Point(26, 153);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(80, 25);
            this.label_Model.TabIndex = 30;
            this.label_Model.Text = "Модел:";
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.BackColor = System.Drawing.Color.Transparent;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hello.Location = new System.Drawing.Point(236, 46);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(118, 29);
            this.label_hello.TabIndex = 31;
            this.label_hello.Text = "Здравей!";
            this.label_hello.Click += new System.EventHandler(this.label_hello_Click);
            // 
            // label_users
            // 
            this.label_users.AutoSize = true;
            this.label_users.BackColor = System.Drawing.Color.Transparent;
            this.label_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_users.Location = new System.Drawing.Point(787, 628);
            this.label_users.Name = "label_users";
            this.label_users.Size = new System.Drawing.Size(157, 25);
            this.label_users.TabIndex = 32;
            this.label_users.Text = "Потребители:";
            // 
            // button_makeAdmin
            // 
            this.button_makeAdmin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_makeAdmin.Location = new System.Drawing.Point(366, 713);
            this.button_makeAdmin.Name = "button_makeAdmin";
            this.button_makeAdmin.Size = new System.Drawing.Size(160, 49);
            this.button_makeAdmin.TabIndex = 33;
            this.button_makeAdmin.Text = "НАПРАВИ АДМИН";
            this.button_makeAdmin.UseVisualStyleBackColor = false;
            this.button_makeAdmin.Click += new System.EventHandler(this.button_makeAdmin_Click);
            // 
            // button_removeAdmin
            // 
            this.button_removeAdmin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_removeAdmin.Location = new System.Drawing.Point(366, 768);
            this.button_removeAdmin.Name = "button_removeAdmin";
            this.button_removeAdmin.Size = new System.Drawing.Size(160, 49);
            this.button_removeAdmin.TabIndex = 34;
            this.button_removeAdmin.Text = "ПРЕМАХНИ АДМИН";
            this.button_removeAdmin.UseVisualStyleBackColor = false;
            this.button_removeAdmin.Click += new System.EventHandler(this.button_removeAdmin_Click);
            // 
            // button_addToFavorites
            // 
            this.button_addToFavorites.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_addToFavorites.Location = new System.Drawing.Point(26, 506);
            this.button_addToFavorites.Name = "button_addToFavorites";
            this.button_addToFavorites.Size = new System.Drawing.Size(139, 49);
            this.button_addToFavorites.TabIndex = 35;
            this.button_addToFavorites.Text = "ДОБАВИ В ЛЮБИМИ";
            this.button_addToFavorites.UseVisualStyleBackColor = false;
            this.button_addToFavorites.Click += new System.EventHandler(this.button_addToFavorites_Click);
            // 
            // button_myFavorites
            // 
            this.button_myFavorites.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_myFavorites.Location = new System.Drawing.Point(26, 561);
            this.button_myFavorites.Name = "button_myFavorites";
            this.button_myFavorites.Size = new System.Drawing.Size(139, 49);
            this.button_myFavorites.TabIndex = 36;
            this.button_myFavorites.Text = "МОИТЕ ЛЮБИМИ";
            this.button_myFavorites.UseVisualStyleBackColor = false;
            this.button_myFavorites.Click += new System.EventHandler(this.button_myFavorites_Click);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(285, 368);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBrand.TabIndex = 37;
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(171, 370);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxMinPrice.TabIndex = 38;
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(412, 370);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxPrice.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Начална цена:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(320, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Марка: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(409, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Крайна цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Година:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Model", true));
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTextBox.Location = new System.Drawing.Point(122, 186);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(377, 27);
            this.yearTextBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(201, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "от:";
            // 
            // textBoxYearFrom
            // 
            this.textBoxYearFrom.Location = new System.Drawing.Point(171, 413);
            this.textBoxYearFrom.Name = "textBoxYearFrom";
            this.textBoxYearFrom.Size = new System.Drawing.Size(100, 22);
            this.textBoxYearFrom.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(328, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "до:";
            // 
            // textBoxYearTo
            // 
            this.textBoxYearTo.Location = new System.Drawing.Point(285, 413);
            this.textBoxYearTo.Name = "textBoxYearTo";
            this.textBoxYearTo.Size = new System.Drawing.Size(121, 22);
            this.textBoxYearTo.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(108, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Година:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::Задание.Properties.Resources.e184d4f7eb73582904b70986425b7670;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1715, 1055);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxYearTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxYearFrom);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.button_myFavorites);
            this.Controls.Add(this.button_addToFavorites);
            this.Controls.Add(this.button_removeAdmin);
            this.Controls.Add(this.button_makeAdmin);
            this.Controls.Add(this.label_users);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.label_Model);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Brand);
            this.Controls.Add(this.button_myProfile);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.button_deleteUser);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.View);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.View_all);
            this.Controls.Add(this.Delete_all);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.carsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CarsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).EndInit();
            this.carsBindingNavigator.ResumeLayout(false);
            this.carsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CarsInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_CarsInfo dataSet_CarsInfo;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private DataSet_CarsInfoTableAdapters.CarsTableAdapter carsTableAdapter;
        private DataSet_CarsInfoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button Delete_all;
        private System.Windows.Forms.Button View_all;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_CarsInfo dataSet_CarsInfo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button button_deleteUser;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_myProfile;
        private System.Windows.Forms.Label label_Brand;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Model;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label_users;
        private System.Windows.Forms.Button button_makeAdmin;
        private System.Windows.Forms.Button button_removeAdmin;
        private System.Windows.Forms.Button button_addToFavorites;
        private System.Windows.Forms.Button button_myFavorites;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxYearFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYearTo;
        private System.Windows.Forms.Label label7;
    }
}

