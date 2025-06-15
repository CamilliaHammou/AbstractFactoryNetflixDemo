using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo.Web
{
    public class WebRecommendationEngine : IRecommendationEngine
    {
        public void LoadRecommendations(string userId)
        {
            Console.WriteLine($"Web Recommendations: Loading varied recommendations for web user {userId} with extensive filtering options");
        }
        
        public void DisplaySuggestions()
        {
            Console.WriteLine("Web Recommendations: Showing medium preview cards in grid format for web with hover details");
        }
        
        public void TrackUserInteraction(string contentId)
        {
            Console.WriteLine($"Web Recommendations: Tracking browser viewing patterns for content {contentId} with detailed analytics");
        }
    }
}
