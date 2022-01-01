using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF
{
    class Person
    {
        private int id;
        private string name;
        private string firstName;
        private int tel;
        private string passWord;

        public Person(int id, string name, string firstName, int tel, string passWord)
        {
            this.id = id;
            this.name = name;
            this.firstName = firstName;
            this.tel = tel;
            this.passWord = passWord;
        }
        public Person(){ }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

    }
}
