using System;
using System.Collections.Generic;
using System.Text;

namespace Projet
{
    class Bike
    {
        private int weight;
        private string type;
        private int length;
        private Member bikeMember;

        public Bike(int weight, string type, int length, Member bikeMember)
        {
            this.weight = weight;
            this.type = type;
            this.length = length;
            this.bikeMember = bikeMember;
        }

        public Bike(){ }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Member BikeMember
        {
            get { return bikeMember; }
            set { bikeMember = value; }
        }

    }
}
