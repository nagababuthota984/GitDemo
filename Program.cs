using namespace GitDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GreetUser("Sena");
            SayHi();
        }

        public void static SayHi(){
            Console.Writeline("Hi there!");
        }

        public void static GreetUser(string userName){
            Console.Writeline($"Hi {userName}");
        }
    }
}