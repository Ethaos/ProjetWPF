using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    class Responsible : Person
    {
        private int idCategory;

        public Responsible(int id, string name, string firstname, int tel, string password, string login, int idCategory) : base(id, name, firstname, tel, password, login)
        {
            this.idCategory = idCategory;
        }

        public int Category
        {
            get { return idCategory; }
            set { idCategory = value; }
        }
    }
}
