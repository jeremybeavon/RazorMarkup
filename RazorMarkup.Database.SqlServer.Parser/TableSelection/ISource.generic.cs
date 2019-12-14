using System;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ISource<TSource> : ISource
    {
        TSource Source { get; set; }
    }
}
