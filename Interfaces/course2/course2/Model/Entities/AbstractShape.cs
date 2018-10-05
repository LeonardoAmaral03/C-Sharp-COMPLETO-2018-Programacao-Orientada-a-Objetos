using course2.Model.Enums;

namespace course2.Model.Entities {
    abstract class AbstractShape : IShape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
