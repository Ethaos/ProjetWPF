using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Ride
    {
        private int num;
        private string placeDeparture;
        private DateTime dateDeparture;
        private float packageFee;
        private int idCategory;

        public Ride() { }

        public Ride(string placeDeparture, DateTime dateDeparture, float packageFee, int idCategory)
        {
            this.placeDeparture = placeDeparture;
            this.dateDeparture = dateDeparture;
            this.packageFee = packageFee;
            this.idCategory = idCategory;
        }
        public Ride(int num, string placeDeparture, DateTime dateDeparture, float packageFee, int idCategory)
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

        public DateTime DateDeparture
        {
            get { return dateDeparture; }
            set { dateDeparture = value; }
        }

        public float PackageFee
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
