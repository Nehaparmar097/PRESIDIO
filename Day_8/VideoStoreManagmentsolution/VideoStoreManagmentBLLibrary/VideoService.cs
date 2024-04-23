using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStoreManagmentModelLibrary;

namespace VideoStoreManagmentBLLibrary
{
    public class VideoService : IVideoService
    {
        private readonly List<Video> videos;

        public VideoService(List<Video> videos)
        {
            this.videos = videos;
        }

        public void AddVideo(Video video)
        {
            videos.Add(video);
        }

        public List<Video> GetAllVideos()
        {
            return videos;
        }

        public object GetVideoById(int videoId)
        {
            throw new NotImplementedException();
        }

        public bool IsVideoAvailable(int videoId)
        {
            throw new NotImplementedException();
        }

        public void RentVideo(int videoId)
        {
            throw new NotImplementedException();
        }

        public void ReturnVideo(int videoId)
        {
            throw new NotImplementedException();
        }
    }
}
