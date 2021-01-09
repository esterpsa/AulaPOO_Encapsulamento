using System;
using AulaPOO_Encapsulamento.Classes;

namespace AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.Parcela = 12;
            m.Bandeira = "Visa";
            Console.WriteLine(m.Bandeira);
        }
    }
}
