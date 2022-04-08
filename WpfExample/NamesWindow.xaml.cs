using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for NamesWindow.xaml
    /// </summary>
    public partial class NamesWindow : Window
    {
        public NamesWindow()
        {
            InitializeComponent();
            DataContext = new NamesList();
        }

        public class NamesList : INotifyPropertyChanged
        {
            string _firstName = "";
            string _lastName = "";
            string _selectedName;

            public NamesList()
            {
                Names = new ObservableCollection<string>();
            }

            public string FirstName
            {
                get { return _firstName; }
                set
                {
                    if (_firstName != value)
                    {
                        _firstName = value;
                        OnPropertyChanged("FirstName");
                    }
                }
            }

            public string LastName
            {
                get { return _lastName; }
                set
                {
                    if (_lastName != value)
                    {
                        _lastName = value;
                        OnPropertyChanged("LastName");
                    }
                }
            }
            public string SelectedName
            {
                get { return _selectedName; }
                set
                {
                    if (_selectedName != value)
                    {
                        _selectedName = value;
                        OnPropertyChanged("SelectedName");
                    }
                }
            }
            public ObservableCollection<string> Names { get; private set; }
            private void OnPropertyChanged(string property)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            AddCommand _addNameCommand = new AddCommand();

            public AddCommand AddNameCommand
            {
                get { return _addNameCommand; }
            }

            RemoveCommand _removeNameCommand = new RemoveCommand();

            public RemoveCommand RemoveNameCommand
            {
                get { return _removeNameCommand; }
            }
        }

        public class AddCommand : ICommand
        {
            public void Execute(object parameter)
            {
                var nameList = parameter as NamesList;
                var newName = String.Format("{0} {1}", nameList.FirstName, nameList.LastName);
                nameList.Names.Add(newName);
                nameList.FirstName = nameList.LastName + "";
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
        }

        public class RemoveCommand : ICommand
        {
            public void Execute(object parameter)
            {
                var nameList = parameter as NamesList;
                var oldName = nameList.SelectedName;
                nameList.Names.Remove(oldName);
            }

            public bool CanExecute(object parameter)
            {
                var nameList = parameter as NamesList;
                return nameList != null && nameList.SelectedName != null;
            }

            public event EventHandler CanExecuteChanged;
        }
    }
}
