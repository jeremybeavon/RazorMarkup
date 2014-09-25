using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class KeyGeneratorElement : AbstractHtmlElement<IKeyGeneratorElement>, IKeyGeneratorElement
    {
        public KeyGeneratorElement()
            : base("keygen", true)
        {
        }

        public IKeyGeneratorElement WithAutoFocus()
        {
            return AddEmptyAttribute("autofocus");
        }

        public IKeyGeneratorElement WithChallenge(string challenge)
        {
            return AddAttribute("challenge", challenge);
        }

        public IKeyGeneratorElement WithDisabled()
        {
            return AddEmptyAttribute("disabled");
        }

        public IKeyGeneratorElement WithForm(string formId)
        {
            return AddAttribute("form", formId);
        }

        public IKeyGeneratorElement WithKeyGen(KeyType keyType)
        {
            return AddAttribute("keytype", keyType.ToHtmlString());
        }

        public IKeyGeneratorElement WithName(string name)
        {
            return AddAttribute("name", name);
        }
    }
}
