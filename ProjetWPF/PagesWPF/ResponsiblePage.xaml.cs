using ProjetWPF.DAO;
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
            calendar.SelectedDate = DateTime.Now.AddDays(1);
        }

        private void AddDate(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)calendar.SelectedDate;



            Trace.WriteLine(date);
            
             

        }
    }
}
