using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IntroductionLinq.App.Class
{

    /// <summary>
    /// Classe d'un employé
    /// </summary>
    abstract class Employee
    {
        #region Attributes

        /// <summary>
        /// Nom de famille
        /// </summary>
        private readonly string _LastName;

        /// <summary>
        /// Nom de famille
        /// </summary>
        private readonly string _FirstName;

        /// <summary>
        /// Liste des commandes à gérer
        /// </summary>
        private List<Order> _Orders;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient le nom de famille
        /// </summary>
        public string LastName => _LastName;

        /// <summary>
        /// Obtient le prénom
        /// </summary>
        public string FirstName => _FirstName;

        /// <summary>
        /// Obtient ou défini les commandes associées
        /// </summary>
        internal List<Order> Orders 
        {
            get => _Orders; 
            set => _Orders = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Employé du bar
        /// </summary>
        /// <param name="lastName">nom de famille</param>
        /// <param name="firstName">prénom</param>
        public Employee(string lastName, string firstName)
        {
            if (lastName is null)
                throw new ArgumentNullException("Le nom de famille ne peut pas être null");
            if (firstName is null)
                throw new ArgumentNullException("Le prénom  ne peut pas être null");
            
            this._LastName = lastName;
            this._FirstName = firstName;

            this.Orders = new();
        }


        #endregion

        /// <summary>
        /// Gère la commande la plus ancienne
        /// </summary>
        public abstract void ManageOldestOrder();

        /// <summary>
        /// Nouvelle commande
        /// </summary>
        /// <param name="order"></param>
        public virtual void AddNewOrder(Order order) => this.Orders.Add(order);

        public override string ToString() => this.LastName.ToUpper() + " " + this.FirstName; 



    }
}
