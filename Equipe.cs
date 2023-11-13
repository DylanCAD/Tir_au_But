using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tir_au_But
{
    internal class Equipe
    {
        private string nom;
        private Joueur[] joueurs;
        public string Nom { get => nom; set => nom = value; }
        internal Joueur[] Joueurs { get => joueurs; set => joueurs = value; }

        public Equipe(string nom, Joueur[] joueurs)
        {
            this.Nom = nom;
            this.Joueurs = joueurs;
        }

        public void AfficherEffectif()
        {
            Console.WriteLine($"Effectif de l'équipe {Nom}:");
            foreach (var joueur in Joueurs)
            {
                Console.WriteLine($" - {joueur.Nom}");
            }
        }

        public int RealiserTirs(int nombreDeTirs)
        {
            int butsMarques = 0;

            for (int i = 0; i < nombreDeTirs; i++)
            {
                Console.WriteLine($"Tentative de tir {i + 1} pour l'équipe {Nom}");
                foreach (var joueur in Joueurs)
                {
                    if (joueur is Joueur)
                    {
                        Console.Write("Choisissez la direction du tir (gauche, droite, au milieu) : ");
                        string directionDeTir = Console.ReadLine();
                        joueur.TirerAuBut(directionDeTir);
                    }
                    else
                    {
                        Random random = new Random();
                        int randomDirectionIndex = random.Next(3);
                        string[] directions = { "gauche", "droite", "au milieu" };
                        string randomDirection = directions[randomDirectionIndex];
                        joueur.TirerAuBut(randomDirection);
                    }
                }
            }

            foreach (var joueur in Joueurs)
            {
                butsMarques += joueur.Score;
            }

            return butsMarques;
        }
    }
}