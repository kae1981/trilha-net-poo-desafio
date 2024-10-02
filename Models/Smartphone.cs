namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        private string Modelo {get; set;}

        private string Imei {get; set;}
        private int Memoria {get; set;}
        public string modelo { get; private set; }
        public string imei { get; private set; }
        public int memoria { get; private set; }

        public Smartphone(string numero)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}