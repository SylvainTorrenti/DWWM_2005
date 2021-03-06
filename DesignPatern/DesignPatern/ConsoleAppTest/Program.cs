﻿using DesignPatern;
using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression e = new Nombre(33);
            string strnumber= e.Formate();

            Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
            int res = exp1.Evalue();

            Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
            int res2 = exp2.Evalue();

            Expression exp3 = new Soustraction(new Nombre(3), new Nombre(6));
            int res3 = exp3.Evalue();

            Expression exp4 = new Addition(new Addition(new Nombre(3), new Nombre(6)),new Nombre(7));
            int res4 = exp4.Evalue();
            string str4 = exp4.Formate();

        }
    }
}
