using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroductionLinq.App.Core;
using IntroductionLinq.App.Enums;
using IntroductionLinq.App.Interfaces;

namespace IntroductionLinq.App.Class 
{
    /// <summary>
    /// Commande
    /// </summary>
    internal class Order : IGetPrice
    {
        #region Attributes

        /// <summary>
        /// Numéro de commande
        /// </summary>
        private readonly int _OrderNumber;

        /// <summary>
        /// Table associée à la commande
        /// </summary>
        private readonly Tables _Table;

        /// <summary>
        /// Liste des verres commandes
        /// </summary>
        private Dictionary<Glass, int> _Glasses;

        /// <summary>
        /// Date de la commande
        /// </summary>
        private DateTime _OrderDate;

        /// <summary>
        /// Statut de la commande
        /// </summary>
        private OrderStatus _OrderStatus;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient la table associée
        /// </summary>
        public Tables Table => _Table;

        /// <summary>
        /// Obtient le numéro associé
        /// </summary>
        public int OrderNumber => _OrderNumber;

        /// <summary>
        /// Liste des verres demandés
        /// </summary>
        internal Dictionary<Glass, int> Glasses 
        { 
            get => _Glasses; 
            set => _Glasses = value; 
        }

        /// <summary>
        /// Obtient ou défini la date de la commande
        /// </summary>
        public DateTime OrderDate 
        { 
            get => _OrderDate;
            set => _OrderDate = value; 
        }

        /// <summary>
        /// Statut de la commande
        /// </summary>
        public OrderStatus OrderStatus 
        { 
            get => _OrderStatus; 
            set => _OrderStatus = value; 
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Défini la commande
        /// </summary>
        /// <param name="table"></param>
        public Order(Tables table)
        {
            this.Glasses = new();
            this._Table = table;
            this._OrderNumber = OrderNumberManagerSingleton
                .GetInstance()
                .GetNewOrderNumber();
            this.Glasses = new();
            this.OrderDate = DateTime.Now;
            this.OrderStatus = OrderStatus.Creation;
        }

        #endregion

        /// <summary>
        /// Retourne les informations de la commande
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder result = new();




            result.AppendLine($"Commande N° {this.OrderNumber} ")
                .AppendLine($"  Table : {this.Table} le {this.OrderDate.ToString()}");

            foreach (KeyValuePair<Glass,int> glass in this.Glasses)
            {
                result.AppendLine($"    {glass.Key.Name} x {glass.Value}  ");
            }

            result.AppendLine($"Montant de la commande HT : {Math.Round(GetTotalAmountHT(), 2)} euros ");
            result.AppendLine($"                     TVA : {Math.Round(GetTotalAmountVat(), 2)} euros");
            result.AppendLine($"                     TTC : {Math.Round(GetTotalAmountWithVat(),2)}  euros");
            return result.ToString();
        }

        /// <summary>
        /// Montant de la commande HT
        /// </summary>
        /// <returns></returns>
        internal double GetTotalAmountHT()
        {
            double result = 0;

            foreach (KeyValuePair<Glass, int> glass in this.Glasses)
            {
                result += glass.Key.Price * glass.Value;
            }
           
            return result;
        }

        /// <summary>
        /// Montant de la TVA
        /// </summary>
        /// <returns></returns>
        internal double GetTotalAmountVat() => GetTotalAmountHT() * 0.20;

        /// <summary>
        /// Montant de la commande TTC
        /// </summary>
        /// <returns></returns>
        internal double GetTotalAmountWithVat() => GetTotalAmountHT() * 1.20;

        public double GetPrice() => this.GetTotalAmountWithVat();
    }
}
