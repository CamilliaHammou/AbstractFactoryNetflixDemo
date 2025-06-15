namespace NetflixAbstractFactoryDemo.Interfaces
{
    public interface IStreamingPlatformFactory
    {
        IUserInterface CreateUserInterface();
        IVideoPlayer CreateVideoPlayer();
        IRecommendationEngine CreateRecommendationEngine();
    }
}
