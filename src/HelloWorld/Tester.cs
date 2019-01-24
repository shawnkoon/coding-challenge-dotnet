using System;

namespace HelloWorld
{
    public class Tester
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Hello World! {this.Name}";
        }
    }
}
