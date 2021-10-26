
namespace Assignment_2
{
    partial class filterButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filterButton));
            this.CityGymLogo = new System.Windows.Forms.PictureBox();
            this.mainExitButton = new System.Windows.Forms.Button();
            this.SearchMemberButton = new System.Windows.Forms.Button();
            this.ClearGridButton = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.membershipDataSet = new Assignment_2.MembershipDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new Assignment_2.MembershipDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new Assignment_2.MembershipDataSetTableAdapters.TableAdapterManager();
            this.memberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.memberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.basicFilter = new System.Windows.Forms.RadioButton();
            this.regularFilter = new System.Windows.Forms.RadioButton();
            this.premiumFilter = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.BookAClassButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).BeginInit();
            this.memberBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CityGymLogo
            // 
            this.CityGymLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CityGymLogo.Image = global::Assignment_2.Properties.Resources.CityGymLogo;
            this.CityGymLogo.Location = new System.Drawing.Point(1, -1);
            this.CityGymLogo.Name = "CityGymLogo";
            this.CityGymLogo.Size = new System.Drawing.Size(196, 68);
            this.CityGymLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CityGymLogo.TabIndex = 148;
            this.CityGymLogo.TabStop = false;
            // 
            // mainExitButton
            // 
            this.mainExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExitButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mainExitButton.Location = new System.Drawing.Point(1219, 608);
            this.mainExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(166, 55);
            this.mainExitButton.TabIndex = 12;
            this.mainExitButton.Text = "Exit";
            this.mainExitButton.UseVisualStyleBackColor = true;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // SearchMemberButton
            // 
            this.SearchMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SearchMemberButton.Location = new System.Drawing.Point(49, 127);
            this.SearchMemberButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchMemberButton.Name = "SearchMemberButton";
            this.SearchMemberButton.Size = new System.Drawing.Size(228, 51);
            this.SearchMemberButton.TabIndex = 2;
            this.SearchMemberButton.Text = "Search Member";
            this.SearchMemberButton.UseVisualStyleBackColor = true;
            this.SearchMemberButton.Click += new System.EventHandler(this.SearchMemberButton_Click);
            // 
            // ClearGridButton
            // 
            this.ClearGridButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearGridButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearGridButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClearGridButton.Location = new System.Drawing.Point(1157, 280);
            this.ClearGridButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearGridButton.Name = "ClearGridButton";
            this.ClearGridButton.Size = new System.Drawing.Size(228, 50);
            this.ClearGridButton.TabIndex = 8;
            this.ClearGridButton.Text = "Clear Filter";
            this.ClearGridButton.UseVisualStyleBackColor = true;
            this.ClearGridButton.Click += new System.EventHandler(this.ClearGridButton_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(23, 58);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(254, 26);
            this.SearchInput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 220;
            this.label3.Text = "Search by Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 36);
            this.label2.TabIndex = 221;
            this.label2.Text = "Search a Member";
            // 
            // membershipDataSet
            // 
            this.membershipDataSet.DataSetName = "MembershipDataSet";
            this.membershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.membershipDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassBookingTableAdapter = null;
            this.tableAdapterManager.FitnessClassTableAdapter = null;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.UpdateOrder = Assignment_2.MembershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberBindingNavigator
            // 
            this.memberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memberBindingNavigator.BindingSource = this.memberBindingSource;
            this.memberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memberBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.memberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.memberBindingNavigatorSaveItem});
            this.memberBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memberBindingNavigator.Name = "memberBindingNavigator";
            this.memberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memberBindingNavigator.Size = new System.Drawing.Size(1405, 33);
            this.memberBindingNavigator.TabIndex = 222;
            this.memberBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // memberBindingNavigatorSaveItem
            // 
            this.memberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memberBindingNavigatorSaveItem.Image")));
            this.memberBindingNavigatorSaveItem.Name = "memberBindingNavigatorSaveItem";
            this.memberBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.memberBindingNavigatorSaveItem.Text = "Save Data";
            this.memberBindingNavigatorSaveItem.Click += new System.EventHandler(this.memberBindingNavigatorSaveItem_Click);
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.memberDataGridView.DataSource = this.memberBindingSource;
            this.memberDataGridView.Location = new System.Drawing.Point(12, 371);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.RowHeadersWidth = 62;
            this.memberDataGridView.RowTemplate.Height = 28;
            this.memberDataGridView.Size = new System.Drawing.Size(1373, 220);
            this.memberDataGridView.TabIndex = 239;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mobile";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobile";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PaymentFrequency";
            this.dataGridViewTextBoxColumn6.HeaderText = "PaymentFrequency";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MembershipExpiry";
            this.dataGridViewTextBoxColumn7.HeaderText = "MembershipExpiry";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Extras";
            this.dataGridViewTextBoxColumn8.HeaderText = "Extras";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MembershipType";
            this.dataGridViewTextBoxColumn9.HeaderText = "MembershipType";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(201, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 242;
            this.label1.Text = "Filter by Membership:";
            // 
            // basicFilter
            // 
            this.basicFilter.AutoSize = true;
            this.basicFilter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.basicFilter.Location = new System.Drawing.Point(3, 3);
            this.basicFilter.Name = "basicFilter";
            this.basicFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.basicFilter.Size = new System.Drawing.Size(73, 24);
            this.basicFilter.TabIndex = 6;
            this.basicFilter.Text = "Basic";
            this.basicFilter.UseVisualStyleBackColor = true;
            // 
            // regularFilter
            // 
            this.regularFilter.AutoSize = true;
            this.regularFilter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regularFilter.Location = new System.Drawing.Point(3, 46);
            this.regularFilter.Name = "regularFilter";
            this.regularFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.regularFilter.Size = new System.Drawing.Size(90, 24);
            this.regularFilter.TabIndex = 244;
            this.regularFilter.Text = "Regular";
            this.regularFilter.UseVisualStyleBackColor = true;
            // 
            // premiumFilter
            // 
            this.premiumFilter.AutoSize = true;
            this.premiumFilter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.premiumFilter.Location = new System.Drawing.Point(3, 86);
            this.premiumFilter.Name = "premiumFilter";
            this.premiumFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.premiumFilter.Size = new System.Drawing.Size(96, 24);
            this.premiumFilter.TabIndex = 245;
            this.premiumFilter.Text = "Premium";
            this.premiumFilter.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(13, 608);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Assignment_2.Properties.Resources.Help;
            this.pictureBox9.Location = new System.Drawing.Point(94, 608);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(71, 63);
            this.pictureBox9.TabIndex = 246;
            this.pictureBox9.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.basicFilter);
            this.panel1.Controls.Add(this.regularFilter);
            this.panel1.Controls.Add(this.premiumFilter);
            this.panel1.Location = new System.Drawing.Point(30, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 123);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SearchMemberButton);
            this.panel2.Controls.Add(this.SearchInput);
            this.panel2.Location = new System.Drawing.Point(31, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 193);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(523, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 193);
            this.panel4.TabIndex = 4;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignUpButton.Location = new System.Drawing.Point(168, 17);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(212, 38);
            this.SignUpButton.TabIndex = 9;
            this.SignUpButton.Text = "Sign up Member";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // BookAClassButton
            // 
            this.BookAClassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookAClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAClassButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BookAClassButton.Location = new System.Drawing.Point(421, 15);
            this.BookAClassButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookAClassButton.Name = "BookAClassButton";
            this.BookAClassButton.Size = new System.Drawing.Size(208, 40);
            this.BookAClassButton.TabIndex = 10;
            this.BookAClassButton.Text = "Book a Class";
            this.BookAClassButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.BookAClassButton);
            this.panel3.Controls.Add(this.SignUpButton);
            this.panel3.Location = new System.Drawing.Point(742, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 71);
            this.panel3.TabIndex = 251;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 220;
            this.label4.Text = "Menu Shortcuts:";
            // 
            // filterButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1405, 678);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ClearGridButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.memberBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.CityGymLogo);
            this.Name = "filterButton";
            this.Text = "MemberSearchcs";
            this.Load += new System.EventHandler(this.MemberSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityGymLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).EndInit();
            this.memberBindingNavigator.ResumeLayout(false);
            this.memberBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CityGymLogo;
        private System.Windows.Forms.Button mainExitButton;
        private System.Windows.Forms.Button SearchMemberButton;
        private System.Windows.Forms.Button ClearGridButton;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MembershipDataSet membershipDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private MembershipDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private MembershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memberBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton memberBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton basicFilter;
        private System.Windows.Forms.RadioButton regularFilter;
        private System.Windows.Forms.RadioButton premiumFilter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button BookAClassButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}