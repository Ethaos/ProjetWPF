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

        public override List<Ride> FindAll()
        {
            return null;
        }

        public override Ride Find(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Ride> FindBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
