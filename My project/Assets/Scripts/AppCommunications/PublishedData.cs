using UnityEngine;
using UnityEngine.Video;

namespace AppCommunications
{
    public struct PublishedData
    {
        public int Id;
        public string Text;
        public VideoClip VideoClip;
        public Texture2D Image;
        public bool Flag;
    }
}
