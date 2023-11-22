using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionLinq.App.Class
{
    /// <summary>
    /// Serveur
    /// </summary>
    internal class Server : Employee
    {

        #region Constructor

        /// <summary>
        /// Instancie un serveur
        /// </summary>
        /// <param name="lastName">Nom de famille</param>
        /// <param name="firstName">Prénom</param>
        public Server(string lastName, string firstName) : base(lastName, firstName)
        {

        }

        public override void ManageOldestOrder()
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Methods

        /// <summary>
        /// Retourne les informations du serveur
        /// </summary>
        /// <returns></returns>
        public override string ToString() => base.ToString() + " [Serveur]";

        #endregion

    }
}
