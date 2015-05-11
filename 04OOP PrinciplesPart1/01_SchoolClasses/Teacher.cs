using System;
using System.Collections.Generic;

namespace School
{
    class Teacher : People
    {
        public List<Discipline> Disciplines { get; set; }
        public string Comment { get; set; }

        internal Class Class
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Teacher(string name, List<Discipline> disciplines, string comment = "")
            : base(name)
        {
            Disciplines = disciplines;
            Comment = comment;
        }
    }
}