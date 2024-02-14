using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_List_Creator
{
    public partial class facultyForm : Form
    {
        public static string facultyString = "";
        public facultyForm()
        {
            InitializeComponent();
            switch (Form1.mode)
            {
                case "faculty":
                    newfacultyLabel.Text = "New faculty name:";
                    break;
                case "dean":
                    newfacultyLabel.Text = "New Dean's name:";
                    break;
                case "abbrev":
                    newfacultyLabel.Text = "New abbreviation:";
                    break;
            }
        }

        private void facultyOKButton_Click(object sender, EventArgs e)
        {
            facultyString = newfacultyBox.Text;
            this.Close();
        }

        private void facultyCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
