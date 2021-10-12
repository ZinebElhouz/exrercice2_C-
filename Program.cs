using System;

namespace InserEntier
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim;
            Console.WriteLine(" entrer le nombre des cases du tableau (dimension) : ");
            dim = int.Parse(Console.ReadLine());

            int[] tab = new int[dim]; //declarer un tableau de dimension entrée

            Console.WriteLine(" entrer les elements du tableau selon l'ordre croissant :  "); //on va entrer des valeurs selon l'ordre croissant

            for (int i = 0; i < tab.Length; ++i)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter une valeur à inserer : ");
            Array.Resize<int>(ref tab, tab.Length + 1); //redimensionner le tableau
            int val = int.Parse(Console.ReadLine());

            int j;
            if (tab[0] > val)
            {
                for (j = tab.Length - 1; tab[j - 1] < val; j--)
                {
                    tab[j] = tab[j - 1];
                }
                tab[j] = val;
            }
            else          //si la valeur de première case est superieur de valeur inserée donc il va automatiquement ecraser le tableau et l'inserer au debut
            {
                for (j = tab.Length - 1; j > 0; j--)
                {
                    tab[j] = tab[j - 1];
                }
                tab[0] = val;
            }
            Console.WriteLine("affichage de nouveau tableau apres insertion"); //affichage de nouveau tableau

            for (int k = 0; k < tab.Length; k++)
            {
                Console.Write(tab[k] + "\t");
            }
        }
    }
}