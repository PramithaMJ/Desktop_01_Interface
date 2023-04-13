using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Desktop_01_3990.ViewModel;
using Desktop_01_3990.View;
using System.ComponentModel;
using Desktop_01_3990.Model;

namespace Desktop_01_3990
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();

            //var converter = new BrushConverter();
            //ObservableCollection<Student> students = new ObservableCollection<Student>();

            //////Create DataGrid Items Info
            //students.Add(new Student { Number = "1", Character = "A", bgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Dohn", Position = "Coach", Email = "132@gmail.com", Phone = "1326548794" });
            //students.Add(new Student { Number = "2", Character = "B", bgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Naoh", Position = "Administer", Email = "gfhf@gmail.com", Phone = "4561325467" });
            //students.Add(new Student { Number = "3", Character = "C", bgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Amma", Position = "Staff", Email = "dsds@gmail.com", Phone = "5462133695" });
            //students.Add(new Student { Number = "4", Character = "D", bgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Niyan", Position = "Manager", Email = "", Phone = "4242583691" });
            //students.Add(new Student { Number = "5", Character = "E", bgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Saji", Position = "Coach", Email = "abc@gmail.com", Phone = "7535196394" });

            //StudentsDatagrid.ItemsSource= students;

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();    
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 3)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var row = e.Source as DataGridRow;

                DetailsWindowView detailsWindow = new DetailsWindowView(row.Item);
                detailsWindow.Owner = this;

                detailsWindow.Show();


            }
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchTextBox.Text;
            ICollectionView view = CollectionViewSource.GetDefaultView(StudentsDatagrid.ItemsSource);

            if (!string.IsNullOrEmpty(searchText))
            {
                view.Filter = item =>
                {
                    Student student2 = item as Student;
                    return (student2 != null) &&
                           (student2.StudentID.Contains(searchText) ||
                            student2.FirstName.Contains(searchText) ||
                            student2.LastName.Contains(searchText) ||
                            student2.Age.ToString().Contains(searchText) ||
                            student2.DateOfBirth.ToString().Contains(searchText) ||
                            student2.GPA.ToString().Contains(searchText));
                };
            }
            else
            {
                view.Filter = null;
            }
        }






        //public class Student
        //{
        //    public string Character { get; set; }
        //    public string Number { get; set; }
        //    public string Name { get; set; }
        //    public string Position { get; set; }
        //    public string Email { get; set; }
        //    public string Phone { get; set; }
        //    public Brush bgColor { get; set; }

        //}
    }

}
