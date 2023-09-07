using System;

namespace Xml
{
    [Serializable]
    public class XmlTestClass
    {
        public int Id;
        public int Value;
        public bool Boolean;
        public XmlTestSubClass[] CustomData;
    }
}
