using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormAddInformation : Form
    {
        public string name;
        public int date;
        public FormAddInformation()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            date = Convert.ToInt32(textBoxdate.Text);
            
        }
    }
}
