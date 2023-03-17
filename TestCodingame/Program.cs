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

            #region Interface d'options Cycle de vie

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

            #region Net Garbage Collection

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

            #region Index Unique

            /*
            
            Pour définir un index unique sur la propriété SerialNumber de la classe Device en utilisant Entity Framework, 
            vous pouvez utiliser les attributs Index et IsUnique comme suit :

            csharp
            Copy code
            public class Device
            {
                public int Id { get; set; }

                [Index(IsUnique = true)]
                public string SerialNumber { get; set; }

                public string Name { get; set; }
            }
            L'attribut Index est utilisé pour indiquer que la propriété SerialNumber doit avoir
            un index et IsUnique est utilisé pour spécifier que cet index doit être unique.

            Assurez-vous que vous avez la référence suivante pour utiliser l'attribut Index :

            cpp
            Copy code
            using System.ComponentModel.DataAnnotations.Schema;
             
             
            */

            #endregion

            #region Dictionnary

            /*
            Comment les collisions de hachage sont-elles traitées dans la collection générique  Dictionary<Tkey,Tvalue> ? 
             
            */

            #endregion

            #region TDD

            /*
            Parmi ces deux procédures de développement, laquelle préconisez-vous ?
            
            Procedure # 1
            1- Ecrire des test pour la nouvelle fonctionnalité "F"
            2- Tester que F ne fonctionne pas
            3- Implémenter "F"
            4- Tester que "F" fonctionne correctement
             
            */

            #endregion

            #region Switch Expression

            /*
            var shippingCost = order switch
            {
                {Zip: "68501"} => 7.0M
                {Zip: "68512"} => 7.75M
                {Zip: "68540"} => 6.05M
                {Zip: "99787"} => 10.05M
                _=> throw new InvalidOperationException("Invalid zip")
            } 

            - Switch expression
            - Property pattern

             
            */

            #endregion

            #region HashCode

            /*
            Si deux objets sont égaux alors ils devraient avoir le même hashcode
            
            Vrai
            */

            #endregion

            #region Private_Protected
            /*
            A quoi sert le modificateur d'accès private protected quand il est placé sur un membre d'une classe

            Le modificateur d'accès private protected en C# est une combinaison de deux modificateurs d'accès :
            private et protected. 
            Lorsqu'il est placé sur un membre d'une classe, cela signifie que ce membre est accessible
            uniquement à partir de la classe elle-même et de ses classes dérivées situées dans le même assembly.

            - Il restreint l'accès de ce membre aux memebres de la même classe ou de ses sous-classes, mais seulement
            Si la sous-classe fait partie du même assembly que la classe.
            
            */
            #endregion

            #region StringTuple
            /*
            Qu'est-ce qui est vrai 0 à propos du stringTuple du code ci-dessous
            (string Message1, string Message2) stringTuple = ("Hello", "world");

            stringTuple est du type System.ValueTuple<string,string>
             
            */
            #endregion

            #region CastObject
            /*
            
                Shape s = new Square();
                Shape c = s as Circle;

                class Shape { }
                class Square : Shape { }
                class Circle : Shape { }

                la valeur de c est null

            Les trois premières lignes de code définissent trois classes : Shape, Square et Circle.
            Square et Circle sont tous deux dérivés de Shape, ce qui signifie qu'ils héritent de toutes 
            les propriétés et méthodes de Shape.

            La quatrième ligne de code crée une instance de la classe Square 
            et l'assigne à une variable de type Shape.
            Cela est possible car Square est une sous-classe de Shape, 
            donc un objet Square peut être traité comme un objet Shape.

            La cinquième ligne de code tente de convertir la variable s, 
            qui fait référence actuellement à un objet Square,
            en un objet Circle en utilisant l'opérateur as. 
            Comme Square n'est pas dérivé de Circle, 
            cette conversion échouera et la variable c sera assignée null.

            Par conséquent, la valeur de la variable c sera null.
            */
            #endregion

            #region Exception sans perdre la trace d'appel
            /*
               Considérerz l'exception suivante lancée à partir du bloc try. Vous voulez la relancer
               dans le bloc catch sans perdre la trace d'appels (stack trace) de l'exception initiale:

               public static void ErrorMethod()
               {
                   try
                   {
                       throw new Exception("Error occured");
                   }
                   // catch ...
               }

               quel extrait de code pouvez-vous utiliser?

                - catch(Exption ex)
                 {
                   ExceptionDispatchInfo.Capture(ex).Throw();
                 }




               - catch(Exption ex)
                 {
                   ExceptionDispatchInfo.Capture(ex).Throw();
                 }

               - catch(Exption ex)
                 {
                   throw ex;
                 }

               - catch(Exption ex)
                 {
                   throw new Exception("RETHROW", ex);
                 }

               _ catch
                 {
                   throw ;
                 }

               */
            #endregion

            #region SDK NET
            /*
            Vous voulez héberger une application NET Core self-contained sur une machine Windows.
            Que devez-vous installer sur cette machine?

            Runtime .Net Core

            il s'agit d'un composant essentiel qui permet d'exécuter des applications .NET Core sur la machine.
            Vous pouvez télécharger la dernière version de .NET Core runtime à partir du site Web Microsoft.
             
            */
            #endregion

            #region Casting
            /*
            Selectionnez le code C# qui est valide et ne déclenche pas d'exception
            
              if (obj is int multiply)
                result *= multiply




            if (obj as int multiplyBy)
                result *= multiplyBy;

            if (int multiply from obj)
                result *= multiply;
            
            if (obj is int multiply)
                result *= multiply;
            
            if (int multiply = (int)obj)
                result *= multiply;
             
            */
            #endregion

            #region Public Class A
            /*
                public class A
                {
                    public string str = "foo";
                    
                    public class B {}
                    
                    public static void Main(String[] args)
                    {
                        A.B b = new A.B()
                        Console.Writeline(b.str);
                    }
            
                } 

            - Une erreur à la compilation
            */
            #endregion

            #region Declaration de classe
            /*
                private static class A {}
                Dans quel(s) cas la déclaration de cette classe est-elle correcte?

                public class MyClass
                {
                    private static class A
                    {
                        // members of class A
                    }

                    // other members of MyClass
                }
                
                Correcte pour une classe interne

                - Pour une classe anonyme
                - Tous les cas
                - Aucun cas
                - Pour une classe interne
            */
            #endregion

            #region TryParse
            /*
            Comment un paramètre "out" peut-il être utilisé en C#
            
             int.TryParse("1", out int num);
           
            int.TryParse("1", out num);

            */
            #endregion

            #region Slice Array

            /*
                Quel code permet de retourner les nombres 4;5;6 depuis le tableau
            
                var numbers = new int[] {1, 2, 3, 4, 5, 6};

                var res6 = numbers[^3..^0];

            */

            #endregion

            #region MyRegion
            /*
            Quel code-contre permet d'affecter une référence vers un tableau à une variable
            ref var  element = ref (variable1 != null ? ref variable2[x] : ref variable3[x]);


            ref var  element = ref (variable1 != null ? ref variable2[x] : ref variable3[x]);
            ref var  element =  (variable1 != null ? ref variable2[x] : ref variable3[x]);
            ref var  variable1 = ref (variable1 != null ? variable2[x] : variable3[x]);
            ref var  element =  (variable1 != null ? variable2[x] : variable3[x]);
            var  element = ref (variable1 != null ? ref variable2[x] : ref variable3[x]);

            */
            #endregion

            #region Return Async
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

            #region Flux Asynchrone
            /*
            Quel est le meilleur moyen de créer un flux ("stream") qui a une longueur indéterminée et un intervalle
            de temps indéterminé entre ces éléments ?

            public static async System.Collections.Generic.IAsyncEnumerable<string> Stream()
            {
                while (await HasNextStringAsync())
                {
                    yield return await GetNextStringAsync();
                }
            }
             
            */
            #endregion

            #region Fonction Locataire
            /*
            Sélectionner la réponse qui est un exemple de fonction locale en C#

            public int DoSomething()
            {
                return 1 + DoSomething2();
                int DoSomething2()
                {
                    return 1;
                }
            }

            Dans cette réponse, la fonction DoSomething2 est définie à l'intérieur de la fonction DoSomething, 
            ce qui la rend locale à cette fonction.
            La fonction DoSomething peut donc appeler DoSomething2 comme une fonction locale.







            
            int DoSomething2()
            {
                return 1;
            }

            public int DoSomething()
            {
                return 1 + DoSomething2();
            }
            private int DoSomething2()
            {
                return 1;
            }

            public int DoSomething()
            {
                return 1 + DoSomething2();
            }
            local int DoSomething2()
            {
                return 1;
            }

            public int DoSomething()
            {
                return 1 + DoSomething2();
                int DoSomething2()
                {
                    return 1;
                }
            }


            */
            #endregion

            #region Execution Différee de List Count
            /*
            string[] fruits = { "apple", "orange", "apricot", "kiwi" };
            var list = new List<string>(fruits);
            IEnumerable<string> query = list.Where(c => c.Length== 4);
            list.Remove("kiwi");
            Console.WriteLine(query.Count()); => 0
            0

            */
            #endregion

            #region DoSomethingAsync
            /*
            Sélectionner le meilleur programme qui permette d'appeler le code ci-dessous

            public static async Task<String> DoSomethingAsync(string file)
            {
                using(var reader = new System.IO.StreamReader(file))
                {
                    return await reader.ReadToEndAsync();
                }
            } 

            public static async Task MainAsync(string[] args)
            {
                Console.WriteLine(await DoSomethingAsync(args[0]));
            }

            */
            #endregion

            #region Equals and GetHashedCode
            /*
            Le contrat liant Equals() et GetHashCode dit que deux objets ayant le même 
            hashcode doivent être égaux

            */
            #endregion

            #region Performance Async
            /*
            Quelle est la meilleure façon de déclarer "async" quand la performance est cruciale ?

             -  public async Task<decimal> MethodAsync()
                {
                    await Task.Delay(500);
                    return 9m;
                }
            Cette option utilise une tâche asynchrone qui ne bloque pas un thread,
            mais permet au thread de se libérer pour effectuer d'autres tâches importantes.
            De plus, elle utilise la structure Task qui est optimisée pour une utilisation
            efficace des ressources et une performance élevée.

            Les autres options utilisent soit Thread.Sleep, qui bloque un thread, 
            soit une tâche personnalisée (CustomTask) qui peut ne pas être optimisée pour les performances, 
            et donc pourraient ne pas être la meilleure option lorsque la performance est cruciale.





            
            - public async ValueTask<decimal> MethodAsync()
              {
                 await Task.Delay(500);
                 return 9m;
              }

            - public decimal MethodAsync()
              {
                 await Thread.Sleep(500)
                 return 9m;
              }

            - public async CustomTask<decimal> MethodAsync()
              {
                 await Task.Delay(500);
                 return 9m;
              }

            - public async Task<decimal> MethodAsync()
              {
                 await Task.Delay(500);
                 return 9m;
              }


            */
            #endregion

            #region Retourner une reference
            /*
            De quelles façon peut-on retourner une référence depuis une méthode en C#

            public ref int GetLocation(int[] intArray, int index)
            {
                return ref intArray[index]
            }




            
            public int GetLocation(int[] intArray, int index)
            {
                return ref intArray[index]
            } 
            
            public ref int GetLocation(int[] intArray, int index)
            {
                ref int result = intArray[index]
                return result;
            }
            
            public ref int GetLocation(int[] intArray, int index)
            {
                ref int result = ref intArray[index]
                return ref result;
            }
            
            public ref int GetLocation(int[] intArray, int index)
            {
                int result = intArray[index]
                return ref result;
            }

            public ref int GetLocation(int[] intArray, int index)
            {
                return  intArray[index]
            }
            
            public ref int GetLocation(int[] intArray, int index)
            {
                return ref intArray[index]
            }


            */
            #endregion

            #region Interpolation
            /*
            Comment peut-on créer une chaine de caractère dont on peut récupérer
            les variables plus tard, par exemple pour paramètrer une requête SQL 
            sans avoir à faire un parsing manuel de la chaine (mécanisme utilisé
            par exemple par entity Framework Core)?

            var string1 = $"Here is the number {number}.";


            var string1 = $"Here is the number {number}.";
            DelayedString string1 = $"Here is the number {number}.";
            FormattableString string1 = $"Here is the number {number}.";
            IFormattable string1 = $"Here is the number {number}.";
            SQLString string1 = $"Here is the number {number}.";
            */
            #endregion

            #region Access Concurrentiel
            /*
            Transformer la méthode Counter.Increment() pour qu'elle supporte l'accès concurrentiel de plusieurs threads
            

            class Counter
            {
                private static int count = 0
                private static readonly object countLock = new object()
                public static int Increment()
                {
                    lock(countLock)
                    {
                        count = count + 1
                        return count;
                    }
                }
                
            }

            */
            #endregion

            #region Declarer un parametre out qui ne sera pas utilise
            /*
             var isParsed = int.TryParse("1", out _);

            */
            #endregion

            #region Method
            /*
            Sélectionnez la méthode qui permet d'appeler la méthode ci-dessous
            en fournissant uniquement les paramètres str et number

            var result = Method(str, number: 55)

            public string Method (string str, string anotherString = " ",int number = 66)
            {
                //
            }

            - var result = Method(str, " ", 55)
            - var result = Method(str, number = 55)
            - var result = Method(str,number: 55)
            - var result = Method(str, number=: 55)
            - var result = Method(str, , 55)

            */
            #endregion

            #region Execution d'une classe au moment du run-time
            /*
            Quel mot clé permet d'optimiser les performances d'exécution d'une classe au moment
            d'un run-time

            Le mot clé qui permet d'optimiser les performances d'exécution 
            d'une classe au moment d'un run-time est "sealed".

            Le mot clé "sealed" est utilisé pour empêcher l'héritage d'une classe 
            ou la substitution de méthodes dans une classe dérivée.
            En marquant une classe comme "sealed", le compilateur peut effectuer 
            des optimisations supplémentaires pour
            l'exécution de cette classe, car il sait qu'aucune autre classe ne peut 
            hériter de celle-ci ou substituer ses méthodes.
            Cela peut conduire à une exécution plus rapide de la classe scellée.

            - new
            - sealed
            - abstract
            - virtual

            */
            #endregion

            #region Tuple et ValueTuple
            /*
            Qu'elles sont les affirmations vrai concernant les classes "Tuple" et "ValueTuple"

            1- Tuple et ValueTuple sont des types par valeur.
            2- Les données d'un ValueTuple sont modifiables, 
               car les valeurs sont stockées directement dans l'objet ValueTuple.


            
            - Tuple et ValueTuple sont des types par valeur
            - ValueTuple est un type par valeur, Tuple est un type par référence
            - Tuple est un types par valeur, ValueTuple est un type par référence
            - Les données d'un tuple sont modifiables
            - Tuple et ValueTuple sont des types par référence
            - Les données d'un Tuple sont en lecture seule
            - Les données d'un valueTuple sont modifiable
            - Les données d'un value tuple sont en lecture seule
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
