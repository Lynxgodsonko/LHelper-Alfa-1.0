//pralude.cs

using LHelper.Ui;
using LHelper.Backend;

namespace LHelper.Prelude
{
    public static class Prelude
    {
        public static void Print(object o) => LScIO.Print(o);
        public static string Input(string text) => LScIO.Input(text);
        public static int InputInt(string text) => LScIO.IntInput(text);
        public static double InputDouble(string text) => LScIO.Doubleinput(text);
        public static void Exit() => LogicSystemFunctions.Exit();
        public static void Clear() => LogicSystemFunctions.Clear();
        public static void Pause() => LogicSystemFunctions.Pause();
        public static void SleepMs(int number) => LogicSystemFunctions.Sleep(number);
        public static int RandomNumber(int min, int max) => LogicSystemFunctions.IntRandom(min, max);
        public static double Add(double numberOne, double numberTwo) => MathActionFunctions.Add(numberOne, numberTwo);
        public static double Subtract(double numberOne, double numberTwo) => MathActionFunctions.Subtract(numberOne, numberTwo);
        public static double Multiply(double numberOne, double numberTwo) => MathActionFunctions.Multiply(numberOne, numberTwo);
        public static double Divide(double numberOne, double numberTwo) => MathActionFunctions.Divide(numberOne, numberTwo);
        public static double Mod(double numberOne, double numberTwo) => MathActionFunctions.Mod(numberOne, numberTwo);
        public static double Pow(double number, int Pow) => MathActionFunctions.Pow(number, Pow);
        public static string Up(string Target) => StringFunctions.Up(Target);
        public static string Low(string Target) => StringFunctions.Low(Target);
        public static string Strip(string Target) => StringFunctions.Strip(Target);
        public static int Length(string Target) => StringFunctions.Length(Target);
        public static bool IsAlpha(string Target) => StringFunctions.IsAlpha(Target);
        public static bool IsEmpty(string Target) => StringFunctions.IsEmpty(Target);
        public static bool IsNumeric(string Target) => StringFunctions.IsNumeric(Target);
        public static bool IsNull(object o) => CheckingANDConversion.IsNull(o);
        public static bool IsBool(object o) => CheckingANDConversion.IsBool(o);
        public static bool IsInt(object o) => CheckingANDConversion.IsInt(o);
        public static bool IsString(object o) => CheckingANDConversion.IsString(o);
        public static bool IsDouble(object o) => CheckingANDConversion.IsDouble(o);
        public static int ToInt(object o) => CheckingANDConversion.ToInt(o);
        public static double ToDouble(object o) => CheckingANDConversion.ToDouble(o);
        public static string ToString(object o) => CheckingANDConversion.ToString(o);
        public static long ToLong(object o) => CheckingANDConversion.ToLongInt(o);
    }
}