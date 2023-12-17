using System;
using System.Collections.Generic;

namespace Bayno
{
    class Program
    {
        static List<Post> posts = new List<Post>();
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FaceBayno");
            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");

            int choice;
            do
            {
                choice = GetUserChoice();

                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        Register();
                        break;
                }

            } while (choice != 3);
        }

        static int GetUserChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            return choice;
        }

        static void Login()
        {
            Console.WriteLine("Enter Username: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();

            User user = FindUser(name, pass);

            if (user != null)
            {
                Console.WriteLine($"Welcome {user.Username}, what's on your mind?");
                UserMenu(user);
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        static void Register()
        {
            Console.WriteLine("Enter Username: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();

            User newUser = new User(name, pass);
            users.Add(newUser);

            Console.WriteLine($"Welcome {newUser.Username}, you have been registered successfully.");
            UserMenu(newUser);
        }

        static User FindUser(string username, string password)
        {
            return users.Find(user => user.Username == username && user.Password == password);
        }

        static void UserMenu(User user)
        {
            int input;
            do
            {
                Console.WriteLine("1. Post Something \n2. View All Posts \n3. Log Out");
                input = GetUserChoice();

                switch (input)
                {
                    case 1:
                        PostSomething(user);
                        break;
                    case 2:
                        ViewAllPosts();
                        break;
                }

            } while (input != 3);
        }

        static void PostSomething(User user)
        {
            Console.WriteLine("Create a post? \n1. Yes \n2. No");
            int answer = GetUserChoice();

            switch (answer)
            {
                case 1:
                    Console.WriteLine("Create Post: ");
                    string postContent = Console.ReadLine();
                    Post newPost = new Post(user, postContent);
                    posts.Add(newPost);
                    Console.WriteLine($"{user.Username} has posted something \n{postContent}");
                    break;
                default:
                    Console.WriteLine("Exiting post creation.");
                    break;
            }
        }

        static void ViewAllPosts()
        {
            Console.WriteLine("All Posts:");

            foreach (var post in posts)
            {
                Console.WriteLine($"{post.User.Username} - {post.Content}");
            }
        }
    }

    class User
    {
        public string Username { get; }
        public string Password { get; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    class Post
    {
        public User User { get; }
        public string Content { get; }

        public Post(User user, string content)
        {
            User = user;
            Content = content;
        }
    }
}
