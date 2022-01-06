using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Inscription
    {
        private int idMember;
        private int idRide;
        private int passenger;
        private int bikes;

        public Inscription(int idMember, int idRide,int passenger, int bikes)
        {
            this.idMember = idMember;
            this.idRide = idRide;
            this.passenger = passenger;
            this.bikes = bikes;
        }

        public Inscription(){ }

        public int Member
        {
            get { return idMember; }
            set { idMember = value; }
        }

        public int Ride
        {
            get { return idRide; }
            set { idRide = value; }
        }

        public int Passenger
        {
            get { return passenger; }
            set { passenger = value; }
        }

        public int Bikes
        {
            get { return bikes; }
            set { bikes = value; }
        }
    }
}
