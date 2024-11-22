namespace readlines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Run();

            // Variable: program
            // Type: class
        }

        internal void Run()
        {
            Console.WriteLine("Did it work?");
            Vraag1();
        }

        internal void Vraag1()
        {
            Console.WriteLine("Nah bro it worked");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
    }
}