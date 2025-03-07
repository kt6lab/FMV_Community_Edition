using Microsoft.AspNetCore.Components;
using System.Xml.Linq;

namespace FMV_Standard.Shared
{
    public class Token
    {
        private string index;
        private string type;
        private string name;
        private string from;
        private string to;
        private string timing;
        private string precision;
        private string color;

        public Token(string index, string type, string name, string from, string to, string timing, string precision, string color)
        {
            this.index = index;
            this.type = type;
            this.name = name;
            this.from = from;
            this.to = to;
            this.timing = timing;
            this.precision = precision;
            this.color = color;
        }
        public string Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string From
        {
            get { return from; }
            set { from = value; }
        }
        public string To
        {
            get { return to; }
            set { to = value; }
        }
        public string Timing
        {
            get { return timing; }
            set { timing = value; }
        }
        public string Precision
        {
            get { return precision; }
            set { precision = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}