/* INFO241 - Assignment #2
 * Minh, HA 300113109
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INFO241A2
{
    public partial class RankingForm : Form
    {
        public RankingForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rESULTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rESULTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sUDOKUDataSet);

        }

        private void RankingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sUDOKUDataSet.RESULT' table. You can move, or remove it, as needed.
            this.rESULTTableAdapter.Fill(this.sUDOKUDataSet.RESULT);

        }
    }
}
