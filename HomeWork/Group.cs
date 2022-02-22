using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Group
    {
        public string No;
        public int Limit;

        public Student[] _students;

        public Group(string no, int limit)
        {
            _students = new Student[0];
            No = no;
            Limit = limit;
        }
        public void AddStudent(Student student)
        {
           
            if (_students.Length < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("yer yoxdur");
            }
        }
        public Student[] GetStudents()
        {
            return _students;
        }
    }

}
