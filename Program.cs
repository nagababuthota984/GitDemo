using namespace GitDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GreetHello();
            GreetUser("Sena");
        }

        public void static GreetHello(){
            Console.Writeline("Hello there!");
        }

        public void static GreetUser(string userName){
            Console.Writeline($"Hi {userName}");
        }
    }
}