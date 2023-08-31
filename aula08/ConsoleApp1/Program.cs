using ConsoleApp1.NovaPasta;
using System.Security.Cryptography;

namespace DOCliente

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente CL1 = new Cliente("45707361812", 1.78F, 25, "Allan", "Masculino");
            CL1.Visualizar();
            Cliente CL2 = new Cliente("16555867606", 1.72F, 45, "Adailton", "Masculindo");
            CL2.Visualizar();


        }

    }
}