using System.Collections.Generic;
using System.Text;

namespace RazorMarkup.Web.Css
{
    public sealed class MatchFormula
    {
        public MatchFormula(int index, MatchDirection direction)
            : this(index.ToString(), direction)
        {
        }

        public MatchFormula(MatchSpecialType type, MatchDirection direction)
            : this(type.ToString().ToLower(), direction)
        {
        }

        public MatchFormula(int multiplier, int offset, MatchDirection direction)
            : this(string.Format("{0}n+{1}", multiplier, offset), direction)
        {
        }

        public MatchFormula(string formula, MatchDirection direction)
        {
            Formula = formula;
            Direction = direction;
            ChildFormulas = new List<MatchFormula>();
        }

        public string Formula { get; private set; }

        public MatchDirection Direction { get; private set; }

        public IList<MatchFormula> ChildFormulas { get; private set; }

        public MatchFormula And(MatchFormula formula)
        {
            ChildFormulas.Add(formula);
            return this;
        }

        internal void Write(StringBuilder textBuilder, string forwardsKeyword, string backwardsKeyword)
        {
            textBuilder.Append(":");
            textBuilder.Append(Direction == MatchDirection.Forwards ? forwardsKeyword : backwardsKeyword);
            textBuilder.Append("(");
            textBuilder.Append(Formula);
            textBuilder.Append(")");
            foreach (MatchFormula child in ChildFormulas)
            {
                child.Write(textBuilder, forwardsKeyword, backwardsKeyword);
            }
        }
    }
}
