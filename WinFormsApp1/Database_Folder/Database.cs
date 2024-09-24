using System;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp1.Patients;
using WinFormsApp1.Adminpanel;
using WinFormsApp1.Interface;


namespace Database
{
    public class DatabaseManager:IDatabase
    {
        private string connectionString;

        public DatabaseManager()
        {
            connectionString = "Server=localhost;Database=hospitalmanagement;User ID=root;Password=12345678!;port=3306";
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }


        public bool AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return false;

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT EncryptedPassword FROM Patients WHERE PhoneNumber = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string dbpass = result.ToString();
                            if (dbpass == password)
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }




        public bool AuthenticateAdmin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return false;

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT Password FROM Admins WHERE Username = '{username}'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        //cmd.Parameters.AddWithValue("@Username", username);
                        object result = null;
                        if (cmd.ExecuteScalar()!=null)
                         result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string dbpass = result.ToString();
                            if (dbpass == password)
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }


        public string AdminName(string username)
        {
            if (string.IsNullOrEmpty(username)) return "";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT FullName FROM Admins WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string adminName = result.ToString();
                            Debug.WriteLine("Full Name: " + adminName);
                            return adminName;
                        }
                        return "";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                    return "";
                }
            }
        }


        public string AdminPicture(string username)
        {
            if (string.IsNullOrEmpty(username)) return "";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT ImagePath FROM Admins WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string adminPicture = result.ToString();
                            Debug.WriteLine("Path: " + adminPicture);
                            return adminPicture;
                        }
                        return "";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                    return "";
                }
            }
        }


        public string AdminEmail(string username)
        {
            if (string.IsNullOrEmpty(username)) return "";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT Email FROM Admins WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string adminEmail = result.ToString();
                            Debug.WriteLine("Email: " + adminEmail);
                            return adminEmail;
                        }
                        return "";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                    return "";
                }
            }
        }


        public string AdminID(string username)
        {
            if (string.IsNullOrEmpty(username)) return "";

            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT AdminID FROM Admins WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string adminID = result.ToString();
                            Debug.WriteLine("AdminID: " + adminID);
                            return adminID;
                        }
                        return "";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                    return "";
                }
            }
        }



        public void SaveData(string fullName, int age, string gender, string address, string medicalCondition, string phoneNumber, string encryptedPassword)
        {
            string query = $@"
        INSERT INTO Patients ( FullName, Age, Gender, Address, MedicalCondition, PhoneNumber, EncryptedPassword) 
        VALUES ('{fullName}', {age}, '{gender}', '{address}', '{medicalCondition}', '{phoneNumber}', '{encryptedPassword}')";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Console.WriteLine("Data saved successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to save data.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        public bool PhoneNumberExists(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber)) return false;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Patients WHERE PhoneNumber = @PhoneNumber";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int count = Convert.ToInt32(result);
                        return count > 0;
                    }
                    return false;
                }
            }
        }




        public void UpdateImagePathInDatabase(string Username, string imagePath)
        {



            string query = $"UPDATE Admins SET ImagePath = @ImagePath WHERE Username = '{Username}'";



            using (var connection = new MySqlConnection(connectionString))
            {

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ImagePath", imagePath);
                    command.Parameters.AddWithValue("@Username", Username);
                    connection.Open();
                    command.ExecuteNonQuery();
                }





            }

        }

        public void InsertAdmin(string username, string email, string password, string fullName, string imagePath)
        {
            string query = "INSERT INTO Admins (Username, Email, Password, FullName, ImagePath) VALUES (@Username, @Email, @Password, @FullName, @ImagePath)";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password); // Consider hashing the password before storing
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@ImagePath", imagePath);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        public void SaveData(string username, String fullname, String email)
        {
            Debug.WriteLine(username +  " " + fullname + " " + email);
            string query = $"UPDATE Admins SET FullName = '{fullname}', Email = '{email}'  WHERE Username = '{username}'";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    {
                     
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public DataTable PatientTable()
        {
            using (var connection = new MySqlConnection(connectionString)
)
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    // Define your query
                    string query = "SELECT PatientId, FullName, Age, Gender, Address, MedicalCondition, PhoneNumber FROM Patients;";
                    var dataTable = new DataTable();
                    
                    using (var dataAdapter = new MySqlDataAdapter(query, connection))
                    {

                        dataAdapter.Fill(dataTable);

                    }
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return null;
                }
            }

        }

        public string GetPatientIDByPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return "";

            using (MySqlConnection connection = GetConnection()) 
            {
                try
                {
                    connection.Open();
                    string query = "SELECT PatientId FROM Patients WHERE PhoneNumber = @PhoneNumber";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        object result = cmd.ExecuteScalar(); 
                        if (result != null)
                        {
                            string patientID = result.ToString();
                            Debug.WriteLine("PatientID: " + patientID);
                            return patientID;
                        }
                        return ""; 
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                    return "";
                }
            }
        }

        public string GetPatientNameById(string patientId)
        {
            //int id = Int32.Parse(patientId);
            //if (patientId <= 0)
            //    return "";

            using (MySqlConnection connection = GetConnection()) // Assuming GetConnection() returns a MySqlConnection
            {
                try
                {
                    connection.Open();
                    string query = "SELECT FullName FROM Patients WHERE PatientId = @PatientId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientId", patientId);
                        object result = cmd.ExecuteScalar(); // Fetch a single value from the result set

                        if (result != null)
                        {
                            string fullName = result.ToString();
                            Debug.WriteLine("FullName: " + fullName);
                            return fullName;
                        }
                        return ""; // Return empty if no patient found
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occurred: " + ex.Message);
                    return "";
                }
            }
        }

        public DataTable GetPatientAppointmentsByID(string patientId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    A.AppointmentID,
                    D.Name AS DoctorName,
                    A.AppointmentStatus,
                    A.AppointmentTime 
                FROM 
                    Appointments A
                JOIN 
                    Doctors D ON A.DoctorID = D.DoctorId
                WHERE 
                    A.PatientID = @PatientID
                ORDER BY 
                    A.AppointmentTime DESC;";

                    var dataTable = new DataTable();

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", patientId);
                        using (var dataAdapter = new MySqlDataAdapter(command))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return null;
                }
            }
        }

        public bool CancelAppointment(int appointmentId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Appointments SET AppointmentStatus = 'Canceled' WHERE AppointmentID = @AppointmentID";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        return command.ExecuteNonQuery() > 0; // Returns true if the operation was successful
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return false; // Indicate failure
                }
            }
        }




        public int GetPatientAppointmentCount(string patientId, string doctorId, DateTime date)
        {
            string query = @"SELECT COUNT(*) FROM Appointments 
                     WHERE PatientID = @PatientID AND DoctorID = @DoctorID 
                     AND DATE(AppointmentTime) = @Date";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientID", patientId);
                    command.Parameters.AddWithValue("@DoctorID", doctorId);
                    command.Parameters.AddWithValue("@Date", date);

                    connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }


        public Patient GetPatientById(string patientId)
        {
            Patient patient = null;

            string query = "SELECT FullName, Age, Gender, Address, MedicalCondition, PhoneNumber FROM Patients WHERE PatientId = @PatientId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        patient = new Patient
                        {
                            FullName = reader["FullName"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Gender = reader["Gender"].ToString(),
                            Address = reader["Address"].ToString(),
                            MedicalCondition = reader["MedicalCondition"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString()
                        };
                    }
                }
            }

            return patient;
        }


        public void DeleteRowFromDatabasePatient(string patientId)
        {
           
            
            string query = $"DELETE FROM Patients WHERE PatientId = '{patientId}'";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
    
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCellInDatabasePatient(string patientId, string columnName, string newValue)
        {
           
            string query = $"UPDATE Patients SET {columnName} = @NewValue WHERE PatientId = @PatientId";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@PatientId", patientId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



        public DataTable DoctorTable()
        {
            using (var connection = new MySqlConnection(connectionString)
)
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    // Define your query
                    string query = "SELECT DoctorId, Name, Specialty, PhoneNumber FROM Doctors;";
                    var dataTable = new DataTable();

                    using (var dataAdapter = new MySqlDataAdapter(query, connection))
                    {

                        dataAdapter.Fill(dataTable);

                    }
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return null;
                }
            }

        }

        public void DeleteRowFromDatabaseDoctor(string doctorId)
        {
            string query = $"DELETE FROM Doctors WHERE DoctorId = '{doctorId}'";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCellInDatabaseDoctor(string doctorId, string columnName, string newValue)
        {
            string query = $"UPDATE Doctors SET {columnName} = @NewValue WHERE DoctorId = @DoctorId";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@DoctorId", doctorId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public int InsertDoctorAndGetId(string name, string specialty, string phoneNumber)
        {
            int doctorId;
            string query = "INSERT INTO Doctors (Name, Specialty, PhoneNumber) VALUES (@Name, @Specialty, @PhoneNumber); SELECT LAST_INSERT_ID();";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Specialty", specialty);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    Debug.WriteLine("Name: " + name + specialty + phoneNumber);
                    connection.Open();
                    doctorId = Convert.ToInt32(command.ExecuteScalar()); // Fetch the last inserted DoctorId
                }
            }

            return doctorId; // Return the new DoctorId
        }

        public void UpdateDoctorImagePath(int doctorId, string imagePath)
        {
            string query = "UPDATE Doctors SET ImagePath = @ImagePath WHERE DoctorId = @DoctorId";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ImagePath", imagePath);
                    command.Parameters.AddWithValue("@DoctorId", doctorId);

                    connection.Open();
                    command.ExecuteNonQuery(); // Update the image path
                }
            }
        }



        public List<Doctor> GetAllDoctors()
        {
            string query = "SELECT DoctorId, Name, Specialty, ImagePath FROM Doctors";
            List<Doctor> doctors = new List<Doctor>();

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor
                            {
                                DoctorName = reader.GetString("Name"),
                                Specialty = reader.GetString("Specialty"),
                                DoctorImagePath = reader.GetString("ImagePath")
                            };
                            doctors.Add(doctor);
                        }
                    }
                }
            }

            return doctors;
        }


        public string GetDoctorIdByName(string doctorName)
        {
            string query = "SELECT DoctorId FROM Doctors WHERE Name = @DoctorName";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorName", doctorName);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null; // Return as string
                }
            }
        }

         public void SaveAppointment(string patientId, string doctorId, string appointmentStatus, DateTime appointmentTime)
         {
       
                string query = @"INSERT INTO Appointments (PatientID, DoctorID, AppointmentStatus, AppointmentTime) 
                             VALUES (@PatientID, @DoctorID, @AppointmentStatus, @AppointmentTime)";

                        using (var connection = new MySqlConnection(connectionString))
                        {
                            using (var command = new MySqlCommand(query, connection))
                            { command.Parameters.AddWithValue("@PatientID", patientId);
                        command.Parameters.AddWithValue("@DoctorID", doctorId);
                        command.Parameters.AddWithValue("@AppointmentStatus", appointmentStatus);
                        command.Parameters.AddWithValue("@AppointmentTime", appointmentTime);

                        connection.Open();
                        command.ExecuteNonQuery();
               }
           }
          }



        public List<DateTime> GetBookedAppointmentTimes(string doctorId, DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT AppointmentTime 
                     FROM Appointments 
                     WHERE DoctorID = @DoctorID 
                     AND AppointmentTime BETWEEN @StartDate AND @EndDate 
                     AND AppointmentStatus = @Status";

            List<DateTime> bookedTimes = new List<DateTime>();

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    // Add parameters with explicit types for better performance and accuracy
                    command.Parameters.Add("@DoctorID", MySqlDbType.VarChar).Value = doctorId;
                    command.Parameters.Add("@StartDate", MySqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@EndDate", MySqlDbType.DateTime).Value = endDate;
                    command.Parameters.Add("@Status", MySqlDbType.VarChar).Value = "Upcoming"; // Filter only upcoming appointments

                    try
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Read AppointmentTime and normalize to minutes to avoid precision issues
                                DateTime appointmentTime = reader.GetDateTime("AppointmentTime");
                                bookedTimes.Add(appointmentTime);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // You could log the exception here for further debugging
                        Console.WriteLine("Error fetching booked appointment times: " + ex.Message);
                    }
                }
            }

            return bookedTimes;
        }


        public void UpdatePastAppointmentsToDone()
        {
            string query = "UPDATE Appointments SET AppointmentStatus = 'Done' " +
                           "WHERE AppointmentTime < @CurrentTime AND AppointmentStatus = 'Upcoming'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CurrentTime", DateTime.Now); // Current time
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery(); // Executes the query
                Console.WriteLine($"{rowsAffected} appointments updated to 'Done'.");
            }
        }


        public List<AppointmentDetails> GetAllAppointments()
        {
            List<AppointmentDetails> appointments = new List<AppointmentDetails>();
            string query = @"
        SELECT a.AppointmentID, 
               p.FullName AS PatientName, 
               d.Name AS DoctorName, 
               a.AppointmentStatus, 
               a.AppointmentTime 
        FROM Appointments a
        JOIN Patients p ON a.PatientID = p.PatientId
        JOIN Doctors d ON a.DoctorID = d.DoctorId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appointments.Add(new AppointmentDetails
                        {
                            AppointmentID = reader.GetInt32("AppointmentID"),
                            PatientName = reader.GetString("PatientName"),
                            DoctorName = reader.GetString("DoctorName"),
                            AppointmentStatus = reader.GetString("AppointmentStatus"),
                            AppointmentTime = reader.GetDateTime("AppointmentTime")
                        });
                    }
                }
            }
            return appointments;
        }


       
        public DataTable GetAppointments()
        {
            DataTable table = new DataTable();
            table.Columns.Add("AppointmentID", typeof(int));
            table.Columns.Add("PatientName", typeof(string));
            table.Columns.Add("DoctorName", typeof(string));
            table.Columns.Add("AppointmentStatus", typeof(string));
            table.Columns.Add("AppointmentTime", typeof(DateTime));

            string query = @"
                SELECT a.AppointmentID, p.FullName AS PatientName, d.Name AS DoctorName, 
                       a.AppointmentStatus, a.AppointmentTime
                FROM Appointments a
                JOIN Patients p ON a.PatientID = p.PatientId
                JOIN Doctors d ON a.DoctorID = d.DoctorId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            table.Rows.Add(
                                reader["AppointmentID"],
                                reader["PatientName"],
                                reader["DoctorName"],
                                reader["AppointmentStatus"],
                                reader["AppointmentTime"]
                            );
                        }
                    }
                }
            }

            return table;
        }


        public List<string> GetAllSpecialties()
        {
            List<string> specialties = new List<string>();

            string query = "SELECT DISTINCT Specialty FROM Doctors"; // Adjust your SQL query as needed

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            specialties.Add(reader.GetString("Specialty"));
                        }
                    }
                }
            }

            return specialties;
        }


        public List<Doctor> GetDoctorsBySpecialty(string specialty)
        {
            List<Doctor> doctors = new List<Doctor>();

            string query = "SELECT * FROM Doctors WHERE Specialty = @Specialty"; // Adjust your SQL query as needed

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Specialty", specialty);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor
                            {
                                DoctorName = reader.GetString("Name"),
                                Specialty = reader.GetString("Specialty"),
                                DoctorImagePath = reader.GetString("ImagePath")
                            };
                            doctors.Add(doctor);
                        }
                    }
                }
            }

            return doctors;
        }



        public DataTable AdminTable()
        {
            using (var connection = new MySqlConnection(connectionString)
)
            {
                try
                {
                 
                    connection.Open();
                 
                    string query = "SELECT AdminID, FullName, Username, Email FROM Admins;";
                    var dataTable = new DataTable();

                    using (var dataAdapter = new MySqlDataAdapter(query, connection))
                    {

                        dataAdapter.Fill(dataTable);

                    }
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return null;
                }
            }

        }

        public void DeleteRowFromDatabaseAdmin(string AdminID)
        {


            string query = $"DELETE FROM Admins WHERE AdminID = '{AdminID}'";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCellInDatabaseAdmin(string AdminID, string columnName, string newValue)
        {

            string query = $"UPDATE Admins SET {columnName} = @NewValue WHERE  '{AdminID}'";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                 
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<AppointmentInfo> GetUpcomingAppointments(int patientId, int limit = 3)
        {
            string query = @"SELECT a.AppointmentId, d.Name AS DoctorName, d.Specialty, a.AppointmentTime 
                     FROM Appointments a
                     JOIN Doctors d ON a.DoctorId = d.DoctorId
                     WHERE a.PatientId = @PatientId AND a.AppointmentStatus = @Status
                     ORDER BY a.AppointmentTime DESC
                     LIMIT @Limit";

            List<AppointmentInfo> appointments = new List<AppointmentInfo>();

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientId", patientId);
                    command.Parameters.AddWithValue("@Status", "upcoming");
                    command.Parameters.AddWithValue("@Limit", limit);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new AppointmentInfo
                            {
                                AppointmentId = reader.GetInt32("AppointmentId"),
                                DoctorName = reader.GetString("DoctorName"),
                                Specialty = reader.GetString("Specialty"),
                                AppointmentTime = reader.GetDateTime("AppointmentTime")
                            });
                        }
                    }
                }
            }

            return appointments;
        }



        public string GetDoctorImagePath(string doctorName)
        {
            string query = "SELECT ImagePath FROM Doctors WHERE Name = @DoctorName";

            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorName", doctorName);

                    connection.Open();
                    var result = command.ExecuteScalar(); // Use ExecuteScalar for single value

                    if (result != null)
                    {
                        return result.ToString(); // Return the image path as a string
                    }
                }
            }

            return null; // Return null if no image path is found
        }






    }
}

