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
      
        public int day;
        public int month;
        public int year;
        public FormAddInformation()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            day = dateTimePicker.Value.Day;
            month = dateTimePicker.Value.Month;
            year = dateTimePicker.Value.Year;
            this.Close();

        }
    }
}
