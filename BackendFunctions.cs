//backendfunctions.cs

using System;
using System.Linq;


namespace LHelper.Backend
{
    public class MathActionFunctions
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b) => a / b;
        public static double Mod(double a, double b) => a % b;
        public static double Pow(double a, int b)
        {
            double result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

    }
    public class MathCheckFunctions
    {
        public static bool IsZero(double number)
        {
            return Math.Abs(number) <= 0.00000000000001;
        }
        public static bool IsEven(int a) => a % 2 == 0;
        public static bool Positive(double a) => a > 0;
        public static bool PositiveORZero(double a) => a >= 0;
    }
    public class StringFunctions
    {
        public static string Up(string Target) => Target.ToUpper();
        public static string Low(string Target) => Target.ToLower();
        public static int Length(string Target) => Target.Length;
        public static string Strip(string Target) => Target.Trim();
        public static bool IsEmpty(string Target) => String.IsNullOrEmpty(Target);
        public static bool IsAlpha(string Target) => Target.All(char.IsLetter);
        public static bool IsNumeric(string Target) => double.TryParse(Target, out _);
    }
    public class LogicSystemFunctions
    {
        static Random rnd = new Random();
        public static void Exit() => Environment.Exit(0);
        public static void Clear() => Console.Clear();
        public static void Pause() => Console.ReadKey();
        public static int IntRandom(int min, int max) => rnd.Next(min, max);
        public static void Sleep(int ms) => System.Threading.Thread.Sleep(ms);
    }
    public class CheckingANDConversion
    {
        public static bool IsInt(object o) => o is int;
        public static bool IsDouble(object o) => o is double;
        public static bool IsBool(object o) => o is bool;
        public static bool IsString(object o) => o is string;
        public static bool IsNull(object o) => o is null;

        public static string ToString(object o) => Convert.ToString(o);
        public static int ToInt(object o) => Convert.ToInt32(o);
        public static double ToDouble(object o) => Convert.ToDouble(o);
        public static long ToLongInt(object o) => Convert.ToInt64(o);
    }
}
