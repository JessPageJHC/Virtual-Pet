using System;
using System.Threading;
using static System.Console;

namespace VirtualPet
{
    class Program
    {
        static void Br() { WriteLine(""); } // Short command for line breaks.
        static Random random = new Random(); // Random object used to generate random numbers.
        static bool gameOver = false; // Stores whether the game has ended or not.
        
        const int startingMoney = 40; // Default 40

        class Owner
        {
            public int Money
            {
                get; set;
            }
        }
        
        class Shop
        {
            public void GetFood(Pet pet, Owner owner)
            {
                int selection = 1;
                bool selected = false;
                while (!selected)
                {
                    Clear();
                    WriteLine("      === FOOD SHOP ===      ");
                    WriteLine("    STICK                $0  ");
                    WriteLine("    APPLE                $3  ");
                    WriteLine("    CHICKEN LEG          $7  ");
                    WriteLine("    PIZZA                $10 ");
                    WriteLine("    SALAD                $12 ");
                    WriteLine("    BIRTHDAY CAKE        $20 ");
                    WriteLine("    LOBSTER              $50 ");
                    WriteLine("    OSTRICH EGG          $99 ");

                    SetCursorPosition(1, selection);
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (selection < 8) { selection++; }
                            break;
                        case ConsoleKey.UpArrow:
                            if (selection > 1) { selection--; }
                            break;
                        case ConsoleKey.Enter:
                            selected = true;
                            break;
                        case ConsoleKey.Escape:
                            selected = true;
                            selection = 0;
                            break;
                    }
                }

                if (selection == 1)
                {
                    Clear();
                    WriteLine(" Ate a stick for some reason ");
                    WriteLine("          -10 FOOD           ");
                    WriteLine("          -15 MOOD           ");
                    WriteLine("         -15 HEALTH          ");
                    pet.Food -= 10;
                    pet.Health -= 15;
                    pet.Happy -= 15;
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 2)
                {
                    Clear();
                    if (owner.Money < 3)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Food > 90)
                    {
                        WriteLine("        Pet is full!         ");
                    }
                    else
                    {
                        WriteLine("          Ate APPLE          ");
                        WriteLine("          +10 FOOD           ");
                        WriteLine("          +3 WATER           ");
                        WriteLine("         +10 HEALTH          ");
                        pet.Food += 10;
                        pet.Water += 3;
                        pet.Health += 10;
                        owner.Money -= 3;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 3)
                {
                    Clear();
                    if (owner.Money < 7)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Food > 85)
                    {
                        WriteLine("        Pet is full!         ");
                    }
                    else
                    {
                        WriteLine("       Ate CHICKEN LEG       ");
                        WriteLine("          +15 FOOD           ");
                        WriteLine("          -2 WATER           ");
                        WriteLine("          +6 MOOD            ");
                        pet.Food += 15;
                        pet.Water -= 2;
                        pet.Happy += 6;
                        owner.Money -= 7;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 4)
                {
                    Clear();
                    if (owner.Money < 10)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Food > 75)
                    {
                        WriteLine("        Pet is full!         ");
                    }
                    else
                    {
                        WriteLine("          Ate PIZZA          ");
                        WriteLine("          +25 FOOD           ");
                        WriteLine("          +10 MOOD           ");
                        WriteLine("         -8 HEALTH          ");
                        pet.Food += 25;
                        pet.Happy += 10;
                        pet.Health -= 8;
                        owner.Money -= 10;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 5)
                {
                    Clear();
                    if (owner.Money < 12)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Food > 90)
                    {
                        WriteLine("        Pet is full!         ");
                    }
                    else
                    {
                        WriteLine("          Ate SALAD          ");
                        WriteLine("          +10 FOOD           ");
                        WriteLine("         +16 HEALTH          ");
                        WriteLine("          -4 MOOD            ");
                        pet.Food += 10;
                        pet.Happy -= 4;
                        pet.Health += 16;
                        owner.Money -= 12;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 6)
                {
                    Clear();
                    if (owner.Money < 20)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Food > 60)
                    {
                        WriteLine("        Pet is full!         ");
                    }
                    else
                    {
                        WriteLine("      Ate BIRTHDAY CAKE      ");
                        WriteLine("          +40 FOOD           ");
                        WriteLine("          +20 MOOD           ");
                        WriteLine("         -20 HEALTH          ");
                        pet.Food += 40;
                        pet.Happy += 20;
                        pet.Health -= 20;
                        owner.Money -= 20;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 7)
                {
                    Clear();
                    if (owner.Money < 50)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Food > 50)
                    {
                        WriteLine("        Pet is full!         ");
                    }
                    else
                    {
                        WriteLine("         Ate LOBSTER         ");
                        WriteLine("         +100 FOOD           ");
                        WriteLine("         +10 MOOD            ");
                        WriteLine("         +15 HEALTH          ");
                        pet.Food += 100;
                        pet.Happy += 10;
                        pet.Health += 15;
                        owner.Money -= 50;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 8)
                {
                    Clear();
                    if (owner.Money < 99)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Food > 40)
                    {
                        WriteLine("        Pet is full!         ");
                    }
                    else
                    {
                        WriteLine("       Ate OSTRICH EGG       ");
                        WriteLine("         +180 FOOD           ");
                        WriteLine("         -100 MOOD            ");
                        WriteLine("         +40 HEALTH          ");
                        pet.Food += 180;
                        pet.Happy -= 100;
                        pet.Health += 40;
                        owner.Money -= 99;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
            }

            public void GetDrink(Pet pet, Owner owner)
            {
                int selection = 1;
                bool selected = false;
                while (!selected)
                {
                    Clear();
                    WriteLine("     === DRINK SHOP ===      ");
                    WriteLine("    TAP WATER            $1  ");
                    WriteLine("    BOTTLE WATER         $3  ");
                    WriteLine("    MILK                 $5  ");
                    WriteLine("    APPLE JUICE          $8  ");
                    WriteLine("    TOTALLY NOT POISON   $12 ");
                    WriteLine("    ICED TEA             $14 ");
                    WriteLine("    COLA                 $20 ");
                    WriteLine("    UNKNOWN LIQUID       $25 ");
                    WriteLine("    MILKSHAKE            $40 ");

                    SetCursorPosition(1, selection);
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (selection < 9) { selection++; }
                            break;
                        case ConsoleKey.UpArrow:
                            if (selection > 1) { selection--; }
                            break;
                        case ConsoleKey.Enter:
                            selected = true;
                            break;
                        case ConsoleKey.Escape:
                            selected = true;
                            selection = 0;
                            break;
                    }
                }

                if (selection == 1)
                {
                    Clear();
                    if (owner.Money < 1)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Water > 91)
                    {
                        WriteLine("    Pet is not thirsty!      ");
                    }
                    else
                    {
                        WriteLine("       Drank TAP WATER       ");
                        WriteLine("          +9 WATER           ");
                        WriteLine("          -3 HEALTH          ");
                        pet.Water += 9;
                        pet.Health -= 3;
                        owner.Money -= 1;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 2)
                {
                    Clear();
                    if (owner.Money < 3)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Water > 91)
                    {
                        WriteLine("    Pet is not thirsty!      ");
                    }
                    else
                    {
                        WriteLine("      Drank BOTTLE WATER     ");
                        WriteLine("          +9 WATER           ");
                        pet.Water += 9;
                        owner.Money -= 3;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 3)
                {
                    Clear();
                    if (owner.Money < 5)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Water > 86)
                    {
                        WriteLine("    Pet is not thirsty!      ");
                    }
                    else
                    {
                        WriteLine("      Drank BOTTLE WATER     ");
                        WriteLine("          +14 WATER          ");
                        WriteLine("           +3 MOOD           ");
                        pet.Water += 14;
                        pet.Happy += 3;
                        owner.Money -= 5;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 4)
                {
                    Clear();
                    if (owner.Money < 8)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Water > 80)
                    {
                        WriteLine("    Pet is not thirsty!      ");
                    }
                    else
                    {
                        WriteLine("      Drank APPLE JUICE      ");
                        WriteLine("          +20 WATER          ");
                        WriteLine("           +5 MOOD           ");
                        pet.Water += 20;
                        pet.Happy += 5;
                        owner.Money -= 8;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 5)
                {
                    Clear();
                    if (owner.Money < 12)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else
                    {
                        WriteLine("     I lied, it is poison    ");
                        WriteLine("        -99999 HEALTH        ");
                        pet.Health = 0;
                        owner.Money -= 12;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 6)
                {
                    Clear();
                    if (owner.Money < 14)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Water > 72)
                    {
                        WriteLine("    Pet is not thirsty!      ");
                    }
                    else
                    {
                        WriteLine("        Drank ICED TEA       ");
                        WriteLine("          +28 WATER          ");
                        WriteLine("           +7 MOOD           ");
                        pet.Water += 28;
                        pet.Happy += 7;
                        owner.Money -= 14;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 7)
                {
                    Clear();
                    if (owner.Money < 20)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Water > 70)
                    {
                        WriteLine("    Pet is not thirsty!      ");
                    }
                    else
                    {
                        WriteLine("          Drank COLA         ");
                        WriteLine("          +30 WATER          ");
                        WriteLine("          -15 HEALTH         ");
                        pet.Water += 30;
                        pet.Health -= 15;
                        owner.Money -= 20;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 8)
                {
                    Clear();
                    if (owner.Money < 25)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else
                    {
                        WriteLine("     Drank UNKNOWN LIQUID    ");
                        int waterChange = random.Next(-50, 50);
                        if (waterChange > 0)
                        {
                            WriteLine("          +" + waterChange + " WATER          ");
                        }
                        else
                        {
                            WriteLine("          " + waterChange + " WATER          ");
                        }
                        int healChange = random.Next(-50, 50);
                        if (healChange > 0)
                        {
                            WriteLine("          +" + healChange + " HEALTH          ");
                        }
                        else
                        {
                            WriteLine("          " + healChange + " HEALTH          ");
                        }
                        pet.Water += waterChange;
                        pet.Health -= healChange;
                        owner.Money -= 25;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 9)
                {
                    Clear();
                    if (owner.Money < 50)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Water > 50)
                    {
                        WriteLine("    Pet is not thirsty!      ");
                    }
                    else
                    {
                        WriteLine("        Drank MILKSHAKE      ");
                        WriteLine("          +100 WATER         ");
                        WriteLine("           +25 MOOD          ");
                        pet.Water += 100;
                        pet.Happy += 25;
                        owner.Money -= 50;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
            }

            public void GetMed(Pet pet, Owner owner)
            {
                int selection = 1;
                bool selected = false;
                while (!selected)
                {
                    Clear();
                    WriteLine("    === MEDICINE SHOP ===    ");
                    WriteLine("    PILL                 $5  ");
                    WriteLine("    OTHER PILL           $7  ");
                    WriteLine("    SYRINGE              $15 ");
                    WriteLine("    ANTI-POISON          $20 ");
                    WriteLine("    DISCO BALL           $35 ");
                    WriteLine("    THE EVERYTHING FIXER $300");

                    SetCursorPosition(1, selection);
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (selection < 6) { selection++; }
                            break;
                        case ConsoleKey.UpArrow:
                            if (selection > 1) { selection--; }
                            break;
                        case ConsoleKey.Enter:
                            selected = true;
                            break;
                        case ConsoleKey.Escape:
                            selected = true;
                            selection = 0;
                            break;
                    }
                }

                if (selection == 1)
                {
                    Clear();
                    if (owner.Money < 5)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Health > 85)
                    {
                        WriteLine("   Pet is already healthy!   ");
                    }
                    else
                    {
                        WriteLine("          Took PILL          ");
                        WriteLine("          +15 HEALTH         ");
                        pet.Health += 15;
                        owner.Money -= 5;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 2)
                {
                    Clear();
                    if (owner.Money < 7)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Health > 80)
                    {
                        WriteLine("   Pet is already healthy!   ");
                    }
                    else
                    {
                        WriteLine("        Took OTHER PILL      ");
                        WriteLine("          +20 HEALTH         ");
                        pet.Health += 20;
                        owner.Money -= 7;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 3)
                {
                    Clear();
                    if (owner.Money < 15)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Health > 75)
                    {
                        WriteLine("   Pet is already healthy!   ");
                    }
                    else
                    {
                        WriteLine("         Used SYRINGE        ");
                        WriteLine("          +25 HEALTH         ");
                        pet.Health += 25;
                        owner.Money -= 15;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 4)
                {
                    Clear();
                    if (owner.Money < 20)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Health > 60)
                    {
                        WriteLine("   Pet is already healthy!   ");
                    }
                    else
                    {
                        WriteLine("        Took ANTIPOISON      ");
                        WriteLine("          +40 HEALTH         ");
                        pet.Health += 40;
                        owner.Money -= 20;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 5)
                {
                    Clear();
                    if (owner.Money < 35)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else if (pet.Health > 75)
                    {
                        WriteLine("   Pet is already healthy!   ");
                    }
                    else
                    {
                        WriteLine("  Music is the best medicine ");
                        WriteLine("          +75 HEALTH         ");
                        pet.Health += 75;
                        owner.Money -= 35;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
                else if (selection == 6)
                {
                    Clear();
                    if (owner.Money < 300)
                    {
                        WriteLine("      Not enough money.      ");
                    }
                    else
                    {
                        WriteLine(" You used the Everything Fixer. ");
                        WriteLine("   Everything has been fixed.   ");
                        pet.Health += 200;
                        pet.Happy += 200;
                        pet.Food += 200;
                        pet.Water += 200;
                        owner.Money -= 300;
                    }
                    WriteLine("\n   Press ENTER to continue   ");
                    ReadLine();
                }
            }

            public void Play(Pet pet, Owner owner)
            {
                int selection = 1;
                bool selected = false;
                while (!selected)
                {
                    Clear();
                    WriteLine("     === ACTIVITIES ===    ");
                    WriteLine("    Beg for money           $0");
                    WriteLine("    Play with ball          $1");
                    WriteLine("    Play with laser pointer $1");
                    WriteLine("    Go fishing              $5");
                    WriteLine("    Gamble                  $5");
                    WriteLine("    Go to the park          $20");
                    WriteLine("    Go to space             $100");

                    SetCursorPosition(1, selection);
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (selection < 7) { selection++; }
                            break;
                        case ConsoleKey.UpArrow:
                            if (selection > 1) { selection--; }
                            break;
                        case ConsoleKey.Enter:
                            selected = true;
                            break;
                        case ConsoleKey.Escape:
                            selected = true;
                            selection = 0;
                            break;
                    }
                }

                if (selection == 2)
                {
                    if (owner.Money < 1)
                    {
                        Clear();
                        WriteLine(" You can't afford a bouncy ball. (Sad.)");
                        WriteLine("\n Press ENTER to continue.");
                        ReadLine();
                    }
                    else
                    {
                        Clear();
                        WriteLine(" You threw a bouncy ball.");
                        WriteLine(" Your pet chased it around for several minutes.");
                        WriteLine("\n +3 MOOD");
                        pet.Happy += 3;
                        WriteLine("\n Press ENTER to continue");
                        ReadLine();
                    }
                }
                else if (selection == 3)
                {
                    if (owner.Money < 1)
                    {
                        Clear();
                        WriteLine(" You can't afford a laser pointer.");
                        WriteLine("\n Press ENTER to continue.");
                        ReadLine();
                    }
                    else
                    {
                        Clear();
                        WriteLine(" Your pet chased a laser pointer.");
                        WriteLine(" They liked it, but the laser hurt their eyes for some reason.");
                        WriteLine("\n +10 MOOD");
                        WriteLine(" -5 HEALTH");
                        pet.Happy += 10;
                        pet.Health -= 5;
                        WriteLine("\n Press ENTER to continue");
                        ReadLine();
                    }
                }
                else if (selection == 1)
                {
                    if (pet.BegsLeft >= 1)
                    {
                        pet.BegsLeft--;
                        Clear();
                        WriteLine(" You begged on the streets.");
                        switch (random.Next(0, 3))
                        {
                            case 0:
                                WriteLine(" Some guy gave you $1.");
                                WriteLine("\n +1 MONEY");
                                WriteLine("\n Press ENTER to continue   ");
                                ReadLine();
                                owner.Money++;
                                break;
                            case 1:
                                WriteLine(" A kind person gave you $2.");
                                WriteLine("\n +2 MONEY");
                                WriteLine("\n Press ENTER to continue   ");
                                ReadLine();
                                owner.Money += 2;
                                break;
                            case 2:
                                WriteLine(" Nobody gave you any money.");
                                WriteLine(" The world can be so cruel sometimes.");
                                WriteLine("\n Press ENTER to continue");
                                ReadLine();
                                break;
                        }
                    }
                    else
                    {
                        Clear();
                        WriteLine(" It's raining now.");
                        WriteLine(" You need to wait until later before you can beg again.");
                        WriteLine("\n Press ENTER to continue");
                        ReadLine();
                    }
                }
                else if (selection == 4)
                {
                    if (owner.Money < 5)
                    {
                        Clear();
                        WriteLine("      Not enough money.      ");
                        WriteLine("\n   Press ENTER to continue.  ");
                        ReadLine();
                    }
                    else
                    {
                        string[] fishTypes = new string[] { "a shoe", "a blue cod", "a neon tetra", "a goldfish", "a catfish", "a zebrafish", "a rainbow trout", "a swordfish", "a Siberian fishy boi", "an ocean sunfish", "Big Chungus" };
                        int fishCaught = random.Next(0, 12);
                        selection = 0;
                        selected = false;
                        while (!selected)
                        {
                            Clear();
                            WriteLine(" You went fishing and caught " + fishTypes[fishCaught] + "!");
                            WriteLine(" Do you want to sell it or eat it?");
                            Br();
                            WriteLine("   SELL ($" + fishCaught + ")");
                            WriteLine("   EAT");
                            SetCursorPosition(1, 3 + selection);
                            switch (ReadKey(true).Key)
                            {
                                case ConsoleKey.UpArrow:
                                    if (selection > 0)
                                    {
                                        selection--;
                                    }
                                    break;
                                case ConsoleKey.DownArrow:
                                    if (selection < 1)
                                    {
                                        selection++;
                                    }
                                    break;
                                case ConsoleKey.Enter:
                                    selected = true;
                                    break;
                                default: break;
                            }
                        }

                        Clear();
                        if (selection == 0)
                        {
                            WriteLine(" You sold " + fishTypes[fishCaught] + " for $" + fishCaught);
                            WriteLine("\n Press ENTER to continue   ");
                            owner.Money += fishCaught;
                            ReadLine();
                        }
                        else
                        {
                            WriteLine(" Your pet ate " + fishTypes[fishCaught] + ".");
                            if (fishCaught == 0)
                            {
                                WriteLine(" -30 HEALTH");
                                WriteLine(" -30 FOOD");
                                WriteLine(" Why would you do that. It's literally a shoe");
                                pet.Food -= 30;
                                pet.Health -= 30;
                            }
                            else
                            {
                                WriteLine(" +" + (fishCaught * 2) + " FOOD           ");
                                WriteLine("\n Press ENTER to continue   ");
                                pet.Food += fishCaught * 2;
                            }
                            ReadLine();
                            pet.Happy += 10;
                        }
                    }
                }
                else if (selection == 5)
                {
                    Clear();
                    if (owner.Money < 5)
                    {
                        WriteLine("      Not enough money.      ");
                        WriteLine("\n   Press ENTER to continue.  ");
                        ReadLine();
                    }
                    else
                    {
                        bool placedBet = false;
                        WriteLine(" You can bet a certain amount of money on a coin flip.");
                        WriteLine(" If you get heads, you get double the amount you bet.");
                        WriteLine(" If you get tails, you lose the money.");
                        Br();
                        WriteLine(" How much money do you want to bet?");
                        Write(" >> ");
                        int bet = 0;
                        while (!placedBet)
                        {
                            try
                            {
                                bet = Convert.ToInt32(ReadLine());
                                if (bet == 0)
                                {
                                    Clear();
                                    WriteLine(" You can't bet on nothing.");
                                    Write(" >> ");
                                }
                                else if (bet < 0)
                                {
                                    Clear();
                                    WriteLine(" You can't bet a negative number!");
                                    Write(" >> ");
                                }
                                else if (bet > owner.Money)
                                {
                                    Clear();
                                    WriteLine(" You don't have that much money.");
                                    Write(" >> ");
                                }
                                else
                                {
                                    placedBet = true;
                                }
                            }
                            catch (FormatException)
                            {
                                Clear();
                                WriteLine(" Please enter a number.");
                                Write(" >> ");
                            }
                            catch (OverflowException)
                            {
                                Clear();
                                WriteLine(" Please enter a valid number.");
                                Write(" >> ");
                            }
                        }

                        for (int i = 0; i < 6; i++)
                        {
                            Clear();
                            WriteLine("   ╭───╮");
                            WriteLine("   │ H │");
                            WriteLine("   ╰───╯");
                            WriteLine("\n Flipping...");
                            Thread.Sleep(300);
                            Clear();
                            WriteLine("");
                            WriteLine("   ─────");
                            WriteLine("");
                            WriteLine("\n Flipping...");
                            Thread.Sleep(300);
                            Clear();
                            WriteLine("   ╭───╮");
                            WriteLine("   │ T │");
                            WriteLine("   ╰───╯");
                            WriteLine("\n Flipping...");
                            Thread.Sleep(300);
                            Clear();
                            WriteLine("");
                            WriteLine("   ─────");
                            WriteLine("");
                            WriteLine("\n Flipping...");
                            Thread.Sleep(300);
                        }
                    
                        Clear();
                        switch (random.Next(0, 2))
                        {
                            case 0:
                                WriteLine("   ╭───╮");
                                WriteLine("   │ H │");
                                WriteLine("   ╰───╯");
                                Br();
                                WriteLine(" The coin landed on heads!");
                                WriteLine(" You win $" + (bet * 2) + ".");
                                owner.Money += bet;
                                pet.Happy += 20;
                                break;
                            case 1:
                                WriteLine("   ╭───╮");
                                WriteLine("   │ T │");
                                WriteLine("   ╰───╯");
                                Br();
                                WriteLine(" The coin landed on tails.");
                                WriteLine(" You lost $" + bet + ".");
                                owner.Money -= bet;
                                pet.Happy -= 20;
                                break;
                        }
                        WriteLine("\n Press ENTER to continue.");
                        ReadLine();
                    }
                }
                else if (selection == 6)
                {
                    Clear();
                    if (owner.Money < 20)
                    {
                        WriteLine("      Not enough money.      ");
                        WriteLine("\n   Press ENTER to continue.  ");
                        ReadLine();
                    }
                    else
                    {
                        WriteLine(" You and " + pet.Name + " had a great time at the park.");
                        WriteLine("\n +50 MOOD");
                        pet.Happy += 50;
                        WriteLine("\n Press ENTER to continue.");
                        ReadLine();
                    }
                }
                else if (selection == 7)
                {
                    Clear();
                    if (owner.Money < 100)
                    {
                        WriteLine("      Not enough money.      ");
                        WriteLine("\n   Press ENTER to continue.  ");
                        ReadLine();
                    }
                    else
                    {
                        WriteLine(" What planet do you want to go to?");
                        Write(" >> ");
                        string planet = ReadLine();

                        Clear();
                        WriteLine(" You and " + pet.Name + " traveled to the planet of " + planet + ".");
                        Br();

                        switch(random.Next(0, 7))
                        {
                            case 0:
                                WriteLine(" You encountered an alien species.");
                                WriteLine(" They stole some of your food supplies.");
                                WriteLine("\n -30 FOOD");
                                WriteLine("\n Press ENTER to continue.");
                                ReadLine();
                                pet.Food -= 30;
                                break;
                            case 1:
                                WriteLine(" You encountered an alien species.");
                                WriteLine(" You became friends with them, so they gave you some more food!");
                                WriteLine("\n +100 FOOD");
                                WriteLine("\n Press ENTER to continue.");
                                ReadLine();
                                pet.Food += 100;
                                break;
                            case 2:
                                while (true)
                                {
                                    WriteLine(" Apparently this planet has an ocean, but you don't know what it's made of.");
                                    Br();
                                    WriteLine(" Drink it?");
                                    Write(" >> ");
                                    string response = Console.ReadLine();
                                    if (response == "yes" || response == "y")
                                    {
                                        Clear();
                                        WriteLine(" You and your pet drink the liquid.");
                                        Br();

                                        switch (random.Next(0, 2))
                                        {
                                            case 0:
                                                WriteLine(" It makes you very sick.");
                                                WriteLine("\n -30 WATER");
                                                pet.Water -= 30;
                                                WriteLine("\n Press ENTER to continue.");
                                                ReadLine();
                                                break;
                                            case 1:
                                                WriteLine(" It tastes like if happiness was a drink.");
                                                WriteLine("\n +80 WATER");
                                                pet.Water += 80;
                                                WriteLine("\n Press ENTER to continue.");
                                                ReadLine();
                                                break;
                                        }
                                    }
                                    else if (response == "no" || response == "n")
                                    {
                                        Clear();
                                        WriteLine(" You decide not to drink the liquid.");
                                        WriteLine("\n Press ENTER to continue.");
                                        ReadLine();
                                    }
                                    else { Clear(); }
                                }
                            case 3:
                                WriteLine(" You got hit by a flying asteroid.");
                                WriteLine("\n -20 HEALTH");
                                pet.Health -= 20;
                                WriteLine("\n Press ENTER to continue.");
                                ReadLine();
                                break;
                            case 4:
                                WriteLine(" You found an ancient temple full of cool glowy things.");
                                WriteLine("\n +30 MOOD");
                                pet.Happy += 30;
                                WriteLine("\n Press ENTER to continue.");
                                ReadLine();
                                break;
                            case 5:
                                WriteLine(" Oh no. A creeper from Minecraft is on this planet for some reason.");
                                WriteLine(" It blew up and destroyed your water supply.");
                                WriteLine("\n -50 WATER");
                                pet.Water -= 50;
                                WriteLine("\n Press ENTER to continue.");
                                ReadLine();
                                break;
                            case 6:
                                WriteLine(" While you're on the planet, a guy comes out of the ground and says:");
                                WriteLine(" \"I am the Ground Man. If you can guess what number I am thinking of, you win a special prize.");
                                WriteLine("\n What number do you guess?");
                                Write(" >> ");
                                ReadLine();
                                Clear();
                                WriteLine(" \"Ok I lied, I don't actually have a prize. I'm sorry. Here, take my life savings for compensation.\"");
                                WriteLine("\n +2 MONEY");
                                owner.Money += 2;
                                WriteLine("\n Press ENTER to continue.");
                                ReadLine();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        class Pet
        {
            public string Type { get; private set; }
            public int Hours { get; private set; } = 1;

            public Pet(string type)
            {
                Type = type;
            }

            public int Food { get; set; } = 100;
            public int Water { get; set; } = 100;
            public int Happy { get; set; } = 100;
            public int Health { get; set; } = 100;
            public double BegsLeft { get; set; } = 10;

            public string Name { get; private set; }

            public void SetName(string name)
            {
                string newName;
                if (name == "")
                {
                    newName = "No-Name";
                }
                else
                {
                    newName = char.ToUpper(name[0]) + name.Substring(1);
                }
                Name = newName;
            }

            public void DisplayStatuses(Owner own)
            {
                if (Food >= 80) { WriteLine(" FOOD:   ▓▓▓▓▓      E to buy food"); }
                else if (Food >= 60) { WriteLine(" FOOD:   ▓▓▓▓       E to buy food"); }
                else if (Food >= 40) { WriteLine(" FOOD:   ▓▓▓        E to buy food"); }
                else if (Food >= 20) { WriteLine(" FOOD:   ▓▓         E to buy food"); }
                else if (Food > 0) { WriteLine(" FOOD:   ▓          E to buy food"); }
                else { WriteLine(" FOOD:   EMPTY!     E to buy food"); }

                if (Water >= 80) { WriteLine(" WATER:  ▓▓▓▓▓      Q to buy drink"); }
                else if (Water >= 60) { WriteLine(" WATER:  ▓▓▓▓       Q to buy drink"); }
                else if (Water >= 40) { WriteLine(" WATER:  ▓▓▓        Q to buy drink"); }
                else if (Water >= 20) { WriteLine(" WATER:  ▓▓         Q to buy drink"); }
                else if (Water > 0) { WriteLine(" WATER:  ▓          Q to buy drink"); }
                else { WriteLine(" WATER:  EMPTY!     Q to buy drink"); }

                if (Health >= 80) { WriteLine(" HEALTH: GREAT      R to buy medicine"); }
                else if (Health >= 60) { WriteLine(" HEALTH: GOOD       R to buy medicine"); }
                else if (Health >= 40) { WriteLine(" HEALTH: OK         R to buy medicine"); }
                else if (Health >= 20) { WriteLine(" HEALTH: BAD        R to buy medicine"); }
                else if (Health > 0) { WriteLine(" HEALTH: CRITICAL   R to buy medicine"); }
                else { WriteLine(" HEALTH: OOF        R to buy medicine"); }

                if (Happy >= 80) { WriteLine(" MOOD:   (^ᗊ ^)     F to see activities"); }
                else if (Happy >= 60) { WriteLine(" MOOD:   (^v^)      F to see activities"); }
                else if (Happy >= 40) { WriteLine(" MOOD:   ('v')      F to see activities"); }
                else if (Happy >= 20) { WriteLine(" MOOD:   ('-')      F to see activities"); }
                else if (Happy > 0) { WriteLine(" MOOD:   (╯︵╰)     F to see activities"); }
                else { WriteLine(" MOOD:  （>﹏<）    F to see activities"); }
                
                WriteLine(" MONEY:  $" + Convert.ToString(own.Money).PadRight(5, ' '));
            }

            public void Tick()
            {
                if (Food > 0) { Food -= 2; }
                if (Water > 0) { Water -= 3; }
                if (Happy > 0)
                {
                    if (Food == 0 && Water == 0)
                    {
                        Happy -= 10;
                        Health = 0;
                    }
                    else if (Food < 25 || Water < 25)
                    {
                        Happy -= 4;
                        Health -= 3;
                    }
                    else if (Food < 50 || Water < 50)
                    {
                        Happy -= 2;
                        Health -= 1;
                    }
                    else
                    {
                        Happy -= 1;
                    }
                }

                if (Food < 0) { Food = 0; }
                if (Water < 0) { Water = 0; }
                if (Happy < 0) { Happy = 0; }
                if (Health < 0) { Health = 0; }
                if (Health == 0 || (Food == 0 && Water == 0)) { gameOver = true; }

                Hours++;
                BegsLeft += 0.25;
            }
        }

        static void DisplayPet(string type)
        {
            if (type == "cat")
            {
                WriteLine("");
                WriteLine("         /\\_/\\");
                WriteLine("        = o_o =_______    \\ \\");
                WriteLine("         __^      __(  \\.__) )");
                WriteLine("        <_____>__(_____)____/");
            }
            else if (type == "dog")
            {
                WriteLine("               __");
                WriteLine("            o-''|\\_____/)");
                WriteLine("             \\_/|_)     )");
                WriteLine("                \\  __  /");
                WriteLine("                (_/ (_/");
            }
            else if (type == "bird")
            {
                WriteLine("                .-.");
                WriteLine("               /'v'\\");
                WriteLine("              (/   \\)");
                WriteLine("             =\'=\"=\"===< ");
                WriteLine("                |_|");
            }
            else
            {
                WriteLine("");
                WriteLine("");
                WriteLine("                 ???");
                WriteLine("");
                WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Owner owner = new Owner();
            Shop shop = new Shop();

            Clear();
            WriteLine("                        == Welcome to Virtual Pet! ==");
            Br();
            WriteLine("                                   (\")(\")");
            WriteLine("                                 (\"),--.(\")");
            WriteLine("                                  :\"    \";");
            WriteLine("                                  `.____,\'");
            Br();
            WriteLine("   In this game, you will get your very own virtual pet which lives in your console.");
            WriteLine("Make sure to feed it, give it water, and keep it happy by playing with them and buying stuff.");
            WriteLine("                  If you don't, you lose, and nobody wants that.");
            Br();
            WriteLine("                    Press ENTER to begin choosing your pet!");
            Write("                                    >> ");
            ReadLine();
            Clear();

            int selection = 0;
            bool petSelected = false;
            while (!petSelected)
            {
                Clear();
                WriteLine("    Use the arrow keys to select a pet.");
                WriteLine("Press ENTER when you've found the right one.");
                if (selection == 0)
                {
                    DisplayPet("cat");
                    Br();
                    WriteLine("                  CAT");
                    Br();
                    WriteLine("The best pet. It can scratch, knock things");
                    WriteLine("         off tables, and more!");
                }
                else if (selection == 1)
                {
                    DisplayPet("dog");
                    Br();
                    WriteLine("                  DOG");
                    Br();
                    WriteLine("Do you want unconditional affection? Well");
                    WriteLine("       a dog is perfect for you!");
                }
                else if (selection == 2)
                {
                    DisplayPet("bird");
                    Br();
                    WriteLine("                BIRD");
                    Br();
                    WriteLine("I don't know what kind of bird this is,");
                    WriteLine("      but it's pretty cool right?");
                }
                else
                {
                    DisplayPet("unknown");
                    Br();
                    WriteLine("               UNKNOWN");
                }
                switch (ReadKey(true).Key)
                {
                    case ConsoleKey.RightArrow: selection++; break;
                    case ConsoleKey.LeftArrow: selection--; break;
                    case ConsoleKey.Enter:
                        if (selection >= 0 && selection <= 2)
                        {
                            petSelected = true;
                        }
                        break;
                    default: break;
                }
            }

            Pet myPet;
            switch (selection)
            {
                case 0:
                    myPet = new Pet("cat");
                    break;
                case 1:
                    myPet = new Pet("dog");
                    break;
                case 2:
                    myPet= new Pet("bird");
                    break;
                default:
                    throw new ArgumentException("Uh what");
            }

            while (true)
            {
                Clear();
                DisplayPet(myPet.Type);
                Br();
                WriteLine("Choose a name for your new " + myPet.Type + ":");
                Write(" >> ");
                myPet.SetName(ReadLine());
                if (myPet.Name != "")
                {
                    break;
                }
            }

            Clear();
            while (!gameOver)
            {
                Clear();
                WriteLine(" " + myPet.Name);
                WriteLine(" Hour " + myPet.Hours);
                DisplayPet(myPet.Type);
                Br();
                myPet.DisplayStatuses(owner);
                switch (ReadKey(true).Key)
                {
                    case ConsoleKey.E: shop.GetFood(myPet, owner); myPet.Tick(); break;
                    case ConsoleKey.Q: shop.GetDrink(myPet, owner); myPet.Tick(); break;
                    case ConsoleKey.R: shop.GetMed(myPet, owner); myPet.Tick(); break;
                    case ConsoleKey.F: shop.Play(myPet, owner); myPet.Tick(); break;
                    default: break;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Clear();
            WriteLine("         ╭─────╮");
            WriteLine("         │     │");
            WriteLine("         │ RIP │");
            WriteLine("         │     │");
            WriteLine("         └─────┘");
            Br();
            string[] deathCauses = new string[] { "a heart disease", "a medical disease thingy", "osteoporosis", "death", "food poisoning", "arachnophobia", "Discord light mode", "the number 7", "a generic disease", "appendicitis", "uncreativity", "diabetes", "COVID-20", "mass genocide", "electrocution", "falling off a chair" };
            WriteLine(" " + myPet.Name + " died of " + deathCauses[random.Next(0, deathCauses.Length)] + ".");
            WriteLine(" They lived for " + myPet.Hours + " hours.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}