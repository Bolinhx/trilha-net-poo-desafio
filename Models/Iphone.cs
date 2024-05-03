namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override string Modelo { get; set; }
        public override string Imei { get; set; }
        public override string Memoria { get; set; }
     

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso!");

        }
    }
}