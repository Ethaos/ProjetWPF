using System;
using System.Collections.Generic;
using System.Text;

namespace Projet
{
    class Member : Person
    {
        private int balance;
        private List<Category> lcat = new List<Category>();
        private List<Bike> lbike = new List<Bike>();

        public Member(int id, string nom, string prenom, int tel, string motdepasse, int balance, List<Category> lcat,List<Bike> lbike) : base (id, nom, prenom, tel, motdepasse)
        {
            this.balance = balance;
            this.lcat = lcat;
            this.lbike = lbike;
        }

        public Member(){ }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<Category> Category
        {
            get { return lcat; }
            set { lcat = value; }
        }

        public List<Bike> Bike
        {
            get { return lbike; }
            set { lbike = value; }
        }

        public void calculbalance()
        {

        }

        public void verifierbalance()
        {

        }
    }
}
