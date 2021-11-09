using _24._09._11._2021_home_task.CRUD;
using _24._09._11._2021_home_task.TicketClasses;
using System;

namespace _24._09._11._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Genre genre = new Genre
            //{
            //    Id = 1,
            //    Name = "Sci-Fi"
            //};

            //Movie movie = new Movie
            //{
            //    Id = 1,
            //    Name = "Transformers",
            //    Duration = 45,
            //    Genre = genre,
            //    Poster = "Poster!"
            //};

            //Ticket ticket = new Ticket
            //{
            //    Id = 1,
            //    Movie = movie,
            //    Price = 14.75,
            //    Date = new DateTime(),
            //    SellDate = new DateTime(),
            //    Time = new TimeSpan(),
            //};

            //Console.WriteLine($"Ticket Id: {ticket.Id}");
            //Console.WriteLine($"Ticket Movie Id: {ticket.Movie.Id}");
            //Console.WriteLine($"Ticket Movie Name: {ticket.Movie.Name}");
            //Console.WriteLine($"Ticket Movie Genre Id: {ticket.Movie.Genre.Id}");
            //Console.WriteLine($"Ticket Movie Genre Name: {ticket.Movie.Genre.Name}");
            //Console.WriteLine($"Ticket Movie Poster: {ticket.Movie.Poster}");
            //Console.WriteLine($"Ticket Movie Duration: {ticket.Movie.Duration}");
            //Console.WriteLine($"Ticket Price: {ticket.Price}");
            //Console.WriteLine($"Ticket Date: {ticket.Date}");
            //Console.WriteLine($"Ticket SellDate: {ticket.SellDate}");
            //Console.WriteLine($"Ticket Time: {ticket.Time}");
            #endregion

            #region Task 2
            byte choise = 255;
            int depEmpCount;
            string depName;

            DepartmentService depService = new DepartmentService();

            Console.WriteLine("Welcome to Department Information System.\n");

            do
            {
                Console.WriteLine("------ Actions ------\n");
                Console.WriteLine("1. Create department");
                Console.WriteLine("2. Update department");
                Console.WriteLine("3. Delete department");
                Console.WriteLine("4. Read department");
                Console.WriteLine("5. Find department");
                Console.WriteLine("0. Exit\n");
                Console.Write("Choose action: ");

                choise = Convert.ToByte(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("\nEnter department info:\n");

                        Console.Write("Name: ");
                        depName = Console.ReadLine();

                        Console.Write("Employee Count: ");
                        depEmpCount = Convert.ToInt32(Console.ReadLine());

                        depService.Create(new Department
                        {
                            Name = depName,
                            EmployeeCount = depEmpCount
                        });

                        Console.Write("\nDepartment created successfully!\n\n");

                        break;
                    case 2:
                        Console.WriteLine("\nChoose department you want to edit:\n");

                        foreach (var item in depService.Read())
                        {
                            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, EmployeeCount: {item.EmployeeCount}");
                        }

                        Console.WriteLine("\nUpdate department info:\n");

                        Console.Write("Name: ");
                        depName = Console.ReadLine();

                        Console.Write("Employee Count: ");
                        depEmpCount = Convert.ToInt32(Console.ReadLine());

                        depService.Create(new Department
                        {
                            Name = depName,
                            EmployeeCount = depEmpCount
                        });

                        Console.Write("\nDepartment created successfully!\n\n");
                        break;
                    case 3:
                        Console.WriteLine("Delete");
                        break;
                    case 4:
                        Console.WriteLine("Read");
                        break;
                    case 5:
                        Console.WriteLine("Find");
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Default");
                        break;
                }
            } while (choise != 0);
            #endregion
        }
    }
}
