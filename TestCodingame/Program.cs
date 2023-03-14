using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TestCodingame.Exo10;


namespace TestCodingame
{
    class Program
    {
        static void Main(string[] args)
        {


            #region SendGridEmailService

            /*
             Où enrigistrer SendGridEmailService, une implémentation de IEmailService,
             dans une application ASP.NET Core ?

             Startup.ConfigureServices

             */

            #endregion

            #region Entity Framework

            /*
             Vous travaillez sur un projet avec une base de données existante. Elle doit 
             être prise en charge et utilisée dans une nouvelle application, qui doit 
             être dévéloppée à l'aide d'Entity Framework. Une équipe DB distincte est dédiée
             à la gestion de la base de données et seuls les membres de cette équipe sont autorisés
             à apporter des modifications au schéma de la base de données
             
             Quelle approche Entity Framework conviendrait à ces cas ?
             
             Database-First
             */

            #endregion

            #region Typage fort

            /*
            Dans une application ASP.NET Core MVC, comment spécifier une classe Model dans une vue
            avec typage fort (strongly typed)

            @model User
             
            */

            #endregion

            #region DbContext

            /*
            En utilisant l'Enity Framework, quelle méthode de DbContext devez-vous remplacer afin de
            configurer manuellement le modèle de base de données

            OnModelCreating

            */

            #endregion

            #region Garbage Collection

            /*
             Quelle méthode peut être utilisée pour exécuter une garbage collection et libérer la
             mémoire du managed heap?

             GC.Collect()
             */

            #endregion

            #region Trafic en temps réel

            /*
            Vous souhaitez concevoir une application web ASP.NET Core qui permet 
            aux utilisateurs de consulter des tableaux de bord mis à jour de mannière
            continue. Ces tableaux de bord affichent des données de trafic en temps
            réel.
            Quel package ou framework pouvez-vous utiliser pour atteindre cet objectif

            SignalR

            */

            #endregion

            #region JIT

            /*
            Dans une application .Net, la traduction du code source(écrit en C#, F# ou 
            Visual Basic) en code machine passe par plusieur étapes intermédiaires.

            Quel composant est responsable de la génération d'un code natif à partir
            du code CIL?

            Compilateur Just-in-time (JIT)

            */

            #endregion

            #region Route en ASP.NET

            /*
            Considérer la méthode et la route suivante d'une application ASP.NET Core:
            
            [Route("orders/{id:int}")]
            public async Task<IActionResult> GetOrderById(int id)
            {
              var order = await _orderService.GetById(id);
              return OK(order);
            }
            Cela retournera une réponse "404" page not found
            */

            #endregion

            #region Assembly

            /*
            Vous installez un assembly de Nuget dans votre application .NET qui sera
            partagé entre d'autres applications sur votre machine

            Où cette bibliothèque sera-t-elle stockée ?
            
            Dans le GAC

            */

            #endregion

            #region Interface d'options

            /*
            Quelles interfaces d'options sont enregistrées en tant que singleton dans 
            conteneur DI(Dependency Injection) ASP.NET?
                - IOptionsMonitor<TOptions>
                - IOptions<TOptions>
            */

            #endregion

            #region Interface d'options

            /*
            Vous exécutez une application ASP.NET Core. Des modifications de configuration
            ont été apportées au fichier appsettings.json pendant l'exécution de l'application

            Quelles Interfaces d'Options peuvent être utilisées pour obtenir la valeur de configuration
            actuelle de appsettings.json lors d'une Nouvelle requête?
                - IOptionsSnapshot
                - IOptionsFactory
             
            */

            #endregion

            #region Typage faible

            /*
            Quelles options peuvent être utilisées pour transmettre des données avec un typage
            faible (weakly typed) à la Vue d'une opération ASP.NET Core MVC?
                - ViewData
                - ViewBag
            */

            #endregion

            #region Filter ASP.NET Core

            /*
            Les filtres sont essentiellement utilisés dans une application ASP.NET Core pour éviter
            de dupliquer. Ils permettent au code d'être exécuté avant ou après certaines étapes 
            spécifique du process de traitement des requêtes.
            
            Celui qui n'est pas un filtre est : Filtres de route

            les fitres sont :                
             - Filtres de ressouces
             - Filtres d'exception
             - Filtres d'action
             - Filtres de resultat
             - FIltres d'autorisation
            
            */

            #endregion

            #region Filter ASP.NET Core

            /*
            Vous avez une application écrite avec .NET Framework. Considérez
            séquence d'événement suivante:
               - Une nouvelle variable est créée et est référencée par d'autres
                 parties du code 
                 var foo = new Foo();
               - La 1ère garbage collection est effectuée par le CLR
               - La 2ème garbage collection est effectuée par le CLR
               _ foo n'est plus utilisée(inacessible depuis la racine de l'application)
               - la 3ème garbage collection est effectuée par le CLR

            A partir de quand la mémoire allouée à foo pourra-t-elle être libérée du heap ?

            Avec la 3ème garbage collection
            
            */

            #endregion

            #region Async Await

            /*
            Vous utilisez un service avec une méthode pour récupérer les taux de change à partir d'une API tierce :
            class ExchangeRatesService
            {
                //...
                public async Task<ExchangeRates> GetRates()
                {
                    var rates = await this.httpClient.GetAsync(ExchangeEndpoint);
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ExchangeRates>(authContent);
                    return result;
                }
            }
            Quelles options exécutent cette méthode et récupèrent le résultat de manière asynchrone ?
            var exchangeRatesService = new ExchangeRatesService(); 
             

            var rates = await exchangeRatesService.GetRates();
            var rates = exchangeRatesService.GetRates().Result;

            */

            #endregion

            #region Throw exception

            /*
             En C#, comment désigne-t-on le bloc de code suivant ?
             public string DoSomething(string str)
             {
                return str ?? throw new ArgumentNullException(nameof(str));
             }
             
             Throw Expression
             
             
             */

            #endregion

            #region Coalescence de la valeur null

            /*
            Quelle est l'alternative recommandée au code ci-dessous ?
            int? number = null;
            ...
            if (number == null)
            {
                number = 1;
            }
            
            int? number = null;
            ...
            number ??= 1;
             
            */

            #endregion

            #region Switch avec clause when

            /*
             
            Sélectionnez la réponse qui représente une alternative au code ci-dessous :
            foreach (var number in numberList)
            {
                 switch(number) {
                 case 1:
                 case 2:
                 case 3:
                 return "yes";
                 case 4:
                 case 5:
                 return "no";
                 default:
                 return "unknown";
                 }
            }
             
                foreach (var number in numberList)
                {
                    switch(number) {
                    case var x when x >= 1 && x <= 3:
                        return "yes";
                    case var x when x >= 4 && x <= 5:
                        return "no";
                    default:
                        return "unknown";
                    }
                }

             
             */

            #endregion

            #region Méthode de la garbage collection

            /*
            Quelle méthode peut être utilisée pour exécuter une garbage collection et libérer la mémoire du
            managed heap ? 
            
            GC.Collect()
            */

            #endregion

            #region Code first d'Entity Framework

            /*
            En utilisant l'approche code-first d'Entity Framework, vous écrivez le
            modèle d'entité suivant:

            class Car
            {
                public Guid VIN {get; set;}
                public string Make {get; set;}
                public string Model {get;set;}
                public int Year {get; set;}
            }
            Quelles sont les façons correctes de déclarer VIN comme clé primaire ?


            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Car>()
                    .HasKey(c => c.VIN);
            }
            ----------------------------------------------------------------------
            class Car
            {
                [Key]
                public Guid VIN { get; set; }
                public string Make { get; set; }
                public string Model { get; set; }
                public int Year { get; set; }
            }
             
            */

            #endregion

            #region Middleware Net

            /*
             
            Vous  travaillez sur une application ASP.NET Core et vous souhaitez servir 
            certains fichiers statique situés dans le dossier racine web par défaut de
            votre application.
            Quelle méthode middleware devriez-vous  ecrire à la  //

            app.UseStaticFiles();

            */

            #endregion

            #region Migration Linq

            /*
            Vous travaillez dans une équipe qui développe une application utilisant Entity Framework.
            Les dernières modifications que vous avez extraites de l'outil de source control contiennent
            de nouvelles migrations. 

            Quelles commande devez-vous exécuter afin de mettre à jour votre base de données locale?

            Update-Database
             
            */

            #endregion

            #region Save Entity Framework

            /*
             Vous travaillez sur un projet Entity Framework Core. Vous disposez
             de la méthode suivante pour ajouter une nouvelle commande dans la 
             base de données:
             
             public async Task<bool> SaveOrder(Order order)
             {
                using(var context = new ApplicationDbcontext())
                {
                    context.order.Add(order);
                    context.SaveChanges();
                }
             }
            */

            #endregion

            //var r = Exo_9.CountMax();

            //var r1 = Exo_10.Total();

            //Console.WriteLine("Resultat : {0}", r1);

            //var r2 = Exo_11.Test(1, 5);
            //var r3 = Exo_11.Test(2, 3);
            //var r4 = Exo_11.Test(-3, 4);

            //Console.WriteLine("Resultat : {0} - {1} - {2}", r2, r3, r4);

            //Exo_15.DisplayString();

            //Exo_17.TestStruct();

            //Exo_18.Count();

            //Exo_22.Test();

            //var r2 = Exo_25.Reshape(3, "abc de fghij");
            // var r3 = Exo_25.Reshape(2, "1 23 456");

            Console.WriteLine("abc\rde\rfghij");

            //Console.WriteLine("Le resultat est : {0}", 01 | 11); //=> 11;
            //Console.WriteLine("Le resultat est : {0}", 00 | 11); //=> 11;
            //Console.WriteLine("Le resultat est : {0}", 10 & 11); //=> 10;
            //Console.WriteLine("Le resultat est : {0}", 1<<0); //=> 1

            //Console.WriteLine("Le resultat est : {0}",  0<<1); //=> 0
            Console.WriteLine("Le resultat est : {0}", Exo_10.Total()); //=> 0


            // 4 - Exo
            #region Exo 4

            /* public interface A : B, C, D {} */
            /* Cette interface est correcte si B,C,D sont egalement des interfaces */

            #endregion

            // 8 - Exo
            #region Exo 8
            /*
              Vous avez une bibliotheque en C#. Parmi ces operations, laquelle privilegiez-vous pour traiter
              un comportement inattendu ?

                  - return false
                  - System.Environnement.Exit(-1)
                  - Console.WriteLine("Erreur : Comportement inattendu")
                  - throw new ComportementInattenduException() *

              */
            #endregion          

        }


    }

   
}
