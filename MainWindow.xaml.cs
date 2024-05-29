using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3._3._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> StudentList = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
            List<string> test = new List<string>();
            int i = 0;

        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Add_Student_Button_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(First_Name.Text) || String.IsNullOrEmpty(Last_Name.Text) || String.IsNullOrEmpty(Address.Text) || String.IsNullOrEmpty(Month_of_Admission.Text) || String.IsNullOrEmpty(GPA.Text))
                { MessageBox.Show("Ensure all fields are filled with applicable data"); }
            else {
                Student student= new Student(StudentID.Text, First_Name.Text, Last_Name.Text, Address.Text, Month_of_Admission.Text, Convert.ToDouble(GPA.Text));
                StudentList.Add(student);
                MessageBox.Show("student added");
            }

        }
    }
}
