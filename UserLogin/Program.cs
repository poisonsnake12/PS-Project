﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class Program
    {
        public delegate void ActionOnError(string errorMsg);

        public static void ErrorMsg(string error)
        {
            Console.WriteLine("Warning: " + error + "!");
        }

        public static void AdminMenu()
        {
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Change user role");
            Console.WriteLine("2: Change account validity");
            Console.WriteLine("3: Output list of users ");
            Console.WriteLine("4: Show log ");
            Console.WriteLine("5: Show current activity ");


            string tempUser;
            while(true)
            {
                Console.WriteLine("Choose Option:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        return;

                    case 1:
                        Console.WriteLine("Enter user's name to change role of:");
                        tempUser = Console.ReadLine();

                        Console.WriteLine("Enter role to change user to:");
                        int tempRole = Convert.ToInt32(Console.ReadLine());

                        UserData.AssignUserRole(tempUser, (UserRoles)tempRole);
                       break;

                    case 2:
                        Console.WriteLine("Enter user to change active date of:");
                        tempUser = Console.ReadLine();

                        Console.WriteLine("Enter date to change user activity to:");
                        DateTime tempDate = Convert.ToDateTime(Console.ReadLine());

                        UserData.SetUserActiveTo(tempUser, tempDate);
                       break;

                    case 3:
                        Console.WriteLine("List of users: ");
                       break;

                    case 4:
                        IEnumerable<string> logActivity = Logger.GetLogActivities();

                        StringBuilder inputStream = new StringBuilder();

                        foreach (string activity in logActivity)
                        {
                            inputStream.Append(activity + Environment.NewLine);
                        }
                        Console.WriteLine(inputStream.ToString());
                       break;

                    case 5:
                        Console.WriteLine("Enter Filter:");
                        string filter = Console.ReadLine();
                        
                        StringBuilder sb = new StringBuilder();

                        IEnumerable<string> logActivities = Logger.GetCurrentActivities(filter);

                        foreach (string activity in logActivities)
                        {
                            sb.Append(activity + Environment.NewLine);
                        }
                        Console.WriteLine(sb.ToString());
                       break;

                    default:
                        Console.WriteLine("Wrong Input");
                       break;
                }
            }
        }
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Enter username:");
            user.username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            user.password = Console.ReadLine();

            LoginValidation loginValidation = new LoginValidation(user.username, user.password, ErrorMsg);
            List<User> test = UserData.TestUsers;
            if(loginValidation.ValidateUserInput(ref user))
            {
                Console.WriteLine(user.username);
                Console.WriteLine(user.password);
                Console.WriteLine(user.facultyNumber);
                Console.WriteLine(user.userRole);
                switch(user.userRole)
                {
                    case 0:
                        Console.WriteLine("Your role is: {0}", LoginValidation.currentUserRole);
                        break;
                    case 1:
                        Console.WriteLine("Your role is: {0}", LoginValidation.currentUserRole);
                        AdminMenu();
                        break;
                    case 2:
                        Console.WriteLine("Your role is: {0}", LoginValidation.currentUserRole);
                        break;
                    case 3:
                        Console.WriteLine("Your role is: {0}", LoginValidation.currentUserRole);
                        break;
                    case 4:
                        Console.WriteLine("Your role is: {0}", LoginValidation.currentUserRole);
                        break;
                }
            }
        }
    }
}