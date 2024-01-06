namespace DesafioPOO.Models
{
    
    // FEITO!!!
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string imei, int memoria, string modeloNokia, string modelo)
            : base(numero, imei, modelo, memoria)
        {
            Modelo = modeloNokia;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalação do {nomeApp} no Nokia {Modelo} esta em andamento");
        }
        
        // FEITO!!!
    }
}