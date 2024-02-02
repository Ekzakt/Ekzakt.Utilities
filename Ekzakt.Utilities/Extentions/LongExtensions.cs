﻿namespace Ekzakt.Utilities.Extentions;

public static class LongExtensions
{
    public static string FormatFileSize(this long value)
    {
        var bytes = value;

        string[] sizeSuffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        const int scale = 1024;

        int order = 0;
        while (bytes >= scale && order < sizeSuffixes.Length - 1)
        {
            bytes /= scale;
            order++;
        }

        return $"{bytes} {sizeSuffixes[order]}";
    }
}