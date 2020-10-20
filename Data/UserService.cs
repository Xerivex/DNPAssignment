using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text.Json;
using System.Threading.Tasks;
using DNPAssignment.Models;

namespace DNPAssignment.Data {
    public class UserService : IUserService {
        private string loginFile = "login.json";

        private List<User> users;

        public UserService() {
            if (!File.Exists(loginFile)) {
                Seed();
                WriteUsersToFile();
            }
            else {
                string userC = File.ReadAllText(loginFile);
                users = JsonSerializer.Deserialize<List<User>>(userC);
            }
        }

        public void registerUser(string username, string password) {
            User newUser = new User();
            newUser.UserName = username;
            newUser.Password = password;
            newUser.Role = "user";
            newUser.SecurityLevel = 1;
            users.Add(newUser);
            WriteUsersToFile();
        }

        public User validateUser(string userName, string password) {
            User user = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (user == null) {
                throw new Exception("User does not exist");
            }
            if (!user.Password.Equals(password)) {
                throw new Exception("Incorrect Password");
            }

            return user;
        }

        public void WriteUsersToFile() {
            string jsonConvert = JsonSerializer.Serialize(users);
            File.WriteAllText(loginFile, jsonConvert);
        }

        public void Seed() {
            User[] uL = {
                new User {
                    UserName = "Admin",
                    BirthYear = 1998,
                    Role = "Administrator",
                    SecurityLevel = 1,
                    Password = "admin"
                }
            };
            users = uL.ToList();
        }
    }
}
