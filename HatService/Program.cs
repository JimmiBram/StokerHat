using System;

namespace HatService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HatService starting..");
            HatServiceInstance _service = new HatServiceInstance();
            Console.WriteLine("Service ready");
            while(_service.IsRunning){
                //Looping forever, or at least for a good while
            }
            
        }
    }
}
