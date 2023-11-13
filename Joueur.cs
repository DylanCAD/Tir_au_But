using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tir_au_But
{
    internal class Joueur
    {
        private string nom;
        private int score;
        public string Nom { get => nom; set => nom = value; }
        public int Score { get => score; set => score = value; }

        public Joueur(string nom)
        {
            this.Nom = nom;
            this.Score = 0;
        }

        public virtual void TirerAuBut(string direction)
        {
            Console.WriteLine($"{Nom} tire au but ({direction}) .");
            Random random = new Random();
            bool butMarque = random.Next(2) == 1; // 50% de chance de marquer
            if (butMarque)
            {
                Console.WriteLine($"But marqué par {Nom} .");
                Score++;
            }
            else
            {
                Console.WriteLine($"Le tir de {Nom} a été arrêté .");
            }
        }
    }
}