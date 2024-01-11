namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone

    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        Console.WriteLine("Abrindo o App Store...");
        Console.WriteLine($"{nomeApp} está sendo instalado");
        Console.WriteLine("...");
        Console.WriteLine("Instalado com sucesso!");
        }
    }
}