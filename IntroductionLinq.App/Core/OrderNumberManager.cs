using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionLinq.App.Core
{
    /// <summary>
    /// Gère les numéros de commandes
    /// </summary>
    public sealed class OrderNumberManagerSingleton
    {

        #region Attributes

        /// <summary>
        /// Instance statique
        /// </summary>
        private static OrderNumberManagerSingleton? _Instance;

        /// <summary>
        /// Dernier numéro
        /// </summary>
        private int _LastOrderNumber;

        #endregion

        #region Properties


        /// <summary>
        /// Obtient ou défini le dernier numéro
        /// </summary>
        private int LastOrderNumber 
        { 
            get => _LastOrderNumber; 
            set => _LastOrderNumber = value;
        }

        #endregion

        /// <summary>
        /// Constructeur privé de la classe OrderNumberManagerSingleton
        /// </summary>
        private OrderNumberManagerSingleton() => LastOrderNumber = 0;

        /// <summary>
        /// Obtient l'instance du gestionnaire de numéro de commande
        /// </summary>
        /// <returns></returns>
        public static OrderNumberManagerSingleton GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new OrderNumberManagerSingleton();
            }
            return _Instance;
        }

        /// <summary>
        /// retourne le nouveau numéro
        /// </summary>
        /// <returns></returns>
        public int GetNewOrderNumber()
        {
            LastOrderNumber++;
            return LastOrderNumber;
        }

    }
}
