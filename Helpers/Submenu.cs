using System;
using demo_1.Services;

namespace demo_1.Helpers
{
    public class Submenu
    {
        public static void StudentSubMenu()
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Show students");
                Console.WriteLine("2. Add student");
                Console.WriteLine("3. Update student");
                Console.WriteLine("4. Remove student");
                Console.WriteLine("5. Find students by name");
                Console.WriteLine("6. Find students by bday ranges");
                Console.WriteLine("0. Go back");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");


                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

                switch (option)
                {
                    case 1:
                        MenuService.MenuShowStudents();
                        break;
                    case 2:
                        MenuService.MenuAddStudent();
                        break;
                    case 3:
                        MenuService.MenuUpdateStudent();
                        break;
                    case 4:
                        MenuService.MenuRemoveStudent();
                        break;
                    case 5:
                        MenuService.MenuFindStudentsByName();
                        break;
                    case 6:
                        MenuService.MenuSearchStudentsByBday();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            } while (option != 0);
        }

        public static void TeacherSubMenu()
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Show teachers");
                Console.WriteLine("2. Add teacher");
                Console.WriteLine("3. Update teacher");
                Console.WriteLine("4. Remove teacher");
                Console.WriteLine("5. Find teachers by name");
                Console.WriteLine("6. Find teachers by bday ranges");
                Console.WriteLine("0. Go back");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");


                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

                switch (option)
                {
                    case 1:
                        MenuService.MenuShowTeachers();
                        break;
                    case 2:
                        MenuService.MenuAddTeacher();
                        break;
                    case 3:
                        MenuService.MenuUpdateTeacher();
                        break;
                    case 4:
                        MenuService.MenuRemoveTeacher();
                        break;
                    case 5:
                        MenuService.MenuFindTeachersByName();
                        break;
                    case 6:
                        MenuService.MenuSearchTeachersByBday();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            } while (option != 0);
        }
    }
}
