using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TPMoyennes
{
    internal class Eleve
    {
        public string     prenom;
        public string     nom;
        public List<Note> notes;

        // Constructeur de la classe
        public Eleve(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom    = nom;
            this.notes  = new List<Note>();
        }

        // Méthode permettant d'ajouter une note
        public void ajouterNote(Note note)
        {
            this.notes.Add(note);
        }

        // Calcul de la moyenne de l'élève dans la matière donnée
        public double moyenneMatiere(int matiere)
        {
            int    nbrNotesMatiere = 0;
            double total           = 0;
            
            foreach(Note note in this.notes)
            {
                if(note.matiere == matiere)
                {
                    nbrNotesMatiere++;
                    total += note.note;
                }
            }

            double resultat = total / nbrNotesMatiere;
            return Math.Round(resultat, 2);
        }

        // Calcul de la moyenne générale de l'élève
        public double moyenneGeneral()
        {
            // On parcours une première fois la liste des notes pour savoir quelles sont les matères étudiées
            List<int> matieresEtudiees = new List<int>();
            foreach(Note note in this.notes)
            {
                if (matieresEtudiees.Contains(note.matiere) == false)
                {
                    matieresEtudiees.Add(note.matiere);
                }
            }

            // On calcule la moyenne pour chaque matière, puis on fait la moyenne des moyennes
            double total = 0; 

            foreach (int matiere in matieresEtudiees)
            {
                total += this.moyenneMatiere(matiere);
            }

            double resultat = total / matieresEtudiees.Count;
            return Math.Round(resultat, 2);
        }
    }
}
