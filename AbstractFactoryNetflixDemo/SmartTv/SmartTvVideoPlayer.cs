using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.SmartTv
{
    public class SmartTvVideoPlayer : IVideoPlayer
    {
        public void PlayContent(string contentId)
        {
            Console.WriteLine($"Smart TV Player: Playing content {contentId} optimized for large screen viewing");
        }
        
        public void AdjustQuality(string quality)
        {
            Console.WriteLine($"Smart TV Player: Adjusting to {quality} quality - supporting up to 4K for TV");
        }
        
        public void ShowSubtitles(bool enable)
        {
            Console.WriteLine(enable 
                ? "Smart TV Player: Displaying subtitles with TV-optimized font size and position" 
                : "Smart TV Player: Subtitles disabled");
        }
    }
}
