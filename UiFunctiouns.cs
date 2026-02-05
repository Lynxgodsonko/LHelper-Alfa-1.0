//UiFunctions.cs

using System;
namespace LHelper.Ui
{
    public class OutputMessages
    {

        public static string ZeroDivisionMessage() => $"[ERROR] \nZeroDivisionError: Bir sayıyı sıfıra bölemezsiniz. \nHata kodu \"CannotBeDivideByZero\" \n tür: kullanıcı taraflı hata\nhata tarihi {DateTime.Now}";       
        public static string CommonErrorMessage() => $"[ERROR] \nCommonError: Bir hata oluştu, tekrar deneyin veya üretici ile iletişime geçin. \nbu hata sistem yada kullanacı kaynaklı olabilir. \nhata tarihi {DateTime.Now}";
        public static string InvalidPowMessage() => $"[ERROR] \nInvalidPowError: Negatif üs alınamaz, lütfen sonra tekrar deneyin. Hata kodu \"CantGetNegativePow\" \n tür: kullanıcı taraflı hata\nhata tarihi {DateTime.Now}";
        public static string TypeErrorMessage() => $"[ERROR] \nTypeError: İstenilen ve verilen tip uyuşmadı, lütfen tekrar deneyin. \nHata kodu \"InvalidTypeLogin\" \n tür: kullanıcı taraflı hata\nhata tarihi {DateTime.Now}";
    }
    public class LScIO
    {
        public static void Print(Object Text) => Console.WriteLine(Text);
        public static string Input(string Text)
        {
            Console.Write(Text);
            return Console.ReadLine();
        }
        public static int IntInput(string Text)
        {
            int number;
            Console.Write(Text);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                LScIO.Print("lütfen sadece tam sayı girin");
            }
            return number;
        }
        public static double Doubleinput(string Text)
        {
            double number;
            Console.Write(Text);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                LScIO.Print("lütfen sadece ondalıklı sayı girin");
            }
            return number;
        }
    }
    public class InputFunctions
    {
        public static double GetFirstNumber()
        {
            return LScIO.Doubleinput("Lütfen ilk sayıyı giriniz: ");
        }
        public static double GetSecondNumber()
        {
            return LScIO.Doubleinput("Lütfen ikinci sayıyı giriniz: ");
        }
        public static int GetIntNumber()
        {
            return LScIO.IntInput("Lütfen bir tamsayı giriniz: ");
        }
    }
}
