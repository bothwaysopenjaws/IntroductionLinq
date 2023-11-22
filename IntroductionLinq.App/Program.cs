using IntroductionLinq.App.Class;
using IntroductionLinq.App.Interfaces;
using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
        #region Initialisation

        Bar bar = new();
        bar.GenerateDatas();

        bool isFinished = false;
        string? userInput = "";

        #endregion

        #region Menu

        do
        {
            Console.Clear();
            string menuText = """
        --Bar Manager--
        1 - Lister les commandes
        2 - Lister les équipes
        3 - Lister les produits 
        ----------
        0 - Quitter

        """;
            Console.WriteLine(menuText);


            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    isFinished = true;
                    break;
                case "1":
                    Console.WriteLine(bar.GetOrderInfos());
                    break;
                case "2":
                    Console.WriteLine(bar.GetEmployeeInfos());
                    break;
                case "3":
                    Console.WriteLine(bar.GetGlasseInfos());
                    break;
                default:
                    break;
            }

            if (!isFinished)
            {
                Console.WriteLine("Appuyez sur une touche pour continuer");
                Console.ReadKey();
            }


        } while (!isFinished);

        #endregion

        /* Exemple sur les interface/linq
        List<IGetPrice> prices = new List<IGetPrice>();

        prices.Add(bar.Orders.FirstOrDefault());
        prices.Add(bar.Glasses.FirstOrDefault());
        prices.Add(bar.Glasses.FirstOrDefault());

        prices.First(p => p.GetPrice() > 10).GetPrice();
        prices.Any(p => p.GetPrice() > 10);

        */
    }


    #region  SubMenus

    public static void GetEmployeeMenu(Bar bar)
    {
        #region Initialisation
        
        bool isFinished = false;
        string? userInput = "";

        #endregion

        #region Menu

        do
        {
            
            string menuText = """
        --Gestion des employés--
        1 - Ajouter un barman
        1 - Ajouter un serveur
        2 - Supprimer
        3 - Rechercher
        ----------
        0 - Revenir au menu principal
        """;
            Console.WriteLine(menuText);


            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    isFinished = true;
                    break;
                case "1":
                    Console.WriteLine("Nom : ");
                    string? userInputLastName = Console.ReadLine();
                    Console.WriteLine("Prénom : ");
                    string? userInputFirstName = Console.ReadLine();


                    Employee employee = new Barman(userInputLastName, userInputFirstName);


                    bar.Employees.Add(employee);
                    break;
                case "2":
                    Console.WriteLine(bar.GetEmployeeInfos());
                    break;
                case "3":
                    Console.WriteLine(bar.GetGlasseInfos());
                    break;
                default:
                    break;
            }

            if (!isFinished)
            {
                Console.WriteLine("Appuyez sur une touche pour continuer");
                Console.ReadKey();
            }


        } while (!isFinished);

        #endregion
    }

    #endregion

}


