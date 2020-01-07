using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkWindowsForms2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void year_for_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ollYear = DateTime.Now.Year;


            int myYear = Convert.ToInt32(year_for_user.Text);
            int difference = ollYear - myYear;
            result.Text = Convert.ToString(difference);
        }
    }
}
