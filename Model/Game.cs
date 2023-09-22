using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TextAdventureGame.Model
{
    internal class Game
    {
        static string CharacterName;
        private static string SaveFileName = Path.Combine(Environment.CurrentDirectory, "savegame.txt");
        private static string playerLocation { get; set; } = "";

        static void Endgame()
        {
            string save = Console.ReadLine();

            if (save == "s")
            {
                SaveGame();
                Console.WriteLine("Het spel wordt afgesloten");
                Environment.Exit(0);
            }
        }

        internal static void StartGame()
        {
            Console.WriteLine(@"
   __            _                    __     __ _     _            _             ___ _                     _      _                    __                      _      
  /__\ ___  __ _| |_ __ ___     ___  / _|   /__\ | __| | ___  _ __(_) __ _ _    / __\ |__  _ __ ___  _ __ (_) ___| | ___  ___    ___  / _|   /\/\   __ _  __ _(_) ___ 
 / \/// _ \/ _` | | '_ ` _ \   / _ \| |_   /_\ | |/ _` |/ _ \| '__| |/ _` (_)  / /  | '_ \| '__/ _ \| '_ \| |/ __| |/ _ \/ __|  / _ \| |_   /    \ / _` |/ _` | |/ __|
/ _  \  __/ (_| | | | | | | | | (_) |  _| //__ | | (_| | (_) | |  | | (_| |_  / /___| | | | | | (_) | | | | | (__| |  __/\__ \ | (_) |  _| / /\/\ \ (_| | (_| | | (__ 
\/ \_/\___|\__,_|_|_| |_| |_|  \___/|_|   \__/ |_|\__,_|\___/|_|  |_|\__,_(_) \____/|_| |_|_|  \___/|_| |_|_|\___|_|\___||___/  \___/|_|   \/    \/\__,_|\__, |_|\___|
                                                                                                                                                         |___/        
");
            Console.WriteLine("Welcome to Chronicles of Magic! In this game we will be exploring the world of Eldoria\n");
            Console.WriteLine("Would you like to get some basic instructions before the game starts?");

            Console.WriteLine("1) No I want to start playing\n" +
                              "2) Yes I want some instuctions\n" +
                              "3) Load game");
            Console.WriteLine();
            Console.Write("Your answer?\n");

            string answer = Console.ReadLine();

            if (answer == "1")
            {
                NameCharacter();
            }

            if (answer == "2")
            {
                HelpDialog("Hello I'm Suzie your helper for all your questions during your trip through Elodia. Feel free to ask my help anytime! As asked here are some instructions to the world of Eldoria!\n");
                HelpDialog("You just entered the world of Eldoria! This world is inhabited by Eldorians. " +
                    "Eldorians are a unique species native to the mystical realm of Eldoria. They possess distinct physical and mystical characteristics that set them apart from other beings in the world. " +
                    "Eldorians are known for their ethereal beauty and radiant skin, which seems to shimmer with a subtle, otherworldly glow. " +
                    "Their most striking feature is their hair, which can come in various vibrant, almost luminescent colors, often matching the hues of the environment they live in." +
                    "\r\n\r\nEldorians have an innate connection to the natural energies of Eldoria, allowing them to harness the powers of the land. They are skilled in various forms of nature magic, which they use to maintain the balance of their world. " +
                    "Eldorians have the ability to communicate with the spirits of the land, animals, and plants, fostering a deep bond with their surroundings.\r\n\r\nTheir society is organized around communal living within immense, living tree cities that blend seamlessly with the forest. " +
                    "These cities are grown from colossal, sentient trees that have evolved alongside the Eldorians over generations. Eldorians are also known for their harmonious coexistence with the diverse flora and fauna of Eldoria, which they consider as equals and protectors of their realm." +
                    "\r\n\r\nEldorians are inherently peaceful and strive to preserve the pristine beauty of their world. However, they can call upon the might of nature to defend their homeland when threatened, making them formidable protectors. " +
                    "Their culture is rich in art, music, and storytelling, with a deep reverence for the cycles of nature and the mysteries of the cosmos.\r\n\r\nThese Eldorians are a wondrous addition to the world of Eldoria, with their unique blend of mystical abilities, natural harmony, and vibrant, enchanting appearances.");
                HelpDialog("Your choices in the game will earn you strength, charisma points and sometimes even villager points that will help your progress in the game or unlock secret dialog.Be carefull as your choices will affect the path you set on and your ending in the world of Eldoria. Good luck and enjoy!\n\n");
                NameCharacter();
            }

            if (answer == "3")
            {
                ResumeGame();
                GameProgress();
            }
        }

        static void NameCharacter()
        {
            Console.WriteLine("You will need a name to go on this adventure. What will it be?\n");
            CharacterName = Console.ReadLine();
            Console.WriteLine($"Great! Your character is now named {CharacterName} ");
            Console.ReadLine();
            Console.Clear();
            GameProgress();
        }

        internal static void GameProgress()
        {
            Console.WriteLine($" TEST: {playerLocation}");
            HelpDialog("Press s twice to save\n\n");

            int charismaPoints = 0;
            int strengthPoints = 0;
            int simonPoints = 0;
            int tamaraPoints = 0;

            string answer = " ______________________________";
            
            if(playerLocation == "")
            {
                Console.WriteLine("You wake up on the floor slowly opening your eyes as you see a stranger hovering above you\n");
                SimonDialog("Hey there are you okay?\n");

                Console.WriteLine("How do you answer?\n" +
                      "1). I'm okay thank you\n" +
                      "2). No, ofcourse I'm not.");
                Console.WriteLine();
                Console.Write("Your awnser\n");

                answer = Console.ReadLine();
            }

            if (answer == "1" || playerLocation.StartsWith("path 1."))
            {
                string answerSave = "path 1";
                playerLocation = answerSave;
                charismaPoints++;
                simonPoints++;

                HelpDialog("Good job, you gained charismapoints!, These will help you gain the trust of villagers and keep you on the good path!\n\n");
                SimonDialog("*Simon looks happy* That's great! Here let me help you up.\n");
                Console.WriteLine("The strager helps you up and dust of your clothes.\n");
                SimonDialog("My name is Simon by the way, what's yours?\n");
                McDialog($"My name is {CharacterName}.\n");
                McDialog($"It's nice to meet you Simon, would you mind telling me how I get to the nearest village?\n");
                SimonDialog("Ofcourse not! I'll walk you there.\n");
                Console.WriteLine("You and Simon chat while walking towards the village.\n");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You walk alongside a raging river until you arrive at a beautifull village with light colored houses and blue roofs surounded by nature and wildlife. At the center of the village lies a beautifull pond surounded by plants." +
                    "Simon leads you to the center of the sqare where a tall woman with a spear is leaning against a statue waiting for you.\n");
                TamaraDialog("You must be the human who woke up in the forest. My name is Tamara, what's yours?\n");
                McDialog($"My name is {CharacterName}.\n");
                TamaraDialog($"Alright {CharacterName} you can explore a little more, or I can give you some basic survival and combat training. What do you want to do?\n");
                
                Console.WriteLine("What do you do?\n" +
                    "1). Take your time to explore the village\n" +
                    "2). Take the training");
                Console.WriteLine();
                Console.Write("Your action\n");

                string answer1Action = Console.ReadLine();

                if (answer1Action == "1" || playerLocation.StartsWith("path 1.1."))
                {
                    string answer1ActionSave = "path 1.1";
                    playerLocation = answer1ActionSave;
                    simonPoints++;

                    SimonDialog("Alrighty! I'll give you a tour\n");
                    Console.WriteLine("Tamara shrugs her shoulders and walks off as you turn towards Simon to start your tour\n");
                    Console.WriteLine("Simon gives you a tour through the village telling you more about the architecture and the history of the Elodians. " +
                        "Just as he wants to tell you about the folklore of Elodia a loud shriek fills the air\n");
                    SimonDialog("That doesn't sound good, let's check it out!\n");
                    Console.WriteLine("You and Simon run to the village where you see a large blue dragon flying through the village wreaking havoc on the houses and villagers. " +
                        "Everyone is in panic\n");
                    Console.WriteLine("What do you do?\n" +
                        "1). Attack\n" +
                        "2). Run");
                    Console.WriteLine();
                    Console.Write("Your action\n");

                    string answer1Action1 = Console.ReadLine();

                    if (answer1Action1 == "1" || playerLocation.StartsWith("path 1.1.1."))
                    {
                        string answer1Action1Save = "path 1.1.1";
                        playerLocation = answer1Action1Save;
                        if (strengthPoints > 2)
                        {
                            Console.WriteLine("You run towards the dragon in full speed. It tries to throw you in the wall with it's tail, but you jump over the tail instead. You jump up plunging your sword in the dragons side and pull yourself up getting on the dragons back." +
                                "You pull your sword out of the dragons side and run towards it's head, but before you have time to plunge your sword in it's head it shakes you of leaving you hanging on at one of it's horns." +
                                "The dragon tries to bite you, but you manage to swing yourself up sword in hand as slice the dragons head off in your fall. You land on the floor as the dragons head falls at your feet.\n\n");
                            WinDialog("You won!\n");
                            HelpDialog("Wow, you won the game, congrats! You can exit or restart the game to get a different ending\n");

                            Console.WriteLine("What do you do?\n" +
                            "1). Restart\n" +
                            "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }

                        if (strengthPoints > 1)
                        {
                            Console.WriteLine("You run towards the dragon, but it throws you in to a wall with it's tail. You quickly get up just before the dragons claw hit the wall you where just laying against." +
                                "You analize the dragons movent and jump up on it's tail running up the dragons back to it's head. The dragon tries to shake you off, but Tamara throws her spear in it's side making the dragon stop moving you run to it's head pluning your sword into the dragons head." +
                                "The dragon falls on the floor lifelesly as you get of of it's back\n\n");
                            WinDialog("You won!\n");
                            HelpDialog("Wow, you won the game, congrats! You can exit or restart the game to get a different ending\n");

                            Console.WriteLine("What do you do?\n" +
                            "1). Restart\n" +
                            "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You try to attack the dragon, but he opens his mouth and breathes hot fire killing you on the spot\n\n");
                            DeathDialog("You died\n");
                            HelpDialog("Oh no, you died. You can exit or restart the game\n");

                            Console.WriteLine("What do you do?\n" +
                            "1). Restart\n" +
                            "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                    }

                    if (answer1Action1 == "2" || playerLocation.StartsWith("path 1.1.2."))
                    {
                        string answer1Action1Save = "path 1.1.2";
                        playerLocation = answer1Action1Save;
                        Console.WriteLine("You try to run awway from the dragon, but he opens his mouth and breathes hot fire killing you on the spot\n\n");
                        DeathDialog("You died\n");
                        HelpDialog("Oh no, you died. You can exit or restart the game\n");

                        Console.WriteLine("What do you do?\n" +
                        "1). Restart\n" +
                        "2). Exit");
                        Console.WriteLine();
                        Console.Write("Your action\n");

                        string endGame = Console.ReadLine();

                        if (endGame == "1")
                        {
                            GameProgress();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }

                }

                if (answer1Action == "2" || playerLocation.StartsWith("path 1.2."))
                {
                    string answer1ActionSave = "path 1.2";
                    playerLocation = answer1ActionSave;
                    tamaraPoints++;
                    TamaraDialog("Alright, let's go\n");
                    SimonDialog($"Good luck with your training {CharacterName}, see you later!\n");
                    Console.WriteLine("Simon walks of as you turn towards Tamara to start your training\n");
                    Console.WriteLine("You and Tamara walk towards the training ground which is at the south side of the village. " +
                        "The training ground is on the side of the forest with some tagrets for archery and dummies for swords and spear fighting\n");
                    TamaraDialog("Judging by your physice I'd advise you to start learing sword fighting. Later you can advance to archery or even fighting with a spear like me, but that depends on your talent.\n");
                    McDialog("Alright, sounds good\n");
                    Console.WriteLine("Tamara throws you a sword, but you are unable to catch it so you crouch down to pick it up\n");

                    strengthPoints++;

                    Console.WriteLine("Tamara teaches you the basics of sowrd fighting like how to hold the sword, block attacks and a couple of basic strikes. " +
                        "Just when Tamara wants to teach you how to start to disarm your oppent you hear a loud shriek fill the air\n");
                    TamaraDialog("That sounds like a dragon\n");
                    McDialog("A dragon! What do we do?\n");
                    TamaraDialog("Help ofcourse, let's go!\n");
                    Console.WriteLine("You both run to the village sword in hand, when you arrive you see a large blue dragon flying through the village wreaking havoc on the houses and villagers. " +
                        "Everyone is in panic\n");
                    
                    Console.WriteLine("What do you do?\n" +
                        "1). Attack\n" +
                        "2). Run");
                    Console.WriteLine();
                    Console.Write("Your action\n");

                    string answer1Action1 = Console.ReadLine();

                    if (answer1Action1 == "1" || playerLocation.StartsWith("path 1.2.1."))
                    {
                        string answer1Action1Save = "path 1.2.1";
                        playerLocation = answer1Action1Save;
                        if (strengthPoints > 2)
                        {
                            Console.WriteLine("You run towards the dragon in full speed. It tries to throw you in the wall with it's tail, but you jump over the tail instead. You jump up plunging your sword in the dragons side and pull yourself up getting on the dragons back." +
                                "You pull your sword out of the dragons side and run towards it's head, but before you have time to plunge your sword in it's head it shakes you of leaving you hanging on at one of it's horns." +
                                "The dragon tries to bite you, but you manage to swing yourself up sword in hand as slice the dragons head off in your fall. You land on the floor as the dragons head falls at your feet.\n\n");
                            WinDialog("You won!\n");
                            HelpDialog("Wow, you won the game, congrats! You can exit or restart the game to get a different ending\n");

                            Console.WriteLine("What do you do?\n" +
                            "1). Restart\n" +
                            "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }

                        if (strengthPoints > 1)
                        {
                            Console.WriteLine("You run towards the dragon, but it throws you in to a wall with it's tail. You quickly get up just before the dragons claw hit the wall you where just laying against." +
                                "You analize the dragons movent and jump up on it's tail running up the dragons back to it's head. The dragon tries to shake you off, but Tamara throws her spear in it's side making the dragon stop moving you run to it's head pluning your sword into the dragons head." +
                                "The dragon falls on the floor lifelesly as you get of of it's back\n\n");
                            WinDialog("You won!\n");
                            HelpDialog("Wow, you won the game, congrats! You can exit or restart the game to get a different ending\n");
                            
                            Console.WriteLine("What do you do?\n" +
                            "1). Restart\n" +
                            "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You try to attack the dragon, but he opens his mouth and breathes hot fire killing you on the spot\n\n");
                            DeathDialog("You died\n");
                            HelpDialog("Oh no, you died. You can exit or restart the game\n");
                            
                            Console.WriteLine("What do you do?\n" +
                            "1). Restart\n" +
                            "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                    }

                    if (answer1Action1 == "2" || playerLocation.StartsWith("path 1.2.2."))
                    {
                        string answer1Action1Save = "path 1.2.2";
                        playerLocation = answer1Action1Save;
                        Console.WriteLine("You try to run awway from the dragon, but he opens his mouth and breathes hot fire killing you on the spot\n\n");
                        DeathDialog("You died\n");
                        HelpDialog("Oh no, you died. You can exit or restart the game\n");

                        Console.WriteLine("What do you do?\n" +
                        "1). Restart\n" +
                        "2). Exit");
                        Console.WriteLine();
                        Console.Write("Your action\n");

                        string endGame = Console.ReadLine();

                        if (endGame == "1")
                        {
                            GameProgress();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }

            if (answer == "2" || playerLocation.StartsWith("path 2."))
            {
                string answerSave = "path 2";
                playerLocation = answerSave;
                charismaPoints--;
                tamaraPoints++;
                strengthPoints++;

                HelpDialog("Oh no, you just lost charismapoints!, if you don't gain enough charismapoints you might lose the trust of the villagers and turn to a dark path. Beware!\n\n");
                SimonDialog("*Simon looks confused* Owh that's not good.\n");
                Console.WriteLine("You get up and dust of your clothes.");
                SimonDialog("My name is Simon, what's yours?\n");
                McDialog($"My name is {CharacterName}.\n");
                McDialog($"Simon, would you mind telling me how I get to the nearest village?\n");
                SimonDialog("No ofcourse not, I'ts straigth ahead, just follow the lake. I have things to atend to, so I''l talk to you later.\n");
                Console.WriteLine("Simon leaves and you head towards the village.\n");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You walk alongside a raging river until you arrive at a beautifull village with light colored houses and blue roofs surounded by nature and wildlife. At the center of the village lies a beautifull pond surounded by plants.");
                
                Console.WriteLine("What do you do?\n" +
                    "1). Walk to the village\n" +
                    "2). Leave towards the mountains");
                Console.WriteLine();
                Console.Write("Your action\n");

                string answer2Action = Console.ReadLine();

                if (answer2Action == "1" || playerLocation.StartsWith("path 2.1."))
                {
                    string answer2ActionSave = "path 2.1";
                    playerLocation = answer2ActionSave;
                    Console.WriteLine("You decide to go towards the village. You walk towards the center of the square when you see a tall woman holding a spear standing against a statue looking at you\n");
                    TamaraDialog("You must be the human who woke up in the forest. Simon told me about you. My name is Tamara, what's yours?\n");
                    McDialog($"My name is {CharacterName}.\n");
                    TamaraDialog($"Alright {CharacterName} you can explore a little more, or I can give you some basic survival and combat training. What do you want to do?\n");
                   
                    Console.WriteLine("What do you do?\n" +
                        "1). Take your time to explore the village\n" +
                        "2). Take the training");
                    Console.WriteLine();
                    Console.Write("Your action\n");

                    string answer2Action1 = Console.ReadLine();

                    if (answer2Action1 == "1" || playerLocation.StartsWith("path 2.1.1."))
                    {
                        string answer2Action1Save = "path 2.1.1";
                        playerLocation = answer2Action1Save;
                        Console.WriteLine("Tamara shrugs her shoulders and walks off.\n");
                        Console.WriteLine("Whilst walking through the village you meet Simon who offers to give you a tour. You agree and Simon gives you a tour through the village telling you more about the architecture and the history of the Elodians. Just as he wants to tell you about the folklore of Elodia a loud shriek fills the air.\n");
                        SimonDialog("That doesn't sound good, let's check it out!\n");
                        Console.WriteLine("You and Simon run to the village where you see a large blue dragon flying through the village wreaking havoc on the houses and villagers. " +
                            "Everyone is in panic\n");
                        Console.WriteLine("What do you do?\n" +
                            "1). Attack\n" +
                            "2). Run");
                        Console.WriteLine();
                        Console.Write("Your action\n");

                        string answer2Action2 = Console.ReadLine();

                        if (answer2Action2 == "1" || playerLocation.StartsWith("path 2.1.1.1."))
                        {
                            string answer2Action2Save = "path 2.1.1.1";
                            playerLocation = answer2Action2;
                            if (strengthPoints > 2)
                            {
                                Console.WriteLine("You run towards the dragon in full speed. It tries to throw you in the wall with it's tail, but you jump over the tail instead. You jump up plunging your sword in the dragons side and pull yourself up getting on the dragons back." +
                                    "You pull your sword out of the dragons side and run towards it's head, but before you have time to plunge your sword in it's head it shakes you of leaving you hanging on at one of it's horns." +
                                    "The dragon tries to bite you, but you manage to swing yourself up sword in hand as slice the dragons head off in your fall. You land on the floor as the dragons head falls at your feet.\n\n");
                                WinDialog("You won!\n");
                                HelpDialog("Wow, you won the game, congrats! You can exit or restart the game to get a different ending\n");

                                Console.WriteLine("What do you do?\n" +
                                "1). Restart\n" +
                                "2). Exit");
                                Console.WriteLine();
                                Console.Write("Your action\n");

                                string endGame = Console.ReadLine();

                                if (endGame == "1")
                                {
                                    GameProgress();
                                }
                                else
                                {
                                    Environment.Exit(0);
                                }
                            }

                            if (strengthPoints > 1)
                            {
                                Console.WriteLine("You run towards the dragon, but it throws you in to a wall with it's tail. You quickly get up just before the dragons claw hit the wall you where just laying against." +
                                    "You analize the dragons movent and jump up on it's tail running up the dragons back to it's head. The dragon tries to shake you off, but Tamara throws her spear in it's side making the dragon stop moving you run to it's head pluning your sword into the dragons head." +
                                    "The dragon falls on the floor lifelesly as you get of of it's back\n\n");
                                WinDialog("You won!\n");
                                HelpDialog("Wow, you won the game, congrats! You can exit or restart the game to get a different ending\n");

                                Console.WriteLine("What do you do?\n" +
                                "1). Restart\n" +
                                "2). Exit");
                                Console.WriteLine();
                                Console.Write("Your action\n");

                                string endGame = Console.ReadLine();

                                if (endGame == "1")
                                {
                                    GameProgress();
                                }
                                else
                                {
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                Console.WriteLine("You try to attack the dragon, but he opens his mouth and breathes hot fire killing you on the spot\n\n");
                                DeathDialog("You died\n");
                                HelpDialog("Oh no, you died. You can exit or restart the game\n");

                                Console.WriteLine("What do you do?\n" +
                                "1). Restart\n" +
                                "2). Exit");
                                Console.WriteLine();
                                Console.Write("Your action\n");

                                string endGame = Console.ReadLine();

                                if (endGame == "1")
                                {
                                    GameProgress();
                                }
                                else
                                {
                                    Environment.Exit(0);
                                }
                            }
                        }

                        if (answer2Action2 == "2" || playerLocation.StartsWith("path 2.1.1.2."))
                        {
                            string answer2Action2Save = "path 2.1.1.2";
                            playerLocation = answer2Action2Save;
                            Console.WriteLine("You try to run awway from the dragon, but he opens his mouth and breathes hot fire killing you on the spot\n\n");
                            DeathDialog("You died\n");
                            HelpDialog("Oh no, you died. You can exit or restart the game\n");

                            Console.WriteLine("What do you do?\n" +
                            "1). Restart\n" +
                            "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                    }

                if (answer2Action1 == "2" || playerLocation.StartsWith("path 2.1.2."))
                {
                    string answer2Action1Save = "path 2.1.2";
                    playerLocation = answer2Action1;
                    tamaraPoints++;

                    TamaraDialog("Alright, let's go\n");
                    Console.WriteLine("You and Tamara walk towards the training ground which is at the south side of the village. The training ground is on the side of the forest with some tagrets for archery and dummies for swords and spear fighting\n");
                    TamaraDialog("Judging by your physice I'd advise you to start learing sword fighting. Later you can advance to archery or even fighting with a spear like me, but that depends on your talent.\n");
                    McDialog("Alright, sounds good\n");
                    Console.WriteLine("Tamara throws you a sword and you catch it in your hand with a smooth move\n");
                        
                    strengthPoints++;
                    tamaraPoints++;

                    TamaraDialog("Good job, you are a natural\n");
                    Console.WriteLine("Tamara teaches you the basics of sowrd fighting like how to block attacks, disarm your opponent and basic strikes. Just when Tamara wants to take you for a round of sparring you hear a loud shriek fill the air\n");
                    TamaraDialog("That sounds like a dragon\n");
                    McDialog("A dragon! What do we do?\n");
                    TamaraDialog("Help ofcourse, let's go!\n");
                    Console.WriteLine("You both run to the village sword in hand, when you arrive you see a large blue dragon flying through the village wreaking havoc on the houses and villagers. " +
                        "Everyone is in panic\n");

                    Console.WriteLine("What do you do?\n" +
                        "1). Attack\n" +
                        "2). Run");
                    Console.WriteLine();
                    Console.Write("Your action\n");

                    string answer2Action2 = Console.ReadLine();

                    if (answer2Action2 == "1" || playerLocation.StartsWith("path 2.1.2.1."))
                    {
                        string answer2Action2Save = "path 2.1.2.1";
                        playerLocation = answer2Action2Save;
                        if (strengthPoints > 2)
                        {
                            Console.WriteLine("You run towards the dragon in full speed. It tries to throw you in the wall with it's tail, but you jump over the tail instead. You jump up plunging your sword in the dragons side and pull yourself up getting on the dragons back." +
                                "You pull your sword out of the dragons side and run towards it's head, but before you have time to plunge your sword in it's head it shakes you of leaving you hanging on at one of it's horns." +
                                "The dragon tries to bite you, but you manage to swing yourself up sword in hand as slice the dragons head off in your fall. You land on the floor as the dragons head falls at your feet.\n\n");
                            WinDialog("You won!\n");
                            HelpDialog("Wow, you won the game, congrats! You can exit or restart the game to get a different ending\n");

                            Console.WriteLine("What do you do?\n" +
                                "1). Restart\n" +
                                "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }

                        if (strengthPoints > 1)
                        {
                            Console.WriteLine("You run towards the dragon, but it throws you in to a wall with it's tail. You quickly get up just before the dragons claw hit the wall you where just laying against." +
                                "You analize the dragons movent and jump up on it's tail running up the dragons back to it's head. The dragon tries to shake you off, but Tamara throws her spear in it's side making the dragon stop moving you run to it's head pluning your sword into the dragons head." +
                                "The dragon falls on the floor lifelesly as you get of of it's back\n\n");
                            WinDialog("You won!\n");
                            HelpDialog("Wow, you won the game, congrats! You can exit or restart the game to get a different ending\n");

                            Console.WriteLine("What do you do?\n" +
                                "1). Restart\n" +
                                "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You try to attack the dragon, but he opens his mouth and breathes hot fire killing you on the spot\n\n");
                            DeathDialog("You died\n");
                            HelpDialog("Oh no, you died. You can exit or restart the game\n");

                            Console.WriteLine("What do you do?\n" +
                                "1). Restart\n" +
                                "2). Exit");
                            Console.WriteLine();
                            Console.Write("Your action\n");

                            string endGame = Console.ReadLine();

                            if (endGame == "1")
                            {
                                    GameProgress();
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                    }

                    if (answer2Action2 == "2" || playerLocation.StartsWith("path 2.1.2.2."))
                    {
                        string answer2Action2Save = "path 2.1.2.2";
                        playerLocation = answer2Action2Save;
                        Console.WriteLine("You try to run awway from the dragon, but he opens his mouth and breathes hot fire killing you on the spot\n\n");
                        DeathDialog("You died\n");
                        HelpDialog("Oh no, you died. You can exit or restart the game\n");

                        Console.WriteLine("What do you do?\n" +
                            "1). Restart\n" +
                            "2). Exit");
                        Console.WriteLine();
                        Console.Write("Your action\n");

                        string endGame = Console.ReadLine();

                        if (endGame == "1")
                        {
                            GameProgress();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
                else
                {
                    Console.WriteLine("You walk towards the mountains to leave the village and start climbing up the mountain to reach the top. " +
                        "Whilst climbing you see a purple fog appearing blurng your vision and numbing your body. You try to hold on but eventually fall down hitting the rocks\n\n");
                    DeathDialog("You died\n");
                    HelpDialog("Oh no, you died. You can exit or restart the game\n");

                    Console.WriteLine("What do you do?\n" +
                    "1). Restart\n" +
                    "2). Exit");
                    Console.WriteLine();
                    Console.Write("Your action\n");

                    string endGame = Console.ReadLine();

                    if (endGame == "1") 
                    {
                        GameProgress();
                    }
                    else
                    {
                       Environment.Exit(0);
                    }
                }
            }
            Endgame();
        }
        
        internal static void SaveGame()
        {
            try
            {
                string gameDataToSave = $"PlayerLocation:{playerLocation}";

                File.WriteAllText(SaveFileName, gameDataToSave);

                Console.WriteLine("Spel opgeslagen.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Er is een fout opgetreden bij het opslaan van het spel: " + ex.Message);
            }
        }

        internal static void ResumeGame()
        {
            string savedGameData = File.ReadAllText(SaveFileName);
            string[] savedDataParts = savedGameData.Split(',');

            foreach (string dataPart in savedDataParts)
            {
                string[] keyValue = dataPart.Split(':');
                string key = keyValue[0];
                string value = keyValue[1];

                if (key == "PlayerLocation")
                {
                    playerLocation = value;
                }
            }
            Console.WriteLine("Je hervat het opgeslagen spel op locatie: " + playerLocation);
        }

        static void DeathDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ResetColor();
        }

        static void WinDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }

        static void SimonDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(message);
            Console.ResetColor();
        }

        static void TamaraDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(message);
            Console.ResetColor();
        }

        static void McDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(message);
            Console.ResetColor();
        }

        static void HelpDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
