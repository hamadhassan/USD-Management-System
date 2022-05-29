using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class Credential
    {
        private string firstName;
        private string lastName;
        private string username;
        private string password;
        private string role;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public Credential()
        {
            firstName = "student";
            lastName = "student";
            username = "student";
            password = "student";
            role = "Student";
        }
        public Credential(string firstName, string lastName, string username, string password, string role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public bool checkUser(string role, string username, string password, List<Credential> crediationalsList)
        {
            foreach (Credential c in crediationalsList)
            {
                if (c.username == username && c.password == password && c.role == role)
                {
                    return true;
                }
            }
            return false;
        }
        public string checkRole(string role, string username, string password, List<Credential> crediationalsList)
        {
            foreach (Credential c in crediationalsList)
            {
                if (c.username == username && c.password == password && c.role == role)
                {
                    if(c.role == "Student")
                    {
                        return "Student";
                    }
                    else 
                    {
                        return "Parent";
                    }
                }
            }
            return null;
        }
        
      
    }
}
