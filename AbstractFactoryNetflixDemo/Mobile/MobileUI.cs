using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.Mobile
{
    public class MobileUI : IUserInterface
    {
        public void DisplayContent()
        {
            Console.WriteLine("Mobile UI: Showing compact list layout optimized for mobile screens with touch navigation");
        }
        
        public void NavigateMenu()
        {
            Console.WriteLine("Mobile UI: Using touch gestures and swipe navigation for mobile");
        }
        
        public void ShowSettings()
        {
            Console.WriteLine("Mobile UI: Displaying compact settings menu with mobile-specific options (data usage, download quality)");
        }
    }
}
