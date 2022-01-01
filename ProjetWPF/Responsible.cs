using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF
{
    class Responsible
    {
        private Category catResp;
        private Person personResp;

        public Responsible(Category catResp, Person personResp)
        {
            this.catResp = catResp;
            this.personResp = personResp;
        }

        public Category CatResp
        {
            get { return catResp; } 
            set { catResp = value; }
        }

        public Person PersonResp
        {
            get { return personResp; }
            set { personResp = value; }
        }
    }
}
