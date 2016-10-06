using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public enum Gender { Male, Female};
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Student(string id, string name, Gender gender)
        {
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
        }
    }
    public class StudentClass
    {
        public string CRN { get; set; }
        public string Lecturer { get; set; }
        private ArrayList students;
        public StudentClass()
        {
            this.students = new ArrayList();
        }
        public void addStudent(Student stu)
        {
            this.students.Add(stu);
        }
        public Student this[int i]
        {
            get
            {
                if (i >= this.students.Count)
                    throw new IndexOutOfRangeException("There are not that many students in the class");
                return (Student)this.students[i];
            }
        }
        public Student this[string studentID]
        {
            get
            {
                foreach(Student student in this.students)
                {
                    if (student.ID == studentID)
                        return student;
                }
                throw new Exception("Could not find a student with this ID");
            }
        }
    }
}
