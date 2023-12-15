namespace DesafioPOO.Models
{
    public class Xiaomi : Smartphone
    {
        public Xiaomi(
                string numero, 
                string modelo, 
                string imei, 
                int memoria) : base(numero, modelo, imei, memoria
            )
        {}
       
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Xiaomi");
        }
    }
}