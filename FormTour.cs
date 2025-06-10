using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormTour : Form
    {

        List<string> freetours = new List<string>() { "Moscow", "London" };
        List<Tour> gettours = new List<Tour>();
        //public string NameDate;

        public FormTour()
        {
            InitializeComponent();
            
        }

        private void FormTour_Load(object sender, EventArgs e)
        {
            foreach (var t in freetours)
            {
                listBoxFreeTours.Items.Add(t);
            }
            
        }

        private void listBoxFreeTours_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentIndex = listBoxFreeTours.SelectedIndex;
            
            FormAddInformation formadd = new FormAddInformation();
            formadd.ShowDialog();

            Tour tour = new Tour();
            tour.toursname = freetours[currentIndex];
            tour.name = formadd.name;
            tour.date = formadd.date;
            gettours.Add(tour);
            freetours.RemoveAt(currentIndex);
            listBoxFreeTours.Items.Clear();
            listBoxGetTours.Items.Clear();
            foreach (var t in freetours)
            {
                listBoxFreeTours.Items.Add(t);
            }
            foreach (var t in gettours)
            {
                listBoxGetTours.Items.Add(t.toursname + " " + t.name + " " + t.date);

            }
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            listBoxGetTours.Items.Clear();
            foreach (var t in gettours)
            {
                if (t.date >= 2025) listBoxGetTours.Items.Add(t.toursname + " " + t.name + " " + t.date);
                if (t.date == 2025) MessageBox.Show("Скоро поездка: "+t.toursname);
            }

        }
    }
}
