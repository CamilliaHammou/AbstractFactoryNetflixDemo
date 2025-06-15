using NetflixAbstractFactoryDemo.Interfaces;
using NetflixAbstractFactoryDemo.SmartTv;

namespace NetflixAbstractFactoryDemo.Factories
{
    public class SmartTvPlatformFactory : IStreamingPlatformFactory
    {
        public IUserInterface CreateUserInterface()
        {
            return new SmartTvUI();
        }
        
        public IVideoPlayer CreateVideoPlayer()
        {
            return new SmartTvVideoPlayer();
        }
        
        public IRecommendationEngine CreateRecommendationEngine()
        {
            return new SmartTvRecommendationEngine();
        }
    }
}
