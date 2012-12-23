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
    public partial class ChoosePuzzleForm : Form
    {
        string dIFFString = null;   //will pass these 2 strings to the PlayForm
        string pIDString = null;

        PlayForm letPlayForm;

        public ChoosePuzzleForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            letPlayForm = new PlayForm();
        }

        private void ChoosePuzzleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sUDOKUDataSet.DIFFICULTY' table. You can move, or remove it, as needed.
            this.dIFFICULTYTableAdapter.Fill(this.sUDOKUDataSet.DIFFICULTY);
            // TODO: This line of code loads data into the 'sUDOKUDataSet.PUZZLE1' table. You can move, or remove it, as needed.
            this.pUZZLE1TableAdapter.Fill(this.sUDOKUDataSet.PUZZLE1);

        }

        private void dIFFComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.pUZZLE2TableAdapter.Fill(this.sUDOKUDataSet.PUZZLE2, dIFFComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            dIFFString = dIFFComboBox.Text;
            pIDString = pIDComboBox.Text;

            letPlayForm.PassDIFF = dIFFString;
            letPlayForm.PassPID = pIDString;

            letPlayForm.Show();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pUZZLE2TableAdapter.Fill(this.sUDOKUDataSet.PUZZLE2, dIFFToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
