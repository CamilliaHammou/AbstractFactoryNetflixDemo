using NetflixAbstractFactoryDemo.Interfaces;
using NetflixAbstractFactoryDemo.Mobile;

namespace NetflixAbstractFactoryDemo.Factories
{
    public class MobilePlatformFactory : IStreamingPlatformFactory
    {
        public IUserInterface CreateUserInterface()
        {
            return new MobileUI();
        }
        
        public IVideoPlayer CreateVideoPlayer()
        {
            return new MobileVideoPlayer();
        }
        
        public IRecommendationEngine CreateRecommendationEngine()
        {
            return new MobileRecommendationEngine();
        }
    }
}
