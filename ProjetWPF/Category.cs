﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projet
{
    class Category
    {
        private int num;

        public Category(int num)
        {
            this.num = num;
        }

        public Category(){ }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
    }
}
