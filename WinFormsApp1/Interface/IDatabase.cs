using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Adminpanel;
using WinFormsApp1.Patients;

namespace WinFormsApp1.Interface
{
    internal interface IDatabase
    {
        bool AuthenticateUser(string username, string password);
        bool AuthenticateAdmin(string username, string password);
        string AdminName(string username);
        string AdminPicture(string username);
        string AdminEmail(string username);
        string AdminID(string username);
        void SaveData(string fullName, int age, string gender, string address, string medicalCondition, string phoneNumber, string encryptedPassword);
        bool PhoneNumberExists(string phoneNumber);
        void UpdateImagePathInDatabase(string username, string imagePath);
        void InsertAdmin(string username, string email, string password, string fullName, string imagePath);
        void SaveData(string username, string fullname, string email);
        DataTable PatientTable();
        string GetPatientIDByPhone(string phone);
        string GetPatientNameById(string patientId);
        DataTable GetPatientAppointmentsByID(string patientId);
        bool CancelAppointment(int appointmentId);

        int GetPatientAppointmentCount(string patientId, string doctorId, DateTime date);
        Patient GetPatientById(string patientId);
        void DeleteRowFromDatabasePatient(string patientId);
        void UpdateCellInDatabasePatient(string patientId, string columnName, string newValue);
        DataTable DoctorTable();
        void DeleteRowFromDatabaseDoctor(string doctorId);
        void UpdateCellInDatabaseDoctor(string doctorId, string columnName, string newValue);
        int InsertDoctorAndGetId(string name, string specialty, string phoneNumber);
        void UpdateDoctorImagePath(int doctorId, string imagePath);
        List<Doctor> GetAllDoctors();
        string GetDoctorIdByName(string doctorName);
        void SaveAppointment(string patientId, string doctorId, string appointmentStatus, DateTime appointmentTime);
        List<DateTime> GetBookedAppointmentTimes(string doctorId, DateTime startDate, DateTime endDate);
        void UpdatePastAppointmentsToDone();
        List<AppointmentDetails> GetAllAppointments();
        DataTable GetAppointments();
        List<string> GetAllSpecialties();
        List<Doctor> GetDoctorsBySpecialty(string specialty);
        DataTable AdminTable();
        void DeleteRowFromDatabaseAdmin(string adminId);
        void UpdateCellInDatabaseAdmin(string adminId, string columnName, string newValue);
        List<AppointmentInfo> GetUpcomingAppointments(int patientId, int limit = 3);
        string GetDoctorImagePath(string doctorName);
    }
}
