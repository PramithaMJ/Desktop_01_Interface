﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Desktop_01_3990.Model
{
    public class Student
    {
        public string StudentID { get;  set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BitmapImage Image { get; set; }

        public string DateOfBirth { get; set; }
        public Double GPA { get; set; }

        public String ImagePath
        {
            get { return $"/Images/{Image}"; }
        }

        public int Semester { get; set; }

        public Student(string studentID,int age, string firstName, string lastName,bool gender,double gpa,int semester, string dateOfBirth, BitmapImage image)
        {
            StudentID = studentID;
            Age = age;
            Gender = gender;
            Semester = semester;
            GPA= gpa;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Image = image;
        }

        public Student()
        {
        }
    }
}