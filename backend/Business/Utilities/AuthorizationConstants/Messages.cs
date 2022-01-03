using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.AuthorizationConstants
{
    public static class Messages
    {
        public static string PasswordIncorrect = "Incorrect password.";
        public static string PasswordCorrect = "Successful login.";
        public static string NotFoundCitizen = "Citizen not found.";
        public static string FoundCitizen = "Citizen found.";
        public static string ComplaintSuccess = "Complaint success.";
        public static string ComplaintError = "Complaint error.";
        public static string ComplaintTypesGet = "Successful complaint type retrival";
        public static string ComplaintTypeCreated = "Successfully new complaint type added.";
    }
}
