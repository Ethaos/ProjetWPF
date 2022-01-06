using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    public class Member : Person
    {
        private double balance;
        private List<Category> lcat = new List<Category>();
        private List<Bike> lbike = new List<Bike>();


        public Member()
        {

        }
        public Member(int id, string name, string firstname, int tel, string login, string password, double balance) : base(id, name, firstname, tel, login, password)
        {
            this.balance = balance;
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<Category> Category
        {
            get { return lcat; }
            set { lcat = value; }
        }    

        public void calculbalance()
        {

        }

        public void verifierbalance()
        {

        }

  
    }
}
