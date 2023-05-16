namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("\n1- Abrir arquivo\n2 - Criar novo arquivo\n0 - Sair");
            short optionSelected = short.Parse(Console.ReadLine()); 

            switch(optionSelected) 
            {
                case 1: OpenArchive(); break;
                case 2: EditArchive(); break;
                case 0: Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void OpenArchive() 
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void EditArchive()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-------");
            var text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveArchive(text);
        }

        static void SaveArchive(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}