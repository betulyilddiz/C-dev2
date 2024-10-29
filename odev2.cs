/*
//girilen sayının tek mi çift mi olduğunu gösteren C# kodu
//if-else yapısıyla yaz

Console.WriteLine("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çift");
}

else
{
    Console.WriteLine("Girdiğiniz sayı tek");
}
*/




/*
// 1 den 10 a kadar olan sayıları ekrana yazı olarak yazdıran C# kodu(örnek: 1 girildiğinde ekrana bir yazılsın)
//switch yapısıyla yaz

Console.WriteLine("1-10 arasında bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
switch (sayi)
{
    case 1:
     Console.WriteLine("bir");
     break;


    case 2:
     Console.WriteLine("iki");
     break;


    case 3:
     Console.WriteLine("üç");
     break;


    case 4:
     Console.WriteLine("dört");
     break;


    case 5:
     Console.WriteLine("beş");
     break;


    case 6:
     Console.WriteLine("altı");
     break;

    case 7:
     Console.WriteLine("yedi");
     break;


    case 8:
     Console.WriteLine("sekiz");
     break;


    case 9:
     Console.WriteLine("dokuz");
     break;


    case 10:
     Console.WriteLine("on");
     break;


    default:
     Console.WriteLine("Lütfen sadece 1-10 arasında bir sayı giriniz... ");
     break;  
}
*/





/*
//10-20 20-30 30-40  arası sıcaklık durumlarına göre ekrana (normal-sıcak-çok sıcak )uyarısı veren C# kodu
//if - else if - else yapısıyla yaz 

Console.WriteLine("10-40 arasında bir sıcaklık değeri giriniz: ");
int sicaklik = Convert.ToInt32(Console.ReadLine());
if (sicaklik >=10 && sicaklik<=20)
{
    Console.WriteLine("Normal");
}

else if (sicaklik >=21 && sicaklik <= 30)
{
    Console.WriteLine("Sıcak");
}

else if (sicaklik >=31 && sicaklik <= 40)
{
    Console.WriteLine("Çok sıcak");
}

else
{
    Console.WriteLine("Lütfen sadece 10-40 arasında bir sıcaklık değeri giriniz...");
}
*/



/*
//kullanıcı adı: admin ve şifre:Admin_32453@ olduğunda giriş başarısızsa başarısız uyarısı veren C# kodu

Console.WriteLine("Kullancı Adı: ");
string kullanici_adi = Console.ReadLine();

Console.WriteLine("Şifre: ");
string sifre = Console.ReadLine();

if (kullanici_adi == "admin" && sifre == "Admin_32453@")
{
    Console.WriteLine("Giriş başarıyla yapıldı");
}

else
{
    Console.WriteLine("Hatalı giriş");
}  
*/



