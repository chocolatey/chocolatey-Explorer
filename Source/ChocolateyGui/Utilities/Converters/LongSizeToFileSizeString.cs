﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="LongSizeToFileSizeString.cs">
//   Copyright 2014 - Present Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ChocolateyGui.Utilities.Converters
{
    using System;
    using System.Text;
    using System.Windows.Data;

    public sealed class LongSizeToFileSizeString : IValueConverter
    {
        /// <summary>
        /// Converts a numeric value into a string that represents the number expressed as a size value in bytes, kilobytes, megabytes, or gigabytes, depending on the size.
        /// </summary>
        /// <param name="filesize">The numeric value to be converted.</param>
        /// <returns>the converted string</returns>
        public static string StrFormatByteSize(long filesize)
        {
            var sb = new StringBuilder(16);
            NativeMethods.StrFormatByteSize(filesize, sb, sb.Capacity);
            return sb.ToString();
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is long))
            {
                return string.Empty;
            }

            return StrFormatByteSize((long)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}