namespace ConsoleApp1
{
    internal class Flash : Storage, IBackup
    {
        private bool usb_3;
        private float memory;
        private float media_size;


        public bool Usb_3 { get { return usb_3; } set { usb_3 = value; } }

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
            Console.WriteLine($"FLASH {size} copy {size} deqiqeye hazir olacaq");
        }

        public void PrintDeviceİnfo()
        {
            Console.WriteLine($"Media Name: {this.MediaName}\nModel: {this.Model}\nUsb 3: {this.Usb_3}\nMemory: {this.Memory}\n" +
                $"Media Size: {this.Media_Size}\nFree Memory: {this.Free_Memory}");
        }

        public Flash() : base()
        {
            Usb_3 = true;
            Memory = 128;
            media_size = 0;
        }
        public Flash(string name , string model ,float memory , float size , bool usb) :base(name,model)
        {
            Usb_3 = usb;
            Memory = memory;
            media_size = size;
        }

    }
}