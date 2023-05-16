namespace Calculator
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
            Console.WriteLine("Seja bem-vindo! O que deseja fazer?");
            Console.WriteLine("\n1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Sair");
            Console.WriteLine("---------");

            Console.WriteLine("Selecione uma opção: ");
            short optionSelected = short.Parse(Console.ReadLine());

            switch(optionSelected)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float result = firstValue + secondValue;
            Console.WriteLine($"A soma dos números é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float result = firstValue - secondValue;
            Console.WriteLine($"A subtração dos números é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float result = firstValue / secondValue;
            Console.WriteLine($"A divisão dos números é: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float result = firstValue * secondValue;
            Console.WriteLine($"A multiplicação dos números é: {result}");
            Console.ReadKey();
            Menu();
        }
    }

}