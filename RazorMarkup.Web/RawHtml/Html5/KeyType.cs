using System.Web;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public sealed class KeyType : HtmlString
    {
        /// <summary>
        /// Default. Specifies an RSA security algorithm. The user may be given a choice of RSA key strengths
        /// </summary>
        public static readonly KeyType Rsa = new KeyType("rsa");

        /// <summary>
        /// Specifies a DSA security algorithm. The user may be given a choice of DSA key sizes
        /// </summary>
        public static readonly KeyType Dsa = new KeyType("dsa");

        /// <summary>
        /// Specifies an EC security algorithm. The user may be given a choice of EC key strengths
        /// </summary>
        public static readonly KeyType Ec = new KeyType("ec");

        public KeyType(string html)
            : base(html)
        {
        }
    }
}
