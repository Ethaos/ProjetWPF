using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.DAO
{
    internal class VehicleDAO : DAO<Vehicle>
    {
        public override bool Create(Vehicle obj)
        {
            //Créer la fonction
            return false;
        }

        public override bool Delete(Vehicle obj)
        {
            throw new NotImplementedException();
        }

        public override Vehicle Find(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Vehicle> FindAll()
        {
            throw new NotImplementedException();
        }

        public override List<Vehicle> FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Vehicle> FindByMember(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override Vehicle LoginCheck(string a, string b)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Vehicle obj)
        {
            throw new NotImplementedException();
        }
    }
}
