using System;
using System.Reflection;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Dvd : Storage, IBackup
    {
        private float r_w_speed;
        private float media_size;
        private float memory;
        private bool two_sided;

        public float R_W_Speed
        { 
            get { return r_w_speed; }
            set
            {
                if(value > 0) { r_w_speed = value;}
                else throw new ApplicationException("Read Write Speed  Error...");
            }
        }

        public bool Two_Sided { get;set; }

        public float Memory
        {
            get
            {
                if (two_sided) return 9;
                else return 4.7f;
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
            Console.WriteLine($"DVD {size} copy {size} deqiqeye hazir olacaq");
        }

        public void PrintDeviceİnfo()
        {
            Console.WriteLine($"Media Name: {this.MediaName}\nR/W Speed: {this.R_W_Speed}\nModel: {this.Model}\nTwo Sided: {this.Two_Sided}\nMemory: {this.Memory}\n" +
                $"Media Size: {this.Media_Size}\nFree Memory: {this.Free_Memory}");
        }

        public Dvd() : base()
        {
            R_W_Speed = 50;
            Media_Size = 0;
            Two_Sided = false;
        }

        public Dvd(string name , string model,bool tw0_sided , float media_size , float speed) : base(name, model)
        {
            R_W_Speed = speed;
            Media_Size = media_size;
            Two_Sided = tw0_sided;
        }
    }
}
