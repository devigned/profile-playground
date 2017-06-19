using System.Collections.Generic;

namespace Service
{
    public abstract partial class _2017_01_01
    {
        public interface IOperation
        {
            void A();
            void B(int x);
            void Set(Model model);
            Model Get();
        }

        public sealed class NestedModel
        {
            public int B { get; }

            public NestedModel(int b)
            {
                B = b;
            }
        }

        public sealed class Model
        {
            public string A { get; }

            public NestedModel NestedModel { get; }

            public Dictionary<string, NestedModel> Map { get; }

            public Model(string a, NestedModel nestedModel, Dictionary<string, NestedModel> map)
            {
                A = a;
                NestedModel = nestedModel;
                Map = map;
            }
        }
    }
}
