//mainfunctions.cs

using System;
using LHelper.Ui;
using LHelper.Backend;
using LHelper.ErrorCatch;


namespace LHelper.MainFunctions
{
    class MainFunctions
    {
        
        public static void BinaryOperation(Func<double, double, double> Op, Action<double, double> guard = null)
        {
            double a = InputFunctions.GetFirstNumber();
            double b = InputFunctions.GetSecondNumber();
            guard?.Invoke(a, b);
            double result = Op(a, b);
            LScIO.Print(result);
        }
        public static void DivideOperation()
        {
            BinaryOperation(MathActionFunctions.Divide, (a, b) => CheckError.DivisionControl(b));
        }
        public static void ModOperation()
        {
            BinaryOperation(MathActionFunctions.Mod, (a, b) => CheckError.DivisionControl(b));
        }
        public static void PowOperation()
        {
            double a = InputFunctions.GetFirstNumber();
            int b = InputFunctions.GetIntNumber();
            CheckError.PowControl(b);
            double result = MathActionFunctions.Pow(a, b);
            LScIO.Print(result);
        }
    }
}
            