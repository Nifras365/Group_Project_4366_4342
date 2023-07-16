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
using System.Data.SQLite;


namespace Student_management_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string adminConnectionString = "Data Source=C:/Users/Nifras MJM/Desktop/Programming Project/Group project/Student management system/LoginData.db; Version=3;";
        private string userRegistrationsConnectionString = "Data Source=C:/Users/Nifras MJM/Desktop/Programming Project/Group project/Student management system/UserRegistration.db; Version=3;";
        private string teacherRegistrationsConnectionString = "Data Source=C:/Users/Nifras MJM/Desktop/Programming Project/Group project/Student management system/TeacherRegistration.db; Version=3;";

        //string connectionString = @"C:/Users/Nifras MJM/Desktop/Programming Project/Group project/Student management system/Userlogin.db";
        public MainWindow()
        {
            InitializeComponent();
        }
        
      
    private void Button_Click(object sender, RoutedEventArgs e)
        {

            RegisterAstecORstu registerAstecORstu = new RegisterAstecORstu();
            registerAstecORstu.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = Usernametb.Text;
            string password = Passwordtb.Password;

            // Connect to the SQLite databases
            using (var adminConnection = new SQLiteConnection(adminConnectionString))
            using (var userRegistrationsConnection = new SQLiteConnection(userRegistrationsConnectionString))
            using (var teacherRegistrationsConnection = new SQLiteConnection(teacherRegistrationsConnectionString))
            {
                try
                {
                    adminConnection.Open();
                    userRegistrationsConnection.Open();
                    teacherRegistrationsConnection.Open();

                    // Check if the entered credentials match the admin login information
                    string adminLoginQuery = "SELECT COUNT(*) FROM Logindata WHERE Username = @Username AND Password = @Password";
                    using (var adminCommand = new SQLiteCommand(adminLoginQuery, adminConnection))
                    {
                        adminCommand.Parameters.AddWithValue("@Username", username);
                        adminCommand.Parameters.AddWithValue("@Password", password);

                        int adminMatchCount = Convert.ToInt32(adminCommand.ExecuteScalar());

                        if (adminMatchCount > 0)
                        {
                            // Admin login successful
                            StudentDetails studentDetails = new StudentDetails();
                            studentDetails.Show();
                            return;
                        }
                    }

                    // Check if the entered credentials match the user login information in UserRegistrations
                    string userLoginQuery = "SELECT COUNT(*) FROM UserRegistrations WHERE Username = @Username AND Password = @Password";
                    using (var userCommand = new SQLiteCommand(userLoginQuery, userRegistrationsConnection))
                    {
                        userCommand.Parameters.AddWithValue("@Username", username);
                        userCommand.Parameters.AddWithValue("@Password", password);

                        int userMatchCount = Convert.ToInt32(userCommand.ExecuteScalar());

                        if (userMatchCount > 0)
                        {
                            // User login successful
                            StudentDetails studentDetails = new StudentDetails();
                            studentDetails.Show();
                            return;
                        }
                    }

                    // Check if the entered credentials match the user login information in TeacherRegistrations
                    string teacherLoginQuery = "SELECT COUNT(*) FROM TeacherRegistrations WHERE Username = @Username AND Password = @Password";
                    using (var teacherCommand = new SQLiteCommand(teacherLoginQuery, teacherRegistrationsConnection))
                    {
                        teacherCommand.Parameters.AddWithValue("@Username", username);
                        teacherCommand.Parameters.AddWithValue("@Password", password);

                        int teacherMatchCount = Convert.ToInt32(teacherCommand.ExecuteScalar());

                        if (teacherMatchCount > 0)
                        {
                            // Teacher login successful
                            TeacherConfirm teacherConfirm = new TeacherConfirm();
                            teacherConfirm.Show();
                            return;
                        }
                    }

                    // No matching credentials found
                    MessageBox.Show("Invalid username or password");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                }
                finally
                {
                    adminConnection.Close();
                    userRegistrationsConnection.Close();
                    teacherRegistrationsConnection.Close();
                }
            }
        }
    }

    /*
    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        string username = Usernametb.Text;
        string password = Passwordtb.Password;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.");
            return;
        }

        string connectionString = "Data Source=C:/Users/Nifras MJM/Desktop/Programming Project/Group project/Student management system/LoginData.db; Version=3;";

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM Logindata WHERE Username = @Username AND Password = @Password";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int matchCount = Convert.ToInt32(command.ExecuteScalar());

                if (matchCount > 0)
                {
                    // Match found in the database
                    StudentDetails studentDetails = new StudentDetails();
                    studentDetails.Show();
                }
                else
                {
                    // No match found in the database
                    MessageBox.Show("Invalid username or password.");
                }
            }

            connection.Close();
        }
    }
    */

    /*  private void Button_Click_1(object sender, RoutedEventArgs e)
      {
          string username = Usernametb.Text;
          string password = Passwordtb.Password;


          //if nothing in textboxes
          if (string.IsNullOrEmpty(Usernametb.Text) || string.IsNullOrEmpty(Passwordtb.Password))
          {
              MessageBox.Show("Enter Username and Password before Login");
          }
          if (username == "Admin" && password == "1234")
          {
              StudentDetails studentDetails = new StudentDetails();
              studentDetails.Show();
          }
      }
    */
}
