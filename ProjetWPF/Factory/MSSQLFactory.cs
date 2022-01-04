using ProjetWPF.DAO;
using ProjetWPF.Metier;
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

        /*
        public override DAO<Category> GetCategoryDAO()
        {
            return new CategoryDAO();
        }
        public override DAO<Matiere> GetMatiereDAO()
        {
            return new MatiereDAO();
        }
        public override DAO<Professeur> GetProfesseurDAO()
        {
            return new ProfesseurDAO();
        }*/
    }

}
