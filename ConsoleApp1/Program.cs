
using ConsoleApp1;

Flash f1= new Flash();
Flash f2= new Flash("flash","versiya 1",64,14.5f,true);
f1.PrintDeviceİnfo();
f2.PrintDeviceİnfo();


HDD h1 = new HDD();
HDD h2 = new HDD("hdd","versiya 2" ,120,100,true);
Console.WriteLine(h1.Free_Memory);
Console.WriteLine(h2.Usb_2);
