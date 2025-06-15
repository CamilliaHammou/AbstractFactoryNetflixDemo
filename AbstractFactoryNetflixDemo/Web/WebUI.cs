using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.Web
{
    public class WebUI : IUserInterface
    {
        public void DisplayContent()
        {
            Console.WriteLine("Web UI: Showing responsive layout optimized for web browsers with mouse navigation");
        }
        
        public void NavigateMenu()
        {
            Console.WriteLine("Web UI: Using hover effects and mouse-based navigation for web");
        }
        
        public void ShowSettings()
        {
            Console.WriteLine("Web UI: Displaying full settings panel with advanced options for web interface");
        }
    }
}
