using System;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Apropos.Language
{
    class AproposFunction : IXsltContextFunction
    {
        public XPathResultType[] ArgTypes => throw new NotImplementedException();

        public int Maxargs => throw new NotImplementedException();
        public int Minargs => throw new NotImplementedException();

        public XPathResultType ReturnType => type;
        XPathResultType type;

        public string Name { get; private set; }
        public event Invoke OnInvoke;

        public AproposFunction(XPathResultType type, string name, Invoke onInvoke)
        {
            Name = name;
            OnInvoke = onInvoke;
        }

        public object Invoke(XsltContext xsltContext, object[] args, XPathNavigator docContext)
        {
            return OnInvoke?.Invoke(args);
        }

    }
}
