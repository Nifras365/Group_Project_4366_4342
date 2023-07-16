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

namespace Student_management_system
{
    /// <summary>
    /// Interaction logic for RegisterAstecORstu.xaml
    /// </summary>
    public partial class RegisterAstecORstu : Window
    {
        public RegisterAstecORstu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            StudentReg studentReg = new StudentReg();
            studentReg.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            TeacherReg teacherReg = new TeacherReg();
            teacherReg.Show();
        }
    }
}
