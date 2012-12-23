namespace INFO241A2
{
    partial class ChoosePuzzleForm
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
            System.Windows.Forms.Label dIFFLabel;
            System.Windows.Forms.Label pNAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosePuzzleForm));
            this.sUDOKUDataSet = new INFO241A2.SUDOKUDataSet();
            this.pUZZLE1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUZZLE1TableAdapter = new INFO241A2.SUDOKUDataSetTableAdapters.PUZZLE1TableAdapter();
            this.tableAdapterManager = new INFO241A2.SUDOKUDataSetTableAdapters.TableAdapterManager();
            this.dIFFICULTYTableAdapter = new INFO241A2.SUDOKUDataSetTableAdapters.DIFFICULTYTableAdapter();
            this.pUZZLE2TableAdapter = new INFO241A2.SUDOKUDataSetTableAdapters.PUZZLE2TableAdapter();
            this.pUZZLE1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pUZZLE1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dIFFComboBox = new System.Windows.Forms.ComboBox();
            this.dIFFICULTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUZZLE2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dIFFToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dIFFToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pIDComboBox = new System.Windows.Forms.ComboBox();
            this.playButton = new System.Windows.Forms.Button();
            dIFFLabel = new System.Windows.Forms.Label();
            pNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sUDOKUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLE1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLE1BindingNavigator)).BeginInit();
            this.pUZZLE1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIFFICULTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLE2BindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dIFFLabel
            // 
            dIFFLabel.AutoSize = true;
            dIFFLabel.Location = new System.Drawing.Point(43, 20);
            dIFFLabel.Name = "dIFFLabel";
            dIFFLabel.Size = new System.Drawing.Size(81, 13);
            dIFFLabel.TabIndex = 1;
            dIFFLabel.Text = "Difficulty Level";
            // 
            // pNAMELabel
            // 
            pNAMELabel.AutoSize = true;
            pNAMELabel.Location = new System.Drawing.Point(43, 47);
            pNAMELabel.Name = "pNAMELabel";
            pNAMELabel.Size = new System.Drawing.Size(70, 13);
            pNAMELabel.TabIndex = 4;
            pNAMELabel.Text = "Puzzle Code";
            // 
            // sUDOKUDataSet
            // 
            this.sUDOKUDataSet.DataSetName = "SUDOKUDataSet";
            this.sUDOKUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUZZLE1BindingSource
            // 
            this.pUZZLE1BindingSource.DataMember = "PUZZLE1";
            this.pUZZLE1BindingSource.DataSource = this.sUDOKUDataSet;
            // 
            // pUZZLE1TableAdapter
            // 
            this.pUZZLE1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIFFICULTYTableAdapter = this.dIFFICULTYTableAdapter;
            this.tableAdapterManager.PUZZLE2TableAdapter = this.pUZZLE2TableAdapter;
            this.tableAdapterManager.PUZZLETableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = INFO241A2.SUDOKUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dIFFICULTYTableAdapter
            // 
            this.dIFFICULTYTableAdapter.ClearBeforeFill = true;
            // 
            // pUZZLE2TableAdapter
            // 
            this.pUZZLE2TableAdapter.ClearBeforeFill = true;
            // 
            // pUZZLE1BindingNavigator
            // 
            this.pUZZLE1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pUZZLE1BindingNavigator.BindingSource = this.pUZZLE1BindingSource;
            this.pUZZLE1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pUZZLE1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pUZZLE1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pUZZLE1BindingNavigatorSaveItem});
            this.pUZZLE1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pUZZLE1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pUZZLE1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pUZZLE1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pUZZLE1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pUZZLE1BindingNavigator.Name = "pUZZLE1BindingNavigator";
            this.pUZZLE1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pUZZLE1BindingNavigator.Size = new System.Drawing.Size(359, 25);
            this.pUZZLE1BindingNavigator.TabIndex = 0;
            this.pUZZLE1BindingNavigator.Text = "bindingNavigator1";
            this.pUZZLE1BindingNavigator.Visible = false;
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
            // pUZZLE1BindingNavigatorSaveItem
            // 
            this.pUZZLE1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pUZZLE1BindingNavigatorSaveItem.Enabled = false;
            this.pUZZLE1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pUZZLE1BindingNavigatorSaveItem.Image")));
            this.pUZZLE1BindingNavigatorSaveItem.Name = "pUZZLE1BindingNavigatorSaveItem";
            this.pUZZLE1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pUZZLE1BindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dIFFComboBox
            // 
            this.dIFFComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pUZZLE1BindingSource, "DIFF", true));
            this.dIFFComboBox.DataSource = this.dIFFICULTYBindingSource;
            this.dIFFComboBox.DisplayMember = "DIFF";
            this.dIFFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dIFFComboBox.FormattingEnabled = true;
            this.dIFFComboBox.Location = new System.Drawing.Point(130, 17);
            this.dIFFComboBox.Name = "dIFFComboBox";
            this.dIFFComboBox.Size = new System.Drawing.Size(121, 21);
            this.dIFFComboBox.TabIndex = 2;
            this.dIFFComboBox.SelectedIndexChanged += new System.EventHandler(this.dIFFComboBox_SelectedIndexChanged);
            // 
            // dIFFICULTYBindingSource
            // 
            this.dIFFICULTYBindingSource.DataMember = "DIFFICULTY";
            this.dIFFICULTYBindingSource.DataSource = this.sUDOKUDataSet;
            // 
            // pUZZLE2BindingSource
            // 
            this.pUZZLE2BindingSource.DataMember = "PUZZLE2";
            this.pUZZLE2BindingSource.DataSource = this.sUDOKUDataSet;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dIFFToolStripLabel,
            this.dIFFToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(359, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // dIFFToolStripLabel
            // 
            this.dIFFToolStripLabel.Name = "dIFFToolStripLabel";
            this.dIFFToolStripLabel.Size = new System.Drawing.Size(34, 22);
            this.dIFFToolStripLabel.Text = "DIFF:";
            // 
            // dIFFToolStripTextBox
            // 
            this.dIFFToolStripTextBox.Name = "dIFFToolStripTextBox";
            this.dIFFToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // pIDComboBox
            // 
            this.pIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pUZZLE2BindingSource, "PNAME", true));
            this.pIDComboBox.DataSource = this.pUZZLE2BindingSource;
            this.pIDComboBox.DisplayMember = "PID";
            this.pIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pIDComboBox.FormattingEnabled = true;
            this.pIDComboBox.Location = new System.Drawing.Point(130, 44);
            this.pIDComboBox.Name = "pIDComboBox";
            this.pIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.pIDComboBox.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(110, 82);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // ChoosePuzzleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 125);
            this.ControlBox = false;
            this.Controls.Add(this.playButton);
            this.Controls.Add(pNAMELabel);
            this.Controls.Add(this.pIDComboBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(dIFFLabel);
            this.Controls.Add(this.dIFFComboBox);
            this.Controls.Add(this.pUZZLE1BindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChoosePuzzleForm";
            this.Text = "Choose A Puzzle";
            this.Load += new System.EventHandler(this.ChoosePuzzleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sUDOKUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLE1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLE1BindingNavigator)).EndInit();
            this.pUZZLE1BindingNavigator.ResumeLayout(false);
            this.pUZZLE1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIFFICULTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUZZLE2BindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SUDOKUDataSet sUDOKUDataSet;
        private System.Windows.Forms.BindingSource pUZZLE1BindingSource;
        private INFO241A2.SUDOKUDataSetTableAdapters.PUZZLE1TableAdapter pUZZLE1TableAdapter;
        private INFO241A2.SUDOKUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pUZZLE1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pUZZLE1BindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox dIFFComboBox;
        private INFO241A2.SUDOKUDataSetTableAdapters.PUZZLE2TableAdapter pUZZLE2TableAdapter;
        private System.Windows.Forms.BindingSource pUZZLE2BindingSource;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel dIFFToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dIFFToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ComboBox pIDComboBox;
        private INFO241A2.SUDOKUDataSetTableAdapters.DIFFICULTYTableAdapter dIFFICULTYTableAdapter;
        private System.Windows.Forms.BindingSource dIFFICULTYBindingSource;
        private System.Windows.Forms.Button playButton;



    }
}