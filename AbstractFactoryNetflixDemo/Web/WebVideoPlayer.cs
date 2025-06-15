using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.Web
{
    public class WebVideoPlayer : IVideoPlayer
    {
        public void PlayContent(string contentId)
        {
            Console.WriteLine($"Web Player: Playing content {contentId} in browser-optimized player with keyboard shortcuts");
        }
        
        public void AdjustQuality(string quality)
        {
            Console.WriteLine($"Web Player: Adjusting to {quality} quality - adapting based on connection speed and browser capabilities");
        }
        
        public void ShowSubtitles(bool enable)
        {
            Console.WriteLine(enable 
                ? "Web Player: Displaying subtitles with customizable web options (font, size, position)" 
                : "Web Player: Subtitles disabled");
        }
    }
}
