namespace NetflixAbstractFactoryDemo.Interfaces
{
    public interface IRecommendationEngine
    {
        void LoadRecommendations(string userId);
        void DisplaySuggestions();
        void TrackUserInteraction(string contentId);
    }
}
