using VideoStoreManagmentModelLibrary;
namespace VideoStoreManagmentDALLibrary
{
    /// <summary>
    /// for creating a collection of video for doing crud operation on video
    /// </summary>
    public class VideoStoreRepo : IRepository<int, Video>
    {
        private readonly Dictionary<int, Video> _videos;

        public VideoStoreRepo()
        {
            _videos = new Dictionary<int, Video>();
        }

        public Video Add(Video item)
        {
            if (_videos.ContainsValue(item))
            {
                return null;
            }
            _videos.Add(item.VideoId, item);
            return item;
        }

        public Video Delete(int key)
        {
            if (_videos.ContainsKey(key))
            {
                var video = _videos[key];
                _videos.Remove(key);
                return video;
            }
            return null;
        }

        public Video Get(int key)
        {
            return _videos.ContainsKey(key) ? _videos[key] : null;
        }

        public List<Video> GetAll()
        {
            return _videos.Values.ToList();
        }

        public Video Update(Video item)
        {
            if (_videos.ContainsKey(item.VideoId))
            {
                _videos[item.VideoId] = item;
                return item;
            }
            return null;
        }
    }
}

