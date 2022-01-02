using ProjetWPF.DAO;
using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Factory
{
    public enum DAOFactoryType
    {
        MS_SQL_FACTORY,
        XML_FACTORY
    }
    internal abstract class AbstractDAOFactory
    {
        public abstract DAO<Member> GetMemberDAO();
        /*
        public abstract DAO<Professeur> GetProfesseurDAO();
        public abstract DAO<Eleve> GetEleveDAO();
        public abstract DAO<Matiere> GetMatiereDAO();*/
        public static AbstractDAOFactory GetFactory(DAOFactoryType type)
        {
            switch (type)
            {
                case DAOFactoryType.MS_SQL_FACTORY:
                    return new MSSQLFactory();
                case DAOFactoryType.XML_FACTORY:
                    return null;
                default:
                    return null;
            }
        }
    }

}
