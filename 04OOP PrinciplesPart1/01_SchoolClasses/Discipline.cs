using System;

namespace School
{
    class Discipline
    {
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }
        public string Comment { get; set; }

        internal Teacher Teacher
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Discipline(string name, int numberOfLecture, int numberOfExercises, string comment = "")
        {
            Name = name;
            NumberOfLectures = numberOfLecture;
            NumberOfExercises = numberOfExercises;
            Comment = comment;
        }
    }
}