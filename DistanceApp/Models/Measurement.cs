
namespace DistanceApp.Models
{
    public enum units { inches, feet, centimeters, meters }
    public class Measurement
    {
        static int _inchesPerFoot = 12;
        static double _cmPerInch = 2.54;
        static int _ftPerMile = 5280;

        public double? entered { get; set; } = null;
        public double inches { get; set; }
        public double feet { get; set; }
        public double centimeters { get; set; }
        public double meters { get; set; }
        public units unit { get; set; }

        public Measurement Calc(Measurement m)
        {
            switch(m.unit)
            {
                case units.inches:
                    m.inches = m.entered ?? 0;
                    m.feet = m.inches / _inchesPerFoot;
                    m.centimeters = m.inches * _cmPerInch;
                    m.meters = m.centimeters / 100;
                    break;
                case units.feet:
                    m.feet = m.entered ?? 0;
                    m.inches = m.feet * _inchesPerFoot;
                    m.centimeters = m.inches * _cmPerInch;
                    m.meters = m.centimeters / 100;
                    break;
                case units.centimeters:
                    m.centimeters = m.entered ?? 0;
                    m.inches = m.centimeters / _cmPerInch;
                    m.feet = m.inches / _inchesPerFoot;
                    m.meters = m.centimeters / 100;
                    break;
                case units.meters:
                    m.meters = m.entered ?? 0;
                    m.centimeters = m.meters * 100;
                    m.inches = m.centimeters / _cmPerInch;
                    m.feet = m.inches / 12;
                    break;
                default:
                    m.inches = 0; m.feet = 0;
                    m.centimeters = 0; m.meters = 0;
                    break;
            }
            return m;
        }
    }
}
