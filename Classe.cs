using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    internal class Classe
    {
        public string       nomClasse;
        public List<Eleve>  eleves;
        public List<string> matieres;

        // Constructeur de la classe
        public Classe(string nomClasse)
        {
            this.nomClasse = nomClasse;
            this.eleves    = new List<Eleve>();
            this.matieres  = new List<string>();
        }

        // Méthode permettant d'ajouter un élève dans la classe
        public void ajouterEleve(string prenom, string nom)
        {
            this.eleves.Add(new Eleve(prenom, nom));
        }

        // Méthode permettant d'ajouter une matière étudiée par les élèves de la classe
        public void ajouterMatiere(string matiere)
        {
            this.matieres.Add(matiere);
        }

        // Calcul de la moyenne de la classe pour une matière donnée
        public double moyenneMatiere(int i)
        {
            double total = 0;

            foreach(Eleve eleve in this.eleves)
            {
                total += eleve.moyenneMatiere(i);
            }

            double resultat = total / this.eleves.Count;
            return Math.Round(resultat, 2);
        }

        // Calcul de la moyenne générale de la classe
        public double moyenneGeneral()
        {
            double total = 0;

            foreach(Eleve eleve in this.eleves)
            {
                total += eleve.moyenneGeneral();
            }

            double resultat = total / this.eleves.Count;
            return Math.Round(resultat, 2);
        }
    }
}
