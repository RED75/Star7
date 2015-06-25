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
        public int R0 { get; set; }
        /// <summary>
        /// Установленный квант ццифрового потенциометра
        /// </summary>
        public double F { get ; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Time { get; set; }
    }
}
