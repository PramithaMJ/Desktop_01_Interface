using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using Desktop_01_3990.Model;

namespace Desktop_01_3990.ViewModel
{
    public partial class AddStudentVM : ObservableObject

    {
        [ObservableProperty]
        public string studentID;

        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public int semester;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public bool gender;

        //To change the tile

        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public BitmapImage selectedImage;

        

        public AddStudentVM(Student u)
        {
            Student1 = u;

            studentID = Student1.StudentID;
            firstname = Student1.FirstName;
            lastname = Student1.LastName;
            age = Student1.Age;
            gpa = Student1.GPA;
            gender = Student1.Gender;
            semester = Student1.Semester; ;
            dateofbirth = Student1.DateOfBirth;
            selectedImage = Student1.Image;

        }
        public AddStudentVM()
        {

        }


        //get image 
        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(dialog.FileName));

                MessageBox.Show("Imgae successfuly uploded!", "successfull");
            }
        }






        public Student Student1 { get; private set; }
        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {
           

            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "Error");
                return;
            }
            if (Student1 == null)
            {

                Student1 = new Student()
                {
                    StudentID=studentID,
                    FirstName = firstname,
                    LastName = lastname,
                    Semester  = semester,
                    Age = age,
                    Gender= gender,
                    DateOfBirth = dateofbirth,
                    Image = selectedImage,

                    GPA = gpa

                };


            }
            else
            {
                Student1.Semester =semester;
                Student1.FirstName = firstname;
                Student1.LastName = lastname;
                Student1.Age = age;
                Student1.GPA = gpa;
                Student1.DateOfBirth = dateofbirth;//-----------------
                Student1.Gender= gender;
                Student1.Image = selectedImage;
                Student1.DateOfBirth = dateofbirth;



            }

            if (Student1.FirstName != null)
            {

                CloseAction();
            }
            Application.Current.MainWindow.Show();


        }
    }
}
