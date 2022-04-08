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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {
            foreach (var item in StudentInfoSystem.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        public void GetStudentInfo()
        {
            List<Student> students = StudentData.TestStudents;

            txtName.Text = students[0].name;
            txtMiddleName.Text = students[0].middleName;
            txtFamilyName.Text = students[0].familyName;
            txtFaculty.Text = students[0].faculty;
            txtSpecialty.Text = students[0].specialty;
            txtEducationalDegree.Text = students[0].educationalDegree;
            txtStatus.Text = students[0].status;
            txtFacultyNumber.Text = students[0].facultyNumber;
            txtCourse.Text = students[0].course.ToString();
            txtFlow.Text = students[0].stream.ToString();
            txtGroup.Text = students[0].group.ToString();
        }

        public void DisableFields()
        {
            foreach (var cntrl in StudentInfoSystem.Children)
            {
                if (cntrl is TextBox)
                {
                    ((TextBox)cntrl).IsEnabled = false;
                }
            }
        }

        public void EnableFields()
        {
            foreach (var cntrl in StudentInfoSystem.Children)
            {
                if (cntrl is TextBox)
                {
                    ((TextBox)cntrl).IsEnabled = true;
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void btnDisableCntrls_Click(object sender, RoutedEventArgs e)
        {
            DisableFields();
        }

        private void btnShowData_Click(object sender, RoutedEventArgs e)
        {
            GetStudentInfo();
        }

        private void btnEnableCntrls_Click(object sender, RoutedEventArgs e)
        {
            EnableFields();
        }
    }
}
