using System.Collections.Generic;
using System.Text;

namespace RazorMarkup
{
    internal sealed class InternalTextBuilder
    {
        private static string defaultIndentText;
        private readonly StringBuilder textBuilder;
        private readonly Stack<string> currentIndentText;

        public InternalTextBuilder()
        {
            textBuilder = new StringBuilder();
            currentIndentText = new Stack<string>();
            currentIndentText.Push(string.Empty);
            IndentText = DefaultIndentText;
        }

        public InternalTextBuilder(string sql)
            : this()
        {
            textBuilder.Append(sql);
        }

        public static string DefaultIndentText
        {
            get => defaultIndentText ?? string.Empty.PadLeft(4);
            set => defaultIndentText = value;
        }

        public static bool DisableIndentation { get; set; }

        public string IndentText { get; set; }

        public int Indent { get; private set; }

        public void Append(string text)
        {
            textBuilder.Append(text);
        }

        public void AppendIndent()
        {
            if (!DisableIndentation)
            {
                if (textBuilder.Length != 0)
                {
                    textBuilder.AppendLine();
                }

                textBuilder.Append(currentIndentText.Peek());
            }
        }

        public void IncrementIndent()
        {
            currentIndentText.Push(currentIndentText.Peek() + IndentText);
            Indent++;
        }

        public void DecrementIndent()
        {
            currentIndentText.Pop();
            Indent--;
        }

        public override string ToString()
        {
            return textBuilder.ToString();
        }
    }
}
