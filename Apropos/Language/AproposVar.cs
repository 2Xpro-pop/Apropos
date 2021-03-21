using System;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Apropos.Language
{
    public class AproposVar : IXsltContextVariable
    {
        public bool IsLocal => false;
        public bool IsParam => false;

        public XPathResultType VariableType { get; }
        public string Name { get; private set; }
        public object Value { get; set; }

        public AproposVar(XPathResultType type, string name,object value=null)
        {
            VariableType = type;
            Value = value;
            Name = name;
        }

        public object Evaluate(XsltContext xsltContext) => Value;

    }
}