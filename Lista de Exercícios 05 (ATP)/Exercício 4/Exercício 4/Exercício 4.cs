using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] votos = new int[100];
            int i, cont0, cont1, cont2, cont3, cont4, contNulo;

            cont0 = 0; 
            cont1 = 0; 
            cont2 = 0; 
            cont3 = 0;
            cont4 = 0;
            contNulo = 0;

            for (i = 0; i < votos.Length; i++)
            {
                Console.WriteLine("Informe o voto para um dos Personagens: ");
                Console.WriteLine();
                Console.WriteLine("0. Perna Longa");
                Console.WriteLine("1. Pluto");
                Console.WriteLine("2. Mickey");
                Console.WriteLine("3. Bob Esponja");
                Console.WriteLine("4. Cebolinha"); 
                Console.WriteLine();
                votos[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (votos[i] == 0)
                    cont0++;

                else if (votos[i] == 1)
                    cont1++;

                else if (votos[i] == 2)
                    cont2++;

                else if (votos[i] == 3)
                    cont3++;

                else if (votos[i] == 4)
                    cont4++;
                else
                    contNulo++;
            }

            if (cont0 > cont1 && cont0 > cont2 && cont0 > cont3 && cont0 > cont4)
                Console.WriteLine($"Perna Longa foi o personagem mais votado com {cont0} votos!");

            else if (cont1 > cont0 && cont1 > cont2 && cont1 > cont3 && cont1 > cont4)
                Console.WriteLine($"Pluto foi o personagem mais votado com {cont1} votos!");

            else if (cont2 > cont0 && cont2 > cont1 && cont2 > cont3 && cont2 > cont4)
                Console.WriteLine($"Mickey foi o personagem mais votado com {cont2} votos!");

            else if (cont3 > cont0 && cont3 > cont1 && cont3 > cont2 && cont3 > cont4)
                Console.WriteLine($"Bob Esponja foi o personagem mais votado com {cont3} votos!");

            else if (cont4 > cont0 && cont4 > cont1 && cont4 > cont2 && cont4 > cont3)
                Console.WriteLine($"Cebolinha foi o personagem mais votado com {cont4} votos!");

            if (cont0 <= cont1 && cont0 <= cont2 && cont0 <= cont3 && cont0 <= cont4)
                Console.WriteLine($"Perna Longa foi o personagem menos votado com {cont0} votos!");

            else if (cont1 <= cont0 && cont1 <= cont2 && cont1 <= cont3 && cont1 <= cont4)
                Console.WriteLine($"Pluto foi o personagem menos votado com {cont1} votos!");

            else if (cont2 <= cont0 && cont2 <= cont1 && cont2 <= cont3 && cont2 <= cont4)
                Console.WriteLine($"Mickey foi o personagem menos votado com {cont2} votos!");

            else if (cont3 <= cont0 && cont3 <= cont1 && cont3 <= cont2 && cont3 <= cont4)
                Console.WriteLine($"Bob Esponja foi o personagem menos votado com {cont3} votos!");

            else if (cont4 <= cont0 && cont4 <= cont1 && cont4 <= cont2 && cont4 <= cont3)
                Console.WriteLine($"Cebolinha foi o personagem menos votado com {cont4} votos!");

            Console.WriteLine("Quantidade de votos nulos: " + contNulo);
            Console.ReadLine();
        }
    }
}
