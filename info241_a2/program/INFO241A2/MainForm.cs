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
    public partial class MainForm : Form
    {
        AdminAuthenticationForm authForm;
        ChoosePuzzleForm choosePzlForm;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            authForm = new AdminAuthenticationForm();
            choosePzlForm = new ChoosePuzzleForm();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            authForm.Show();
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            choosePzlForm.Show();
        }
    }
}
