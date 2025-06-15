using NetflixAbstractFactoryDemo.Factories;
using NetflixAbstractFactoryDemo.Interfaces;
using System;

namespace NetflixAbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("NETFLIX ABSTRACT FACTORY DEMO");
            Console.WriteLine("Design Pattern : Abstract Factory");
            Console.WriteLine("===================================");
            
            bool exit = false;
            
            while (!exit)
            {
                Console.WriteLine("\nChoisissez une option:");
                Console.WriteLine("1. Démonstration Smart TV");
                Console.WriteLine("2. Démonstration Mobile");
                Console.WriteLine("3. Démonstration Web");
                Console.WriteLine("4. Démonstration interactive");
                Console.WriteLine("5. Quitter");
                
                Console.Write("\nVotre choix: ");
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        DemoSmartTv();
                        break;
                    case "2":
                        DemoMobile();
                        break;
                    case "3":
                        DemoWeb();
                        break;
                    case "4":
                        DemoInteractive();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Option invalide. Veuillez réessayer.");
                        break;
                }
                
                if (!exit)
                {
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("===================================");
                    Console.WriteLine("NETFLIX ABSTRACT FACTORY DEMO");
                    Console.WriteLine("===================================");
                }
            }
        }
        
        static void DemoSmartTv()
        {
            Console.WriteLine("\n=== SMART TV CONFIGURATION ===");
            IStreamingPlatformFactory tvFactory = new SmartTvPlatformFactory();
            StreamingApp tvApp = new StreamingApp(tvFactory);
            tvApp.LaunchApp("user123");
            tvApp.WatchContent("movie-789", "4K", true);
            tvApp.OpenSettings();
        }
        
        static void DemoMobile()
        {
            Console.WriteLine("\n=== MOBILE CONFIGURATION ===");
            IStreamingPlatformFactory mobileFactory = new MobilePlatformFactory();
            StreamingApp mobileApp = new StreamingApp(mobileFactory);
            mobileApp.LaunchApp("user123");
            mobileApp.WatchContent("movie-789", "HD", false);
            mobileApp.OpenSettings();
        }
        
        static void DemoWeb()
        {
            Console.WriteLine("\n=== WEB CONFIGURATION ===");
            IStreamingPlatformFactory webFactory = new WebPlatformFactory();
            StreamingApp webApp = new StreamingApp(webFactory);
            webApp.LaunchApp("user123");
            webApp.WatchContent("movie-789", "Auto", true);
            webApp.OpenSettings();
        }
        
        static void DemoInteractive()
        {
            Console.WriteLine("\n=== DÉMONSTRATION INTERACTIVE ===");
            Console.WriteLine("Cette démo simule la détection automatique de plateforme");
            
            Console.Write("\nChoisissez votre plateforme (1=SmartTV, 2=Mobile, 3=Web): ");
            string platformChoice = Console.ReadLine();
            
            Console.Write("Entrez votre ID utilisateur: ");
            string userId = Console.ReadLine();
            
            Console.Write("Quel contenu souhaitez-vous regarder? ");
            string contentId = Console.ReadLine();
            
            Console.Write("Quelle qualité vidéo? (4K, HD, Auto): ");
            string quality = Console.ReadLine();
            
            Console.Write("Activer les sous-titres? (oui/non): ");
            bool subtitles = Console.ReadLine().ToLower() == "oui";
            
            IStreamingPlatformFactory factory = platformChoice switch
            {
                "1" => new SmartTvPlatformFactory(),
                "2" => new MobilePlatformFactory(),
                "3" => new WebPlatformFactory(),
                _ => new SmartTvPlatformFactory()
            };
            
            Console.WriteLine("\n=== EXÉCUTION AVEC LA PLATEFORME SÉLECTIONNÉE ===");
            StreamingApp app = new StreamingApp(factory);
            app.LaunchApp(userId);
            app.WatchContent(contentId, quality, subtitles);
            app.OpenSettings();
        }
    }
}
