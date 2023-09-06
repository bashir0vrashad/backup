namespace ConsoleApp1
{

    internal interface IBackup
    {
        void Copy(int size);
        void PrintDeviceİnfo();
        float Media_Size { get; set; }
        float Free_Memory { get;  }
    }



    internal abstract class Storage
    {
        private string media_name;
        private string model;

        public string MediaName
        {
            get { return media_name; }
            set 
            {
                if (value.Length >= 3) media_name = value;
                else throw new ApplicationException("Media Name Error...");
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length >= 3) model = value;
                else throw new ApplicationException("Model Error...");
            }
        }

        public Storage()
        {
            MediaName = "NULL";
            Model = "NULL";
        }

        public Storage(string name, string model)
        {
            MediaName =name;
            Model = model;
        }
    }
}
