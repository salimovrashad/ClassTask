namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Rashad", "123456");
            User[] users = {user1};

            foreach (User user in users)
            {
                Console.WriteLine("istifadəçi hesaba daxil oldu: " + user.Username + " " + user.Password);
            }
        }
    }
}