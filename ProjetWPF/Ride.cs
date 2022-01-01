using System;
using System.Collections.Generic;
using System.Text;

namespace Projet
{
    class Ride
    {
        private int num;
        private string placeDeparture;
        private DateTime dateDeparture;
        private double flatFee;

        public Ride(int num, string placeDeparture, DateTime dateDeparture, double flatFee)
        {
            this.num = num;
            this.placeDeparture = placeDeparture;
            this.dateDeparture = dateDeparture;
            this.flatFee = flatFee;
        }

        public Ride(){ }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public string PlaceDeparture
        {
            get { return placeDeparture; }
            set { placeDeparture = value; }
        }

        public DateTime DateDeparture
        {
            get { return dateDeparture; }
            set { dateDeparture = value; }
        }

        public double FlatFee
        {
            get { return flatFee; } 
            set { flatFee = value; }
        }
    }
}
