
//int i = 0;
//while(i <= 10){
//    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
//    i++;
//}


//adım değişkeni tanımladık her döngü döndüğünde 1 artıyor ve ekrana yazdırılıyor.
//int adım = 1;

//while(adım <= 20)
//{
//    Console.WriteLine(adım);
//    adım++;
//}

//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

//int adım = 1;
//while (adım <=20)
//{

//    if (adım %2 == 0)
//    {
//        Console.WriteLine("çift sayi: "+ adım);

//    }
//    adım++;

//}

//50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

//int adim =50;
//int sayi = 0;
//while(adim <= 150)
//{
//    sayi = adim + sayi;
//    adim++;

//}
//Console.WriteLine("toplamları: " + sayi);


//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int i = 1;
int tekSayi = 0;
int ciftSayi = 0;
while (i <= 120)
{
    if(i % 2 == 0)
    {
        ciftSayi = ciftSayi + i;
        
    }
    else
    {
        tekSayi = tekSayi + i;
       
    }
    i++;
}
Console.WriteLine("tek sayi: " + tekSayi);
Console.WriteLine("cift sayi: " + ciftSayi);