using System;

namespace RazorMarkup.Common
{
    public class TextBuilder : ITextBuilder
    {
        private readonly InternalTextBuilder textBuilder;

        public TextBuilder()
        {
            textBuilder = new InternalTextBuilder();
        }

        public TextBuilder(string sql)
            : this()
        {
            textBuilder.Append(sql);
        }

        public static string DefaultIndentText
        {
            get { return InternalTextBuilder.DefaultIndentText; }
            set { InternalTextBuilder.DefaultIndentText = value; }
        }

        public static bool DisableIndentation
        { 
            get { return InternalTextBuilder.DisableIndentation; }
            set { InternalTextBuilder.DisableIndentation = value; }
        }

        public string IndentText 
        {
            get { return textBuilder.IndentText; }
            set { textBuilder.IndentText = value; }
        }

        public int Indent
        {
            get { return textBuilder.Indent; }
        }

        public ITextBuilder Append(string text)
        {
            textBuilder.Append(text);
            return this;
        }

        public ITextBuilder AppendIndent()
        {
            textBuilder.AppendIndent();
            return this;
        }

        public IDisposable IncrementIndent()
        {
            textBuilder.IncrementIndent();
            return new DisposableIndent(textBuilder);
        }
        
        public override string ToString()
        {
            return textBuilder.ToString();
        }

        private sealed class DisposableIndent : IDisposable
        {
            private InternalTextBuilder textBuilder;

            public DisposableIndent(InternalTextBuilder textBuilder)
            {
                this.textBuilder = textBuilder;
            }

            public void Dispose()
            {
                textBuilder.DecrementIndent();
            }
        }
    }
}
