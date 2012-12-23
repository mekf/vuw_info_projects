namespace INFO241A2
{
    partial class NewPuzzleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPuzzleForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.pBOX1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.pBOX2TextBox = new System.Windows.Forms.TextBox();
            this.pBOX3TextBox = new System.Windows.Forms.TextBox();
            this.pBOX4TextBox = new System.Windows.Forms.TextBox();
            this.pBOX5TextBox = new System.Windows.Forms.TextBox();
            this.pBOX7TextBox = new System.Windows.Forms.TextBox();
            this.pBOX6TextBox = new System.Windows.Forms.TextBox();
            this.pBOX8TextBox = new System.Windows.Forms.TextBox();
            this.pBOX9TextBox = new System.Windows.Forms.TextBox();
            this.pBOX13TextBox = new System.Windows.Forms.TextBox();
            this.pBOX11TextBox = new System.Windows.Forms.TextBox();
            this.pBOX15TextBox = new System.Windows.Forms.TextBox();
            this.pBOX10TextBox = new System.Windows.Forms.TextBox();
            this.pBOX14TextBox = new System.Windows.Forms.TextBox();
            this.pBOX12TextBox = new System.Windows.Forms.TextBox();
            this.pBOX16TextBox = new System.Windows.Forms.TextBox();
            this.pIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sIDTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.sUDOKUDataSet = new INFO241A2.SUDOKUDataSet();
            this.pUZZLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUZZLETableAdapter = new INFO241A2.SUDOKUDataSetTableAdapters.PUZZLETableAdapter();
            this.tableAdapterManager = new INFO241A2.SUDOKUDataSetTableAdapters.TableAdapterManager();
            this.dIFFICULTYTableAdapter = new INFO241A2.SUDOKUDataSetTableAdapters.DIFFICULTYTableAdapter();
            this.pUZZLEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pUZZLEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dIFFComboBox = new System.Windows.Forms.ComboBox();
            this.dIFFICULTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sUDOKUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLEBindingNavigator)).BeginInit();
            this.pUZZLEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIFFICULTYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(192, 338);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pBOX1TextBox
            // 
            this.pBOX1TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pBOX1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX1TextBox.Location = new System.Drawing.Point(61, 152);
            this.pBOX1TextBox.MaxLength = 1;
            this.pBOX1TextBox.Name = "pBOX1TextBox";
            this.pBOX1TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX1TextBox.TabIndex = 4;
            this.pBOX1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puzzle ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Solution ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Difficulty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SP";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(7, 18);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(141, 15);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "INFORMATION FOR PID";
            // 
            // pBOX2TextBox
            // 
            this.pBOX2TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pBOX2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX2TextBox.Location = new System.Drawing.Point(105, 152);
            this.pBOX2TextBox.MaxLength = 1;
            this.pBOX2TextBox.Name = "pBOX2TextBox";
            this.pBOX2TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX2TextBox.TabIndex = 5;
            this.pBOX2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX3TextBox
            // 
            this.pBOX3TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBOX3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX3TextBox.Location = new System.Drawing.Point(150, 152);
            this.pBOX3TextBox.MaxLength = 1;
            this.pBOX3TextBox.Name = "pBOX3TextBox";
            this.pBOX3TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX3TextBox.TabIndex = 6;
            this.pBOX3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX4TextBox
            // 
            this.pBOX4TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBOX4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX4TextBox.Location = new System.Drawing.Point(194, 152);
            this.pBOX4TextBox.MaxLength = 1;
            this.pBOX4TextBox.Name = "pBOX4TextBox";
            this.pBOX4TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX4TextBox.TabIndex = 7;
            this.pBOX4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX5TextBox
            // 
            this.pBOX5TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pBOX5TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX5TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX5TextBox.Location = new System.Drawing.Point(61, 196);
            this.pBOX5TextBox.MaxLength = 1;
            this.pBOX5TextBox.Name = "pBOX5TextBox";
            this.pBOX5TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX5TextBox.TabIndex = 8;
            this.pBOX5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX7TextBox
            // 
            this.pBOX7TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBOX7TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX7TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX7TextBox.Location = new System.Drawing.Point(150, 196);
            this.pBOX7TextBox.MaxLength = 1;
            this.pBOX7TextBox.Name = "pBOX7TextBox";
            this.pBOX7TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX7TextBox.TabIndex = 10;
            this.pBOX7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX6TextBox
            // 
            this.pBOX6TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pBOX6TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX6TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX6TextBox.Location = new System.Drawing.Point(105, 196);
            this.pBOX6TextBox.MaxLength = 1;
            this.pBOX6TextBox.Name = "pBOX6TextBox";
            this.pBOX6TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX6TextBox.TabIndex = 9;
            this.pBOX6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX8TextBox
            // 
            this.pBOX8TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBOX8TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX8TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX8TextBox.Location = new System.Drawing.Point(194, 196);
            this.pBOX8TextBox.MaxLength = 1;
            this.pBOX8TextBox.Name = "pBOX8TextBox";
            this.pBOX8TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX8TextBox.TabIndex = 11;
            this.pBOX8TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX9TextBox
            // 
            this.pBOX9TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBOX9TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX9TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX9TextBox.Location = new System.Drawing.Point(61, 240);
            this.pBOX9TextBox.MaxLength = 1;
            this.pBOX9TextBox.Name = "pBOX9TextBox";
            this.pBOX9TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX9TextBox.TabIndex = 12;
            this.pBOX9TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX13TextBox
            // 
            this.pBOX13TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBOX13TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX13TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX13TextBox.Location = new System.Drawing.Point(61, 284);
            this.pBOX13TextBox.MaxLength = 1;
            this.pBOX13TextBox.Name = "pBOX13TextBox";
            this.pBOX13TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX13TextBox.TabIndex = 16;
            this.pBOX13TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX11TextBox
            // 
            this.pBOX11TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pBOX11TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX11TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX11TextBox.Location = new System.Drawing.Point(150, 240);
            this.pBOX11TextBox.MaxLength = 1;
            this.pBOX11TextBox.Name = "pBOX11TextBox";
            this.pBOX11TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX11TextBox.TabIndex = 14;
            this.pBOX11TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX15TextBox
            // 
            this.pBOX15TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pBOX15TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX15TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX15TextBox.Location = new System.Drawing.Point(150, 284);
            this.pBOX15TextBox.MaxLength = 1;
            this.pBOX15TextBox.Name = "pBOX15TextBox";
            this.pBOX15TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX15TextBox.TabIndex = 18;
            this.pBOX15TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX10TextBox
            // 
            this.pBOX10TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBOX10TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX10TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX10TextBox.Location = new System.Drawing.Point(105, 240);
            this.pBOX10TextBox.MaxLength = 1;
            this.pBOX10TextBox.Name = "pBOX10TextBox";
            this.pBOX10TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX10TextBox.TabIndex = 13;
            this.pBOX10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX14TextBox
            // 
            this.pBOX14TextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBOX14TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX14TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX14TextBox.Location = new System.Drawing.Point(105, 284);
            this.pBOX14TextBox.MaxLength = 1;
            this.pBOX14TextBox.Name = "pBOX14TextBox";
            this.pBOX14TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX14TextBox.TabIndex = 17;
            this.pBOX14TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX12TextBox
            // 
            this.pBOX12TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pBOX12TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX12TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX12TextBox.Location = new System.Drawing.Point(194, 240);
            this.pBOX12TextBox.MaxLength = 1;
            this.pBOX12TextBox.Name = "pBOX12TextBox";
            this.pBOX12TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX12TextBox.TabIndex = 15;
            this.pBOX12TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBOX16TextBox
            // 
            this.pBOX16TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pBOX16TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBOX16TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBOX16TextBox.Location = new System.Drawing.Point(194, 284);
            this.pBOX16TextBox.MaxLength = 1;
            this.pBOX16TextBox.Name = "pBOX16TextBox";
            this.pBOX16TextBox.Size = new System.Drawing.Size(38, 38);
            this.pBOX16TextBox.TabIndex = 19;
            this.pBOX16TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pIDMaskedTextBox
            // 
            this.pIDMaskedTextBox.Location = new System.Drawing.Point(142, 62);
            this.pIDMaskedTextBox.Mask = "00";
            this.pIDMaskedTextBox.Name = "pIDMaskedTextBox";
            this.pIDMaskedTextBox.Size = new System.Drawing.Size(60, 20);
            this.pIDMaskedTextBox.TabIndex = 1;
            this.pIDMaskedTextBox.Leave += new System.EventHandler(this.pIDMaskedTextBox_Leave);
            // 
            // sIDTextBox
            // 
            this.sIDTextBox.Location = new System.Drawing.Point(142, 88);
            this.sIDTextBox.Name = "sIDTextBox";
            this.sIDTextBox.ReadOnly = true;
            this.sIDTextBox.Size = new System.Drawing.Size(60, 20);
            this.sIDTextBox.TabIndex = 2;
            this.sIDTextBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(26, 338);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(109, 338);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // sUDOKUDataSet
            // 
            this.sUDOKUDataSet.DataSetName = "SUDOKUDataSet";
            this.sUDOKUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUZZLEBindingSource
            // 
            this.pUZZLEBindingSource.DataMember = "PUZZLE";
            this.pUZZLEBindingSource.DataSource = this.sUDOKUDataSet;
            // 
            // pUZZLETableAdapter
            // 
            this.pUZZLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIFFICULTYTableAdapter = this.dIFFICULTYTableAdapter;
            this.tableAdapterManager.PUZZLE2TableAdapter = null;
            this.tableAdapterManager.PUZZLETableAdapter = this.pUZZLETableAdapter;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = INFO241A2.SUDOKUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dIFFICULTYTableAdapter
            // 
            this.dIFFICULTYTableAdapter.ClearBeforeFill = true;
            // 
            // pUZZLEBindingNavigator
            // 
            this.pUZZLEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pUZZLEBindingNavigator.BindingSource = this.pUZZLEBindingSource;
            this.pUZZLEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pUZZLEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pUZZLEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pUZZLEBindingNavigatorSaveItem});
            this.pUZZLEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pUZZLEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pUZZLEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pUZZLEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pUZZLEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pUZZLEBindingNavigator.Name = "pUZZLEBindingNavigator";
            this.pUZZLEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pUZZLEBindingNavigator.Size = new System.Drawing.Size(294, 25);
            this.pUZZLEBindingNavigator.TabIndex = 23;
            this.pUZZLEBindingNavigator.Text = "bindingNavigator1";
            this.pUZZLEBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pUZZLEBindingNavigatorSaveItem
            // 
            this.pUZZLEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pUZZLEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pUZZLEBindingNavigatorSaveItem.Image")));
            this.pUZZLEBindingNavigatorSaveItem.Name = "pUZZLEBindingNavigatorSaveItem";
            this.pUZZLEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pUZZLEBindingNavigatorSaveItem.Text = "Save Data";
            this.pUZZLEBindingNavigatorSaveItem.Click += new System.EventHandler(this.pUZZLEBindingNavigatorSaveItem_Click);
            // 
            // dIFFComboBox
            // 
            this.dIFFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pUZZLEBindingSource, "DIFF", true));
            this.dIFFComboBox.DataSource = this.dIFFICULTYBindingSource;
            this.dIFFComboBox.DisplayMember = "DIFF";
            this.dIFFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dIFFComboBox.FormattingEnabled = true;
            this.dIFFComboBox.Location = new System.Drawing.Point(102, 114);
            this.dIFFComboBox.Name = "dIFFComboBox";
            this.dIFFComboBox.Size = new System.Drawing.Size(100, 21);
            this.dIFFComboBox.TabIndex = 3;
            // 
            // dIFFICULTYBindingSource
            // 
            this.dIFFICULTYBindingSource.DataMember = "DIFFICULTY";
            this.dIFFICULTYBindingSource.DataSource = this.sUDOKUDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "SS";
            // 
            // NewPuzzleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 375);
            this.ControlBox = false;
            this.Controls.Add(this.dIFFComboBox);
            this.Controls.Add(this.pUZZLEBindingNavigator);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sIDTextBox);
            this.Controls.Add(this.pIDMaskedTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBOX16TextBox);
            this.Controls.Add(this.pBOX8TextBox);
            this.Controls.Add(this.pBOX12TextBox);
            this.Controls.Add(this.pBOX4TextBox);
            this.Controls.Add(this.pBOX14TextBox);
            this.Controls.Add(this.pBOX6TextBox);
            this.Controls.Add(this.pBOX10TextBox);
            this.Controls.Add(this.pBOX2TextBox);
            this.Controls.Add(this.pBOX15TextBox);
            this.Controls.Add(this.pBOX7TextBox);
            this.Controls.Add(this.pBOX11TextBox);
            this.Controls.Add(this.pBOX3TextBox);
            this.Controls.Add(this.pBOX13TextBox);
            this.Controls.Add(this.pBOX5TextBox);
            this.Controls.Add(this.pBOX9TextBox);
            this.Controls.Add(this.pBOX1TextBox);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewPuzzleForm";
            this.Text = "NEW SUDOKU PUZZLE";
            this.Load += new System.EventHandler(this.NewPuzzleForm_Load);
            this.Activated += new System.EventHandler(this.NewPuzzleForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.sUDOKUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLEBindingNavigator)).EndInit();
            this.pUZZLEBindingNavigator.ResumeLayout(false);
            this.pUZZLEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIFFICULTYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox pBOX1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox pBOX2TextBox;
        private System.Windows.Forms.TextBox pBOX3TextBox;
        private System.Windows.Forms.TextBox pBOX4TextBox;
        private System.Windows.Forms.TextBox pBOX5TextBox;
        private System.Windows.Forms.TextBox pBOX7TextBox;
        private System.Windows.Forms.TextBox pBOX6TextBox;
        private System.Windows.Forms.TextBox pBOX8TextBox;
        private System.Windows.Forms.TextBox pBOX9TextBox;
        private System.Windows.Forms.TextBox pBOX13TextBox;
        private System.Windows.Forms.TextBox pBOX11TextBox;
        private System.Windows.Forms.TextBox pBOX15TextBox;
        private System.Windows.Forms.TextBox pBOX10TextBox;
        private System.Windows.Forms.TextBox pBOX14TextBox;
        private System.Windows.Forms.TextBox pBOX12TextBox;
        private System.Windows.Forms.TextBox pBOX16TextBox;
        private System.Windows.Forms.MaskedTextBox pIDMaskedTextBox;
        private System.Windows.Forms.TextBox sIDTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button resetButton;
        private SUDOKUDataSet sUDOKUDataSet;
        private System.Windows.Forms.BindingSource pUZZLEBindingSource;
        private INFO241A2.SUDOKUDataSetTableAdapters.PUZZLETableAdapter pUZZLETableAdapter;
        private INFO241A2.SUDOKUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pUZZLEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pUZZLEBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox dIFFComboBox;
        private INFO241A2.SUDOKUDataSetTableAdapters.DIFFICULTYTableAdapter dIFFICULTYTableAdapter;
        private System.Windows.Forms.BindingSource dIFFICULTYBindingSource;
        private System.Windows.Forms.Label label5;
    }
}