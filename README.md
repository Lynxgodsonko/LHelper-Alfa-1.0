# LHelper-Alfa-1.0
LHelper

LHelper, C# projeleri için yazılmış hafif, modüler bir helper (yardımcı) kütüphanedir.

Bu yapı:

Dil değildir
C# projelerinde direkt kullanılabilir
Prelude mantığıyla (System.Console gibi) çalışır
Hata yönetimi, matematik, string, IO, type check işleri hazır gelir

Mantık şu:
Altyapıyı sağlam kur, üstüne istediğini yaz.

PROJE YAPISI
LHelper
│
├── Backend
│   └── BackendFunctions.cs
│
├── Ui
│   └── UiFunctions.cs
│
├── ErrorCatch
│   └── CustomExceptions.cs
│
├── MainFunctions
│   └── MainFunctions.cs
│
├── Prelude
│   └── Prelude.cs
│
├── LHelper.csproj
├── App.config
└── Properties

Backend (LHelper.Backend)
MathActionFunctions

Temel matematik işlemleri.

Add(a,b)	Toplama
Subtract(a,b)	Çıkarma
Multiply(a,b)	Çarpma
Divide(a,b)	Bölme
Mod(a,b)	Mod alma
Pow(a,b)	Üs alma (manuel loop, negatif yok)
MathCheckFunctions

Matematik kontrolleri (guard mantığı).

Fonksiyon	Açıklama
IsZero(x)	Sıfıra çok yakın mı
IsEven(x)	Çift mi
Positive(x)	Pozitif mi
PositiveORZero(x)	≥ 0 mı
StringFunctions

String yardımcıları;
Up(str)	Büyük harf
Low(str)	Küçük harf
Length(str)	Uzunluk
Strip(str)	Trim
IsEmpty(str)	Null veya boş
IsAlpha(str)	Sadece harf
IsNumeric(str)	Sayıya çevrilebilir mi
LogicSystemFunctions

Sistemle ilgili işler;
Exit()	Programı kapat
Clear()	Console temizle
Pause()	Tuş bekle
IntRandom(min,max)	Random int
Sleep(ms)	Thread sleep
CheckingANDConversion

Type check ve dönüşüm.
TryParse falan yok → kullanıcı sorumluluğu.

IsInt(o)	int mi
IsDouble(o)	double mı
IsBool(o)	bool mu
IsString(o)	string mi
IsNull(o)	null mı
ToInt(o)	int’e çevir
ToDouble(o)	double’a çevir
ToString(o)	string’e çevir
ToLongInt(o)	long’a çevir



UI (LHelper.Ui)
OutputMessages

Merkezi hata mesajları.

ZeroDivisionMessage()	0’a bölme
InvalidPowMessage()	Negatif üs
TypeErrorMessage()	Tip uyuşmazlığı
CommonErrorMessage()	Genel hata
LScIO

Console IO işleri.

Print(x)	Yazdır
Input(text)	String input
IntInput(text)	Güvenli int input
Doubleinput(text)	Güvenli double input
InputFunctions

Standart input helper’ları.

GetFirstNumber()	İlk sayı
GetSecondNumber()	İkinci sayı
GetIntNumber()	Tamsayı


ErrorCatch (LHelper.ErrorCatch)
CustomExceptions

Tüm özel hataların base class’ı.

Özel Hatalar
Hata	Açıklama
ZeroDivisionError	0’a bölme
InvalidPowError	Negatif üs
LTypeError	Tip uyuşmazlığı
CheckError

Guard / kontrol sınıfı.

Fonksiyon	Açıklama
DivisionControl(x)	0’a bölme kontrol
PowControl(x)	Negatif üs kontrol
TypeControl(o, type)	Tip kontrol

Bu sistem LScript interpreter için direkt hazır.

MainFunctions
Yüksek seviye operasyon örnekleri.

BinaryOperation()	İki operandlı işlem
DivideOperation()	Guard’lı bölme
ModOperation()	Guard’lı mod
PowOperation()	Guard’lı üs
Prelude (LHelper.Prelude)

Kullanıcıya açık API
System.Console neyse, burası odur.

using LHelper.Prelude;

İçerik

IO

Matematik

String

Random

Type check

Conversion

Kullanıcı ister:

using LHelper;


yapar, her şeye dalar.
İster sadece Prelude kullanır.

Zorlama yok, kilit yok.
