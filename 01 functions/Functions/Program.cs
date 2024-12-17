namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            Console.WriteLine("...");
             string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
            
            for (int i = 0; i < 4; i++)
            {
                AskQuestions();
            }

            
        }

        internal void AskQuestions()
        {
            Vraag1();
            Vraag2();
        }
        internal void Vraag1()
            {
                Console.WriteLine("how long do you think you'd survive in a zombie apocalypse?");
                string antwoord = Console.ReadLine();

                Console.WriteLine(antwoord);
            }
       

        internal void Vraag2()
        {
            Console.WriteLine("What are your funniest childhood memories?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag3()
        {
            Console.WriteLine("What would you do if you won a million dollars");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag4()
        {
            Console.WriteLine("");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
    }
}
