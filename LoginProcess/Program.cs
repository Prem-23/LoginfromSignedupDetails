using System;

namespace LoginProcess
{
    public class Program
    {
        public void adminLogins()
        {
            string name = "Admin";
            string pin = "admin@12";
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string passCode = Console.ReadLine();

            if ((username == name) && (passCode == pin))
            {
                Console.WriteLine("Welcome " + name + " !");
                Console.WriteLine("\n1.View Profile \n2.Logout");
                Console.Write("Enter your Choice: ");
                int num1 = Convert.ToInt16(Console.ReadLine());
                switch (num1)
                {
                    case 1:
                        Console.WriteLine("\nWelcome Administator!\n");
                        Console.WriteLine("Your Administator's ID: " + name);
                        Console.WriteLine("Your Password: " + pin);
                        break;
                    case 2:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
        }

        void newSignIn()
        {
            Console.Write("Full Name: ");
            string fullname = Console.ReadLine();
            Console.Write("Permanent Address: ");
            string address = Console.ReadLine();
            Console.Write("Mail Id: ");
            string mailId = Console.ReadLine();
            Console.Write("UserName: ");
            string nameOfUser = Console.ReadLine();
            Console.Write("Password: ");
            string PasswordOfNewUser = Console.ReadLine();
            Console.WriteLine("\n1.Login \n2.exit");
            Console.Write("Enter Your Choice: ");
            int num = Convert.ToInt16(Console.ReadLine());
            if(num == 1)
            {
                Console.Write("Username: ");
                string name1 = Console.ReadLine();
                Console.Write("Password: ");
                string pin1 = Console.ReadLine();
                if (name1 == nameOfUser && pin1 == PasswordOfNewUser)
                {
                    Console.WriteLine("Welcome " +fullname+ " !");
                    back:
                    Console.WriteLine("\n1.View Profile \n2.Operations \n3.Logout");
                    Console.Write("Enter your Choice: ");
                    int num2 = Convert.ToInt16(Console.ReadLine());
                    switch (num2)
                    {
                        case 1:
                            Console.WriteLine("Welcome " +fullname+ " !" \n);
                            Console.WriteLine("Your Name: " + fullname);
                            Console.WriteLine("Your Address: " + address);
                            Console.WriteLine("Your Mail ID: " + mailId);
                            Console.WriteLine("Your Username: " + nameOfUser);
                            Console.WriteLine("Your Password: " + PasswordOfNewUser);
                            Console.WriteLine("\n1.Go Back \n2.exit");
                            Console.Write("Enter your Choice: ");
                            int num14 = Convert.ToInt16(Console.ReadLine());
                            if(num14 == 1)
                            {
                                goto back;
                            }
                            else
                            {
                                System.Environment.Exit(0);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Which Operations you want to perform?");
                            Console.WriteLine("\n1.Addition \n2.Subtraction \n3.Multiplications \n4.Division \n5.Modulos \n6.Exit Operation \n7.Close Window");
                            int num3 = Convert.ToInt16(Console.ReadLine());
                            if(num3 == 1)
                            {
                                Console.Write("a = ");
                                int num4 = Convert.ToInt16(Console.ReadLine());
                                Console.Write("b = ");
                                int num5 = Convert.ToInt16(Console.ReadLine());
                                int c = num4 + num5;
                                Console.WriteLine("Answer: " + c);
                                Console.WriteLine("\n1.Go Back \n2.exit");
                                Console.Write("Enter your Choice: ");
                                int num15 = Convert.ToInt16(Console.ReadLine());
                                if (num15 == 1)
                                {
                                    goto back;
                                }
                                else
                                {
                                    System.Environment.Exit(0);
                                }
                            }
                            else if (num3 == 2)
                            {
                                Console.Write("a = ");
                                int num6 = Convert.ToInt16(Console.ReadLine());
                                Console.Write("b = ");
                                int num7 = Convert.ToInt16(Console.ReadLine());
                                int d = num6 - num7;
                                Console.WriteLine("Answer: " + d);
                                Console.WriteLine("\n1.Go Back \n2.exit");
                                Console.Write("Enter your Choice: ");
                                int num16 = Convert.ToInt16(Console.ReadLine());
                                if (num16 == 1)
                                {
                                    goto back;
                                }
                                else
                                {
                                    System.Environment.Exit(0);
                                }
                            }
                            else if (num3 == 3)
                            {
                                Console.Write("a = ");
                                int num8 = Convert.ToInt16(Console.ReadLine());
                                Console.Write("b = ");
                                int num9 = Convert.ToInt16(Console.ReadLine());
                                int e = num8 * num9;
                                Console.WriteLine("Answer: " + e);
                                Console.WriteLine("\n1.Go Back \n2.exit");
                                Console.Write("Enter your Choice: ");
                                int num17 = Convert.ToInt16(Console.ReadLine());
                                if (num17 == 1)
                                {
                                    goto back;
                                }
                                else
                                {
                                    System.Environment.Exit(0);
                                }
                            }
                            else if (num3 == 4)
                            {
                                Console.Write("a = ");
                                int num10 = Convert.ToInt16(Console.ReadLine());
                                Console.Write("b = ");
                                int num11 = Convert.ToInt16(Console.ReadLine());
                                int f = num10 / num11;
                                Console.WriteLine("Answer: " + f);
                                Console.WriteLine("\n1.Go Back \n2.exit");
                                Console.Write("Enter your Choice: ");
                                int num18 = Convert.ToInt16(Console.ReadLine());
                                if (num18 == 1)
                                {
                                    goto back;
                                }
                                else
                                {
                                    System.Environment.Exit(0);
                                }
                            }
                            else if (num3 == 5)
                            {
                                Console.Write("a = ");
                                int num12 = Convert.ToInt16(Console.ReadLine());
                                Console.Write("b = ");
                                int num13 = Convert.ToInt16(Console.ReadLine());
                                int g = num12 % num13;
                                Console.WriteLine("Answer: " + g);
                                Console.WriteLine("\n1.Go Back \n2.exit");
                                Console.Write("Enter your Choice: ");
                                int num19 = Convert.ToInt16(Console.ReadLine());
                                if (num19 == 1)
                                {
                                    goto back;
                                }
                                else
                                {
                                    System.Environment.Exit(0);
                                }
                            }
                            else if(num3 == 6)
                            {
                                goto back;
                            }
                            else
                            {
                                System.Environment.Exit(0);
                            }
                            break;
                        case 3:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid User");
                }
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            Program ad = new Program();
            Console.WriteLine("\n1.Login \n2.Signup");
            Console.Write("Enter your Choice: ");
            int n = Convert.ToInt16(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("\n1.Admin \n2.User");
                    Console.Write("Enter your Choice: ");
                    int n1 = Convert.ToInt16(Console.ReadLine());
                    switch (n1)
                    {
                        case 1:
                            ad.adminLogins();
                            break;
                        case 2:
                            Console.WriteLine("\nYou didn't Sign up yet, Please Sign up \n");
                            ad.newSignIn();
                            break;
                    }
                    break;
                case 2:
                    ad.newSignIn();
                    break;
            }

            Console.ReadLine();
        }
        
    }
}
