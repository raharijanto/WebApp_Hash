using API.Context;
using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class AccountRepository
    {
        MyContext myContext;

        public AccountRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public ResponseLogin Login(Login login)
        {
            var dataLogin = myContext.UserRole
                .Include(x => x.Role)
                .Include(x => x.User)
                .Include(x => x.User.Employees)
                .FirstOrDefault(x =>
                    x.User.Employees.EmployeeEmail.Equals(login.Email) && 
                    x.User.UserPassword.Equals(login.Password));

            if (dataLogin != null)
            {
                ResponseLogin responseLogin = new ResponseLogin()
                {
                    Id = dataLogin.User.UserId,
                    FullName = dataLogin.User.Employees.EmployeeName,
                    Email = dataLogin.User.Employees.EmployeeEmail,
                    Role = dataLogin.Role.RoleName
                };
                return responseLogin;
            }

            return null;
        }

        [HttpPost]
        public int Register(Register register)
        {
            string passwordHash = Hashing.HashPassword(register.Password);
            Employees employees = new Employees();
            employees.EmployeeName = register.FullName;
            employees.EmployeeEmail = register.Email;

            User user = new User();
            user.Employees = employees;
            user.UserPassword = passwordHash;
            myContext.Add(user);
            myContext.SaveChanges();

            UserRole userRole = new UserRole();
            userRole.URUserId = user.UserId;
            userRole.URRoleId = 2;
            myContext.Add(userRole);
            var result = myContext.SaveChanges();
            return result;
        }

        public class Hashing
        {
            private static string GetRandomSalt()
            {
                return BCrypt.Net.BCrypt.GenerateSalt(12);
            }

            public static string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
            }

            public static bool ValidatePassword(string password, string correctHash)
            {
                return BCrypt.Net.BCrypt.Verify(password, correctHash);
            }
        }
    }
}
