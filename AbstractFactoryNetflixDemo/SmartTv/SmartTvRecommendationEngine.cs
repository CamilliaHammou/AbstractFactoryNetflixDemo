using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.SmartTv
{
    public class SmartTvRecommendationEngine : IRecommendationEngine
    {
        public void LoadRecommendations(string userId)
        {
            Console.WriteLine($"Smart TV Recommendations: Loading family-oriented recommendations for TV user {userId}");
        }
        
        public void DisplaySuggestions()
        {
            Console.WriteLine("Smart TV Recommendations: Showing large preview thumbnails in carousel format for TV");
        }
        
        public void TrackUserInteraction(string contentId)
        {
            Console.WriteLine($"Smart TV Recommendations: Tracking group viewing patterns for content {contentId} on TV");
        }
    }
}
