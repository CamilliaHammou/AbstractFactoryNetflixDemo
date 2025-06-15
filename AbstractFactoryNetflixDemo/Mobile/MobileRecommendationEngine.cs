using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.Mobile
{
    public class MobileRecommendationEngine : IRecommendationEngine
    {
        public void LoadRecommendations(string userId)
        {
            Console.WriteLine($"Mobile Recommendations: Loading personalized on-the-go recommendations for mobile user {userId}");
        }
        
        public void DisplaySuggestions()
        {
            Console.WriteLine("Mobile Recommendations: Showing small preview tiles in vertical scroll format for mobile");
        }
        
        public void TrackUserInteraction(string contentId)
        {
            Console.WriteLine($"Mobile Recommendations: Tracking mobile viewing patterns and on-the-go preferences for content {contentId}");
        }
    }
}
