using System;

namespace Story_of_yourName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Story of yourName");
            Console.Write(".");
            Console.Write(".");
            Console.Write(".");
            Console.Clear();
            Console.Write("Story of yourName");
            Console.Write(".");
            Console.Write(".");
            Console.Write(".");
            Console.Clear();
            Console.Write("Story of yourName");
            Console.Write(".");
            Console.Write(".");
            Console.Write(".");
            Console.Clear();
            Console.Write("Story of yourName");
            Console.Write(".");
            Console.Write(".");
            Console.Write(".");
            Console.Clear();
            Console.Write("Story of yourName");
            Console.Write(".");
            Console.Write(".");
            Console.Write(".");
            Console.Clear();

            Console.WriteLine("Drücke Enter um weiterzulesen.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Bitte informiere das Programm über deine Wünsche.");
            Console.ReadLine();

            Console.Write("Dein Name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Dein Name ist " + yourName + ".");
            Console.ReadLine();

            Console.Write("Dein Alter: ");
            string yourAge = Console.ReadLine();
            Console.WriteLine("Du bist " + yourAge + " Jahre alt " + yourName + ".");
            Console.ReadLine();

            Console.Write("Möchtest du lieber als 'er' oder als 'sie' bezeichnet werden?  |  Als ");
            string yourGender = Console.ReadLine();
            Console.WriteLine("Du wirst als '" + yourGender + "' bezeichnet.");
            Console.ReadLine();

            Console.Write("Und in groß nochmal bitte.  |  ");
            string yourGenderBig = Console.ReadLine();
            Console.WriteLine("Danke für ihr '" + yourGenderBig + "'.");
            Console.ReadLine();

            Console.Write("Möchtest du, dass wir 'seinen' oder 'ihren' sagen?  |  ");
            string SeinenIhren = Console.ReadLine();
            Console.WriteLine("Wir sagen '" + SeinenIhren + "'.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(yourName);
            Console.ReadLine();
            Console.WriteLine("Es war einmal ein kleines Kind namens " + yourName + ". " + yourGenderBig + " war " + yourAge + " Jahre alt.");
            Console.Write(yourName + " war ein liebes, nettes und gutmütiges Kind. Somit war " + yourGender + " sehr beliebt bei den Erwachsenen. ");
            Console.WriteLine("Aber die anderen Kinder waren gemeine Mobber und so hatte " + yourGender + " keine Freunde.");
            Console.Write("Doch " + yourGender + " wünschte sich so sehr Freunde, dass " + yourGender + " sogar die Böse Hexe Physchopatika nach Freunden fragte. Diese wollte " + yourName + " reinlegen.");
            Console.WriteLine(" Allerdings war " + yourName + " zu schlau und ließ sich nicht reinlegen. " + yourGender + " befreite sogar ein anderes Kind und sie wurden Freunde.");
            Console.ReadLine();
            Console.WriteLine("Story von Lukas John");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Dunkel und Hell");
            Console.ReadLine();
            Console.WriteLine(yourName + " wachte in völliger Dunkelheit auf und guckte auf die Uhr. Danach dachte " + yourGender + " " + yourGender + " hätte die Gardienen zu aber dem war nicht so.");
            Console.WriteLine("Verwirt rief " + yourGender + SeinenIhren + " Freund Elias an. Als er endlich dran ging sagte er mit ängstlicher Stimme 'Hi' und dann hörte " + yourName + " ein knacken wie von einem brechenden Ast und eine gruselige Stimme kicherte schauerlich vor sich hin.");
            Console.WriteLine("Plötzlich wurde alles schwarz und " + yourName + " wachte in völliger Dunkelheit auf guckte auf die Uhr und merkte, dass es so dunkel war weil die  Gardienen zu wahren.");
            Console.ReadLine();
            Console.WriteLine("Story von Moritz John");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
