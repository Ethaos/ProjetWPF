using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Vehicle
    {
        private int idVehicle;
        private int nbrPlacesMembers;
        private int nbrPlacesBikes;
        private int idDriver;
        private int idRide;

        public Vehicle(int idVehicle, int nbrPlacesMembers, int nbrPlacesBikes, int idDriver, int idRide)
        {
            this.idVehicle = idVehicle;
            this.nbrPlacesMembers = nbrPlacesMembers;
            this.nbrPlacesBikes = nbrPlacesBikes;
            this.idDriver = idDriver;
            this.idRide = idRide;
        }

        public Vehicle(){ }

        public int Id
        {
            get { return idVehicle; }
            set { idVehicle = value; }
        }
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

        public int Driver
        {
            get { return idDriver; }
            set { idDriver = value; }
        }

        public int Ride
        {
            get { return idRide; }
            set { idRide = value; }
        }
    }
}
