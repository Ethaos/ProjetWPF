using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.Metier
{
    public class Category
    {
        private int num;
        private string nameCategory;
        private string nameUnderCategory;

        public Category(int num, string nameCategory, string nameUnderCategory)
        {
            this.num = num;
            this.nameCategory = nameCategory;
            this.nameUnderCategory = nameUnderCategory;
        }

        public Category(){ }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public string NameCategory
        {
            get { return nameCategory; }
            set { nameCategory = value; }
        }

        public string NameUnderCategory
        {
            get { return nameUnderCategory; }
            set { nameUnderCategory = value; }
        }
    }
}
