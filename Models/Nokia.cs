namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override string Modelo {get; set;}
        public override string Imei {get; set;}
        public override string Memoria {get; set;}
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
          Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");
        }
    }
}