using ConsoleAndMonkeys.Models;
using ConsoleAndMonkeys.Interfaces;
using System.Xml.Linq;

namespace ConsoleAndMonkeysTests
{
    [TestClass]
    public class HandlerTests
    {
        [TestMethod]
        public void OrderMonkeysToDoTricks_With_No_Monkey_Notifies_Us()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Handler Sacha = new Handler("Sacha");
                string expectedLine0 = String.Format("{0} demande a ses singes d'exécuter leurs tours.", "Sacha");
                string expectedLine1 = String.Format("{0} n'a pas de singe.", "Sacha");

                // Act
                Sacha.OrderMonkeysToDoTricks();

                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expectedLine0, lines[0]);
                Assert.AreEqual(expectedLine1, lines[1]);
            }
        }

        [TestMethod]
        public void OrderMonkeysToDoTricks_With_One_Monkey()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Handler Sacha = new Handler("Sacha");
                Monkey Pikachu = new Monkey("Pikachu", new List<ITrick>{
                    new Trick(TrickCategory.Acrobatie, "éclair"),
                    new Trick(TrickCategory.Musique, "chanter")
                });
                Sacha.AddMonkey(Pikachu);
                string expectedLine0 = String.Format("{0} demande a ses singes d'exécuter leurs tours.", "Sacha");
                string expectedLine1 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Pikachu.Name,
                    Pikachu.Tricks[0].Name,
                    "une acrobatie"
                );
                string expectedLine2 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Pikachu.Name,
                    Pikachu.Tricks[1].Name,
                    "un tour de musique"
                );
                string expectedLine3 = String.Format("{0} a fini ses tours.", Pikachu.Name);

                // Act
                Sacha.OrderMonkeysToDoTricks();

                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expectedLine0, lines[0]);
                Assert.AreEqual(expectedLine1, lines[1]);
                Assert.AreEqual(expectedLine2, lines[2]);
                Assert.AreEqual(expectedLine3, lines[3]);
            }
        }

        [TestMethod]
        public void OrderMonkeysToDoTricks_With_Two_Monkeys()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Handler Sacha = new Handler("Sacha");
                Monkey Pikachu = new Monkey("Pikachu", new List<ITrick>{
                    new Trick(TrickCategory.Acrobatie, "éclair"),
                    new Trick(TrickCategory.Musique, "chanter")
                });
                Monkey Salameche = new Monkey("Salamèche", new List<ITrick>{
                    new Trick(TrickCategory.Acrobatie, "flammeche"),
                    new Trick(TrickCategory.Musique, "danser en rythme")
                });

                Sacha.AddMonkey(Pikachu);
                Sacha.AddMonkey(Salameche);

                string expectedLine0 = String.Format("{0} demande a ses singes d'exécuter leurs tours.", "Sacha");
                string expectedLine1 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Pikachu.Name,
                    Pikachu.Tricks[0].Name,
                    "une acrobatie"
                );
                string expectedLine2 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Pikachu.Name,
                    Pikachu.Tricks[1].Name,
                    "un tour de musique"
                );
                string expectedLine3 = String.Format("{0} a fini ses tours.", Pikachu.Name);
                string expectedLine4 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Salameche.Name,
                    Salameche.Tricks[0].Name,
                    "une acrobatie"
                );
                string expectedLine5 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Salameche.Name,
                    Salameche.Tricks[1].Name,
                    "un tour de musique"
                );
                string expectedLine6 = String.Format("{0} a fini ses tours.", Salameche.Name);

                // Act
                Sacha.OrderMonkeysToDoTricks();

                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expectedLine0, lines[0]);
                Assert.AreEqual(expectedLine1, lines[1]);
                Assert.AreEqual(expectedLine2, lines[2]);
                Assert.AreEqual(expectedLine3, lines[3]);
                Assert.AreEqual(expectedLine4, lines[4]);
                Assert.AreEqual(expectedLine5, lines[5]);
                Assert.AreEqual(expectedLine6, lines[6]);
            }
        }

    }
}