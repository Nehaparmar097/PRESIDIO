using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStoreManagmentModelLibrary;

namespace VideoStoreManagmentBLLibrary
{
    public interface IVideoService
    {
        void AddVideo(Video video);
        List<Video> GetAllVideos();
        object GetVideoById(int videoId);
        bool IsVideoAvailable(int videoId);
        void RentVideo(int videoId);
        void ReturnVideo(int videoId);
    }
}
