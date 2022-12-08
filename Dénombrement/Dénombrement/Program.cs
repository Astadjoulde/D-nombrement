/**
 * Titre : Application mathématique (dénombrement).
 * Auteur : Habou
 * Description : Ceéer une application qui consite à calculer les arrangements, permutations et combinanisons.
 * Date de création : 08/12/2022
 * Date dernière modification : 
 */

using System;

namespace Denombrements
{
    class Program
    {
        // Module d'affichage liste des choix possibles!
        static void affichage()
        {
            Console.WriteLine("Permutation ...................... 1");
            Console.WriteLine("Arrangement ...................... 2");
            Console.WriteLine("Combinaison ...................... 3");
            Console.WriteLine("Quitter .......................... 0");
        }
        // Module Saisi du choix sans erreur

        static char saisi(char cara1, char cara2, char cara3, char cara0)
        {
           char reponse;
            do
            {
                Console.WriteLine();
                Console.Write("Entrer un choix dans la liste    = ");
                reponse = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (reponse != cara1 && reponse != cara2 && reponse != cara3 && reponse != cara0);
            return reponse;
        }
        // Module saisi des nombres entiers sans erreur
        static int saisiEntier(string message)
        {
            bool correct = true;
            int entier=0;
            while (correct)
            {
                try
                {
                    Console.Write(message + " = ");
                    entier = int.Parse(Console.ReadLine());
                    correct = false;
                }
                catch
                {
                    Console.WriteLine("Veuillez entrer des nombres!");
                    Console.WriteLine();
                }
            }
            return entier;

        }

        // Module principal permettant de faire le calcul de : la permutation, arragement et combinaison.
        static void Main(string[] args)
        {
            // Déclaration des variables
            char rep = '9', cara1 = '1', cara2 = '2', cara3 = '3', cara0 = '0';
            // Boucle principal
            while (rep != cara0)
            {
                switch (rep)
                {
                    case '0':
                        break;  
                    // Choix 1: pour la Permutation
                    case '1':
                        Console.WriteLine("Vous avez choisi l'option 1: PERMUTATION");
                        Console.WriteLine();
                        int nombreElement1 = saisiEntier("Entrer le nombre total d'éléments à gérer");
                        long totalPermutation = 1;
                        // Calcul total Permutation
                        for (int k = 1; k <= nombreElement1; k++)
                            totalPermutation *= k;
                        Console.WriteLine(nombreElement1 + "! = " + totalPermutation);
                        Console.WriteLine();
                        break;
                    // Choix 2: pour l'Arrangement
                    case '2':    
                        Console.WriteLine("Vous avez choisi l'option 2: ARRANGEMENT");
                        Console.WriteLine();
                        int nombreElement2 = saisiEntier("Entrer le nombre total d'éléments à gérer");
                        int SousEnsemble2 = saisiEntier("Entrer le nombre d'éléments dans le sous ensemble");
                        long totalArrangement = 1;
                        // Calcul total Arrangement
                        for (int k = (nombreElement2 - SousEnsemble2 + 1); k <= nombreElement2; k++)
                            totalArrangement *= k;
                        Console.WriteLine("A (" + nombreElement2 + "/" + SousEnsemble2 + ") = " + totalArrangement);
                        Console.WriteLine();
                        break;
                    // Choix 3:pour la Combinaison
                    case '3':              
                        Console.WriteLine("Vous avez choisi l'option 3: COMBINAISON");
                        Console.WriteLine();
                        int nombreElement3 = saisiEntier("Entrer le nombre total d'éléments à gérer");
                        int sousEnsemble3 = saisiEntier("Entrer le nombre d'éléments dans le sous ensemble");
                        long totalCombinaison = 1;
                        // Calcul total Combinaison numerateur
                        for (int k = (nombreElement3 - sousEnsemble3 + 1); k <= nombreElement3; k++)
                            totalCombinaison *= k;
                        long totalCombinaison2 = 1;
                        // Calcul total Combinaison dénominateur
                        for (int k = 1; k <= sousEnsemble3; k++)
                            totalCombinaison2 *= k;
                        Console.WriteLine("C (" + nombreElement3 + "/" + sousEnsemble3 + ") = " + (totalCombinaison / totalCombinaison2));
                        Console.WriteLine();
                        break;

                }
                // Affichage et selection du choix
                affichage();
                rep = saisi(cara1, cara2, cara3, cara0);
                Console.Clear();
            }
            // Message fin du programme
            Console.WriteLine("Fin du programme!");
            Console.ReadLine();
        }
    }
}
