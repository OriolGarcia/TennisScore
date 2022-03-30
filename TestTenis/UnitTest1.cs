using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisLibrary;
using System;
namespace TestTenis
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataScoring score = new DataScoring();
            
            string result = score.Something();
            Console.WriteLine("Result:"+result);
            Assert.AreEqual("Algo", result);




            score.InitGame("Oriol", "Rafa Nadal");
            Assert.AreEqual("Oriol", score.jugador1.Nombre);
            Assert.AreEqual("Rafa Nadal", score.jugador2.Nombre);

            score.AugmentarPuntuación(score.jugador1, score.jugador2);
            Assert.AreEqual(1, score.jugador1.JugadasGanadas);
            Assert.AreEqual(0, score.jugador2.JugadasGanadas);
            Assert.AreEqual("15", score.jugador1.Puntuacion);
            Assert.AreEqual("0", score.jugador2.Puntuacion);


            score.AugmentarPuntuación(score.jugador2, score.jugador1);
            Assert.AreEqual(1, score.jugador1.JugadasGanadas);
            Assert.AreEqual(1, score.jugador2.JugadasGanadas);
            Assert.AreEqual("dos iguales", score.jugador1.Puntuacion);
            Assert.AreEqual("dos iguales", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador2, score.jugador1);
            Assert.AreEqual(1, score.jugador1.JugadasGanadas);
            Assert.AreEqual(2, score.jugador2.JugadasGanadas);
            Assert.AreEqual("15", score.jugador1.Puntuacion);
            Assert.AreEqual("30", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador1, score.jugador2);
            Assert.AreEqual(2, score.jugador1.JugadasGanadas);
            Assert.AreEqual(2, score.jugador2.JugadasGanadas);
            Assert.AreEqual("dos iguales", score.jugador1.Puntuacion);
            Assert.AreEqual("dos iguales", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador2, score.jugador1);
            Assert.AreEqual(2, score.jugador1.JugadasGanadas);
            Assert.AreEqual(3, score.jugador2.JugadasGanadas);
            Assert.AreEqual("30", score.jugador1.Puntuacion);
            Assert.AreEqual("40", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador2, score.jugador1);
            Assert.AreEqual(2, score.jugador1.JugadasGanadas);
            Assert.AreEqual(4, score.jugador2.JugadasGanadas);
            Assert.AreEqual("Losed", score.jugador1.Puntuacion);
            Assert.AreEqual("Game", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador2, score.jugador1);
            Assert.AreEqual(0, score.jugador1.JugadasGanadas);
            Assert.AreEqual(1, score.jugador2.JugadasGanadas);
            Assert.AreEqual("0", score.jugador1.Puntuacion);
            Assert.AreEqual("15", score.jugador2.Puntuacion);


            Assert.AreEqual(0, score.jugador1.Sets);
            Assert.AreEqual(1, score.jugador2.Sets);

            score.AugmentarPuntuación(score.jugador1, score.jugador2);
            Assert.AreEqual(1, score.jugador1.JugadasGanadas);
            Assert.AreEqual(1, score.jugador2.JugadasGanadas);
            Assert.AreEqual("dos iguales", score.jugador1.Puntuacion);
            Assert.AreEqual("dos iguales", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador1, score.jugador2);
            Assert.AreEqual(2, score.jugador1.JugadasGanadas);
            Assert.AreEqual(1, score.jugador2.JugadasGanadas);
            Assert.AreEqual("30", score.jugador1.Puntuacion);
            Assert.AreEqual("15", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador2, score.jugador1);
            Assert.AreEqual(2, score.jugador1.JugadasGanadas);
            Assert.AreEqual(2, score.jugador2.JugadasGanadas);
            Assert.AreEqual("dos iguales", score.jugador1.Puntuacion);
            Assert.AreEqual("dos iguales", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador2, score.jugador1);
            Assert.AreEqual(2, score.jugador1.JugadasGanadas);
            Assert.AreEqual(3, score.jugador2.JugadasGanadas);
            Assert.AreEqual("30", score.jugador1.Puntuacion);
            Assert.AreEqual("40", score.jugador2.Puntuacion);

            Assert.AreEqual(0, score.jugador1.Sets);
            Assert.AreEqual(1, score.jugador2.Sets);

            score.AugmentarPuntuación(score.jugador1, score.jugador2);
            Assert.AreEqual(3, score.jugador1.JugadasGanadas);
            Assert.AreEqual(3, score.jugador2.JugadasGanadas);
            Assert.AreEqual("dos iguales", score.jugador1.Puntuacion);
            Assert.AreEqual("dos iguales", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador1, score.jugador2);
            Assert.AreEqual(4, score.jugador1.JugadasGanadas);
            Assert.AreEqual(3, score.jugador2.JugadasGanadas);
            Assert.AreEqual("ventaja", score.jugador1.Puntuacion);
            Assert.AreEqual("40", score.jugador2.Puntuacion);

            score.AugmentarPuntuación(score.jugador1, score.jugador2);
            Assert.AreEqual(5, score.jugador1.JugadasGanadas);
            Assert.AreEqual(3, score.jugador2.JugadasGanadas);
            Assert.AreEqual("Game", score.jugador1.Puntuacion);
            Assert.AreEqual("Losed", score.jugador2.Puntuacion);


        }
    }
}
