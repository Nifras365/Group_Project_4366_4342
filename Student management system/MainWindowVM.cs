using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Student_management_system
{
        public partial class MainWindowVM : ObservableObject
        {
            //Things get complex when i used this method on other buttons
            public ICommand CloseCommand { get; }

            public MainWindowVM()
            {
                CloseCommand = new RelayCommand(Close);
            }

            private void Close()
            {
                // Close the application loginwindow

                Application.Current.Shutdown();
            }
        }
    }
