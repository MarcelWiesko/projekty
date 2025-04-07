namespace _95_interfejsy_Poziom_Trudnosci
{
    internal class Program
    {
        enum PoziomTrudnosci
        {
            Łatwy, Średni, Trudny
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj poziom trudnosci");
            string wybor = Console.ReadLine();
            Console.WriteLine($"Wybrałeś {wybor} poziom trudnosci");
        }
    }
    

}
