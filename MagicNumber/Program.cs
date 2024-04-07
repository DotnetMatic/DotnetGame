// Bienvenue dans cette présentation.
// le  but est de développer le jeux du nombre magique avec les niveaux de difficulté.

// les différents étapes de développement sont les suivantes:

// 1- choix du niveau de difficulté 1- facile, 2- moyen, 3- difficile
// 2- génération du nombre magique
// 3- saisie du nombre par l'utilisateur
// 4- comparaison du nombre saisi avec le nombre magique
// 5- affichage du résultat
// 6- répéter les étapes 3 à 5 jusqu'à ce que le nombre saisi soit égal au nombre magique
// 7- afficher le nombre d'essais
// 8- proposer de rejouer

// let's go

using System;

int choix = 0;
int nombreMagique = 0;
int nombreSaisi = 0;
int essais = 0;
bool rejouer = true;

while (rejouer)
{
    Console.WriteLine("Choisissez le niveau de difficulté: 1- facile, 2- moyen, 3- difficile");
    choix = int.Parse(Console.ReadLine());

    switch (choix)
    {

        case 1:
            nombreMagique = new Random().Next(1,11);
            break;
        case 2:
            nombreMagique = new Random().Next(1,101);
            break;
        case 3:
            nombreMagique = new Random().Next(1,1001);
            break;
        default:
            Console.WriteLine("Niveau de difficulté inconnu");
            break;
    }

    while (nombreSaisi != nombreMagique)
    {
        Console.WriteLine("Saisissez un nombre:");
        nombreSaisi = int.Parse(Console.ReadLine());
        essais++;

        if (nombreSaisi < nombreMagique)
        {
            Console.WriteLine("Le nombre magique est plus grand");
        }
        else if (nombreSaisi > nombreMagique)
        {
            Console.WriteLine("Le nombre magique est plus petit");
        }
        else
        {
            Console.WriteLine("Bravo! Vous avez trouvé le nombre magique");
        }
    }

    Console.WriteLine($"Vous avez trouvé le nombre magique en {essais} essais");
    Console.WriteLine("Voulez-vous rejouer? (o/n)");
    rejouer = Console.ReadLine() == "o";
    essais = 0;
}

// Merci à vous tous et desolé pour la suspension. A bientôt !!!
