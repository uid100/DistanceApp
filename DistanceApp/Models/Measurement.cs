
namespace DistanceApp.Models
{
    public enum units { inches, feet, miles, nauticalMiles, centimeters, meters, kilometers }
    public class Measurement
    {
        static int _inchesPerFoot = 12;
        static double _cmPerInch = 2.54;
        static int _ftPerMile = 5280;
        static int _ftPerNm = 6076;

        public double? entered { get; set; } = null;
        public double inches { get; set; }
        public double feet { get; set; }
        public double miles { get; set; }
        public double nautMiles { get; set; }
        public double centimeters { get; set; }
        public double meters { get; set; }
        public double kilometers { get; set; }
        public units unit { get; set; }

        public Measurement Calc(Measurement m)
        {
            switch(m.unit)
            {
                case units.inches:
                    m.inches = m.entered ?? 0;
                    m.feet = m.inches / _inchesPerFoot;
                    m.miles = m.feet / _ftPerMile;
                    m.nautMiles = m.feet / _ftPerNm;
                    m.centimeters = m.inches * _cmPerInch;
                    m.meters = m.centimeters / 100;
                    m.kilometers = m.meters / 1000;
                    break;
                case units.feet:
                    m.feet = m.entered ?? 0;
                    m.inches = m.feet * _inchesPerFoot;
                    m.miles = m.feet / _ftPerMile;
                    m.nautMiles = m.feet / _ftPerNm;
                    m.centimeters = m.inches * _cmPerInch;
                    m.meters = m.centimeters / 100;
                    m.kilometers = m.meters / 1000;
                    break;
                case units.miles:
                    m.miles = m.entered ?? 0;
                    m.feet = m.miles * _ftPerMile;
                    m.inches = m.feet * _inchesPerFoot;
                    m.nautMiles = m.feet / _ftPerNm;
                    m.centimeters = m.inches * _cmPerInch;
                    m.meters = m.centimeters / 100;
                    m.kilometers = m.meters / 1000;
                    break;
                case units.nauticalMiles:
                    m.nautMiles = m.entered ?? 0;
                    m.feet = m.nautMiles * _ftPerNm;
                    m.inches = m.feet * _inchesPerFoot;
                    m.miles = m.feet / _ftPerMile;
                    m.nautMiles = m.feet / _ftPerNm;
                    m.centimeters = m.inches * _cmPerInch;
                    m.meters = m.centimeters / 100;
                    m.kilometers = m.meters / 1000;
                    break;
                case units.centimeters:
                    m.centimeters = m.entered ?? 0;
                    m.inches = m.centimeters / _cmPerInch;
                    m.feet = m.inches / _inchesPerFoot;
                    m.nautMiles = m.feet / _ftPerNm;
                    m.miles = m.feet / _ftPerMile;
                    m.meters = m.centimeters / 100;
                    m.kilometers = m.meters / 1000;
                    break;
                case units.meters:
                    m.meters = m.entered ?? 0;
                    m.centimeters = m.meters * 100;
                    m.inches = m.centimeters / _cmPerInch;
                    m.feet = m.inches / 12;
                    m.miles = m.feet / _ftPerMile;
                    m.nautMiles = m.feet / _ftPerNm;
                    m.kilometers = m.meters / 1000;
                    break;
                case units.kilometers:
                    m.kilometers = m.entered ?? 0;
                    m.meters = m.kilometers * 1000;
                    m.centimeters = m.meters * 100;
                    m.inches = m.centimeters / _cmPerInch;
                    m.feet = m.inches / 12;
                    m.miles = m.feet / _ftPerMile;
                    m.nautMiles = m.feet / _ftPerNm;
                    break;
                default:
                    m.inches = 0; m.feet = 0;
                    m.miles = 0; m.nautMiles = 0;
                    m.centimeters = 0; m.meters = 0;
                    m.kilometers = 0;
                    break;
            }
            return m;
        }
    }
}
