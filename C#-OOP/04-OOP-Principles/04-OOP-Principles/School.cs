﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Principles
{
    class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.classes = classes;
        }

        public List<Class> Classes
        {
            get { return this.classes; }
            private set
            {
                this.classes = value;
            }
        }
    }
}
