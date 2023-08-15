using ConsoleAndMonkeys.Interfaces;
using ConsoleAndMonkeys.Models;

// Initialisation des possibles tours d'acrobatie ou de musique
ITrick culbute = new Trick(TrickCategory.Acrobatie, "culbute");
ITrick siffler = new Trick(TrickCategory.Musique, "siffler");
ITrick chanter = new Trick(TrickCategory.Musique, "chanter");
ITrick salto = new Trick(TrickCategory.Acrobatie, "salto");
ITrick pirouette = new Trick(TrickCategory.Acrobatie, "pirouette");

// Initialisation des singes, et enregistrement de leurs tours
IMonkey Gaspar = new Monkey("Gaspar", new List<ITrick> { culbute, siffler, salto });
IMonkey Brutus = new Monkey("Brutus", new List<ITrick> { chanter, pirouette, salto});

// Initialisation des dresseurs
IHandler Roger = new Handler("Roger");
IHandler Vanessa = new Handler("Vanessa");

// Ajout des singes auprès de leur dresseur
Roger.AddMonkey(Gaspar);
Vanessa.AddMonkey(Brutus);

// Initialisation du spectateur qui regarde les singes
ISpectator Rodolphe = new Spectator("Rodolphe");
Rodolphe.StartWatchingMonkeyDoingTricks(Brutus);
Rodolphe.StartWatchingMonkeyDoingTricks(Gaspar);

// Demande d'exécution des tours
Roger.OrderMonkeysToDoTricks();
Vanessa.OrderMonkeysToDoTricks();

// Empêche la fenêtre de se fermer
Console.WriteLine("Appuyez sur une touche pour fermer l'application.");
Console.ReadKey();