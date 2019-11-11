using System;

namespace HatService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HatService starting..");
            HatService _service = new HatService();
            Console.WriteLine("Service ready");
            while(_service.isRunning){
                //Looping forever, or at least for a good while
            }
            
        }
    }
}
