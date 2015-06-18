using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Классы экстраполяции
namespace STAR5Reader.Fitter
{
    /// <summary>
    ///  Класс хранящий в себе полиним аппроксимации и считающий его значение в произвоьной точке
    /// </summary>
    class Polinom
    {
        /// <summary>
        /// Коэффициенты и степени полинома
        /// </summary>
        private List<Coefficent> coefficents;
        /// <summary>
        /// Добавляет в коллекцию очередное слагаемое полинома
        /// </summary>
        /// <param name="coefficent"></param>
        public void Add(Coefficent coefficent)
        {
            coefficents.Add(coefficent);
        }
        /// <summary>
        /// Вычисляет очередное значение полинома в точке Х
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>

        public double CalcYValye(double x)
        {
            double y = coefficents.Sum(coefficient => coefficient.Coefficient*Math.Pow(x, coefficient.Degree));
            return y;
        }
        public Polinom()
        {
            coefficents= new List<Coefficent>();
        }
      
    }


}
