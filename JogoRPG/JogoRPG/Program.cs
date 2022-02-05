using System;




namespace JogoRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight (" Arus" , 23 , "Knight");
           
            Wizard wizard = new Wizard(" Arus", 23, "Knight");

        
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));





        }
       
    }
}