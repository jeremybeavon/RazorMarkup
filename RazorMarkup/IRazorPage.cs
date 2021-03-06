﻿namespace RazorMarkup
{
    public interface IRazorPage
    {
        string FileName { get; }

        string Text { get; }

        void ToFile(string directory);
    }
}
