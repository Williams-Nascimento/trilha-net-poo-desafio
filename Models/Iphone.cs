namespace DesafioPOO.Models
{
    
    // FEITO!!!
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string imei, int memoria, string modeloIphone, string modelo)
            : base(numero, imei, modelo, memoria)
        {
            Modelo = modeloIphone;
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iniciando a instalação do {nomeApp} em Iphone {Modelo}");
        }
        
        // FEITO!!!
    }
}