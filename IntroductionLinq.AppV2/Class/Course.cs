using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionLinq.AppV2.Class
{
    /// <summary>
    /// Cours
    /// </summary>
    internal class Course
    {
        /// <summary>
        /// Nom du cours
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Liste des lessons
        /// </summary>
        public List<Lesson> Lessons { get; set; }

        /// <summary>
        /// Constructeur d'un cours
        /// </summary>
        /// <param name="name">Nom du cours</param>
        public Course(string name) 
        {
            this.Name = name;
            this.Lessons = new List<Lesson>();
        }
    }
}
