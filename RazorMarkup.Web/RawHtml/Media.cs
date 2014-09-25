using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class Media : AbstractFluentHtmlString, IMedia
    {
        private readonly StringBuilder textBuilder;

        internal Media()
        {
            textBuilder = new StringBuilder();
        }

        public static IMedia Not()
        {
            return Create(media => media.Not());
        }

        public static IMediaDevice Device()
        {
            return Create(media => media.Device());
        }

        public static IMediaOperator Width(string width)
        {
            return Create(media => media.Width(width));
        }

        public static IMediaOperator MinWidth(string width)
        {
            return Create(media => media.MinWidth(width));
        }

        public static IMediaOperator MaxWidth(string width)
        {
            return Create(media => media.MaxWidth(width));
        }

        public static IMediaOperator Height(string height)
        {
            return Create(media => media.Height(height));
        }

        public static IMediaOperator MinHeight(string height)
        {
            return Create(media => media.MinHeight(height));
        }

        public static IMediaOperator MaxHeight(string height)
        {
            return Create(media => media.MaxHeight(height));
        }

        public static IMediaOperator DeviceWidth(string width)
        {
            return Create(media => media.DeviceWidth(width));
        }

        public static IMediaOperator MinDeviceWidth(string width)
        {
            return Create(media => media.MinDeviceWidth(width));
        }

        public static IMediaOperator MaxDeviceWidth(string width)
        {
            return Create(media => media.MaxDeviceWidth(width));
        }

        public static IMediaOperator DeviceHeight(string height)
        {
            return Create(media => media.DeviceHeight(height));
        }

        public static IMediaOperator MinDeviceHeight(string height)
        {
            return Create(media => media.MinDeviceHeight(height));
        }

        public static IMediaOperator MaxDeviceHeight(string height)
        {
            return Create(media => media.MaxDeviceHeight(height));
        }

        public static IMediaOperator Orientation(MediaOrientation orientation)
        {
            return Create(media => media.Orientation(orientation));
        }

        public static IMediaOperator AspectRatio(int width, int height)
        {
            return Create(media => media.AspectRatio(width, height));
        }

        public static IMediaOperator MinAspectRatio(int width, int height)
        {
            return Create(media => media.MinAspectRatio(width, height));
        }

        public static IMediaOperator MaxAspectRatio(int width, int height)
        {
            return Create(media => media.MaxAspectRatio(width, height));
        }

        public static IMediaOperator DeviceAspectRatio(int width, int height)
        {
            return Create(media => media.DeviceAspectRatio(width, height));
        }

        public static IMediaOperator MinDeviceAspectRatio(int width, int height)
        {
            return Create(media => media.MinDeviceAspectRatio(width, height));
        }

        public static IMediaOperator MaxDeviceAspectRatio(int width, int height)
        {
            return Create(media => media.MaxDeviceAspectRatio(width, height));
        }

        public static IMediaOperator BitsPerColor(int bitsPerColor)
        {
            return Create(media => media.BitsPerColor(bitsPerColor));
        }

        public static IMediaOperator MinBitsPerColor(int bitsPerColor)
        {
            return Create(media => media.MinBitsPerColor(bitsPerColor));
        }

        public static IMediaOperator MaxBitsPerColor(int bitsPerColor)
        {
            return Create(media => media.MaxBitsPerColor(bitsPerColor));
        }

        public static IMediaOperator NumberOfColors(int numberOfColors)
        {
            return Create(media => media.NumberOfColors(numberOfColors));
        }

        public static IMediaOperator MinNumberOfColors(int numberOfColors)
        {
            return Create(media => media.MinNumberOfColors(numberOfColors));
        }

        public static IMediaOperator MaxNumberOfColors(int numberOfColors)
        {
            return Create(media => media.MaxNumberOfColors(numberOfColors));
        }

        public static IMediaOperator BitsPerPixel(int bitsPerPixel)
        {
            return Create(media => media.BitsPerPixel(bitsPerPixel));
        }

        public static IMediaOperator MinBitsPerPixel(int bitsPerPixel)
        {
            return Create(media => media.MinBitsPerPixel(bitsPerPixel));
        }

        public static IMediaOperator MaxBitsPerPixel(int bitsPerPixel)
        {
            return Create(media => media.MaxBitsPerPixel(bitsPerPixel));
        }

        public static IMediaResolution Resolution()
        {
            return Create(media => media.Resolution());
        }

        public static IMediaResolution MinResolution()
        {
            return Create(media => media.MinResolution());
        }

        public static IMediaResolution MaxResolution()
        {
            return Create(media => media.MaxResolution());
        }

        public static IMediaOperator Scan(MediaScan scan)
        {
            return Create(media => media.Scan(scan));
        }

        public static IMediaOperator IsGridOrBitmap()
        {
            return Create(media => media.IsGridOrBitmap());
        }

        public static IMediaOperator IsNotGridOrBitmap()
        {
            return Create(media => media.IsNotGridOrBitmap());
        }

        public override string ToHtmlString()
        {
            return textBuilder.ToString();
        }

        IMedia IMedia.Not()
        {
            textBuilder.Append("not ");
            return this;
        }

        IMediaDevice IMedia.Device()
        {
            return new MediaDevice(this);
        }

        IMediaOperator IMedia.Width(string width)
        {
            textBuilder.AppendFormat("(width:{0})", width);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinWidth(string width)
        {
            textBuilder.AppendFormat("(min-width:{0})", width);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxWidth(string width)
        {
            textBuilder.AppendFormat("(max-width:{0})", width);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.Height(string height)
        {
            textBuilder.AppendFormat("(height:{0})", height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinHeight(string height)
        {
            textBuilder.AppendFormat("(min-height:{0})", height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxHeight(string height)
        {
            textBuilder.AppendFormat("(max-height:{0})", height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.DeviceWidth(string width)
        {
            textBuilder.AppendFormat("(device-width:{0})", width);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinDeviceWidth(string width)
        {
            textBuilder.AppendFormat("(min-device-width:{0})", width);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxDeviceWidth(string width)
        {
            textBuilder.AppendFormat("(max-device-width:{0})", width);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.DeviceHeight(string height)
        {
            textBuilder.AppendFormat("(device-height:{0})", height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinDeviceHeight(string height)
        {
            textBuilder.AppendFormat("(min-device-height:{0})", height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxDeviceHeight(string height)
        {
            textBuilder.AppendFormat("(max-device-height:{0})", height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.Orientation(MediaOrientation orientation)
        {
            string orientationText;
            switch (orientation)
            {
                case MediaOrientation.Portrait:
                    orientationText = "portrait";
                    break; 
                case MediaOrientation.Landscape:
                    orientationText = "landscape";
                    break;
                default:
                    throw new ArgumentException("orientation value was not supported: " + orientation, "orientation");
            }

            textBuilder.AppendFormat("(orientation:{0})", orientationText);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.AspectRatio(int width, int height)
        {
            textBuilder.AppendFormat("(aspect-ratio:{0}/{1})", width, height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinAspectRatio(int width, int height)
        {
            textBuilder.AppendFormat("(min-aspect-ratio:{0}/{1})", width, height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxAspectRatio(int width, int height)
        {
            textBuilder.AppendFormat("(max-aspect-ratio:{0}/{1})", width, height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.DeviceAspectRatio(int width, int height)
        {
            textBuilder.AppendFormat("(device-aspect-ratio:{0}/{1})", width, height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinDeviceAspectRatio(int width, int height)
        {
            textBuilder.AppendFormat("(min-device-aspect-ratio:{0}/{1})", width, height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxDeviceAspectRatio(int width, int height)
        {
            textBuilder.AppendFormat("(max-device-aspect-ratio:{0}/{1})", width, height);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.BitsPerColor(int bitsPerColor)
        {
            textBuilder.AppendFormat("(color:{0})", bitsPerColor);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinBitsPerColor(int bitsPerColor)
        {
            textBuilder.AppendFormat("(min-color:{0})", bitsPerColor);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxBitsPerColor(int bitsPerColor)
        {
            textBuilder.AppendFormat("(max-color:{0})", bitsPerColor);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.NumberOfColors(int numberOfColors)
        {
            textBuilder.AppendFormat("(color-index:{0})", numberOfColors);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinNumberOfColors(int numberOfColors)
        {
            textBuilder.AppendFormat("(min-color-index:{0})", numberOfColors);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxNumberOfColors(int numberOfColors)
        {
            textBuilder.AppendFormat("(max-color-index:{0})", numberOfColors);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.BitsPerPixel(int bitsPerPixel)
        {
            textBuilder.AppendFormat("(monochrome:{0})", bitsPerPixel);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MinBitsPerPixel(int bitsPerPixel)
        {
            textBuilder.AppendFormat("(min-monochrome:{0})", bitsPerPixel);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.MaxBitsPerPixel(int bitsPerPixel)
        {
            textBuilder.AppendFormat("(max-monochrome:{0})", bitsPerPixel);
            return new MediaOperator(this);
        }

        IMediaResolution IMedia.Resolution()
        {
            throw new NotImplementedException();
        }

        IMediaResolution IMedia.MinResolution()
        {
            throw new NotImplementedException();
        }

        IMediaResolution IMedia.MaxResolution()
        {
            throw new NotImplementedException();
        }

        IMediaOperator IMedia.Scan(MediaScan scan)
        {
            string scanText;
            switch (scan)
            {
                case MediaScan.Progressive:
                    scanText = "progressive";
                    break;
                case MediaScan.Interlace:
                    scanText = "interlace";
                    break;
                default:
                    throw new ArgumentException("scan value was not supported: " + scan, "scan");
            }

            textBuilder.AppendFormat("(scan:{0})", scanText);
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.IsGridOrBitmap()
        {
            textBuilder.Append("(grid:1)");
            return new MediaOperator(this);
        }

        IMediaOperator IMedia.IsNotGridOrBitmap()
        {
            textBuilder.Append("(grid:0)");
            return new MediaOperator(this);
        }

        internal void AppendText(string text)
        {
            textBuilder.Append(text);
        }

        private static TMedia Create<TMedia>(Func<IMedia, TMedia> action)
        {
            return action(new Media());
        }
    }
}
