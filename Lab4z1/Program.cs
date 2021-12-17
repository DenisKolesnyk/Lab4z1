using System;

namespace lab4
{

    class Program
    {

        public static void Main(string[] args)
        {

            var comp = new PC("Asus");
            var pr = new Proc("Процесор: Intel Core i7");
            var dr = new HD("Вінчестер:Western Digitals elements ");
            var mem = new RAM("Оперативна пам'ять: Kingston");
            var dv = new Drive("Дисковод : Asus");
            comp.AddSize("Розмір вінчестера: 1 TB");
            comp.DisplaySize();
            comp.CHEK();
            comp.ON();

        }
    }


    class PC
    {
        public PC(string name)
        {
            this.name = name;
        }
        private static string size;
        private string name;
        private Proc processor;
        private RAM memory;
        private HD dr;
        private Drive dv;
        public void setDrive(Drive dv)
        {
            this.dv = dv;
        }
        public void setHD(HD dr)
        {
            this.dr = dr;
        }

        public void setRAM(RAM RAM)
        {
            this.memory = RAM;
        }

        public void setProc(Proc processor)
        {
            this.processor = processor;
        }

        private void Start()
        {
            Console.WriteLine("Комп'ютер увімкнено");
        }
        public bool ON()
        {
            if (size == null) return false;

            return true;
        }



        public bool CHEK()
        {
            if (size == null) return false;

            return true;
        }

        public void AddSize(string newSize)
        {
            size = newSize;
        }
        public void DisplaySize()
        {
            Console.WriteLine(size);
        }
    }
    class HD
    {
        private string name;
        public HD(string name)
        {
            this.name = name;
        }
        public string getInfo()
        {
            return name;
        }
    }
    class RAM
    {
        private string name;
        public RAM(string name)
        {
            this.name = name;
        }
        public string getInfo()
        {
            return name;
        }
    }
    class Proc
    {
        private string name;
        public Proc(string name)
        {
            this.name = name;
        }
        public string getInfo()
        {
            return name;
        }
    }
    class Drive
    {
        private string name;
        public Drive(string name)
        {
            this.name = name;
        }
        public string getInfo()
        {
            return name;
        }
    }
}
