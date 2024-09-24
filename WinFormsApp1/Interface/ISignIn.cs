using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interface
{
    internal interface ISignIn
    {
        public interface ISignIn
        {
            void HandlePatientLogin(string phone, string password);
            void HandleAdminLogin(string phone, string password);
            bool ValidateInput(string phone, string password);
            void FormClosingEvent();
        }

    }
}
