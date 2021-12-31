using System;

namespace RazorMarkup
{
    public class TextBuilder : ITextBuilder
    {
        private readonly InternalTextBuilder textBuilder;

        public TextBuilder()
        {
            textBuilder = new InternalTextBuilder();
        }

        public TextBuilder(string initialText)
            : this()
        {
            textBuilder.Append(initialText);
        }

        public static string DefaultIndentText
        {
            get => InternalTextBuilder.DefaultIndentText;
            set => InternalTextBuilder.DefaultIndentText = value;
        }

        public static bool DisableIndentation
        {
            get => InternalTextBuilder.DisableIndentation;
            set => InternalTextBuilder.DisableIndentation = value;
        }

        public string IndentText
        {
            get => textBuilder.IndentText;
            set => textBuilder.IndentText = value;
        }

        public int Indent => textBuilder.Indent;

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
            private readonly InternalTextBuilder textBuilder;

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
