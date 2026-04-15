class Player
{
    public string Name;
    public int Health;
    public int Attack;
    public int Defence;
    public int SkillPoints;
    public int playerClass;

    public void ShowStats()
    {
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Attack: {Attack}");
        Console.WriteLine($"Defence: {Defence}");
    }
}

class Program
{
    static void GameMenu()
    {
        Console.WriteLine("Welcome to Forgotten Descent!");
        Console.WriteLine();
        Console.WriteLine("1) Play ");
        Console.WriteLine("2) About ");
        Console.WriteLine("3) Exit ");
        Console.Write("Choose an option: (1-3) ");
    }

    static Player PlayerCreation()
    {
        Console.Clear();
        Player player = new Player();

        //Player stats

        player.Health = 30;
        player.Attack = 1;
        player.Defence = 1;
        player.SkillPoints = 10;

        string name;

        while (true)
        {
            Console.WriteLine("Choose your name: ");
            name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                break;
            }

            Console.WriteLine("Name cannot be empty. Try again.");
        }
        player.Name = name;

        Console.Clear();
        Console.WriteLine($"Welcome {player.Name}!");
        Console.WriteLine();
        Console.WriteLine("You get 10 skill points to assign to your character.");
        Console.WriteLine("Different stats will create different classes.");
        Console.WriteLine("Choose carefully...");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        Console.Clear();

        while (player.SkillPoints != 0)
        {
            Console.WriteLine($"Your current stats: ");
            Console.WriteLine();

            player.ShowStats();

            Console.WriteLine();
            Console.WriteLine($"== Skill points left: {player.SkillPoints} ==");
            Console.WriteLine();
            Console.WriteLine("To increase your stats write [H] for Health, [A] for Attack or [D] for Defence.");
            Console.Write("Choose stat to increase: ");
            string statPointChoice = Console.ReadLine();

            if (statPointChoice == "A")
            {
                player.Attack++;
                player.SkillPoints--;
                Console.Clear();
            }
            else if (statPointChoice == "H")
            {
                player.Health += 10;
                player.SkillPoints--;
                Console.Clear();
            }
            else if (statPointChoice == "D")
            {
                player.Defence++;
                player.SkillPoints--;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid option. Press any key to try again.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        if (player.Attack >= 8)
        {
            Console.Clear();
            Console.WriteLine("Your stats: ");
            Console.WriteLine();

            player.ShowStats();

            Console.WriteLine();
            Console.WriteLine("You have been assigned the class: Berserker ");
            Console.WriteLine();
            Console.WriteLine("Press any key to start your adventure.");
            Console.ReadKey();
            return player;
        }
        else if (player.Defence >= 8)
        {
            Console.Clear();
            Console.WriteLine("Your stats: ");
            Console.WriteLine();

            player.ShowStats();

            Console.WriteLine();
            Console.WriteLine("You have been assigned the class: Paladin ");
            Console.WriteLine();
            Console.WriteLine("Press any key to start your adventure.");
            Console.ReadKey();
        }
        else if (player.Health >= 90)
        {
            Console.Clear();
            Console.WriteLine("Your stats: ");
            Console.WriteLine();

            player.ShowStats();

            Console.WriteLine();
            Console.WriteLine("You have been assigned the class: Juggernaut ");
            Console.WriteLine();
            Console.WriteLine("Press any key to start your adventure.");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Your stats: ");
            Console.WriteLine();

            player.ShowStats();

            Console.WriteLine();
            Console.WriteLine("You have been assigned the class: Adventurer ");
            Console.WriteLine();
            Console.WriteLine("Press any key to start your adventure.");
            Console.ReadKey();
        }

        return player;

    }
    static void DungeonCell(Player player)
    {
        Console.Clear();
        Console.WriteLine("You wake up dazed and confused. You slowly open your eyes and realize you're in a dungeon prison cell.");
        Console.WriteLine();
        Console.WriteLine($"You remember your name is {player.Name}, but everything else is a blur.");
        Console.WriteLine("You have no idea how you ended up here...");
        Console.ReadKey();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("You rise to your feet. What is your next move?");
            Console.WriteLine();
            Console.WriteLine("1) Call for help");
            Console.WriteLine("2) Inspect prison cell");
            Console.WriteLine("3) Peer through the cell bars");
            Console.WriteLine("4) Rest");
            Console.WriteLine();
            Console.Write("Choose an option: (1-4) ");
            if (!int.TryParse(Console.ReadLine(), out int dungeonCellChoice))
            {
                Console.WriteLine("Invalid input. Press any key and try again.");
                Console.ReadKey();
                continue;
            }

            if (dungeonCellChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("You cry out for help, but the only response you receive is the sound of your own voice, echoing back at you..");
                Console.ReadKey();
                continue;
            }
            else if (dungeonCellChoice == 2)
            {
                Console.Clear();
                Console.WriteLine("You look around the prison cell. There isn't much to see...");
                Console.WriteLine();
                Console.WriteLine("On the far wall, you notice the wooden bench you woke up on, and a metal bucket beside it. Flies circle above it.");
                Console.WriteLine("The stench in the cell is unbearable, making escape feel more urgent with every passing second.");
                Console.WriteLine();
                Console.WriteLine("You inspect the prison door. You push against it, but it won't budge — it's locked tight.");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Closer inspection reveals heavily rusted hinges and an old, fragile-looking lock.");
                Console.WriteLine("'If I kick this door hard enough... I might be able to break it open.' you think to yourself.");
                Console.WriteLine();
                Console.WriteLine("Do you try to kick the door open?");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
                Console.Write("Choose an option: (1-2) ");

                if (!int.TryParse(Console.ReadLine(), out int kickDoorChoice))
                {
                    Console.WriteLine("Invalid input. Press any key and try again.");
                    Console.ReadKey();
                    continue;
                }

                if (kickDoorChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You take a step back and prepare to kick the door with all your strength.");
                    Console.WriteLine("With a single kick, the lock shatters and the door swings open with a loud crash.");
                    Console.WriteLine();
                    Console.WriteLine("The sound echoes up the staircase on the far side of the room.");
                    Console.WriteLine("You pause for a moment, listening for any response from the darkness... but nothing comes.");
                    Console.ReadKey();
                }
                else if (kickDoorChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("'What's the use..' you mutter to yourself. You consider your other options again.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();
                Console.WriteLine("You step out of the prison cell and take in your surroundings.");
                Console.WriteLine("In the shadows, something catches your eye in the corner of the room.");
                Console.WriteLine();
                Console.WriteLine("Do you want to investigate it, or make your escape?");
                Console.WriteLine();
                Console.WriteLine("1) Inspect");
                Console.WriteLine("2) Escape");
                Console.Write("Choose an option: (1-2) ");

                if (!int.TryParse(Console.ReadLine(), out int inspectChoice))
                {
                    Console.WriteLine("Invalid input. Press any key and try again.");
                    Console.ReadKey();
                    continue;
                }

                if (inspectChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You slowly approach the corner of the room.");
                    Console.WriteLine("With each step, the stench grows stronger, thick and suffocating.");
                    Console.WriteLine();
                    Console.WriteLine("As your eyes adjust, you make out the shape of a decomposing body.");
                    Console.WriteLine("A sword is lodged deep within its torso.");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("The smell is overwhelming. Your stomach turns as you fight the urge to gag.");
                    Console.WriteLine("Do you risk getting closer to take the sword, or leave it and escape?");
                    Console.WriteLine();
                    Console.WriteLine("1) Take the sword");
                    Console.WriteLine("2) Escape");
                    Console.Write("Choose an option: (1-2) ");

                    if (!int.TryParse(Console.ReadLine(), out int inspectChoiceSword))
                    {
                        Console.WriteLine("Invalid input. Press any key and try again.");
                        Console.ReadKey();
                        continue;
                    }

                    if (inspectChoiceSword == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Disgusted by the smell, you decided to head up the staircase instead.");
                        Console.ReadKey();
                        UpperDungeon(player);
                        return;

                    }
                    else if (inspectChoiceSword == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("You hold your breath and step closer, gripping the sword to pull it free.");
                        Console.WriteLine("It doesn't budge. You're forced to take a breath.");
                        Console.WriteLine();
                        Console.WriteLine("The taste of decay hits you instantly, and panic sets in.");
                        Console.WriteLine("With a final desperate pull, the sword comes loose.");
                        Console.WriteLine("+3 Attack");
                        player.Attack += 3;
                        Console.WriteLine();
                        Console.WriteLine("The stench overwhelms you. You stagger back and begin to retch violently.");
                        Console.WriteLine("-10 Health points");
                        player.Health -= 10;
                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("With the sword now in your grip, you move toward the stairs, a small sense of confidence returning.");
                        Console.ReadKey();

                        UpperDungeon(player);
                        return;
                    }

                }
                else if (inspectChoice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Disgusted by the smell, you decided to head up the staircase instead.");
                    Console.ReadKey();
                    break;
                }
            }
            else if (dungeonCellChoice == 3)
            {
                Console.Clear();
                Console.WriteLine("You step closer to the prison bars and look into the darkness beyond.");
                Console.WriteLine("In the distance, you notice a staircase leading upward, faintly lit by a weak, flickering light.");
                Console.WriteLine("It might be your only way out.");
                Console.ReadKey();
                continue;
            }
            else if (dungeonCellChoice == 4)
            {
                Console.Clear();
                Console.WriteLine("Defeated, you slowly drag your feet across the cold floor and sink down onto the wooden bench.");
                Console.WriteLine("'How did I end up here?' you think to yourself.");
                Console.WriteLine("The foul stench from the metal bucket beside you fills the cell, and you decide you can't stay here any longer.");
                Console.ReadKey();
                continue;
            }
        }
    }

    static void UpperDungeon(Player player)
    {
        Console.Clear();
        Console.WriteLine("You silently climb the stairs, listening closely for any movement above.");
        Console.WriteLine("At the very last steps of the stairs, you manage to see a silhouette of someone beyond this dark room");
        Console.WriteLine();
        Console.WriteLine("You spot an open door to the left leading outside, but this enemy faced away from you is inbetween you and your escape.");
        Console.WriteLine("What will you do?");
        Console.WriteLine();
        Console.WriteLine("1) Charge towards the figure");
        Console.WriteLine("2) Attempt to sneak behind for a stealth attack");
        Console.WriteLine("3) Distract the enemy and escape");
        Console.Write("Choice: ");
        int UpperDungeonChoice = int.Parse(Console.ReadLine());


        Console.ReadKey();
    }
    // Initialization
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            GameMenu();

            if (!int.TryParse(Console.ReadLine(), out int menuChoice))
            {
                Console.WriteLine("Invalid input. Press any key and try again.");
                Console.ReadKey();
                continue;
            }

            switch (menuChoice)
            {
                case 1:

                    Player player = PlayerCreation();
                    DungeonCell(player);
                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("=== About this game ===");
                    Console.WriteLine();
                    Console.WriteLine("This is a text-based RPG built in C# as a personal learning project.");
                    Console.WriteLine("The goal is to develop an understanding of programming in C#.");
                    Console.WriteLine();
                    Console.WriteLine("You start in a dungeon with no memory of how you got there.");
                    Console.WriteLine("You create a character, assign stats, and your choices affect how the story plays out.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Press any key...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
