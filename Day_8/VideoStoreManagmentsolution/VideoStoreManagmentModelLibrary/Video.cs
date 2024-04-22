namespace VideoStoreManagmentModelLibrary
{
    public class Video
    {
        public int VideoId { get; set; }
      
        public string VideoTitle { get; set; }
        public string VideoGenre { get; set; }
        public string VideoDiscription { get; set; }
        public bool AvailabilityStatus { get; set; }
        public int VideoRent { get; set; }
       
        /// <summary>
        /// getting all  the necesary deatils about video
        /// </summary>
        /// <param name="videoId">a unique id</param>
        /// <param name="videoTitle">tite</param>
        /// <param name="videoGenre"></param>
        /// <param name="videoDiscription"></param>
        /// <param name="availabilityStatus"></param>
        /// <param name="videoRent"></param>
        public Video(int videoId, string videoTitle, string videoGenre, string videoDiscription, bool availabilityStatus, int videoRent)
        {
            VideoId = videoId;
            VideoTitle = videoTitle;
            VideoGenre = videoGenre;
            VideoDiscription = videoDiscription;
            AvailabilityStatus = availabilityStatus;
            VideoRent = videoRent;
        }
    }
}
