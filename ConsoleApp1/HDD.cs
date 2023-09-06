using System;
using System.Reflection;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class HDD : Storage, IBackup
    {
        private bool usb_2;
        private float media_size;
        private float memory;
        public bool Usb_2 { get { return usb_2; } set { usb_2 = value; } }

        public float Memory
        {
            get { return memory; }
            set
            {
                if (value > 0) { memory = value; }
                else throw new ApplicationException("Memory Error...");
            }
        }
        public float Media_Size
        {
            get { return media_size; }
            set
            {
                if (value >= 0 && value <= Memory) { media_size = value; }
                else throw new ApplicationException("Media Size Error...");
            }
        }
        public float Free_Memory { get { return Memory - Media_Size; } }

        public void Copy(int size)
        {
            Console.WriteLine($"HDD {size} copy {size} deqiqeye hazir olacaq");
        }

        public void PrintDeviceİnfo()
        {
            Console.WriteLine($"Media Name: {this.MediaName}\nModel: {this.Model}\nUsb 2: {this.Usb_2}\nMemory: {this.Memory}\n" +
              $"Media Size: {this.Media_Size}\nFree Memory: {this.Free_Memory}");
        }


        public HDD() : base()
        {
            Usb_2= true;
            Memory = 512;
            Media_Size = 0;
        }

        public HDD(string name , string model, float memory , float media, bool usb) : base(name, model)
        {
            Usb_2 = usb;
            Memory = memory;
            Media_Size = media;
        }

    }
}
