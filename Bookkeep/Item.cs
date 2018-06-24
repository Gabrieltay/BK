using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookkeep
{
    public class Item
    {
        private string _Value, _Text;
        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public Item(string value, string text)
        {
            this._Value = value;
            this._Text = text;
        }

        public override string ToString()
        { return _Text; }
    }
}
