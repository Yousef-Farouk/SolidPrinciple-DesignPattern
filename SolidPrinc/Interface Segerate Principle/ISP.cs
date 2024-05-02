using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Interface_Segerate_Principle
{
    public interface IAudioPlayer
    {
        public void PlayAudio();
        public void LoadMedia(string filepath);

    }

    public interface IVideoPlayer
    {
        public void PlayVideo();
        public void DsiplaySubtitles();
        public void LoadMedia(string filepath);

    }

   


    public class AudioPlayer : IAudioPlayer
    {
        public void PlayAudio()
        {


        }

        public void LoadMedia(string filepath)
        {


        }
    }

    public class VideoPlayer : IVideoPlayer
    {
       

        public void PlayVideo()
        {

        }

        public void DsiplaySubtitles()
        {


        }

        public void LoadMedia(string filepath)
        {


        }
    }
}
