﻿using ProjetWPF.DAO;
using ProjetWPF.Factory;
using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ProjetWPF.PagesWPF
{
    /// <summary>
    /// Interaction logic for InscriptionPage.xaml
    /// </summary>
    public partial class InscriptionPage : Page
    {
        Member m = null;
        int passenger=0, bike=0;
        List<Ride> listR = new List<Ride>();
        public InscriptionPage(Member member)
        {
            InitializeComponent();
            m = member;
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Member> memberDAO = adf.GetMemberDAO();
            DAO<Category> categoryDAO = adf.GetCategoryDAO();
            List<Category> listCat = categoryDAO.FindBy(m.Id);
            CatChoise.ItemsSource = listCat;
        }

        private void CatChoise_SelectionChanged(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Ride> rideDAO = adf.GetRideDAO();

            int idCategory = CatChoise.SelectedIndex;
            idCategory++;
            
            List<Ride> listRide = rideDAO.FindBy(idCategory);
            LbxRides.ItemsSource = listRide;
            listR = listRide;
        }

        private void RideChoise_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int idOrder = LbxRides.SelectedIndex;
            Ride r = listR[idOrder];
            int idRide = r.Num;
            string id = idRide.ToString();
            textBoxRide.Text = id;

        }

        private void passengerChecked(object sender, RoutedEventArgs e)
        {
            passenger = 1;
        }
        private void passengerUnchecked(object sender, RoutedEventArgs e)
        {
            passenger = 0;
        }

        private void bikesChecked(object sender, RoutedEventArgs e)
        {
            bike = 1;
        }
        private void bikesUnchecked(object sender, RoutedEventArgs e)
        {
            bike = 0;
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            AbstractDAOFactory adf = AbstractDAOFactory.GetFactory(DAOFactoryType.MS_SQL_FACTORY);
            DAO<Inscription> inscriptionDAO = adf.GetInscriptionDAO();

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

            if (inside)
            {
                MessageBox.Show("You are already registered to this ride.");
            }
            else
            {
                Inscription i = new Inscription(m.Id, idRideChoose, passenger, bike);

                inscriptionDAO.Create(i);
                MessageBox.Show("Inscription succès");
            }
        }
    }
}
