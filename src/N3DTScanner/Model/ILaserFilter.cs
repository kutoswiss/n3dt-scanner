/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;

namespace N3DTScanner
{
    public enum LASER_FILTER
    {
        NONE,
        HSV,
        IMG_DIFF
    }

    public interface ILaserFilter
    {
        // Properties
        LASER_FILTER SelectedFilter { get; set; }
        String Name { get; }
        Rectangle CropArea { get; set; }

        // Methods
        void ApplyFilter();
        Bitmap ToBitmap();
        Bitmap ToBitmap(Rectangle cropArea);
    }
}
