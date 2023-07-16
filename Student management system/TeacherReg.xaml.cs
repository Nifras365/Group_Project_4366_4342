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
using System.Data.SQLite;

namespace Student_management_system
{

    public partial class TeacherReg : Window
    {
        private string connectionString = "Data Source=C:/Users/Nifras MJM/Desktop/Programming Project/Group project/Student management system/TeacherRegistration.db; Version=3;";

        public TeacherReg()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = Fnametb.Text;
            string lastName = Lnametb.Text;
            string teacherId = TecIDtb.Text;
            string email = Emailtb.Text;
            string username = USernametb.Text;
            string password = PSwordtb.Password;
            string confirmPassword = ConPStb.Password;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(teacherId) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the passwords.");
                PSwordtb.Clear();
                ConPStb.Clear();
                PSwordtb.Focus();
                return;
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the username already exists in the database
                    string checkUsernameQuery = "SELECT COUNT(*) FROM TeacherRegistrations WHERE Username = @Username";
                    using (var checkUsernameCommand = new SQLiteCommand(checkUsernameQuery, connection))
                    {
                        checkUsernameCommand.Parameters.AddWithValue("@Username", username);
                        int usernameMatchCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                        if (usernameMatchCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            USernametb.Clear();
                            USernametb.Focus();
                            return;
                        }
                    }

                    // Insert the registration data into the database
                    string insertQuery = @"INSERT INTO TeacherRegistrations (FirstName, LastName, TeacherId, Email, Username, Password)
                                          VALUES (@FirstName, @LastName, @TeacherId, @Email, @Username, @Password)";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@TeacherId", teacherId);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Teacher registration successful!");


                        // Close the current window (TeacherReg)
                        this.Close();

                        // Show the MainWindow
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during teacher registration: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            RegisterAstecORstu registerAstecORstu = new RegisterAstecORstu();
            registerAstecORstu.Show();
        }
    }
}
