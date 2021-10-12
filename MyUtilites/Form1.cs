using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilites
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programm" + " MyUtilites" + " contains a row with small programs, that can be useful in life ", "About program");
        }
    }
}
