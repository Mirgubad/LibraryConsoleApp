using System;
using static Library.Helpers;
namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            Library library = new();
            while (exit)
            {
            Menu:
                Menu();
                string chooseMenuOption = Console.ReadLine();
                switch (chooseMenuOption)
                {
                    case "1":
                        #region AddEmployee
                        PrintColor($"<<You are adding new employee...>>", ConsoleColor.DarkGreen);
                        Employees employee = new();
                    nameistrue:
                        PrintColor($"<<Enter name>>", ConsoleColor.Green);
                        employee.Name = Console.ReadLine();
                        bool nameistrue = string.IsNullOrWhiteSpace(employee.Name);
                        if (nameistrue)
                        {
                            PrintColor($"<<Please fill the name!!!>>", ConsoleColor.DarkRed);
                            goto nameistrue;
                        }
                    surnameisTrue:
                        PrintColor($"<<Enter Surname>>", ConsoleColor.Green);
                        employee.SurName = Console.ReadLine();
                        bool surnameisTrue = string.IsNullOrWhiteSpace(employee.SurName);
                        if (surnameisTrue)
                        {
                            PrintColor($"<<Please fill the surname!!!>>", ConsoleColor.DarkRed);
                            goto surnameisTrue;
                        }
                    empageisTrue:
                        PrintColor($"<<Enter Age>>", ConsoleColor.Green);
                        string empAge = Console.ReadLine();
                        bool empageisTrue = int.TryParse(empAge, out int empages);
                        employee.Age = empages;
                        if (!empageisTrue|| empages<18 ||empages>50)
                        {
                            PrintColor($"<<Input was incorrect!!!>>", ConsoleColor.DarkRed);
                            goto empageisTrue;
                        }
                    experience:
                        PrintColor($"<<Enter experience>>", ConsoleColor.Green);
                        string experienceemp = Console.ReadLine();
                        bool experienceisTrue = int.TryParse(experienceemp, out int empexp);
                        employee.Experience = empexp;
                        if (!experienceisTrue || empexp <= 0)
                        {
                            PrintColor($"<<Input was incorrect!!!>>", ConsoleColor.DarkRed);
                            goto experience;
                        }
                        library.employees.Add(employee);
                        PrintColor($"<<Employye is added successfully...>>", ConsoleColor.Green);
                        break;
                    #endregion
                    case "2":
                        #region AddAuthor 
                        PrintColor($"You are adding new author...", ConsoleColor.Green);
                        Author author = new();
                    nameisTrue:
                        PrintColor($"<<Author name is>>", ConsoleColor.Green);
                        author.Name = Console.ReadLine();
                        bool nameisTrue = string.IsNullOrWhiteSpace(author.Name);
                        if (nameisTrue)
                        {
                            PrintColor($"<<Please fill the name!!!>>", ConsoleColor.DarkRed);
                            goto nameisTrue;
                        }
                    authorsurnameisTrue:
                        PrintColor($"<<Author surname is>>", ConsoleColor.Green);
                        author.SurName = Console.ReadLine();
                        bool authorsurnameisTrue = string.IsNullOrWhiteSpace(author.SurName);
                        if (authorsurnameisTrue)
                        {
                            PrintColor($"<<Please fill the surname!!!>>", ConsoleColor.DarkRed);
                            goto authorsurnameisTrue;
                        }
                        library.authors.Add(author);
                        PrintColor($"<<{author.Name} successfully added...>>", ConsoleColor.Green);
                        break;
                    #endregion 
                    case "3":
                        #region AddBook
                        if (library.authors.Count == 0)
                        {
                            PrintColor($"<<Author list is empty!!!>>", ConsoleColor.DarkRed);
                            goto Menu;
                        }
                        PrintColor($"<<You are adding new book...>>", ConsoleColor.DarkGreen);
                        Books book = new();
                    booknameIsTrue:
                        PrintColor($"<<Enter book name>>", ConsoleColor.Green);
                        book.Name = Console.ReadLine();
                        bool booknameIsTrue = string.IsNullOrWhiteSpace(book.Name);
                        if (booknameIsTrue)
                        {
                            PrintColor($"<<Please fill the name!!!>>", ConsoleColor.DarkRed);
                            goto booknameIsTrue;
                        }
                    formatIsTrue:
                        PrintColor($"<<Enter Book format>>", ConsoleColor.Green);
                        book.Format = Console.ReadLine();
                        bool formatIsTrue = string.IsNullOrWhiteSpace(book.Format);
                        if (formatIsTrue)
                        {
                            PrintColor($"<<Please fill the format!!!>>", ConsoleColor.DarkRed);
                            goto formatIsTrue;
                        }
                    year:
                        PrintColor($"<<Enter Release Year>>", ConsoleColor.Green);
                        string relYear = Console.ReadLine();
                        bool ryearisTrue = int.TryParse(relYear, out int year);
                        book.ReleaseYear = year;
                        if (!ryearisTrue|| year>2022|| year<1000)
                        {
                            PrintColor("<<Relese year was incorrect format!!!>>", ConsoleColor.DarkRed);
                            goto year;
                        }
                        PrintColor($"<<Authors list>>", ConsoleColor.Green);
                        foreach (var item in library.authors)
                        {
                            PrintColor($"<<Full name is {item.Name} {item.SurName}>> <<Id is {item.AuthorId}>>", ConsoleColor.DarkCyan);

                        }                                         
                        authorid:
                        PrintColor($"<<Choose authors with id,You can choose 1 more >>", ConsoleColor.Green);
                       
                        string chooseauthor = Console.ReadLine();
                        string[] authorid2 = chooseauthor.Split(",");
                        foreach (var item in authorid2)
                        {
                            bool isAuthorId = int.TryParse(item, out int AuthorId2);
                            if (!isAuthorId)
                            {
                                PrintColor($"<<Incorrect Id!!!>>", ConsoleColor.DarkRed);
                                goto authorid;
                            }
                            foreach (var item1 in library.authors)
                            {
                                if (item1.AuthorId == AuthorId2)
                                {
                                    book.authors.Add(item1);

                                    item1.authorbooks.Add(book);
                                }
                            }
                        }
                        library.books.Add(book);
                        PrintColor($"<<{book.Name} has added Successfully...>>", ConsoleColor.Green);
                        break;
                    #endregion
                    case "4":
                        #region RemoveEmployee
                        if (library.employees.Count == 0)
                        {
                            PrintColor($"<<Employee List is empty!!!>>", ConsoleColor.DarkRed);
                            goto Menu;
                        }
                        PrintColor($"<<You are removing employee...>>", ConsoleColor.DarkRed);
                        PrintColor($"<<Employee List:>>", ConsoleColor.DarkCyan);
                        foreach (var item in library.employees)
                        {
                            PrintColor($"<<Full Name is {item.Name} {item.SurName}>> <<Work experience is {item.Experience}>> <<Age is {item.Age}>> <<Id is {item.EId}>>", ConsoleColor.Green);
                        }
                    remID:
                        PrintColor($"<<Remove Employee (with Id)>>", ConsoleColor.DarkRed);
                        string rememployee = Console.ReadLine();
                        bool IsId = int.TryParse(rememployee, out int removeid);
                        if (!IsId)
                        {
                            PrintColor($"<<Id was incorrect!!!>>", ConsoleColor.DarkRed);
                            goto remID;
                        }
                        foreach (var item in library.employees)
                        {
                            if (item.EId == removeid)
                            {
                                PrintColor($"<<Are you sure? yes/no>>", ConsoleColor.DarkRed);
                                string ask = Console.ReadLine();
                                if (ask == "yes")
                                {
                                    library.employees.Remove(item);
                                    PrintColor($"<<Employee has removed...>>", ConsoleColor.DarkRed);
                                    goto Menu;
                                }
                                else
                                {
                                    goto Menu;
                                }
                            }
                        }
                        PrintColor($"<<Id wasn't matchable!!!>>", ConsoleColor.DarkRed);
                        goto remID;
                    #endregion
                    case "5":
                        #region RemoveBook
                        if (library.books.Count == 0)
                        {
                            PrintColor($"<<Book List is empty!!!>>", ConsoleColor.DarkRed);
                            goto Menu;
                        }
                        PrintColor($"<<You are removing book...>>", ConsoleColor.DarkRed);
                        PrintColor($"<<Book List:>>", ConsoleColor.DarkCyan);
                        foreach (var item in library.books)
                        {
                            foreach (var item1 in library.books)
                            {  PrintColor($"<<Name is {item.Name}>> <<Release year is {item.ReleaseYear}>> <<Id is {item.BId}>>", ConsoleColor.DarkCyan);
                                Console.WriteLine();
                            }
                          
                        }
                    bId:
                        PrintColor($"<<Remove Book (with Id)>>", ConsoleColor.DarkRed);
                        string bookId = Console.ReadLine();
                        bool bId = int.TryParse(bookId, out int idbook);
                        if (!bId)
                        {
                            PrintColor($"<<Id was incorrect!!!>>", ConsoleColor.DarkRed);
                            goto bId;
                        }
                        foreach (var item in library.books)
                        {
                            if (idbook == item.BId)
                            {
                                PrintColor($"<<Are you sure? yes/no>>", ConsoleColor.DarkRed);
                                string askreturn = Console.ReadLine();
                                if (askreturn == "yes")
                                {
                                    library.books.Remove(item);
                                    PrintColor($"<<Book has removed successfully...>>", ConsoleColor.DarkRed);
                                    goto Menu;
                                }
                                else
                                {
                                    goto Menu;
                                }
                            }
                        }
                        PrintColor($"<<Id wasn't matchable!!!>>", ConsoleColor.DarkRed);
                        goto bId;
                    #endregion
                    case "6":
                        #region Exit
                        PrintColor($"<<Would yo like to exit? yes/no>>", ConsoleColor.Green);
                        string exitask = Console.ReadLine();
                        if (exitask == "yes")
                        {
                          exit = false;
                            PrintColor($"<<Thank you for using our service  >>", ConsoleColor.Green);
                            HeartPrint();
                        }
                        else
                        {                           
                            goto Menu;
                        }                      
                        break;
                        #endregion
                }
            }
        }
    }
}
