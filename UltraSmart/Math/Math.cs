﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UltraSmart
{
    public static class Math
    {
        /// <summary>
        /// Returns the value of a combination without repeats. *Important: (N ≥ R)
        /// </summary>
        public static double Combinatorial(double N,double R)
        {
            double result;
            result = Facorials(N) / (Facorials(R) * Facorials(N - R));
            return result;            
        }

        /// <summary>
        /// Returns the value of a repeating combinator. *Important: (N ≥ R)
        /// </summary>
        public static double CombinatorialR(double N, double R)
        {
            double result;
            result = Facorials(N + R - 1) / (Facorials(R) * Facorials(N - 1));
            return result;
        }

        /// <summary>
        /// Returns the value of a non-repeating variation. *Important: (N ≥ R)
        /// </summary>
        public static double Variation(double N, double R)
        {
            double result;
            result = Facorials(N) / Facorials(N - R);
            return result;
        }

        /// <summary>
        /// Returns the value of a sum
        /// </summary>
        public static double Sum(double num)
        {
            double result;
            result = num * (num + 1) / 2;
            return result;
        }

        /// <summary>
        /// Returns the value of the rest of a division
        /// </summary>
        public static double Mod(double num1, double num2)
        {
            return num1 % num2;
        }

        /// <summary>
        /// Returns the factorial of a number
        /// </summary>
        public static double Facorials(double num)
        {
            double factor;
            factor = 1;
            for (int i = 1; i <= num; i++)
            {
                factor = factor * i;
            }
            return factor;
        }

        /// <summary>
        /// Returns the Maximum Common Divisor of 2 numbers
        /// </summary>
        public static double MCD(double num1, double num2) //Algoritmo de Euclides
        {
            double iaux; //Auxiliar
            num1 = System.Math.Abs(num1); //Toma valor absoluto
            num2 = System.Math.Abs(num2);
            double i1 = System.Math.Max(num1, num2); //i1 = el más grande
            double i2 = System.Math.Min(num1, num2); //i2 = el más pequeño
            do
            {
                iaux = i2;  //Guarda Divisor
                i2 = i1 % i2; //Resto pasa a divisor
                i1 = iaux;  //Divisor pasa a dividendo
            } while (i2 != 0);
            return i1; //Ultimo resto no nulo
        }

        /// <summary>
        /// Returns the Minimum Common Multiple of 2 numbers
        /// </summary>
        public static double MCM(double num1, double num2)
        {
            return (num1 / MCD(num1, num2)) * num2;
        }

        /// <summary>
        /// Returns the root of X power
        /// </summary>
        public static double SqrtX(double Pow, double X)
        {
            return System.Math.Pow(X, 1/Pow);
        }
    }
}
