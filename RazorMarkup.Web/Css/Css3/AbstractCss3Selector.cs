using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Web.Css.Css2;

namespace RazorMarkup.Web.Css.Css3
{
    public abstract class AbstractCss3Selector<TSelector, TAttributeSelector> : AbstractCss2Selector<TAttributeSelector>
        where TSelector : AbstractCss3Selector<TSelector, TAttributeSelector>
        where TAttributeSelector : AbstractCss3AttributeSelector<TAttributeSelector>
    {
        public bool OnlySelectCheckedCheckboxesOrRadioButtons { get; set; }

        public bool OnlySelectDisabledElements { get; set; }

        public bool OnlySelectEmptyElements { get; set; }

        public bool OnlySelectEnabledElements { get; set; }

        public bool OnlySelectFirstElementName { get; set; }

        public bool OnlySelectValuesBetweenMinAndMax { get; set; }

        public bool OnlySelectInvalidValues { get; set; }

        public bool OnlySelectLastChild { get; set; }

        public bool OnlySelectLastElementName { get; set; }

        public TSelector Exclude { get; set; }

        public MatchFormula OnlySelectWhenChildMatchesFormula { get; set; }

        public MatchFormula OnlySelectWhenElementNameMatchesFormula { get; set; }

        public bool OnlySelectWhenOnlyElementNameInParent { get; set; }

        public bool OnlySelectWhenOnlyChildInParent { get; set; }

        public bool OnlySelectOptionalElements { get; set; }

        public bool OnlySelectValuesNotBetweenMinAndMax { get; set; }

        public bool OnlySelectReadOnlyElements { get; set; }

        public bool OnlySelectNonReadOnlyElements { get; set; }

        public bool OnlySelectRequiredElements { get; set; }

        public bool OnlySelectActiveTarget { get; set; }

        public bool OnlySelectValidElements { get; set; }

        internal override void Write(StringBuilder textBuilder)
        {
            base.Write(textBuilder);
            WriteChecked(textBuilder);
            WriteDisabled(textBuilder);
            WriteEmpty(textBuilder);
            WriteEnabled(textBuilder);
            WriteFirstOfType(textBuilder);
            WriteInRange(textBuilder);
            WriteInvalid(textBuilder);
            WriteLastChild(textBuilder);
            WriteLastOfType(textBuilder);
            WriteNot(textBuilder);
            WriteChildFormula(textBuilder);
            WriteElementNameFormula(textBuilder);
            WriteOnlyOfType(textBuilder);
            WriteOnlyChild(textBuilder);
            WriteOptional(textBuilder);
            WriteOutOfRange(textBuilder);
            WriteReadOnly(textBuilder);
            WriteReadWrite(textBuilder);
            WriteRequired(textBuilder);
            WriteTarget(textBuilder);
            WriteValid(textBuilder);
        }

        private void WriteChecked(StringBuilder textBuilder)
        {
            if (OnlySelectCheckedCheckboxesOrRadioButtons)
            {
                textBuilder.Append(":checked");
            }
        }

        private void WriteDisabled(StringBuilder textBuilder)
        {
            if (OnlySelectDisabledElements)
            {
                textBuilder.Append(":disabled");
            }
        }

        private void WriteEmpty(StringBuilder textBuilder)
        {
            if (OnlySelectEmptyElements)
            {
                textBuilder.Append(":empty");
            }
        }

        private void WriteEnabled(StringBuilder textBuilder)
        { 
            if (OnlySelectEnabledElements)
            {
                textBuilder.Append(":enabled");
            }
        }

        private void WriteFirstOfType(StringBuilder textBuilder)
        {
            if (OnlySelectFirstElementName)
            {
                textBuilder.Append(":first-of-type");
            }
        }

        private void WriteInRange(StringBuilder textBuilder)
        {
            if (OnlySelectValuesBetweenMinAndMax)
            {
                textBuilder.Append(":in-range");
            }
        }

        private void WriteInvalid(StringBuilder textBuilder)
        {
            if (OnlySelectInvalidValues)
            {
                textBuilder.Append(":invalid");
            }
        }

        private void WriteLastChild(StringBuilder textBuilder)
        {
            if (OnlySelectLastChild)
            {
                textBuilder.Append(":last-child");
            }
        }

        private void WriteLastOfType(StringBuilder textBuilder)
        {
            if (OnlySelectLastElementName)
            {
                textBuilder.Append(":last-of-type");
            }
        }

        private void WriteNot(StringBuilder textBuilder)
        {
            if (Exclude != null)
            {
                textBuilder.Append(":not(");
                Exclude.Write(textBuilder);
                textBuilder.Append(")");
            }
        }

        private void WriteChildFormula(StringBuilder textBuilder)
        {
            if (OnlySelectWhenChildMatchesFormula != null)
            {
                OnlySelectWhenChildMatchesFormula.Write(textBuilder, "nth-child", "nth-last-child");
            }
        }

        private void WriteElementNameFormula(StringBuilder textBuilder)
        {
            if (OnlySelectWhenElementNameMatchesFormula != null)
            {
                OnlySelectWhenElementNameMatchesFormula.Write(textBuilder, "nth-of-type", "nth-last-of-type");
            }
        }

        private void WriteOnlyOfType(StringBuilder textBuilder)
        {
            if (OnlySelectWhenOnlyElementNameInParent)
            {
                textBuilder.Append(":only-of-type");
            }
        }

        private void WriteOnlyChild(StringBuilder textBuilder)
        {
            if (OnlySelectWhenOnlyChildInParent)
            {
                textBuilder.Append(":only-child");
            }
        }

        private void WriteOptional(StringBuilder textBuilder)
        {
            if (OnlySelectOptionalElements)
            {
                textBuilder.Append(":optional");
            }
        }

        private void WriteOutOfRange(StringBuilder textBuilder)
        {
            if (OnlySelectValuesNotBetweenMinAndMax)
            {
                textBuilder.Append(":out-of-range");
            }
        }

        private void WriteReadOnly(StringBuilder textBuilder)
        {
            if (OnlySelectReadOnlyElements)
            {
                textBuilder.Append(":read-only");
            }
        }

        private void WriteReadWrite(StringBuilder textBuilder)
        {
            if (OnlySelectNonReadOnlyElements)
            {
                textBuilder.Append(":read-write");
            }
        }

        private void WriteRequired(StringBuilder textBuilder)
        {
            if (OnlySelectRequiredElements)
            {
                textBuilder.Append(":required");
            }
        }

        private void WriteTarget(StringBuilder textBuilder)
        {
            if (OnlySelectActiveTarget)
            {
                textBuilder.Append(":target");
            }
        }

        private void WriteValid(StringBuilder textBuilder)
        {
            if (OnlySelectValidElements)
            {
                textBuilder.Append(":valid");
            }
        }
    }
}
