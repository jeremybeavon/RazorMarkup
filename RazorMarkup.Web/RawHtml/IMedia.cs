using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IMedia : IHideObjectMethods
    {
        /// <summary>
        /// Specifies a NOT operator
        /// </summary>
        IMedia Not();

        IMediaDevice Device();

        /// <summary>
        /// Specifies the width of the targeted display area.
        /// </summary>
        IMediaOperator Width(string width);

        /// <summary>
        /// Specifies the minimum width of the targeted display area.
        /// </summary>
        IMediaOperator MinWidth(string width);

        /// <summary>
        /// Specifies the maximum width of the targeted display area.
        /// </summary>
        IMediaOperator MaxWidth(string width);

        /// <summary>
        /// Specifies the height of the  targeted display area.
        /// </summary>
        IMediaOperator Height(string height);

        /// <summary>
        /// Specifies the minimum height of the  targeted display area.
        /// </summary>
        IMediaOperator MinHeight(string height);

        /// <summary>
        /// Specifies the maximum height of the  targeted display area.
        /// </summary>
        IMediaOperator MaxHeight(string height);

        /// <summary>
        /// Specifies the width of the target display/paper.
        /// </summary>
        IMediaOperator DeviceWidth(string width);

        /// <summary>
        /// Specifies the minimum width of the target display/paper.
        /// </summary>
        IMediaOperator MinDeviceWidth(string width);

        /// <summary>
        /// Specifies the maximum width of the target display/paper.
        /// </summary>
        IMediaOperator MaxDeviceWidth(string width);

        /// <summary>
        /// Specifies the height of the target display/paper.
        /// </summary>
        IMediaOperator DeviceHeight(string height);

        /// <summary>
        /// Specifies the minimum height of the target display/paper.
        /// </summary>
        IMediaOperator MinDeviceHeight(string height);

        /// <summary>
        /// Specifies the maximum height of the target display/paper.
        /// </summary>
        IMediaOperator MaxDeviceHeight(string height);

        /// <summary>
        /// Specifies the orientation of the target display/paper.
        /// </summary>
        IMediaOperator Orientation(MediaOrientation orientation);

        /// <summary>
        /// Specifies the width/height ratio of the targeted display area.
        /// </summary>
        IMediaOperator AspectRatio(int width, int height);

        /// <summary>
        /// Specifies the minimum width/height ratio of the targeted display area.
        /// </summary>
        IMediaOperator MinAspectRatio(int width, int height);

        /// <summary>
        /// Specifies the maximum width/height ratio of the targeted display area.
        /// </summary>
        IMediaOperator MaxAspectRatio(int width, int height);

        /// <summary>
        /// Specifies the device-width/device-height ratio of the target display/paper.
        /// </summary>
        IMediaOperator DeviceAspectRatio(int width, int height);

        /// <summary>
        /// Specifies the minimum device-width/device-height ratio of the target display/paper.
        /// </summary>
        IMediaOperator MinDeviceAspectRatio(int width, int height);

        /// <summary>
        /// Specifies the maximum device-width/device-height ratio of the target display/paper.
        /// </summary>
        IMediaOperator MaxDeviceAspectRatio(int width, int height);

        /// <summary>
        /// Specifies the bits per color of target display.
        /// </summary>
        IMediaOperator BitsPerColor(int bitsPerColor);

        /// <summary>
        /// Specifies the minimum bits per color of target display.
        /// </summary>
        IMediaOperator MinBitsPerColor(int bitsPerColor);

        /// <summary>
        /// Specifies the maximum bits per color of target display.
        /// </summary>
        IMediaOperator MaxBitsPerColor(int bitsPerColor);

        /// <summary>
        /// Specifies the number of colors the target display can handle.
        /// </summary>
        IMediaOperator NumberOfColors(int numberOfColors);

        /// <summary>
        /// Specifies the minimum number of colors the target display can handle.
        /// </summary>
        IMediaOperator MinNumberOfColors(int numberOfColors);

        /// <summary>
        /// Specifies the maximum number of colors the target display can handle.
        /// </summary>
        IMediaOperator MaxNumberOfColors(int numberOfColors);

        /// <summary>
        /// Specifies the bits per pixel in a monochrome frame buffer.
        /// </summary>
        IMediaOperator BitsPerPixel(int bitsPerPixel);

        /// <summary>
        /// Specifies the minimum bits per pixel in a monochrome frame buffer.
        /// </summary>
        IMediaOperator MinBitsPerPixel(int bitsPerPixel);

        /// <summary>
        /// Specifies the maximum bits per pixel in a monochrome frame buffer.
        /// </summary>
        IMediaOperator MaxBitsPerPixel(int bitsPerPixel);

        /// <summary>
        /// Specifies the pixel density (dpi or dpcm) of the target display/paper.
        /// </summary>
        IMediaResolution Resolution();

        /// <summary>
        /// Specifies the minimum pixel density (dpi or dpcm) of the target display/paper.
        /// </summary>
        IMediaResolution MinResolution();

        /// <summary>
        /// Specifies the maximum pixel density (dpi or dpcm) of the target display/paper.
        /// </summary>
        IMediaResolution MaxResolution();

        /// <summary>
        /// Specifies scanning method of a tv display.
        /// </summary>
        IMediaOperator Scan(MediaScan scan);

        /// <summary>
        /// Specifies if the output device is grid or bitmap.
        /// </summary>
        IMediaOperator IsGridOrBitmap();

        /// <summary>
        /// Specifies if the output device is not grid or bitmap.
        /// </summary>
        IMediaOperator IsNotGridOrBitmap();
    }
}
