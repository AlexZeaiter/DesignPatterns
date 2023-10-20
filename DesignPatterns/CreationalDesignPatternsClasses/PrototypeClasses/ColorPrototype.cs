using System.Text;

namespace DesignPatterns.CreationalDesignPatternsClasses.PrototypeClasses
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone(ref StringBuilder result);
    }
}
