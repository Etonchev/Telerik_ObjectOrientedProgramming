using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace _01_StudentClass
{
    public enum Speciality { Mathematics, Biology, Chemistry };
    public enum University { SU, TU, Medics };
    public enum Faculty { FMI, Physics, Chemists };

    [Serializable]
    class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string Mobilephone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Speciality Speciality { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public Student(string firstName, string middleName, string lastName, string ssn, string address, string mobilephone, string email, string course,
            Speciality speciality, University university, Faculty faculty)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            SSN = ssn;
            Address = address;
            Mobilephone = mobilephone;
            Email = email;
            Course = course;
            Speciality = speciality;
            University = university;
            Faculty = faculty;
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }

            if (!Object.Equals(this.Address, student.Address))
            {
                return false;
            }

            if (!Object.Equals(this.Mobilephone, student.Mobilephone))
            {
                return false;
            }

            if (!Object.Equals(this.Email, student.Email))
            {
                return false;
            }

            if (!Object.Equals(this.Course, student.Course))
            {
                return false;
            }

            if (!Object.Equals(this.Speciality, student.Speciality))
            {
                return false;
            }

            if (!Object.Equals(this.University, student.University))
            {
                return false;
            }

            if (!Object.Equals(this.Faculty, student.Faculty))
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}, SSN: {3}, Address: {4}, Mobilephone: {5}, Email: {6}, Course: {7}, Speciality: {8}, University: {9}, Faculty: {10}",
                FirstName, MiddleName, LastName, SSN, Address, Mobilephone, Email, Course, Speciality, University, Faculty);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode() ^ this.Address.GetHashCode()
                 ^ this.Mobilephone.GetHashCode() ^ this.Email.GetHashCode() ^ this.Course.GetHashCode() ^ this.Speciality.GetHashCode() ^ this.University.GetHashCode() ^ this.Faculty.GetHashCode();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Equals(secondStudent))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (!firstStudent.Equals(secondStudent))
            {
                return true;
            }

            return false;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return formatter.Deserialize(stream);
            }
        }

        public int CompareTo(Student student)
        {
            string firstWholeName = this.FirstName + this.MiddleName + this.LastName;
            string secondWholeName = student.FirstName + student.MiddleName + student.LastName;
            int result = firstWholeName.CompareTo(secondWholeName);
            if (result == 0)
            {
                result = this.SSN.CompareTo(student.SSN);
            }

            return result;
        }
    }
}
