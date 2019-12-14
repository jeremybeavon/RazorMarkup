using System;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractSource<TSource> : ISource<TSource>
    {
        public TSource Source { get; set; }

        public T GetSource<T>()
        {
            return (T)(object)Source;
        }
    }
}
