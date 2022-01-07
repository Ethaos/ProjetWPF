using ProjetWPF.DAO;
using ProjetWPF.Factory;
using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetWPF
{
    
    public partial class ResponsiblePage : Page
    {
        Responsible resp = null;
        public ResponsiblePage(Responsible responsible)
        {
            InitializeComponent();
           
            resp = responsible;
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Responsible> responsibleDAO = adf.GetResponsibleDAO();
            DAO<Ride> rideDao = adf.GetRideDAO();
            DAO<Category> categoryDao = adf.GetCategoryDAO();

            List<Ride> listRide = rideDao.FindBy(responsible.Id);
            LbxRides.ItemsSource = listRide;
            LblFirstName.Content = responsible.FirstName;
            Category cat = categoryDao.Find(responsible.Category);
            LblNameUnderCategory.Content = cat.NameUnderCategory;

            calendar.SelectedDate = DateTime.Now.AddDays(1);
            
            
            
        }

        private void Refresh()
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Ride> rideDao = adf.GetRideDAO();
            List<Ride> listRide = rideDao.FindBy(resp.Id);
            LbxRides.ItemsSource = listRide;
        }

        private void AddRide(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Ride> rideDao = adf.GetRideDAO();
            CultureInfo provider = CultureInfo.InvariantCulture;

            double packageFee;
            DateTime date = (DateTime)calendar.SelectedDate;
            


            string place = textBoxPlace.Text;
            string packageString = textBoxFee.Text;
            string dateString = textboxDate.Text;

            date.ToString("s");

            double.TryParse(packageString, out packageFee);



            

            /*
             DateTime parsedDate = DateTime.ParseExact(dateString, "MM/dd/yyyy",
                                          CultureInfo.InvariantCulture);
            System.TimeZoneInfo.ConvertTimeToUtc(date,myTZ);
            String format = "yyyy-MM-dd";
            System.TimeZoneInfo.ConvertTimeToUtc(date);
            Trace.WriteLine(date);*/

            Ride ride = new Ride(place, date, packageFee, resp.Category);
            
            rideDao.Create(ride);
            Refresh();
        }
    }
}
