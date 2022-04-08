using ExpenseIt;
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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window
    {
        public string MainCaptionText { get; set; }
        public List<Person> ExpenseDataSource { get; set; }
        public DateTime LastChecked { get; set; }
        public ObservableCollection<string> PersonsChecked
        { get; set; }
        public class Expense
        {
            public string ExpenseType { get; set; }
            public double ExpenseAmount { get; set; }
        }

        public class Person
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public List<Expense> Expenses;
        }
        public ExpenseItHome()
        {
            InitializeComponent();
            MainCaptionText = "View Expense Report";
            LastChecked = DateTime.Now;
            this.DataContext = this;
            PersonsChecked = new ObservableCollection<string>();
            ExpenseDataSource = new List<Person>()
            {
            new Person()
            {
                Name="Mike",
                Department ="Legal",
                Expenses = new List<Expense>()
                {
                    new Expense() { ExpenseType="Office Equipment", ExpenseAmount =70 },
                    new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
                }
            },
            new Person()
            {
                Name ="Lisa",
                Department ="Marketing",
                Expenses = new List<Expense>()
                {
                    new Expense() {  ExpenseType="Transportation", ExpenseAmount=50 },
                    new Expense() {  ExpenseType="Document printing", ExpenseAmount=25 }
                }
            },
            new Person()
            {
                Name="John",
                Department ="Engineering",
                Expenses = new List<Expense>()
                {
                  new Expense() { ExpenseType="Online educational work course", ExpenseAmount=100 },
                  new Expense() { ExpenseType="Hardware purchases", ExpenseAmount=670 },
                  new Expense() { ExpenseType="Software purchases", ExpenseAmount=400 }
                }
            },
            new Person()
            {
                Name="Mary",
                Department ="Finance",
                Expenses = new List<Expense>()
                {
                    new Expense() { ExpenseType="Food", ExpenseAmount=120 }
                }
            },
            new Person()
            {
                Name="Theo",
                Department ="Marketing",
                Expenses = new List<Expense>()
                {
                    new Expense() { ExpenseType="Personal C0mputer", ExpenseAmount=2200 }
                }
            },
            new Person()
            {
                Name="James",
                Department ="Finance",
                Expenses = new List<Expense>()
                {
                    new Expense() { ExpenseType="Transportation", ExpenseAmount=30 }
                }
            },
            new Person()
            {
                Name="David",
                Department ="Legal",
                Expenses = new List<Expense>()
                {
                    new Expense() { ExpenseType="Transportation", ExpenseAmount=60 },
                    new Expense() { ExpenseType="Food", ExpenseAmount=130 }
                }
            }
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport expenseReport = new ExpenseReport(peopleListBox.SelectedItem);
            expenseReport.Height = this.Height;
            expenseReport.Width = this.Width;
            expenseReport.Show();
        }

        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            LastChecked = DateTime.Now;
            PersonsChecked.Add((peopleListBox.SelectedItem as ExpenseItHome.Person).Name);
        }
    }
}
