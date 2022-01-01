using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Vehicle
    {
        private int nbrPlacesMembers;
        private int nbrPlacesBikes;
        private Member driver;
        private List<Member> passengers;

        public Vehicle(int nbrPlacesMembers, int nbrPlacesBikes, Member driver, List<Member> passengers)
        {
            this.nbrPlacesMembers = nbrPlacesMembers;
            this.nbrPlacesBikes = nbrPlacesBikes;
            this.driver = driver;
            this.passengers = Passengers;
        }

        public Vehicle(){ }

        public int PMember
        {
            get { return nbrPlacesMembers; }
            set { nbrPlacesMembers = value; }
        }

        public int PBike
        {
            get { return nbrPlacesBikes; }
            set { nbrPlacesBikes = value; }
        }

        public Member Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public List<Member> Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }
    }
}
