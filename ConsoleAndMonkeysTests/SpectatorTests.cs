using ConsoleAndMonkeys.Models;
using ConsoleAndMonkeys.Interfaces;
using System.Xml.Linq;

namespace ConsoleAndMonkeysTests
{
    [TestClass]
    public class SpectatorTests
    {
        [TestMethod]
        public void ReactToMonkeyTrick_With_Acrobatie()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Monkey Fred = new Monkey("Fred", new List<ITrick> { new Trick(TrickCategory.Acrobatie, "culbute") });
                Spectator Vladimir = new Spectator("Vladimir");

                // Act
                Vladimir.StartWatchingMonkeyDoingTricks(Fred);
                Fred.DoAllTricks();
                string expectedLine0 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Fred.Name,
                    Fred.Tricks[0].Name,
                    "une acrobatie"
                );
                string expectedLine1 = String.Format("{0} regarde le tour de {1}, et il applaudit.", Vladimir.Name, Fred.Name);


                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expectedLine0, lines[0]);
                Assert.AreEqual(expectedLine1, lines[1]);
            }
        }

        [TestMethod]
        public void ReactToMonkeyTrick_With_Musique()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Monkey Fred = new Monkey("Fred", new List<ITrick> { new Trick(TrickCategory.Musique, "entonne une sérénade") });
                Spectator Vladimir = new Spectator("Vladimir");

                // Act
                Vladimir.StartWatchingMonkeyDoingTricks(Fred);
                Fred.DoAllTricks();
                string expectedLine0 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Fred.Name,
                    Fred.Tricks[0].Name,
                    "un tour de musique"
                );
                string expectedLine1 = String.Format("{0} regarde le tour de {1}, et il siffle.", Vladimir.Name, Fred.Name);


                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expectedLine0, lines[0]);
                Assert.AreEqual(expectedLine1, lines[1]);
            }
        }

        [TestMethod]
        public void ReactToMonkeyTrick_With_Both_Kinds_Of_Tricks()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Monkey Fred = new Monkey("Fred", new List<ITrick> {
                    new Trick(TrickCategory.Acrobatie, "culbute"),
                    new Trick(TrickCategory.Musique, "entonne une sérénade") 
                });
                Spectator Vladimir = new Spectator("Vladimir");

                // Act
                Vladimir.StartWatchingMonkeyDoingTricks(Fred);
                Fred.DoAllTricks();
                string expectedLine0 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Fred.Name,
                    Fred.Tricks[0].Name,
                    "une acrobatie"
                );
                string expectedLine1 = String.Format("{0} regarde le tour de {1}, et il applaudit.", Vladimir.Name, Fred.Name);

                string expectedLine2 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !",
                    Fred.Name,
                    Fred.Tricks[1].Name,
                    "un tour de musique"
                );
                string expectedLine3 = String.Format("{0} regarde le tour de {1}, et il siffle.", Vladimir.Name, Fred.Name);

                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expectedLine0, lines[0]);
                Assert.AreEqual(expectedLine1, lines[1]);
                Assert.AreEqual(expectedLine2, lines[2]);
                Assert.AreEqual(expectedLine3, lines[3]);
            }
        }
    }
}