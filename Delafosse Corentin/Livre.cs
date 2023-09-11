﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Gestion_de_librairie
{
    public class Livre : Media
    {
        public string Auteur;
        public string Genre;

        //permet de surcharger la méthode AfficherInfos
        public override void AfficherInfos()
        {
            Console.WriteLine("Titre : " + Titre);
            Console.WriteLine("Auteur : " + Auteur);
            Console.WriteLine("Genre : " + Genre);
            Console.WriteLine("Numero de reference : " + NumeroReference);
            Console.WriteLine("Nombre d'exemplaire : " + NombreExemplaire);
        }
    }
}
