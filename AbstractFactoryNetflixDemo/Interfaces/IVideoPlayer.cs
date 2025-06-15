namespace NetflixAbstractFactoryDemo.Interfaces
{
    public interface IVideoPlayer
    {
        void PlayContent(string contentId);
        void AdjustQuality(string quality);
        void ShowSubtitles(bool enable);
    }
}
