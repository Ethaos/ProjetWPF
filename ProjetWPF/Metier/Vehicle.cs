using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Vehicle
    {
        private int idVehicle { get; set; }
        private int nbrPlacesMembers { get; set; }
        private int nbrPlacesBikes { get; set; }
        private int idDriver { get; set; }
        private int idRide { get; set; }

        public Vehicle(int idVehicle, int nbrPlacesMembers, int nbrPlacesBikes, int idDriver, int idRide)
        {
            this.idVehicle = idVehicle;
            this.nbrPlacesMembers = nbrPlacesMembers;
            this.nbrPlacesBikes = nbrPlacesBikes;
            this.idDriver = idDriver;
            this.idRide = idRide;
        }

        public void addPassenger()
        {

        }

        public void addBike()
        {

        }
    }
}
