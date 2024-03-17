using static System.Net.Mime.MediaTypeNames;

Console.Write("Teslimat Adresinin Uzaklığını KM Cinsinden Giriniz : ");
double kmSayac = Convert.ToDouble(Console.ReadLine());
Console.Write("Müşterinin Sepet Tutarını TL Cinsinden Giriniz : ");
double sepetTutari = Convert.ToDouble(Console.ReadLine());
Double totalfiyat, sepet, kmKatsayi, kmUcret, indirim;
indirim = 0;
kmKatsayi = 9;
kmUcret = 0;

if (sepetTutari >= 20)
{
    if (sepetTutari >=100 && sepetTutari < 200)
    {
        indirim = (sepetTutari * 10)/100;
    }
    else if (sepetTutari >= 300 && sepetTutari < 400)
    {
        indirim = (sepetTutari * 15) / 100;
    }
    else if (sepetTutari >= 500)
    {
        indirim = (sepetTutari * 20) / 100;
    }


    if (kmSayac <= 1 && kmSayac > 0)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else if (kmSayac <= 2 && kmSayac > 1)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz."); ;
    }
    else if (kmSayac <= 3 && kmSayac > 2)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else if (kmSayac <= 4 && kmSayac > 3)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else if (kmSayac <= 5 && kmSayac > 4)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else if (kmSayac <= 6 && kmSayac > 5)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else if (kmSayac <= 7 && kmSayac > 6)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else if (kmSayac <= 8 && kmSayac > 7)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else if (kmSayac <= 9 && kmSayac > 8)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL.");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else if (kmSayac <= 10 && kmSayac > 9)
    {
        kmUcret = kmSayac * kmKatsayi;
        sepet = sepetTutari - indirim + kmUcret;
        Console.WriteLine("Toplam Ücret : " + sepet + " TL. ");
        Console.WriteLine(" ");
        Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz.");
    }
    else
    {
        Console.Write("Marketimiz En Fazla 10 Kilometre Mesafeye Kadar Teslimat Yapabilmektedir.");
    }

}
else
{
    Console.WriteLine("Sepet Alt Limiti 20 TL'dir.");
}
    Console.ReadLine();



