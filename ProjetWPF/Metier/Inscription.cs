using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Inscription
    {
        private Boolean passengers;
        private Boolean bikes;

        public Inscription(Boolean passengers, Boolean bikes)
        {
            this.passengers = passengers;
            this.bikes = bikes;
        }

        public Inscription(){ }

        public Boolean Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }

        public Boolean Bikes
        {
            get { return bikes; }
            set { bikes = value; }
        }
    }
}
