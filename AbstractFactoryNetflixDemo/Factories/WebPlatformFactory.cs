using NetflixAbstractFactoryDemo.Interfaces;
using NetflixAbstractFactoryDemo.Web;

namespace NetflixAbstractFactoryDemo.Factories
{
    public class WebPlatformFactory : IStreamingPlatformFactory
    {
        public IUserInterface CreateUserInterface()
        {
            return new WebUI();
        }
        
        public IVideoPlayer CreateVideoPlayer()
        {
            return new WebVideoPlayer();
        }
        
        public IRecommendationEngine CreateRecommendationEngine()
        {
            return new WebRecommendationEngine();
        }
    }
}
