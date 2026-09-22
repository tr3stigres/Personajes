using Personajes;

class Program
{
    public static void Main()
    {
        var personaje1 = new Personaje("Jordi", 100, 20, "Espada");
        var personaje2 = new Personaje("Francisco José", 100, 15, "Varita de Sauco");

        Console.WriteLine(personaje1);
        Console.WriteLine(personaje2);        
        do
        {
            personaje1.Atacar(personaje2);
            personaje2.Atacar(personaje1);
            Console.WriteLine(personaje1);
            Console.WriteLine(personaje2);
        } while (personaje1.EstaVivo() && personaje2.EstaVivo());
    }
}
