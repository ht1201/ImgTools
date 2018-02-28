
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgTools {
    public class NodeInfo<T> {
        public string Key;
        public T Val;

        public override string ToString() {
            return this.Key;
        }
    }
}
