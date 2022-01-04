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
        public static string CitizenRegisterSuccess = "Citizen registered successfully.";
        public static string CitizenRegisterFail = "Citizen registered failed!";
        public static string ComplaintSuccess = "Complaint success.";
        public static string ComplaintError = "Complaint error.";
        public static string ComplaintTypesGet = "Successful complaint type retrival";
        public static string ComplaintTypeCreated = "Successfully new complaint type added.";
        public static string AuthorizationGetSuccess = "Sucessful authorization retrival";
        public static string AuthorizationGetFail = "Failed authorization retrival";
        public static string AuthorizationAddFail = "Failed new authorization";
        public static string AuthorizationAddSuccess = "Successful new authorization";
        public static string StaffGetFail = "Failed staff retrival";
        public static string StaffGetSuccess = "Sucessed staff retrival";
        public static string StaffAuthenticationCrash = "Staff authentication info crash";
        public static string StaffAuthenticationSuccess = "Staff authentication info success";
    }
}
