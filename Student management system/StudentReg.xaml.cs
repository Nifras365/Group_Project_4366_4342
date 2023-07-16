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
        public partial class StudentReg : Window
        {
            private string connectionString = "Data Source=C:/Users/Nifras MJM/Desktop/Programming Project/Group project/Student management system/UserRegistration.db; Version=3;";

            public StudentReg()
            {
                InitializeComponent();
            }

            private void RegisterButton_Click(object sender, RoutedEventArgs e)
            {
                string firstName = Firstnametb.Text;
                string lastName = Lastnametb.Text;
                string registrationNo = Regnotb.Text;
                string email = Mailtb.Text;
                string username = UserNametb.Text;
                string password = PassWordtb.Password;
                string confirmPassword = CpassWordtb.Password;

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(registrationNo) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please re-enter the passwords.");
                    PassWordtb.Clear();
                    CpassWordtb.Clear();
                    PassWordtb.Focus();
                    return;
                }

                using (var connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Check if the username already exists in the database
                        string checkUsernameQuery = "SELECT COUNT(*) FROM UserRegistrations WHERE Username = @Username";
                        using (var checkUsernameCommand = new SQLiteCommand(checkUsernameQuery, connection))
                        {
                            checkUsernameCommand.Parameters.AddWithValue("@Username", username);
                            int usernameMatchCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                            if (usernameMatchCount > 0)
                            {
                                MessageBox.Show("Username already exists. Please choose a different username.");
                                UserNametb.Clear();
                                UserNametb.Focus();
                                return;
                            }
                        }

                        // Insert the registration data into the database
                        string insertQuery = @"INSERT INTO UserRegistrations (FirstName, LastName, RegistrationNo, Email, Username, Password)
                                          VALUES (@FirstName, @LastName, @RegistrationNo, @Email, @Username, @Password)";

                        using (var command = new SQLiteCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@RegistrationNo", registrationNo);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Registration successful!");

                        // Close the current window (StudentReg)
                        this.Close();

                        // Show the MainWindow
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during registration: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegisterAstecORstu registerAstecORstu = new RegisterAstecORstu();
            registerAstecORstu.Show();
        }
    }
    }
