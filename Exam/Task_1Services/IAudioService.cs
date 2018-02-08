namespace Task_1Services
{
    public interface IAudioService
    {
        AudioInfo Info{ get; }
        void Play();
        void Load(string file);
        void Save(string path);
    }
}
