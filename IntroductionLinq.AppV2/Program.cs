// See https://aka.ms/new-console-template for more information
using IntroductionLinq.AppV2.Class;

Console.WriteLine("Hello, World!");



List<Course> courses = new List<Course>();

Course course1 = new Course("C#");
Course course2 = new Course("Java");

course1.Lessons.Add(new Lesson("Linq", course1, 120));
course1.Lessons.Add(new Lesson("WPF", course1, 240));
course1.Lessons.Add(new Lesson("Test unitaires", course1, 10));

courses.Add(course1);


bool isFinished = false;
do
{
    Console.Clear();

    string textMenu =
        """
        1 - First()
        2 - FirstOrDefault()
        3 - Single()
        4 - SingleOrDefault()
        5 - ToList()
        6 - Count()
        7 - Min()
        8 - Max()
        9 - Last()
        10 - LastOrDefault()
        11 - Average()
        12 - Where()
        13 - Conditionnels
        14 - Select()
        """;

    Console.WriteLine(textMenu);
    string? inputUser = Console.ReadLine();

    switch (inputUser)
    {
        case "1":
            // Récupère le premier item
            Console.WriteLine(course1.Lessons.First().Name);
            Console.WriteLine(course2.Lessons.First());
            break;
        case "2":
            Console.WriteLine(course1.Lessons.FirstOrDefault()?.Name);
            Console.WriteLine(course2.Lessons.FirstOrDefault()?.Name);
            break;
        case "3":
            Console.WriteLine(course1.Lessons.Single( p => p.Name == "Linq")?.Name);
            Console.WriteLine(course1.Lessons.Single(p => p.Course.Name == "C#")?.Name);
            break;
        case "4":
            Console.WriteLine(course1.Lessons.SingleOrDefault(p => p.Name == "Linq")?.Name);
            Console.WriteLine(course1.Lessons.SingleOrDefault(p => p.Course.Name == "C#")?.Name);
            break;
        case "5":
            // Recréé une nouvelle liste en se basant sur l'ancienne.
            List<Lesson> lesson2 = course1.Lessons.ToList();
            // Existe pour d'autres énumération, ToDictionnary, ToArray, etc...
            break;
        case "6":
            // Retourne le nombre d'élément de la séquence
            //Contains permet de filtrer sur les éléments qui contienne n
            Console.WriteLine(course1.Lessons.Count(lessonTemp => lessonTemp.Name.Contains("n")));
            break;
        case "7":
            // Indique la valeur minimale suivant le prédicat passé en paramètre
            Console.WriteLine(course1.Lessons.Min(lessonTemp => lessonTemp.Duration));
            break;
        case "8":
            // Indique la valeur maximale suivant le prédicat passé en paramètre
            Console.WriteLine(course1.Lessons.Max(lessonTemp => lessonTemp.Duration));
            break;
        case "9":
            Console.WriteLine(course1.Lessons.Last().Name);
            break;
        case "10":
            Console.WriteLine(course1.Lessons.LastOrDefault()?.Name);
            break;
        case "11":
            Console.WriteLine(course1.Lessons.Average(lessonTemp => lessonTemp.Duration));
            break;
        case "12":
            // Filtrer une énumération suivant la condition : 
            IEnumerable<Lesson> lessonFiltrered =  course1.Lessons.Where(lessonTemp => lessonTemp.Duration > 60);
            // ON peut enchaîner les instructions 
            course1.Lessons
                .Where(l => l.Course.Name == "C#")
                .Where(l => l.Name.Contains("n"))
                .Average(l =>  l.Duration);

            // Filtre les eléments par leur types
            // List<Cocktail> list = Glasses.OfType<Cocktail>();
            // List<Beverage> list = Glasses.OfType<Beverage>();
            break;
        case "13":

            /// Renvoie un bool qui indique si il y'a au moins un élément qui vérifie la condition
            course1.Lessons.Any(l => l.Name.Contains("n"));
            /// Renvoie un bool qui indique si tous les éléments vérifient la condition
            course1.Lessons.All(l => l.Name.Contains("n"));
            break;
        case "14":
            // Retourne la liste des noms des leçons. On "Selectionne" une propriété à exposer dans un IEnumerable.
            course1.Lessons.Select(l => l.Name);
            // Permet de discriminer les doublons.
            course1.Lessons.Distinct();
            break;
        default:
            break;


    }
    Console.ReadKey();

} while (!isFinished);