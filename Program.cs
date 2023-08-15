// See https://aka.ms/new-console-template for more information
using ConsoleAndMonkeys.Interfaces;
using ConsoleAndMonkeys.Models;

// Initialisation des possibles tours d'acrobatie ou de musique
Trick culbute = new Trick(TrickCategory.Acrobatie, "culbute");
Trick siffler = new Trick(TrickCategory.Musique, "siffler");
Trick chanter = new Trick(TrickCategory.Musique, "chanter");
Trick salto = new Trick(TrickCategory.Acrobatie, "salto");
Trick pirouette = new Trick(TrickCategory.Acrobatie, "pirouette");

// Initialisation des singes, et enregistrement de leurs tours
Monkey Gaspar = new Monkey("Gaspar", new List<ITrick> { culbute, siffler, salto });
Monkey Brutus = new Monkey("Brutus", new List<ITrick> { chanter, pirouette, salto});

// Initialisation des dresseurs
Handler Roger = new Handler("Roger");
Handler Vanessa = new Handler("Vanessa");

// Ajout des singes auprès de leur dresseur
Roger.AddMonkey(Gaspar);
Vanessa.AddMonkey(Brutus);

// Initialisation du spectateur qui regarde les singes
Spectator Rodolphe = new Spectator("Rodolphe");
Rodolphe.StartWatchingMonkeyDoingTricks(Brutus);
Rodolphe.StartWatchingMonkeyDoingTricks(Gaspar);

// Demande d'exécution des tours
Roger.OrderMonkeysToDoTricks();
Vanessa.OrderMonkeysToDoTricks();