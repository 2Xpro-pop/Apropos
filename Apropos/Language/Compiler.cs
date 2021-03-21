using System;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Apropos.Language
{
    public class Compiler : XsltContext
    {
        public Compiler()
        {
        }

        public Compiler(NameTable table) : base(table)
        {
        }

        public override bool Whitespace => true;

        public override int CompareDocument(string baseUri, string nextbaseUri)
        {
            return 0;
        }

        public override bool PreserveWhitespace(XPathNavigator node)
        {
            return false;
        }

        public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes)
        {
            return new AproposFunction(XPathResultType.Number, "haha", (a) => 2);
        }

        public override IXsltContextVariable ResolveVariable(string prefix, string name)
        {
            return new AproposVar(XPathResultType.Number, "lol", 18);
        }
    }
}
