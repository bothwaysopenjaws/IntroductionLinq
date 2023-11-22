using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionLinq.App.Class
{
    /// <summary>
    /// Barman
    /// </summary>
    internal class Barman : Employee
    {


        /// <summary>
        /// Instancie un barman
        /// </summary>
        /// <param name="lastName">Nom de famille</param>
        /// <param name="firstName">Prénom</param>
        public Barman(string lastName, string firstName) : base(lastName, firstName)
        {
        }

        public override void ManageOldestOrder()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Retourne les informations du barman
        /// </summary>
        /// <returns></returns>
        public override string ToString() => base.ToString() + " [Barman]";
    }



}
