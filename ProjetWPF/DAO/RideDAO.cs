using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.DAO
{
    internal class RideDAO : DAO<Ride>
    {
        public RideDAO() { }

        public override bool Create(Ride obj)
        {
            return false;
        }
        public override bool Delete(Ride obj)
        {
            return false;
        }
        public override bool Update(Ride obj)
        {
            return false;
        }
        public override Ride Find(int id)
        {
            return null;
        }

        public override List<Ride> FindAll()
        {
            return null;
        }

        public override bool Add(int a, int b)
        {
            return false;
        }

        public override List<Ride> FindBy(int id)
        {
            return null;
        }
    }
}
