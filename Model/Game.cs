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

        public static void StartGame()
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
                              "2) Yes I want some instuctions");
            Console.WriteLine();
            Console.Write("Your answer?\n");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                NameCharacter();
            }
            else
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
                HelpDialog("Your choices in the game will earn you strength, charisma points and sometimes even romance points that will help your progress in the game or unlock secret dialog. Some of your awnsers will also trigger a villager to tell you more about the world of Elodia. The start of the game will highlight these questions for lore hungry players. Be carefull as your choices will affect the path you choose and this will effect your ending. Good luck and enjoy the world of Eldoria!\n\n");
                NameCharacter();
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

        public static void GameProgress()
        {
            int charismaPoints = 0;
            int strengthPoints = 0;
            int romancePoints = 0;
            Console.WriteLine("You wake up on the floor slowly opening your eyes as you see a stranger hovering above you\n");
            NPCDialog("Hey there are you okay?\n");
            Console.WriteLine("How do you answer?\n" +
                  "1). I'm okay thank you\n" +
                  "2). No, ofcourse I'm not.\n" +
                  "3). Where am I? (Learn more about Elodia)\n" +
                  "4). Who are you? (Learn more about Villager)\n");
            Console.WriteLine();
            Console.Write("Your awnser\n");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                charismaPoints++;
                HelpDialog("Good job, you gained charismapoints!, These will help you gain the trust of villagers and keep you on the good path!\n\n");
                NPCDialog("*Simon looks happy* That's great! Here let me help you up.");
                Console.WriteLine("The strager helps you up and dust of your clothes.");
                NPCDialog("My name is Simon by the way, what's yours?\n");
                MCDialog($"My name is {CharacterName}.");
                MCDialog($"It's nice to meet you Simon, would you mind telling me how I get to the nearest village?");
                NPCDialog("Ofcourse not! I'll walk you there.");
                Console.WriteLine("You and Simon chat while walking towards the village.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You walk alongside a raging river until you arrive at a beautifull village with light colored houses and blue roofs surounded by nature and wildlife. At the center of the village lies a beautifull pond surounded by plants.");
                Console.WriteLine("How do you react?\n" +
                 "1). Wow It's beautifull\n" +
                 "2). Hmm looks nice\n" +
                 "3). Looks pretty boring");
                Console.WriteLine();
                Console.Write("Your reply\n");
                string reply = Console.ReadLine();
            }

            if (answer == "2")
            {
                charismaPoints--;
                HelpDialog("Oh no, you just lost charismapoints!, if you don't gain enough charismapoints you might lose the trust of the villagers and turn to a dark path. Beware!\n\n");
                NPCDialog("*Simon looks confused* Owh that's not good.");
                Console.WriteLine("You get up and dust of your clothes.");
                NPCDialog("My name is Simon, what's yours?\n");
                MCDialog($"My name is {CharacterName}.");
                MCDialog($"Simon, would you mind telling me how I get to the nearest village?");
                NPCDialog("No ofcourse not, I'ts straigth ahead, just follow the lake. I have things to atend to, so I''l talk to you later.");
                Console.WriteLine("Simon leaves and you heas towards the village.\n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You walk alongside a raging river until you arrive at a beautifull village with light colored houses and blue roofs surounded by nature and wildlife. At the center of the village lies a beautifull pond surounded by plants.");
                Console.WriteLine("What do you do?\n" +
                 "1). Walk to the village\n" +
                 "2). Leave towards the mountains");
                Console.WriteLine();
                Console.Write("Your action\n");
                string action = Console.ReadLine();
            }

            if (answer == "3")
            {
                charismaPoints++;
                HelpDialog("Good job, you gained charismapoints!, These will help you gain the trust of villagers and keep you on the good path!\n\n");
                NPCDialog("*Simon looks surprised* Owh, you don't know? Your in Elodia! Here let me help you up and then I will tell you more\n");
                Console.WriteLine("The strager helps you up and dust of your clothes.");
                NPCDialog("My name is Simon by the way, what's yours?\n");
                MCDialog($"My name is {CharacterName}.\n");
                NPCDialog($"Well it's lovely to meet you {CharacterName}. Let's head to the village and I'll get you updated on the lovely world of Elodia!\n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You walk alongside a raging river until you arrive at a beautifull village with light colored houses and blue roofs surounded by nature and wildlife. At the center of the village lies a beautifull pond surounded by plants.");
                Console.WriteLine("How do you react?\n" +
                 "1). Wow It's beautifull\n" +
                 "2). Hmm looks nice\n" +
                 "3). Looks pretty boring");
                Console.WriteLine();
                Console.Write("Your reply\n");
                string reply = Console.ReadLine();
            }

            if (answer == "4")
            {
                charismaPoints++;
                romancePoints++;
                HelpDialog("You gained romancepoints! This will unlock some secret dialog and maybe even a secret ending!\n");
                HelpDialog("Good job, you gained charismapoints!, These will help you gain the trust of villagers and keep you on the good path!\n\n");
                NPCDialog("*Simon looks surprised* My name is Simon, here let me help you up!\n");
                Console.WriteLine("Simon helps you up and dusts of your clothes.");
                MCDialog($"My name is {CharacterName} by the way.\n");
                NPCDialog($"Nice to meet you {CharacterName}! Why don't we walk towards my village I can tell you more about myself on the way there.\n");
                MCDialog("Sure, lets go!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You walk alongside a raging river until you arrive at a beautifull village with light colored houses and blue roofs surounded by nature and wildlife. At the center of the village lies a beautifull pond surounded by plants.");
                Console.WriteLine("How do you react?\n" +
                 "1). Wow It's beautifull\n" +
                 "2). Hmm looks nice\n" +
                 "3). Looks pretty boring");
                Console.WriteLine();
                Console.Write("Your reply\n");
                string reply = Console.ReadLine();
            }


        }

        static void NPCDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ResetColor();
        }

        static void MCDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }

        static void HelpDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
