Console.WriteLine("Choisir la langue : ");
Console.WriteLine("1. Français");
Console.WriteLine("2. Anglais");
Console.WriteLine("3. Espagnol");

int langue = int.Parse(Console.ReadLine());

IBonjour bonjour = langue switch
{
    2 => new BonjourEN(),
    3 => new BonjourES(),
    _ => new BonjourFR()
};

AfficherBonjour(bonjour);




void AfficherBonjour(IBonjour bonjour)
{
    Console.WriteLine(bonjour.getBonjour());
}

public interface IBonjour
{
    string getBonjour();
}

public class BonjourFR : IBonjour
{
    public string getBonjour() => "Bonjour";
}

public class BonjourEN : IBonjour
{
    public string getBonjour() => "Hello";
}

public class BonjourES : IBonjour
{
    public string getBonjour() => "Hola";
}