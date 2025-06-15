using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo
{
    public class StreamingApp
    {
        private readonly IUserInterface _ui;
        private readonly IVideoPlayer _player;
        private readonly IRecommendationEngine _recommendations;
        
        public StreamingApp(IStreamingPlatformFactory factory)
        {
            _ui = factory.CreateUserInterface();
            _player = factory.CreateVideoPlayer();
            _recommendations = factory.CreateRecommendationEngine();
        }
        
        public void LaunchApp(string userId)
        {
            Console.WriteLine($"Launching streaming app for user {userId}");
            _ui.DisplayContent();
            _recommendations.LoadRecommendations(userId);
            _recommendations.DisplaySuggestions();
        }
        
        public void WatchContent(string contentId, string quality, bool subtitles)
        {
            Console.WriteLine($"User selected content: {contentId}");
            _player.PlayContent(contentId);
            _player.AdjustQuality(quality);
            _player.ShowSubtitles(subtitles);
            _recommendations.TrackUserInteraction(contentId);
        }
        
        public void OpenSettings()
        {
            Console.WriteLine("Opening settings menu");
            _ui.ShowSettings();
        }
    }
}
