internal class Program
{
    private static void Main(string[] args)
    {
        Talaba talaba = new Talaba();
        Console.WriteLine("Ism");
        talaba.Name = Console.ReadLine();
        Console.WriteLine("Familiya");
        talaba.SurName = Console.ReadLine();
        Console.WriteLine("O`qish joyi (OTM)");
        talaba.Edu = Console.ReadLine();
        Console.WriteLine("Kursi");
        talaba.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\t\t Talaba xaqida ma`lumot \n");
        Console.WriteLine($"Talaba: {talaba.Name} {talaba.SurName}");
        Console.WriteLine($"{talaba.Edu} bakalavr {talaba.Id} - bosqich talabasi");
    }
}

class Talaba
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set;}
    public string Edu { get; set;}
}