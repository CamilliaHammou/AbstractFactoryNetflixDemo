using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.SmartTv
{
    public class SmartTvUI : IUserInterface
    {
        public void DisplayContent()
        {
            Console.WriteLine("Smart TV UI: Showing grid layout optimized for TV screens with focused navigation");
        }
        
        public void NavigateMenu()
        {
            Console.WriteLine("Smart TV UI: Using D-pad navigation style for TV remote control");
        }
        
        public void ShowSettings()
        {
            Console.WriteLine("Smart TV UI: Displaying simplified settings menu for TV interface");
        }
    }
}
