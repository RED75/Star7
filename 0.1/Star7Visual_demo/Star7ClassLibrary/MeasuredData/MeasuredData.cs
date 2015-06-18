using System.Collections.Generic;

namespace Star7ClassLibrary.MeasuredData
{
    class MeasuredData
    {
        public string Label { get; set; }

        public double R1 { get; set; }

        public double R2 { get; set; }

        public double R3 { get; set; }

        public double Uref { get; set; }
        
        public List<MeasuredPoint> MeasuredPoints { get; set; }

        public MeasuredData()
        {
            MeasuredPoints = new List<MeasuredPoint>();
        }
        
        public MeasuredData(string label)
        {
            this.Label = label;
            MeasuredPoints = new List<MeasuredPoint>();
        }

        /// <summary>
        /// Add new MeasuredPoint
        /// </summary>
        /// <param name="point"></param>
        public void AddMeasuredPoint(MeasuredPoint point)
        {
            MeasuredPoints.Add(point);
        }



    }
}
