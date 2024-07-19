using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMoyennes
{
    class Program
    {        
        static void Main(string[] args)
        {
            // Création d'une classe
            Classe sixiemeA = new Classe("6eme A");
            // Ajout des élèves à la classe
            sixiemeA.ajouterEleve("Jean",    "RAGE");
            sixiemeA.ajouterEleve("Paul",    "HAAR");
            sixiemeA.ajouterEleve("Sibylle", "BOQUET");
            sixiemeA.ajouterEleve("Annie",   "CROCHE");
            sixiemeA.ajouterEleve("Alain",   "PROVISTE");
            sixiemeA.ajouterEleve("Justin",  "TYDERNIER");
            sixiemeA.ajouterEleve("Sacha",   "TOUILLE");
            sixiemeA.ajouterEleve("Cesar",   "TICHO");
            sixiemeA.ajouterEleve("Guy",     "DON");
            // Ajout de matières étudiées par la classe
            sixiemeA.ajouterMatiere("Francais");
            sixiemeA.ajouterMatiere("Anglais");
            sixiemeA.ajouterMatiere("Physique/Chimie");
            sixiemeA.ajouterMatiere("Histoire");
            Random random = new Random();
            // Ajout de 5 notes à chaque élève et dans chaque matière
            for (int ieleve = 0; ieleve < sixiemeA.eleves.Count; ieleve++)
            {
                for (int matiere = 0; matiere < sixiemeA.matieres.Count; matiere++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sixiemeA.eleves[ieleve].ajouterNote(new Note(matiere, (float)((6.5 +
                       random.NextDouble() * 34)) / 2.0f));
                        // Note minimale = 3
                    }
                }
            }


            // Affichage des résultats obtenus
            Console.WriteLine("Résultats pour la classe " + sixiemeA.nomClasse + " :");
            Console.WriteLine("----------------------------------------------\n");
            Console.WriteLine("Résultats individuels :\n");

            foreach (Eleve eleve in sixiemeA.eleves)
            {
                Console.WriteLine($"{eleve.prenom} {eleve.nom} :");
                for(int i = 0; i < sixiemeA.matieres.Count; i++)
                {
                    Console.WriteLine($"\t- Moyenne en {sixiemeA.matieres[i]} : {eleve.moyenneMatiere(i)}");
                }
                Console.WriteLine($"Moyenne générale : {eleve.moyenneGeneral()}\n");
            }

            Console.WriteLine("----------------------------------------------\n");
            Console.WriteLine("Résultats sur l'ensemble de la classe :");
            for (int i = 0; i < sixiemeA.matieres.Count; i++)
            {
                Console.WriteLine($"\t- Moyenne en {sixiemeA.matieres[i]} : {sixiemeA.moyenneMatiere(i)}");
            }
            Console.WriteLine($"Moyenne générale : {sixiemeA.moyenneGeneral()}");

            /*
            // Afficher la moyenne d'un élève dans une matière
            Eleve eleve = sixiemeA.eleves[6];
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne en " + sixiemeA.matieres[1] + " : " +
            eleve.moyenneMatiere(1) + "\n");
            // Afficher la moyenne générale du même élève
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne Generale : " + eleve.moyenneGeneral() + "\n");
            // Afficher la moyenne de la classe dans une matière
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne en " + sixiemeA.matieres[1] + " : " +
            sixiemeA.moyenneMatiere(1) + "\n");
            // Afficher la moyenne générale de la classe
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne Generale : " + sixiemeA.moyenneGeneral() + "\n");
            */
            Console.Read();
        }
    }
}



