
#region DateTimeExample 1

//DateTime now = DateTime.Now;
//Console.WriteLine("Hazirki vaxt ve saat " + now);

//int month = int.Parse(Console.ReadLine());
//while (true)

//{
//    if (month == now.Month)
//    {
//        Console.WriteLine("Tarix duzgun daxil olundu..");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Ay yanlish daxil olundu..");
//        break;
//    }
//}







#endregion

#region DateTimeExample 2

//DateTime now = DateTime.Now;
//Console.WriteLine("Hazirki vaxt ve saat " + now);

//int year = now.Year;
//int month = now.Month;
//int day = now.Day;
//int hour = now.Hour;
//int minute = now.Minute;
//int second = now.Second;

//Console.WriteLine($":il {year}, Ay: {month}, Gün: {day}, Saat: {hour}, Deqiqe: {minute}, Saniye: {second}");


#endregion

#region DateTimeExample 3

//Console.ForegroundColor = ConsoleColor.Green;

//Console.WriteLine("Telebe melumat sistemi -- Telebenin infosu");

//Console.ResetColor();

//Console.ForegroundColor= ConsoleColor.Red;

//Console.WriteLine("Telebenin adini qeyd edin: ");

//Console.ResetColor();   
//string telebeAdi = Console.ReadLine();

//Console.WriteLine("Gunu yazin: ");
//string day = Console.ReadLine();

//Console.WriteLine("Ders Saatini Yazin: ");
//string saat = Console.ReadLine();

//DateTime songiristarixi = DateTime.Now;

//string melumatbazasi = "Telebe_Melumat_Sistemi_Infosu.txt";
//using (StreamWriter telebeninInfosu = new(melumatbazasi)) // StreamWriter metodun internetdən araşdırıb yazdım..
//{
//    telebeninInfosu.WriteLine($"TelebeninAdi: {telebeAdi}");
//    telebeninInfosu.WriteLine($"Gün: {day}");
//    telebeninInfosu.WriteLine($"Ders Saati: {saat}");
//    telebeninInfosu.WriteLine($"Sisteme son giris tarixi: {songiristarixi}");
//    telebeninInfosu.WriteLine();
//}
//Console.ForegroundColor=ConsoleColor.Cyan;
//Console.WriteLine("Telebenin datasi yaradildi..");
//Console.ResetColor();
//// Yazılmış tələbənin məlumatları DataTime`in içindəki Debug-Bin-net6.0-TelebeninMelumatlariİnfosu.Txt faylinin içərsinə yazılır avtamatik olaraq...

#endregion

