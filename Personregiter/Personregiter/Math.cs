using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Math
    {
        // PLUS +
        public int Plus(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        public float Plus(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }
        public string Plus(string number1, string number2)
        {
            Double intNumber1 = double.Parse(number1);
            double intNumber2 = double.Parse(number2);
            double sum = intNumber1 + intNumber2;
            string stringSum = sum.ToString();
            return stringSum;
        }

        // MINUS - 
        public int Minus(int number1, int number2)
        {
            int sum = number1 - number2;
            return sum;
        }
        public float Minus(float number1, float number2)
        {
            float sum = number1 - number2;
            return sum;
        }
        public string Minus(string number1, string number2)
        {
            double intNumber1 = double.Parse(number1);
            double intNumber2 = double.Parse(number2);
            double sum = intNumber1 - intNumber2;
            string stringSum = sum.ToString();
            return stringSum;
        }
        // GANGE *
        public int Gange(int number1, int number2)
        {
            int sum = number1 * number2;
            return sum;
        }
        public float Gange(float number1, float number2)
        {
            float sum = number1 * number2;
            return sum;
        }
        public string Gange(string number1, string number2)
        {
            double intNumber1 = double.Parse(number1);
            double intNumber2 = double.Parse(number2);
            double sum = intNumber1 * intNumber2;
            string stringSum = sum.ToString();
            return stringSum;
        }
        // DIVIDER /
        public int Divider(int number1, int number2)
        {
            int sum = number1 / number2;
            return sum;
        }
        public float Divider(float number1, float number2)
        {
            float sum = number1 / number2;
            return sum;
        }
        public string Divider(string number1, string number2)
        {
            double intNumber1 = double.Parse(number1);
            double intNumber2 = double.Parse(number2);
            double sum = intNumber1 / intNumber2;
            string stringSum = sum.ToString();
            return stringSum;
        }
        // Potens
        public float Potens(float number1, float number2)
        {
            float sum = MathF.Pow(number1, number2);
            return sum;
        }
        public int Potens(int number1, int number2)
        {
            float floatSum = MathF.Round(MathF.Pow(number1, number2));
            int sum = Convert.ToInt32(floatSum);
            return sum;
        }
        public string Potens(string number1, string number2)
        {
            float floatNumb1 = float.Parse(number1);
            float floatNumb2 = float.Parse(number2);
            float floatSum = MathF.Pow(floatNumb1, floatNumb2);
            string sum = floatSum.ToString();
            return sum;
        }
        
        


    }
}
