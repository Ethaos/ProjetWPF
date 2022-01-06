using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Bike
    {
        private float weight;
        private string type;
        private float length;

        public Bike(float weight, string type, float length)
        {
            this.weight = weight;
            this.type = type;
            this.length = length;
        }

        public Bike(){ }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public float Length
        {
            get { return length; }
            set { length = value; }
        }
    }
}
