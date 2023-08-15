// See https://aka.ms/new-console-template for more information
using ConsoleAndMonkeys.Interfaces;
using ConsoleAndMonkeys.Models;

// Initialisation des possibles tours d'acrobatie ou de musique
Trick culbute = new Trick("acrobatie", "culbute");
Trick siffler = new Trick("tour de musique", "siffler");
Trick chanter = new Trick("tour de musique", "chanter");
Trick salto = new Trick("acrobatie", "salto");
Trick pirouette = new Trick("acrobatie", "pirouette");

// Initialisation des singes, et enregistrement de leurs tours
Monkey Gaspar = new Monkey("Gaspar", new List<ITrick> { culbute, siffler, salto });
Monkey Brutus = new Monkey("Brutus", new List<ITrick> { chanter, pirouette, salto});

// Initialisation des dresseurs
Handler Roger = new Handler("Roger");
Handler Vanessa = new Handler("Vanessa");

// Ajout des singes auprès de leur dresseur
Roger.AddMonkey(Gaspar);
Vanessa.AddMonkey(Brutus);

// Demande d'exécution des tours
Roger.OrderMonkeysToDoTricks();
Vanessa.OrderMonkeysToDoTricks();