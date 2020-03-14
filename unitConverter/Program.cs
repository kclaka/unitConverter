using System;

namespace unitConverter
{


    public class unitConverter
    {
        int ratio;

        public unitConverter(int unitRatio)
        {
            ratio = unitRatio;

        }

        public int Convert(int unit)
        {
            return unit * ratio;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            unitConverter feet2inchesConverter = new unitConverter(12);
            unitConverter milestofeetConver = new unitConverter(5280);

            Console.WriteLine(feet2inchesConverter.Convert(200));
            Console.WriteLine(milestofeetConver.Convert(20));


        }
    }
}
