using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Principles
{
    public abstract class CommentableObject
    {
        private string comment;

        public string Comment { get{return this.comment;} }

        public void AddComent(string comment)
        {
            this.comment += comment + Environment.NewLine;
        }
    }
}
