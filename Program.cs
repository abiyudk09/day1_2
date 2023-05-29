
//Konversi();
itungan();
Console.ReadKey();

static void itungan()
{
    int mangga, apel, hasil = 0;

    Console.WriteLine("Perhitungan");
    Console.Write("Masukkan Mangga : ");
    mangga = int.Parse(Console.ReadLine()); //atau Convert.ToInt32(Console.ReadLine());
    Console.Write("Masukkan Apel : ");
    apel = int.Parse(Console.ReadLine());

    hasil = mangga + apel;
    Console.WriteLine($"Hasil = {hasil}");
}
static void Konversi ()
{
    Console.WriteLine("Mengkonversi Tipe Data");
    //convert tipe data
    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;
       
   //opsi cara lain 
        /* string strMyInt = Convert.ToString(myInt);
        string strMyInt2 = myInt.ToString();
        Console.WriteLine(strMyInt);
        Console.WriteLine(strMyInt2); */
    
        Console.WriteLine(Convert.ToString(myInt));
        Console.WriteLine(Convert.ToDouble(myInt));
        Console.WriteLine(Convert.ToInt32(myDouble));
        Console.WriteLine(Convert.ToString(myBool));
 
}
