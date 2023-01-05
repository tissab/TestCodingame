using System;
using System.Collections.Generic;
using System.Linq;

namespace Pompe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static TimeSpan GetRunningDurationOnPeriod(Measure[] onoffMeasure, DateTime start, DateTime end)
        {

            //var start = new DateTime(2019, 01, 10, 11, 00, 00);
            //var end = new DateTime(2019, 01, 10, 13, 00, 00);
            //var onOff = new List<Measure>();
            //onOff.Add(new Measure(new DateTime(2019, 01, 10, 10, 14, 11), 0));
            //onOff.Add(new Measure(new DateTime(2019, 01, 10, 10, 55, 00), 1));
            //onOff.Add(new Measure(new DateTime(2019, 01, 10, 12, 21, 00), 0));
            //onOff.Add(new Measure(new DateTime(2019, 01, 10, 13, 14, 12), 1));
            //onOff.Add(new Measure(new DateTime(2019, 01, 10, 14, 45, 14), 0));

            Dictionary<DateTime, DateTime> valeursCapturesProceed = new Dictionary<DateTime, DateTime>();

            var onOffMeasuresByEndTimes = onoffMeasure.Where(x => x.Time <= end).ToArray();

            var onOffMeasuresByStartTime = onOffMeasuresByEndTimes.Where(x => x.Time <= start && x.Value == 1).FirstOrDefault();

            if(onOffMeasuresByStartTime != null)
            {
                onOffMeasuresByStartTime = new Measure(start, 1);
            }
            else
            {
                onOffMeasuresByStartTime = onOffMeasuresByEndTimes.Where(x => x.Time >= start && x.Time <= end && x.Value == 1).FirstOrDefault();
            }

            var onOffMeasuresByAllTime = onOffMeasuresByEndTimes.Where(x => x.Time >= onOffMeasuresByStartTime.Time).ToArray();

            if(onOffMeasuresByStartTime == null)
            {
                return TimeSpan.Zero;
            }

            List<Measure> allMeasures = new List<Measure>();

            allMeasures.Add(onOffMeasuresByStartTime);

            if (onOffMeasuresByAllTime.Any())
            {
                allMeasures.AddRange(onOffMeasuresByAllTime);
            }

            List<Measure> measureDico = new List<Measure>();

            foreach(Measure measure in allMeasures)
            {
                if(measureDico.Count == 2)
                {
                    valeursCapturesProceed.Add(measureDico[0].Time, measureDico[1].Time);
                    measureDico = new List<Measure>();
                }

                if(measure.Value == 1)
                {
                    if((measureDico.Count > 0 && measureDico[0].Value == 0)||(measureDico.Count <= 2 && !measureDico.Contains(measure)))
                    {
                        measureDico.Add(measure);
                    }
                }
                
                if(measure.Value == 0)
                {
                    if((measureDico.Count > 0 && measureDico[0].Value == 1)||(measureDico.Count <= 2 && !measureDico.Contains(measure)))
                    {
                        if(measureDico.Count > 0)
                        {
                            measureDico.Add(measure);
                        }
                    }
                }
            }

            if(measureDico.Count == 2)
            {
                valeursCapturesProceed.Add(measureDico[0].Time, measureDico[1].Time);
            }
            else if(measureDico.Count == 1)
            {
                valeursCapturesProceed.Add(measureDico[0].Time, measureDico[0].Time);
            }

            var totalSpan = new TimeSpan(valeursCapturesProceed.Sum(r => r.Value.Ticks - r.Key.Ticks));

            return totalSpan;



        }
    }

    public class Measure
    {
        public DateTime Time { get; set; }
        public double Value { get; set; }
        public Measure(DateTime time, double value)
        {
            this.Time = time;
            this.Value = value;
        }
    }


}
