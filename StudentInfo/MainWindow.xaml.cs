using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace StudentInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentList = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            InitiateList();
            InitiateTree();
        }

        private void InitiateList()
        {
            // Jag
            studentList.Add(new Student("Cosmos", "Lundell", Student.genderType.Male, 17, "https://yt3.ggpht.com/-EhxXAEvI0MY/AAAAAAAAAAI/AAAAAAAAAAA/h70caHA7Uic/s900-c-k-no/photo.jpg"));
            // Plådrick
            studentList.Add(new Student("Patric", "Doe", Student.genderType.Male, 17));
            // Khaleel
            studentList.Add(new Student("Khaleel", "Elias", Student.genderType.Male, 18, "https://yt3.ggpht.com/-jv1-xl3Zg6g/AAAAAAAAAAI/AAAAAAAAAAA/1UN9-D4WRj4/s900-c-k-no/photo.jpg"));
            // Robert
            studentList.Add(new Student("Robert", "Johansson", Student.genderType.Male, 17, "http://www.swebowl.se/ImageVaultFiles/id_87307/cf_6517/2013_Vinnarna_i_U23_t-vlingen.jpg"));
            // Wiktor
            studentList.Add(new Student("Wiktor", "Rydlund", Student.genderType.Male, 17));
            // Lägger till fler senare
        }

        private void InitiateTree()
        {
            string[] items = new string[] { "Name", "Age", "Gender"};
            for (int i = 0; i < 3; i++)
            {
                TreeViewItem treeItem = new TreeViewItem();
                treeItem.Header = items[i];
                treeItem.Items.Add("");
                treeView.Items.Add(treeItem);
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (studentList.Count != 0 && inputBox.Text != null)
                {
                    treeView.Items.Clear();

                    Student student = studentList.Find(item => item.FirstName.ToString() == inputBox.Text);
                    image.Source = new BitmapImage(new Uri(student.Profile, UriKind.RelativeOrAbsolute));

                    string[] items = new string[] { "Name", "Age", "Gender" };
                    string[] itemValues = new string[] { student.FirstName + " " + student.LastName, student.Age.ToString(), student.Gender.ToString() };
                    for (int i = 0; i < 3; i++)
                    {
                        TreeViewItem treeItem = new TreeViewItem();
                        treeItem.Header = items[i];
                        treeItem.Items.Add(itemValues[i]);
                        treeView.Items.Add(treeItem);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
