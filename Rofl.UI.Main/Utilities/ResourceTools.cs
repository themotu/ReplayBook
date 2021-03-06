﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Rofl.UI.Main.Utilities
{
    public static class ResourceTools
    {
        internal static ImageSource GetImageSourceFromResource(string resourceName)
        {
            return Application.Current.TryFindResource(resourceName) as ImageSource;
        }

        internal static ImageSource GetImageSourceFromPath(string path)
        {
            return BitmapFrame.Create(new Uri(path));
        }
    }
}
