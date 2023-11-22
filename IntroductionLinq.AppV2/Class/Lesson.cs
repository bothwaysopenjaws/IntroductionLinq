using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionLinq.AppV2.Class
{
    /// <summary>
    /// Leçon d'un cours
    /// </summary>
    internal class Lesson
    {
        /// <summary>
        /// Nom de la leçon
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description de la leçon
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Durée de la leçon en minute
        /// </summary>
        public int Duration { get; set; }

        public Course Course { get; set; }

        /// <summary>
        /// Constructeur d'une leçon d'un cours
        /// </summary>
        /// <param name="name">Nom de la leçon</param>
        /// <param name="duration">Durée en minute</param>
        /// <param name="course">Cours associé</param>
        public Lesson(string name, Course course, int duration = 0)
        {
            this.Name = name;
            this.Course = course;
            this.Duration = duration;

        }


    }
}
