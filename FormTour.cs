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
        int todayday = 10;
        int todaymonth = 06;
        int todayyear = 2025;

        public FormTour()
        {
            InitializeComponent();
            
        }

        private void FormTour_Load(object sender, EventArgs e)
        {
            ShowListFreeTours();
            //ShowListFreeTours();
            //foreach (var t in freetours)
            //{
            //    
            //    //listBoxFreeTours.Items.Add(t);
            //}

        }
        void ShowListFreeTours()
        {
            listBoxGetTours.Items.Clear();
            foreach (var t in freetours)
            {
                listBoxFreeTours.Items.Add(t);
            }
            
        }
        void ShowListGetTours()
        {
            listBoxGetTours.Items.Clear();
            foreach (var t in gettours)
            {
                listBoxGetTours.Items.Add(t.toursname + " " + t.name + " " + t.day + " " + t.month + " " + t.year);

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
            //tour.date = formadd.date;
            tour.day = formadd.day;
            tour.month = formadd.month;
            tour.year = formadd.year;
            gettours.Add(tour);
            freetours.RemoveAt(currentIndex);
            listBoxFreeTours.Items.Clear();
            listBoxGetTours.Items.Clear();

            ShowListFreeTours();
            ShowListGetTours();
            //foreach (var t in freetours)
            //{
            //    listBoxFreeTours.Items.Add(t);
            //}
            //foreach (var t in gettours)
            //{
            //    listBoxGetTours.Items.Add(t.toursname + " " + t.name + " " + t.day + " " + t.month + " " + t.year);

            //}
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            listBoxGetTours.Items.Clear();
            foreach (var t in gettours)
            {
                if (t.year >= todayyear && t.month >= todaymonth && t.day >= todayday) ShowListGetTours(); /*listBoxGetTours.Items.Add(t.toursname + " " + t.name + " " + t.day + " " + t.month + " " + t.year);*/
                if (t.year == todayyear && t.month == todaymonth && (t.day == todayday || (t.day - todayday == 2))) MessageBox.Show("Скоро поездка: "+t.toursname);
            }

        }
    }
}
