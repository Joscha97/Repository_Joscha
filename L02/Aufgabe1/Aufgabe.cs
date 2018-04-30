using System;

namespace Aufgabe1
{
    class Aufgabe
    {
        public static void Main(string[] args) 
        {
            string[] subjects = { "Moritz", "Maxi", "Joscha" , "Timmy" , "Hans-Peter" };
            string[] verbs = { "mag", "hasst", "liebt", "verabscheut", "kennt" };
            string[] objects = { "Eltern", "Pizza", "Zigaretten", "Fotoalben", "Computer"};
            Console.WriteLine("Test");
            getVerse(subjects, verbs, objects);

        }

        public static void getVerse(string[] subjects, string[] verbs, string[] objects) {
            string verb;
            string subject;
            string objectff;

            for (int i=subjects.Length; i >= 0; i-- ) {
                Random rnd = new Random();
                int rs = rnd.Next(0, i);
                int rv = rnd.Next(0,i);
                int ro = rnd.Next(0,i);

                subject = subjects[rs];
                verb = verbs[rv];
                objectff = objects[ro];

                int hs = subjects.Length - rs;
                int hv = verbs.Length - rv;
                int ho = objects.Length - ro; 

                for (int l=hs; l >= 0; l=l-1  ) {
                    subjects[rs] = subjects[rs+1];
                    rs = rs+1;
                }
                for (int l=hv; l >= 0; l=l-1 ) {
                    verbs[rv] = verbs[rv+1];
                    rv++;
                }
                for (int l=ho; l >=0; l--) {
                    objects[ro] = objects[ro+1];
                    ro++;
                }
                Console.WriteLine(subject + verb + objectff); 
            
            }
            
        }
    }
}