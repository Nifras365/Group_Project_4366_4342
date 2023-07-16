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
    public partial class StudentDetails : Window
    {
        private string connectionString = "Data Source=C:/Users/Nifras MJM/Desktop/Programming Project/Group project/Student management system/StudentDetails.db; Version=3;";
        private bool isEditing = false;

        public StudentDetails()
        {
            InitializeComponent();

            // Load the student details if available
            LoadStudentDetails();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FiNametb.Text;
            string lastName = LaNametb.Text;
            string registrationNo = ReNotb.Text;
            string email = mailtb.Text;
            string dateOfBirth = DOBtb.Text;
            string age = aGEtb.Text;
            string phoneNumber = Phnotb.Text;
            string address = Addresstb.Text;
            string courseOfStudy = COStb.Text;
            string gender = Gendertb.Text;

            // Save the student details to the database
            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO StudentDetail (FirstName, LastName, RegistrationNo, Email, DateOfBirth, Age, PhoneNumber, Address, COS, Gender ) VALUES (@FirstName, @LastName, @RegistrationNo, @Email, @DateOfBirth, @Age, @PhoneNumber, @Address, @COS, @Gender)";
                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@RegistrationNo", registrationNo);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@COS", courseOfStudy);
                        command.Parameters.AddWithValue("Gender", gender);
                      //  command.Parameters.AddWithValue("@Username", username);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Student details saved successfully!");
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("An error occurred while saving student details: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadStudentDetails()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM StudentDetail";
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the fields with the retrieved data
                                FiNametb.Text = reader["FirstName"].ToString();
                                LaNametb.Text = reader["LastName"].ToString();
                                ReNotb.Text = reader["RegistrationNo"].ToString();
                                mailtb.Text = reader["Email"].ToString();
                                DOBtb.Text = reader["DateOfBirth"].ToString();
                                aGEtb.Text = reader["Age"].ToString();
                                Phnotb.Text = reader["PhoneNumber"].ToString();
                                Addresstb.Text = reader["Address"].ToString();
                                COStb.Text = reader["COS"].ToString();
                                Gendertb.Text = reader["Gender"].ToString();
                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("An error occurred while loading student details: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isEditing)
            {
                EnableEditing();
                EditButton.Content = "Save";
            }
            else
            {
                if (SaveStudentDetails())
                {
                    DisableEditing();
                    EditButton.Content = "Edit";
                }
                else
                {
                    MessageBox.Show("Failed to save student details.");
                }
            }

            isEditing = !isEditing;
        }

        private bool SaveStudentDetails()
        {
            // Get the updated values from the text fields
            string firstName = FiNametb.Text;
            string lastName = LaNametb.Text;
            string registrationNo = ReNotb.Text;
            string email = mailtb.Text;
            string dateOfBirth = DOBtb.Text;
            string age = aGEtb.Text;
            string phoneNumber = Phnotb.Text;
            string address = Addresstb.Text;
            string courseOfStudy = COStb.Text;
            string gender = Gendertb.Text;

            // Update the student details in the database
            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE StudentDetail SET FirstName = @FirstName, LastName = @LastName, Email = @Email, DateOfBirth = @DateOfBirth, Age = @Age, PhoneNumber = @PhoneNumber, Address = @Address, COS = @COS, Gender = @Gender WHERE RegistrationNo = @RegistrationNo";
                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@COS", courseOfStudy);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@RegistrationNo", registrationNo);
                        // ... continue adding parameters for other fields

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student details updated successfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No records found for the given registration number.");
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("An error occurred while updating student details: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }


            return false;
        }
        private void EnableEditing()
        {
            FiNametb.IsEnabled = true;
            LaNametb.IsEnabled = true;
            ReNotb.IsEnabled = true;
            mailtb.IsEnabled = true;
            DOBtb.IsEnabled = true;
            aGEtb.IsEnabled = true;
            Phnotb.IsEnabled = true;
            Addresstb.IsEnabled = true;
            COStb.IsEnabled = true;
            Gendertb.IsEnabled = true;
        }

        private void DisableEditing()
        {
            FiNametb.IsEnabled = false;
            LaNametb.IsEnabled = false;
            ReNotb.IsEnabled = false;
            mailtb.IsEnabled = false;
            DOBtb.IsEnabled = false;
            aGEtb.IsEnabled = false;
            Phnotb.IsEnabled = false;
            Addresstb.IsEnabled = false;
            COStb.IsEnabled = false;
            Gendertb.IsEnabled = false;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }
    }
}
    

