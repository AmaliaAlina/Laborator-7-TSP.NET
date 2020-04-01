using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class Media : InterfaceMedia
    {
        public bool CreateMedia(string pathName)
        {
            Media media = new Media();
            return media.CreateMedia(pathName);
        }

        public bool DeleteMedia(string mediaPath)
        {
            Media media = new Media();
            return media.DeleteMedia(mediaPath);
        }

        public bool DeleteMedia(Media media)
        {
            Media mediaNew = new Media();
            return mediaNew.DeleteMedia(media);
        }

        public List<Media> GetAllMedia()
        {
            Media media = new Media();
            return media.GetAllMedia();
        }

        public List<Media> GetAllMedia(int mediaId)
        {
            Media media = new Media();
            return media.GetAllMedia(mediaId);
        }

        public List<Media> GetAllMedia(string mediaName)
        {
            Media media = new Media();
            return media.GetAllMedia(mediaName);
        }

        public Media GetMedia(string mediaPath)
        {
            Media media = new Media();
            return media.GetMedia(mediaPath);
        }

        public Media GetMedia(int mediaID)
        {
            Media media = new Media();
            return media.GetMedia(mediaID);
        }

        public int GetMediaId(string mediaPath)
        {
            Media media = new Media();
            return media.GetMediaId(mediaPath);
        }

        public bool UpdateMedia(Media newMedia)
        {
            Media media = new Media();
            return media.UpdateMedia(newMedia);
        }
    }
}
