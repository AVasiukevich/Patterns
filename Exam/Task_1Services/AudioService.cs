using System;
using System.IO;
using System.Media;

namespace Task_1Services
{
    internal class AudioService : IAudioService
    {
        private static readonly Lazy<AudioService> _lazy = new Lazy<AudioService>(() => new AudioService());
        private SoundPlayer _player;
        private AudioInfo _info;

        public AudioInfo Info
        {
            get { return _info; }
        }

        private AudioService()
        {
            _player = new SoundPlayer();
        }
        public static AudioService GetInstance()
        {
            return _lazy.Value;
        }

        public void Play()
        {
            _player.Play();
        }
        public void Load(string file)
        {
            _info = new AudioInfo(file);
            _player.Stream = FileService.GetInstance().OpenFile(file);
            _player.Load();
        }
        public void Save(string path)
        {
            var bytes = new byte[_player.Stream.Length];
            _player.Stream.Read(bytes, 0, bytes.Length);
            FileService.GetInstance().SaveFile(bytes, path);
        }
    }
    public class AudioInfo
    {
        public string FullName { get; }
        public string Extension { get; }
        public string Name { get; }
        public long Size { get; }

        public AudioInfo(string path)
        {
            var fileInfo = new FileInfo(path);
            FullName = fileInfo.FullName;
            Extension = fileInfo.Extension;
            Name = fileInfo.Name;
            Size = fileInfo.Length;
        }
    }
}
