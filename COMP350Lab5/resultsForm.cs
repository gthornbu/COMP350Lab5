using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COMP350Lab5
{
    public partial class resultsForm : Form
    {
        string fileName = @"employees.csv";
        public resultsForm()
        {
            InitializeComponent();
        }
        public resultsForm(string fileName)
        {
            InitializeComponent();
        }

        private void resultsForm_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText(fileName);
            string line;
            string[] data = new string[50];
            int i = 0;

            while ((line = sr.ReadLine()) != null)
            {
                data[i] = line.Replace(",", "\t\t");
                i++;
            }
            sr.Close();
            txtResults.Lines = data;
        }

        //this method is used to close the form when the escape key is pressed
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

    }
}
