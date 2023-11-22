using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionLinq.App.Class
{
    /// <summary>
    /// Cocktail
    /// </summary>
    internal class Cocktail : Glass
    {
        #region Attributes

        /// <summary>
        /// Recette du cocktail
        /// </summary>
        private string? _Recipe;

        /// <summary>
        /// Liste des ingrédients d'un cockatail.
        /// </summary>
        private Dictionary<Beverage,double> _BeverageQuantity;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini les boissons et quantités
        /// </summary>
        internal Dictionary<Beverage, double> BeverageQuantity 
        { 
            get => _BeverageQuantity;
            set => _BeverageQuantity = value; 
        }


        /// <summary>
        /// Obtient ou défini la Recette
        /// </summary>
        public string? Recipe 
        { 
            get => _Recipe; 
            set => _Recipe = value; 
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructeur d'un cocktail.
        /// </summary>
        /// <param name="name">nom du cockatail</param>
        /// <param name="price"></param>
        public Cocktail(string name, double price) : base(name, price)
        {
            this.BeverageQuantity = new();
        }



        #endregion

        #region Methods

        #endregion

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString());
            result.AppendLine(" Recette : " + this.Recipe ?? "Non renseigné");

            foreach(KeyValuePair<Beverage,double> ingredient in this.BeverageQuantity)
            {
                result.AppendLine("  " + ingredient.Key.ToString() + " (" + ingredient.Value + "ml)" );
            }
            return result.ToString();
        }

    }
}
