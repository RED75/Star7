using System;

namespace Star7ClassLibrary.MeasuredData
{
    /// <summary>
    /// 
    /// </summary>
    public class  MeasuredPoint
    {
        /// <summary>
        /// 
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double R0 { get; set; }
        /// <summary>
        /// Установленное сопротивление ццифрового потенциометра
        /// </summary>
        public double F { get ; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Time { get; set; }
    }
}
