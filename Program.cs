﻿namespace Assignment2
{
    internal class FavoriteMovie
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();
        static Dictionary<string, string> admins = new Dictionary<string, string>();
        static Dictionary<string, string> movieCollection = new Dictionary<string, string>();
        static Dictionary<string, string> favorites = new Dictionary<string, string>();

        static bool isLoggedIn = false;
        static bool isAdmin = false;
        static bool isUser = false;

        static void Main(string[] args)
        {

            users.Add("user", "User@123");
            admins.Add("Admin", "Admin@123");
            Console.WriteLine("Welcome to the Fevorate Movie App!");

            string currentUser = "";

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your username: ");
                        string username1 = Console.ReadLine();
                        string username = username1.ToLower();
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();



                        if (admins.ContainsKey(username) && admins[username] == password)
                        {
                            isLoggedIn = true;
                            isAdmin = true;
                            currentUser = username;
                            Console.WriteLine("\nAdmin login successful!");
                        }
                        else if (users.ContainsKey(username) && users[username] == password)
                        {
                            isLoggedIn = true;
                            isUser = true;
                            currentUser = username;
                            Console.WriteLine("\nUser login successful!");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid username or password. Please try again.");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Exiting the Movie App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (isLoggedIn)
                {
                    if (isAdmin)
                    {
                        Admin();
                    }
                    else if (isUser)
                    {
                        User();
                    }
                }
            }
        }


        static void Admin()
        {
            while (true)
            {
                Console.WriteLine("\nAdmin Menu:");
                Console.WriteLine("1. Show movie list");
                Console.WriteLine("2. Add movie to collection");
                Console.WriteLine("3. Remove movie from collection");
                Console.WriteLine("4. Logout");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        foreach (KeyValuePair<string, string> i in movieCollection)
                        {
                            Console.WriteLine(i.Key);
                        }
                        break;
                    case 2:
                        Console.Write("Enter the name of the movie to add: ");
                        string movie = Console.ReadLine();
                        Console.Write("Enter the description of the movie: ");
                        string description = Console.ReadLine();
                        movieCollection.Add(movie, description);
                        Console.WriteLine($"Movie '{movie}' added to the collection.");
                        break;
                    case 3:
                        Console.WriteLine("Movies List");
                        foreach (KeyValuePair<string, string> i in movieCollection)
                        {
                            Console.WriteLine(i.Key);
                        }

                        Console.Write("Enter the name of the movie to remove: ");
                        string movieToRemove = Console.ReadLine();
                        if (movieCollection.ContainsKey(movieToRemove))
                        {
                            movieCollection.Remove(movieToRemove);
                            Console.WriteLine($"Movie '{movieToRemove}' removed from the collection.");
                            RemoveMovieFromFavorites(movieToRemove);
                        }
                        else
                        {
                            Console.WriteLine($"Movie '{movieToRemove}' not found in the collection.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Logging out from admin account.");
                        isAdmin = false;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void User()
        {
            while (true)
            {
                Console.WriteLine("\nUser Menu:");
                Console.WriteLine("1. Show movie list");
                Console.WriteLine("2. Add movie to favorites list");
                Console.WriteLine("3. Remove movie from favorites list");
                Console.WriteLine("4. Logout");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please select valid option.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        foreach (KeyValuePair<string, string> i in favorites)
                        {
                            Console.WriteLine(i.Key);
                        }
                        break;
                    case 1:
                        foreach (KeyValuePair<string, string> i in movieCollection)
                        {
                            Console.WriteLine(i.Key);
                        }
                        Console.Write("Enter the name of the movie to add to favorites list: ");
                        string movie = Console.ReadLine();
                        if (movieCollection.ContainsKey(movie))
                        {
                            favorites.Add(movie, movieCollection[movie]);
                            Console.WriteLine($"Movie '{movie}' Added to favorites list.");
                        }
                        else
                        {
                            Console.WriteLine($"Movie '{movie}' not found in the collection.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Favorites List");
                        foreach (KeyValuePair<string, string> i in favorites)
                        {
                            Console.WriteLine(i.Key);
                        }

                        Console.Write("Enter the name of the movie to remove from favorites list: ");
                        string movieToRemove = Console.ReadLine();
                        if (favorites.ContainsKey(movieToRemove))
                        {
                            favorites.Remove(movieToRemove);
                            Console.WriteLine($"Movie '{movieToRemove}' removed from favorites list.");
                        }
                        else
                        {
                            Console.WriteLine($"Movie '{movieToRemove}' not found in favorites list.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Logged out from user account.");
                        isUser = false;
                        return;
                    default:
                        Console.WriteLine("Please select valid option.");
                        break;
                }
            }
        }

        static void RemoveMovieFromFavorites(string movieToRemove)
        {
            if (favorites.ContainsKey(movieToRemove))
            {
                favorites.Remove(movieToRemove);
                Console.WriteLine($"Movie '{movieToRemove}' removed from favoriteslist.");
            }
        }

    }
}