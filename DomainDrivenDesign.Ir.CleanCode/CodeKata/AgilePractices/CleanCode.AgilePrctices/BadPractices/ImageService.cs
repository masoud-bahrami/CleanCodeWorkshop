using System;

namespace CleanCode.AgilePractices.BadPractices
{

    public class ImageService
    {
        private readonly ILogger _logger;

        public ImageService(ILogger logger)
        {
            _logger = logger;
        }

        public byte[] GetImage(string imageId)
        {
            var imageUtility = new ImageUtility();
            ByteArrayResult result = imageUtility.GetImage(imageId);

            if (result.Status == ByteArrayResultStatus.ImageNotFound)
            {
                _logger.LogError($"ImageNotFound - {imageId}");
                return imageUtility.GetNutFoundImageThumbnail();
            }
            else if (result.Status == ByteArrayResultStatus.HasNotAccess)
            {
                _logger.LogError($"HasNotAccess to image - {imageId}");
                return imageUtility.GetNutFoundImageThumbnail();
            }
            else
                return result.Date;
        }
    }

    public class ImageUtility
    {
        public ByteArrayResult GetImage(string imageId)
        {
            ByteArrayResult result = new ByteArrayResult();
            var image = GetImageFromDataBase(imageId);
            if (image == null)
            {
                result.Status = ByteArrayResultStatus.ImageNotFound;
            }
            else if (image.Owner != UserContext.CurrentUser)
            {
                result.Status = ByteArrayResultStatus.HasNotAccess;
            }

            result.Date = image.Data;

            return result;
        }

        private Image GetImageFromDataBase(string imageId)
        {
            //TODO
            return new Image();
        }

        public byte[] GetNutFoundImageThumbnail()
        {
            return new byte[] { };
        }
    }

    public class UserContext
    {
        public static Guid CurrentUser { get; set; }
    }

    internal class Image
    {
        public Guid Owner { get; set; }
        public byte[] Data { get; set; }
    }

    public interface ILogger
    {
        void LogError(string message);
        void LogeError(string userOrPasswordIsWrong, Exception exception);
    }

    public class ByteArrayResult
    {
        public ByteArrayResultStatus Status { get; set; }
        public byte[] Date { get; set; }
    }

    public enum ByteArrayResultStatus
    {
        EverythingIsOkay,
        ImageNotFound,
        HasNotAccess
    }
}