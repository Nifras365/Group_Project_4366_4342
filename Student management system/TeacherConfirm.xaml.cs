﻿using System;
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

namespace Student_management_system
{
    /// <summary>
    /// Interaction logic for TeacherConfirm.xaml
    /// </summary>
    public partial class TeacherConfirm : Window
    {
        public TeacherConfirm()
        {
            InitializeComponent();
        }

        private void allclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
