using Service;
using System.Collections.Generic;

namespace Example
{
    public class Class1
    {
        public Latest.IOperation operation = null;

        void Func()
        {
            var x = new Latest.Model("a", new Latest.NestedModel(5), new Dictionary<string, Latest.NestedModel>());
        }
    }
}
