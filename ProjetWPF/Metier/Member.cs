using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    public class Member : Person
    {
        private double balance { get; set; }
        private List<Category> lcat = new List<Category>();
        private List<Bike> lbike = new List<Bike>();

        public Member(int id, string name, string firstname, int tel, string login, string password, double balance) : base(id, name, firstname, tel, login, password)
        {
            this.balance = balance;
        }

        public void calculBalance()
        {

        }

        public void verifyBalance()
        {

        }

  
    }
}
