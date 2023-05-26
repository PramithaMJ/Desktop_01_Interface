using CommunityToolkit.Mvvm.ComponentModel;
using Desktop_01_3990.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Desktop_01_3990.ViewModel
{
    public partial class DetailsWindowViewVM :ObservableObject

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
        public string gender;

   
        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public DateTime dateOfBirthDMY;


    }
}
