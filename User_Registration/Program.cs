namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name :");
            string name = Console.ReadLine();

            User user = new User();
            user.FirstName(name);
        }
    }
}