using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Tir_au_But
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Joueur joueur1 = new Joueur("Joueur 1");
            Joueur joueur2 = new Joueur("Joueur 2");
            Joueur joueur3 = new Joueur("Joueur 3");
            Joueur joueur4 = new Joueur("Joueur 4");

            Joueur[] equipeDomicileJoueurs = { joueur1, joueur2 };
            Joueur[] equipeExterieurJoueurs = { joueur3, joueur4 };

            EquipeDomicile equipeDomicile = new EquipeDomicile("Équipe Domicile", equipeDomicileJoueurs);
            EquipeExterieur equipeExterieur = new EquipeExterieur("Équipe Extérieure", equipeExterieurJoueurs);

            equipeDomicile.AfficherEffectif();
            equipeExterieur.AfficherEffectif();

            int nombreDeTirs = 5;
            int butsMarquesDomicile = equipeDomicile.RealiserTirs(nombreDeTirs);
            int butsMarquesExterieur = equipeExterieur.RealiserTirs(nombreDeTirs);

            Console.WriteLine($"Score final :");
            Console.WriteLine($"{equipeDomicile.Nom} : {butsMarquesDomicile} buts");
            Console.WriteLine($"{equipeExterieur.Nom} : {butsMarquesExterieur} buts");
        }
    }
}