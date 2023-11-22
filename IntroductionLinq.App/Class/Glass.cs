using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IntroductionLinq.App.Interfaces;


namespace IntroductionLinq.App.Class
{
    /// <summary>
    /// Verre à servir
    /// </summary>
    internal abstract class Glass : IGetPrice
    {
        #region Attributes

        /// <summary>
        /// Nom du verre
        /// </summary>
        private readonly string _Name;
        // readonly défini que le nom ne peut être défini qu'a l'instaciation

        /// <summary>
        /// Prix du verre
        /// </summary>
        private readonly double _Price;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient le nom
        /// </summary>
        public string Name => _Name;

        /// <summary>
        /// Obtient le prix du verre
        /// </summary>
        public double Price => _Price;

        #endregion

        #region Constructors

        /// <summary>
        /// Obtient ou défini le verre 
        /// </summary>
        /// <param name="name"> nom du verre</param>
        /// <param name="price"> prix du verre</param>
        public Glass(string name, double price)
        {
            if (name is null)
                throw new ArgumentNullException("Le nom ne peut pas être null");

            this._Name = name;
            this._Price = price;
        }

        #endregion

        public override string ToString() => ($" {this.Name} - {this.Price} euros");

        public double GetPrice() =>  this.Price;
    }
}
