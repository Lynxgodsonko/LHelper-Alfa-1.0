//CustomExceptions.cs

using LHelper;
using System;

namespace LHelper.ErrorCatch
{
    public abstract class CustomExceptions : Exception
    {
        protected CustomExceptions(string message) : base(message)
        {
        }
    }
    public class ZeroDivisionError : CustomExceptions
    {
        public ZeroDivisionError() : base(Ui.OutputMessages.ZeroDivisionMessage()) { }
    }
    public class InvalidPowError : CustomExceptions
    {
        public InvalidPowError() : base(Ui.OutputMessages.InvalidPowMessage()) { }
    }
    public class LTypeError : CustomExceptions
    {
        public LTypeError() : base(Ui.OutputMessages.TypeErrorMessage()) { }
    }
    public class CheckError
    {
        public static void DivisionControl(double number)
        {
            if (Backend.MathCheckFunctions.IsZero(number))
            {
                throw new ZeroDivisionError();
            }
        }
        public static void PowControl(int number)
        {
            if(!Backend.MathCheckFunctions.Positive(number))
            {
                throw new InvalidPowError();
            }
        }
        public static void TypeControl(object o, Type type)
        {
            if (o.GetType() != type) 
            {
                throw new LTypeError();
            }
        }
    }
}
