namespace Task_1Services
{
    public class FactoryServices : IFactoryServices
    {
        public IAudioService CreateAudioService()
        {
            return AudioService.GetInstance();
        }

        public IFileService CreateFileService()
        {
            return FileService.GetInstance();
        }

        public IMessageBoxService CreateMessageBoxService()
        {
            return MessageBoxService.GetInstance();
        }
    }
}
