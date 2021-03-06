using ProjetWPF.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ProjetWPF.PagesWPF
{
    /// <summary>
    /// Interaction logic for InscriptionPage.xaml
    /// </summary>
    public partial class InscriptionPage : Page
    {
        Member m = null;
        int passenger=0, bike=0,idVehicle,idRide;
        List<Ride> listR = new List<Ride>();
        List<Vehicle> listV = new List<Vehicle>();
        bool check = false;
        public InscriptionPage(Member member)
        {
            InitializeComponent();
            checkBoxPassenger.IsChecked = true;
            m = member;
            CarOption.Visibility = Visibility.Hidden;
            CarChoice.Visibility = Visibility.Visible;
            NoCar.Visibility = Visibility.Hidden;

            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            DAO<Category> categoryDAO = adf.GetCategoryDAO();

            List<Category> listCat = categoryDAO.FindBy(m.Id);
            CatChoice.ItemsSource = listCat;
        }

        private void CatChoice_SelectionChanged(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Ride> rideDAO = adf.GetRideDAO();
            
            int idCategory = CatChoice.SelectedIndex;
            idCategory++;

            if (!String.IsNullOrEmpty(textBoxRide.Text))
            {
                textBoxRide.Clear();
            }

            List<Ride> listRide = rideDAO.FindBy(idCategory);
            LbxRides.ItemsSource = listRide;

            if (listRide.Any())
            {
                listR = listRide; 
            }
            else
            {
                MessageBox.Show("Any Ride for this category");
            }
        }

  

        private void RideChoice_SelectionChanged(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Vehicle> vehicleDAO = adf.GetVehicleDAO();

            int idOrder = LbxRides.SelectedIndex;
            if (idOrder != -1)
            {
                Ride r = listR[idOrder];
                idRide = r.num;
                string id = idRide.ToString();
                textBoxRide.Text = id;
                
                List<Vehicle> listCar = vehicleDAO.FindBy(idRide);
                LbxCar.ItemsSource = listCar;

                if (listCar.Any())
                {
                    listV= listCar;
                   
                }

                if (!listCar.Any() && check)
                {
                    
                    NoCar.Visibility = Visibility.Visible;
                }
                else
                {
                    NoCar.Visibility = Visibility.Hidden;
                }
                
               

            }
        }

        private void CarChoice_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int idOrder = LbxCar.SelectedIndex;
            if (idOrder != -1)
            {
                Vehicle v = listV[idOrder];
                idVehicle = v.Id;
            }
            
        }

        private void passengerChecked(object sender, RoutedEventArgs e)
        {
            if(checkBoxPassenger.IsChecked == true)
            {
                passenger = 1;
                bike = 1;
                check = true;
                checkBoxDriver.IsChecked = false;
                CarChoice.Visibility = Visibility.Visible;
                

            }
            else if(checkBoxPassenger.IsChecked == false){
                passenger = 0;
                bike = 0;
                check = false;
                checkBoxDriver.IsChecked = true;
                CarChoice.Visibility = Visibility.Hidden;
            }
        }
        private void driverChecked(object sender, RoutedEventArgs e)
        {
            if (checkBoxDriver.IsChecked==true)
            {
                passenger = 0;
                bike = 0;
                check = false;
                CarOption.Visibility = Visibility.Visible;
                NoCar.Visibility = Visibility.Hidden;   
                checkBoxPassenger.IsChecked = false;
                
            }
            else if (checkBoxDriver.IsChecked == false)
            {
                passenger = 1;
                bike = 1;
                check = true;
                CarOption.Visibility = Visibility.Hidden;
                checkBoxPassenger.IsChecked = true;
            }
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Inscription> inscriptionDAO = adf.GetInscriptionDAO();
            DAO<Vehicle> vehicleDAO = adf.GetVehicleDAO();

            List<Inscription> listInscription = inscriptionDAO.FindBy(m.Id);
            bool inside = false;
            int idRideChoose; 
            string rideString = textBoxRide.Text;
            int.TryParse(rideString, out idRideChoose);

            foreach (Inscription inscription in listInscription)
            {
                if (inscription.Ride == idRideChoose)
                {
                    inside = true;
                }
            }
            if(check)
            {
                if (inside)
                {
                    MessageBox.Show("You are already registered to this ride.");
                }
                else
                {
                    Inscription i = new Inscription(m.Id, idRideChoose, passenger, bike);

                    Vehicle v = vehicleDAO.Find(idVehicle);

                    v.PMember--;
                    v.PBike--;
                    
                    
                    vehicleDAO.Update(v);
                    
                    inscriptionDAO.Create(i);

                    MessageBox.Show("Inscription as passenger succès");

                    Refresh();

                }
            }else if (!check)
            {
                if (inside)
                {
                    MessageBox.Show("You are already registered to this ride.");
                }
                else
                {
                    Inscription i = new Inscription(m.Id, idRideChoose, passenger, bike);

                    int pMembers, pBikes;
                    string pmString = textBoxMembers.Text;
                    string pbString = textBoxBikes.Text;
                    int.TryParse(pmString, out pMembers);
                    int.TryParse(pbString, out pBikes);
                    Vehicle v = new Vehicle(0, pMembers, pBikes, m.Id, idRideChoose);
                    vehicleDAO.Create(v);
                    inscriptionDAO.Create(i);
                    MessageBox.Show("Inscription as driver succès");
                }
            }
        }

        private void Refresh()
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Vehicle> vehicleDAO = adf.GetVehicleDAO();
            List<Vehicle> listCar = vehicleDAO.FindBy(idRide);
            LbxCar.ItemsSource = listCar;
        }
    }
}
