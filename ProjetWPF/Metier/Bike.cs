using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Bike
    {
        private double weight;
        private string type;
        private double length;

        public Bike(double weight, string type, double length)
        {
            this.weight = weight;
            this.type = type;
            this.length = length;
        }

        public Bike(){ }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
    }
}
