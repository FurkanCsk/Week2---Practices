//Bu pratikte sizden aşağıdaki soruların cevaplarını tek bir kod sayfası olarak yüklemeniz isteniyor. Çözümleri ayrı ayrı yapıp test edip yorum satırı olarak bir sayfaya kopyalayıp yapıştırabilirsiniz. Bu uygulamanın çözümleri Live-Class'ta yapılacak. Örnekler Hafta 1 ve Hafta 2 'nin konularını bir arada içeriyor.

//1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?


using System.Threading.Channels;

Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");



//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.


string text = "patika";
int num = 2;

Console.WriteLine($"string : {text}   integer: {num}");



//3 - Rastgele bir sayı üretip , ekrana yazdırınız.


Random rnd = new Random();
int rndnum = rnd.Next(100);
Console.WriteLine($"Rastgele üretilen sayı : {rndnum}");



//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.


Random rnd2 = new Random();
int random2 = rnd2.Next(100);
int mod = random2 % 3;
Console.WriteLine($"Rastgele üretilen sayı : {random2} , 3'e bölümünden kalan : {mod}");


//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.


Console.WriteLine("Lütfen yaşınızı giriniz.");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}



//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem");
}



//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("Lütfen birinci metini giriniz.");
string firstString = Console.ReadLine();
Console.WriteLine("Lütfen ikinci metini giriniz.");
string secondString = Console.ReadLine();

string tempString = firstString;
firstString = secondString;
secondString = tempString;

Console.WriteLine($"Girilen birinci metin : {firstString}\nGirilen ikinci metin : {secondString}");


//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.


static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();



//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.


static int SumTwoNumber(int number1, int number2)
{
    return number1 + number2;
}
int x = 1;
int y = 8;
Console.WriteLine("İki sayının toplamı : " + SumTwoNumber(x, y));




//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.


Console.WriteLine("Lütfen true ya da false değeri giriniz.");
string input = Console.ReadLine();
string result = BooleanCalc(input);
Console.WriteLine("Sonuç : " + result);
static string BooleanCalc(string input)
{
    bool booleanResult;
    if (bool.TryParse(input, out booleanResult))
    {
        return booleanResult.ToString();
    }
    else
    {
        return "Yanlış bir giriş yaptınız. Lütfen sadece true ya da false girişi yapınız.";
    }
}

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.


Console.WriteLine("Lütfen 3 adet yaş giriniz.");
int age1 = Convert.ToInt32(Console.ReadLine());
int age2 = Convert.ToInt32(Console.ReadLine());
int age3 = Convert.ToInt32(Console.ReadLine());

int maxageresult = MaxAgeCalc(age1, age2, age3);
Console.WriteLine("En yüksek yaş : " + maxageresult);

static int MaxAgeCalc(int age1, int age2, int age3)
{
    int maxage = 0;
    maxage = Math.Max(age1, age2);
    maxage = Math.Max(maxage, age3);
    return maxage;
}


//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.


Console.WriteLine("Lütfen bir sayı giriniz.");
int z = 0;
int k = 0;
while (z < 1)
{
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    int maxNumber = MaxNumberCalc(inputNumber);
    Console.WriteLine($"En yüksek sayı : {maxNumber}");
}

int MaxNumberCalc(int a)
{
    if (k < a)
    {
        k = a;
    }
    return k;
}
//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.


Console.WriteLine("Lütfen iki tane isim giriniz.");
string name1 = Console.ReadLine();
string name2 = Console.ReadLine();
NameChange(ref name1, ref name2);
Console.WriteLine($"Girilen 1.isim : {name1}\nGirilen 2.isim : {name2}");
static void NameChange(ref string name1, ref string name2)
{
    string temp = name1;
    name1 = name2;
    name2 = temp;
}


//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.


Console.WriteLine("Lütfen tek çift kontrolü için bir sayı giriniz.");
int numevenodd = Convert.ToInt32(Console.ReadLine());
bool sonuc = EvenOdd(numevenodd);
if (sonuc)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}

bool EvenOdd(int a)
{
    if (a % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.WriteLine("Lütfen önce hız daha sonra da zaman bilgisini giriniz.");
int speed = Convert.ToInt32(Console.ReadLine());
int time = Convert.ToInt32(Console.ReadLine());
int resultdistance = DistanceCalc(speed, time);
Console.WriteLine($"Verdiğiniz bilgilere göre gidilen yol : {resultdistance}");

int DistanceCalc(int speed, int time)
{
    int distance = speed * time;
    return distance;
}


//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
int r = 3;
double pi = 3.14;

double arearesult = AreaCalc(r, pi);
Console.WriteLine($"Değerleri verilen dairenin alanı : {arearesult}");

double AreaCalc(int r, double pi)
{
    double rpow = Math.Pow(r, 2);
    double area = rpow * pi;
    return area;
}

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.


string stringInput = "Zaman bir GeRi SayIm";
string stringLower = stringInput.ToLower();
string stringUpper = stringInput.ToUpper();
Console.WriteLine($"Girilen ifadenin küçük harfli hali : {stringLower}");
Console.WriteLine($"Girilen ifadenin büyük harfli hali : {stringUpper}");

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string greeting = "    Selamlar   ";
string blanklessgreeting = greeting.Trim();
Console.WriteLine($"İfadenin yeni hali : {blanklessgreeting}");