using System.Text;

namespace DesignPatterns.CreationalDesignPatternsClasses.PrototypeClasses
{
    public class Color : ColorPrototype
    {
        int red;
        int green;
        int blue;
        // Constructor
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        // Create a shallow copy
        public override ColorPrototype Clone(ref StringBuilder result)
        {
            result = result.AppendLine(string.Format("Cloning color RGB: {0,3},{1,3},{2,3}", red, green, blue));
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
