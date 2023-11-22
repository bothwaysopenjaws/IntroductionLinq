using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionLinq.App.Class
{
    /// <summary>
    /// 
    /// </summary>
    internal class Bar
    {
        #region Attributes

        /// <summary>
        /// Liste des employés
        /// </summary>
        private List<Employee> _Employees;

        /// <summary>
        /// Liste des commandes
        /// </summary>
        private List<Order> _Orders;

        /// <summary>
        /// Liste des verres
        /// </summary>
        private List<Glass> _Glasses;

        #endregion

        #region Properties

        /// <summary>
        /// Liste des employés
        /// </summary>
        internal List<Employee> Employees { get => _Employees; set => _Employees = value; }

        /// <summary>
        /// Liste des commandes
        /// </summary>
        internal List<Order> Orders { get => _Orders; set => _Orders = value; }

        /// <summary>
        /// Liste des verres disponibles.
        /// </summary>
        internal List<Glass> Glasses { get => _Glasses; set => _Glasses = value; }

        #endregion

        #region Constructor

        /// <summary>
        /// Instancie le bar
        /// </summary>
        public Bar()
        {
            this.Employees = new List<Employee>();
            this.Orders = new List<Order>();
            this.Glasses = new List<Glass>();
        }

        #endregion

        #region Methods

        #region DataGeneration

        /// <summary>
        /// Génères les données de test
        /// </summary>
        internal void GenerateDatas()
        {
            this.GenerateEmployees();
            this.GenerateGlasses();
            this.GenerateOrders();
        }

        /// <summary>
        /// Génère les serveurs
        /// </summary>
        private void GenerateEmployees()
        {
            this.Employees.Add(new Server("Lorie", "Culaire"));
            this.Employees.Add(new Server("Emma", "TonPouce"));
            this.Employees.Add(new Barman("Anne", "Hulère"));
        }

        /// <summary>
        /// Génère les verres
        /// </summary>
        private void GenerateGlasses()
        {
            Beverage water = new Beverage("Eau", 8.5);
            Beverage vodka = new Beverage("Vodka", 2);
            Beverage hotOil = new Beverage("Huile pimentée", 6);
            Beverage juice = new Beverage("Jus de fruit", 3);

            //Cocktail 1
            Cocktail laMuerte = new("La Muerte", 4)
            {
                Recipe = "Concentrer l'huile à petit feu, puis ajouter y la vodka"
            };
            laMuerte.BeverageQuantity.Add(hotOil, 0.8);
            laMuerte.BeverageQuantity.Add(vodka, 0.2);

            this.Glasses.Add(water);
            this.Glasses.Add(vodka);
            this.Glasses.Add(hotOil);
            this.Glasses.Add(juice);
            this.Glasses.Add(laMuerte);
        }

        /// <summary>
        /// Génère les serveurs
        /// </summary>
        private void GenerateOrders()
        {
            this.Orders.Add(new Order(Enums.Tables.Table1));
            this.Orders.Add(new Order(Enums.Tables.Table2));
            this.Orders.Add(new Order(Enums.Tables.Comptoir));

            this.Orders.ElementAt(1).Glasses.Add(this.Glasses.ElementAt(1), 3);
            this.Orders.ElementAt(2).Glasses.Add(this.Glasses.ElementAt(4), 3);
            this.Orders.ElementAt(2).Glasses.Add(this.Glasses.ElementAt(3), 3);
        }


        #endregion

        #region DataProcess


        internal string GetOrderInfos()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Commandes actuelles : ");
            foreach (Order order in this.Orders)
            {
                result.AppendLine($"{order.ToString()} " + Environment.NewLine);
            }

            return result.ToString();
        }

        /// <summary>
        /// Obtient les informations des employés
        /// </summary>
        /// <returns></returns>
        internal string GetEmployeeInfos()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Liste des employés : ");
            foreach (Employee employee  in this.Employees)
            {
                result.AppendLine($"{employee} " + Environment.NewLine);
            }

            return result.ToString();
        }

        /// <summary>
        /// Obtient la liste des verres possbles
        /// </summary>
        /// <returns></returns>
        internal string GetGlasseInfos()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Liste des verres : ");
            foreach (Glass glass in this.Glasses)
            {
                result.AppendLine($"{glass} " + Environment.NewLine);
            }

            return result.ToString();
        }




        public double GetTotalOrders()
        {
            double result = 0;

            foreach (Order order in this.Orders)
            {
                result += order.GetTotalAmountWithVat();
            }
            return result;
        }

        public double GetTotalOrdersV2()
        {
            double result = 0;
            this.Orders.ForEach(order => result += order.GetTotalAmountWithVat());
            return result;
        }



        #endregion

        #endregion

    }
}
