using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Member : Person
    {
        private float balance;
        private List<Category> lcat = new List<Category>();
        private List<Bike> lbike = new List<Bike>();

        public Member(int id, string name, string firstname, int tel, string password, float balance) : base(id, name, firstname, tel, password)
        {
            this.balance = balance;
        }

        public Member(int id, string name, string firstname, int tel, string password, float balance, List<Category> lcat,List<Bike> lbike) : base (id, name, firstname, tel, password)
        {
            this.balance = balance;
            this.lcat = lcat;
            this.lbike = lbike;
        }

        public Member(){ }

        public float Balance
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
