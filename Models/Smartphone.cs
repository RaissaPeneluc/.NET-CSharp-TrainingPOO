namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Implementando as propriedades faltantes de acoroo com o diagrama
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; } 


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Passando todos os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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