using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionLinq.App.Class
{
    /// <summary>
    /// Boisson
    /// </summary>
    internal class Beverage : Glass
    {

        #region Attributes

        #endregion

        #region Properties

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur d'une boisson
        /// </summary>
        /// <param name="name">nom de la boisson</param>
        public Beverage(string name, double price) : base(name, price)
        {
        }

        #endregion

    }
}
