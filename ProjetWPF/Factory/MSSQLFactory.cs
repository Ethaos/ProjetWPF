using ProjetWPF.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Factory
{
    class MSSQLFactory : AbstractDAOFactory
    {
        public override DAO<Member> GetMemberDAO()
        {
            return new MemberDAO();
        }

        public override DAO<Category> GetCategoryDAO()
        {
            return new CategoryDAO();
        }

        public override DAO<Responsible> GetResponsibleDAO()
        {
            return new ResponsibleDAO();
        }

        public override DAO<Ride> GetRideDAO()
        {
            return new RideDAO();
        }

        public override DAO<Bike> GetBikeDAO()
        {
            return new BikeDAO();
        }

        public override DAO<Inscription> GetInscriptionDAO()
        {
            return new InscriptionDAO();
        }

        public override DAO<Vehicle> GetVehicleDAO()
        {
            return new VehicleDAO();
        }
    }
}
