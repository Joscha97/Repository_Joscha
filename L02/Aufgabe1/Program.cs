using System;

namespace Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Würfel (w), Kugel (k), Oktaeder (o)?");
            string eingabe = Console.ReadLine();

            Console.WriteLine("Durchmesser d = ");
            double durchmesser = Console.Read();

            if (eingabe == "w" ) {
                Console.WriteLine("Oberfläche: " + getCubeSurface(durchmesser));
                Console.WriteLine("Volumen: " + getCubeVolume(durchmesser));
                Console.WriteLine("Test hier: " + 6*durchmesser*durchmesser);
            }
            if (eingabe == "k" ) {
                Console.WriteLine(getSphereSurface(durchmesser));
                Console.WriteLine(getSphereVolume(durchmesser));
            }
            if (eingabe == "o" ) {
                Console.WriteLine(getOktaSurface(durchmesser));
                Console.WriteLine(getOktaVolume(durchmesser));

            }
            Console.WriteLine("Test");
        }    
        
        public static double getCubeSurface (double durchmesser) {
            double oberfläche = 6*(durchmesser*durchmesser);
            return oberfläche;
        }
        public static double getCubeVolume (double durchmesser) {
            double volumen = durchmesser*durchmesser*durchmesser;
            return volumen;
        }
        public static double getSphereSurface (double durchmesser) {
            double oberfläche = durchmesser*durchmesser*3.14;
            return oberfläche;
        }
        public static double getSphereVolume (double durchmesser) {
            double volumen = (3.14*durchmesser*durchmesser*durchmesser)/6;
            return volumen; 
        }
        public static double getOktaSurface (double durchmesser) {
            double oberfläche = 2*Math.Sqrt(3)*(durchmesser*durchmesser);
            return oberfläche;
        }
        public static double getOktaVolume(double durchmesser) {
            double volumen = Math.Sqrt(2)*(durchmesser*durchmesser*durchmesser)/3;
            return volumen; 
        }

    }
}
