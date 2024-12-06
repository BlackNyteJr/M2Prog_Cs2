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
            Console.WriteLine("Nah bro it worked.");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Run()
        {
            Console.WriteLine("Ok dude. Now is not the time to make jokes. Did it work or not?");
            Vraag2();
        }

        internal void Vraag2()
        {
            Console.WriteLine("Yeah yeah yeah stop whining. The stupid thing worked.");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Run()
        {
            Console.WriteLine("Are you sure?");
            Vraag3();
        }

        internal void Vraag3()
        {
            Console.WriteLine("Yes dude!");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Run()
        {
            Console.WriteLine("Can there be any more modifications added?");
            Vraag4();
        }

        internal void Vraag4()
        {
            Console.WriteLine("Yeah, but it's gonna cost ya");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Run()
        {
            Console.WriteLine("How much?");
            Vraag5();
        }

        internal void Vraag5()
        {
            Console.WriteLine("Five thousand lil bro");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
    }
}