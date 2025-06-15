using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.Mobile
{
    public class MobileVideoPlayer : IVideoPlayer
    {
        public void PlayContent(string contentId)
        {
            Console.WriteLine($"Mobile Player: Playing content {contentId} optimized for mobile viewing with data saving");
        }
        
        public void AdjustQuality(string quality)
        {
            Console.WriteLine($"Mobile Player: Adjusting to {quality} quality - adapting based on network conditions (WiFi/Cellular)");
        }
        
        public void ShowSubtitles(bool enable)
        {
            Console.WriteLine(enable 
                ? "Mobile Player: Displaying subtitles with mobile-optimized font size and position" 
                : "Mobile Player: Subtitles disabled");
        }
    }
}
