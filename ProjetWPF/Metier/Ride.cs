using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Ride
    {
        private int num;
        private string placeDeparture;
        private string dateDeparture;
        private double packageFee;
        private int idCategory;

        public Ride() { }

        public Ride(string placeDeparture, string dateDeparture, double packageFee, int idCategory)
        {
            this.placeDeparture = placeDeparture;
            this.dateDeparture = dateDeparture;
            this.packageFee = packageFee;
            this.idCategory = idCategory;
        }
        public Ride(int num, string placeDeparture, string dateDeparture, double packageFee, int idCategory)
        {
            this.num = num;
            this.placeDeparture = placeDeparture;
            this.dateDeparture = dateDeparture;
            this.packageFee = packageFee;
            this.idCategory = idCategory;
        }

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

        public string DateDeparture
        {
            get { return dateDeparture; }
            set { dateDeparture = value; }
        }

        public double PackageFee
        {
            get { return packageFee; } 
            set { packageFee = value; }
        }

        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }
    }
}
