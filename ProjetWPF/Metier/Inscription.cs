using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Inscription
    {
        private int idMember { get; set; }
        private int idRide { get; set; }
        private int passenger { get; set; }
        private int bikes { get; set; }

        public Inscription(int idMember, int idRide,int passenger, int bikes)
        {
            this.idMember = idMember;
            this.idRide = idRide;
            this.passenger = passenger;
            this.bikes = bikes;
        }
    }
}
