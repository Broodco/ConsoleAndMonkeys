using ConsoleAndMonkeys.Models;
using ConsoleAndMonkeys.Interfaces;

namespace ConsoleAndMonkeysTests
{
    [TestClass]
    public class MonkeyTests
    {
        [TestMethod]
        public void DoAllTricks_Without_Any_Trick_Notifies_Us()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Monkey Fred = new Monkey("Fred", new List<ITrick> { });
                string expected = String.Format("{0} ne connait pas de tour.", Fred.Name);

                // Act
                Fred.DoAllTricks();

                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expected, lines[0]);
            }
        }

        [TestMethod]
        public void DoAllTricks_With_One_Trick()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Monkey Fred = new Monkey("Fred", new List<ITrick> { new Trick(TrickCategory.Acrobatie, "culbute") });
                string expectedLine0 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !", 
                    Fred.Name ,
                    Fred.Tricks[0].Name, 
                    "une acrobatie"
                );
                string expectedLine1 = String.Format("{0} a fini ses tours.", Fred.Name);

                // Act
                Fred.DoAllTricks();

                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expectedLine0, lines[0]);
                Assert.AreEqual(expectedLine1, lines[1]);
            }

        }

        [TestMethod]
        public void DoAllTricks_With_Two_Tricks()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Arrange
                Console.SetOut(sw);
                Monkey Fred = new Monkey(
                    "Fred", 
                    new List<ITrick> { 
                        new Trick(TrickCategory.Acrobatie, "culbute"),
                        new Trick(TrickCategory.Musique, "chantonne")
                    }
                );
                string expectedLine0 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !", 
                    Fred.Name ,
                    Fred.Tricks[0].Name, 
                    "une acrobatie"
                );
                string expectedLine1 = String.Format(
                    "{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !", 
                    Fred.Name ,
                    Fred.Tricks[1].Name, 
                    "un tour de musique"
                );
                string expectedLine2 = String.Format("{0} a fini ses tours.", Fred.Name);

                // Act
                Fred.DoAllTricks();

                // Assert
                var sb = sw.GetStringBuilder();
                var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
                Assert.AreEqual(expectedLine0, lines[0]);
                Assert.AreEqual(expectedLine1, lines[1]);
                Assert.AreEqual(expectedLine2, lines[2]);
            }
        }
    }
}