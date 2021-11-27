using System;

namespace Code_book.Design_Pattern.Bridge_Pattern
{
    public interface IEquipment
    {
        void Start();
        void Stop();
    }

    public class Refrigerator : IEquipment
    {
        public void Start()
        {
            Console.WriteLine("Start compressor");
            Console.WriteLine("Start Ice cooling");
        }

        public void Stop()
        {
            Console.WriteLine("stop Ice cooling");
            Console.WriteLine("stop compressor");
        }
    }

    public class Bulb : IEquipment
    {
        public void Start()
        {
            Console.WriteLine("warm up the bulb");
            Console.WriteLine("Glow the bulb");
        }

        public void Stop()
        {
            Console.WriteLine("Swtich off the bulb");
        }
    }
}
