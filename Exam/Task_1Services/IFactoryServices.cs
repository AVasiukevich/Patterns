namespace Task_1Services
{
    public interface IFactoryServices
    {
        IAudioService CreateAudioService();
        IMessageBoxService CreateMessageBoxService();
        IFileService CreateFileService();
    }
}
