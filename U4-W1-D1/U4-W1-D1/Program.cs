using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanze in classi diverse
            Atleti atleta1 = new Atleti("Mario Rossi", 25, "Calcio");
            Dipendenti dipendente1 = new Dipendenti("Epicode","Pinco Pallo",30);
            Animali animale1 = new Animali("Sam", 6, "Cane");
            Veicoli auto1 = new Veicoli();
            auto1.Marca = "BMW";
            Veicoli auto2 = new Veicoli();
            auto2.Marca = "Ford";


            // Stampa a video
            Console.WriteLine("Informazioni sull'Atleta:");
            Console.WriteLine("Atleta: " + atleta1.Nome);
            Console.WriteLine("\n");
            Console.WriteLine("Età: " + atleta1.Età);
            Console.WriteLine("\n");
            Console.WriteLine("Sport: " + atleta1.Sport);
            Console.WriteLine("\n");


            Console.WriteLine("Informazioni sul Dipendente:");
            Console.WriteLine("Nome Azienda: " + dipendente1.NomeAzienda);
            Console.WriteLine("\n");
            Console.WriteLine("Nome: " + dipendente1.Nome);
            Console.WriteLine("\n");
            Console.WriteLine("Età: " + dipendente1.Età);
            Console.WriteLine("\n");





            Console.WriteLine("Informazioni sul tuo Animale Domestico:");
            Console.WriteLine("Nome: " + animale1.Nome);
            Console.WriteLine("\n");
            Console.WriteLine("Età: " + animale1.Età);
            Console.WriteLine("\n");
            Console.WriteLine("Tipo: " + animale1.Tipo);





            Console.WriteLine("Auto 1: " + auto1.Marca);
            Console.WriteLine("\n");
            Console.WriteLine("Auto 2: " + auto2.Marca);

            auto1.Marca = "Ferrari";
            Console.WriteLine("Prima auto aggiornata: " + auto1.Marca);

            string Messaggio = auto1.kmTagliando(500);
            Console.WriteLine("Tagliando auto 1: " + Messaggio);
            string Messaggio2 = auto2.kmTagliando(15000);
            Console.WriteLine("Tagliando auto 2: " + Messaggio2);
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
