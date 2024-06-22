
/*
Console.WriteLine("Enter Triangle's BASE:");
int basee = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Triangle's HEIGHT");
float height = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Area is.." + height * basee / 2 + " unit square");

double a = double.MaxValue;
Console.WriteLine(a);
*/
///////////////////////////////////////////////
/*
Console.WriteLine("How Many Eggs Collected?..");
var eggs = int.Parse(Console.ReadLine());
int divide = eggs / 4;
int remainder = eggs % 4;
Console.WriteLine("Each sister will get " + divide + " :eggs");
Console.WriteLine("ducks will get " + remainder + " :eggs");
*/
///////////////////////////////////////////////////// pg57
/*
Console.WriteLine("Enter no. of Duchies");
int duchies = int.Parse(Console.ReadLine());
duchies *= 3;
Console.WriteLine("Enter no. of Provinces");
int provinces = int.Parse(Console.ReadLine());
provinces *= 6;
Console.WriteLine("Enter no. of Estates");
int estates = int.Parse(Console.ReadLine());
Console.WriteLine("Points are: " + (duchies + provinces + estates));
*/
//////////////////////////////////////////////////////
/*
Console.WriteLine($"{422.1299:#.##}");// Displays "42.12"
Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Deploy To:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"({row},{column-1})");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"({row-1},{column})");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"({row},{column+1})");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"({row+1},{column})");
Console.ForegroundColor = ConsoleColor.White;
*/
//-------------------------------EXTENSION(PROGRAM MAKING PROGRAM)------------------------------
/*
Console.Write("Enter the type of \"units\" you wanna use: ");
 string units = Console.ReadLine();
Console.Write("Enter the \"TYPE\" You Want To Use");
 string type = Console.ReadLine();

string calculations = $$"""
    Console.WriteLine("Enter the width (in {{units}}) of the triangle: ");
    {{type}} width = {{type}}.Parse(Console.ReadLine());
    Console.WriteLine("Enter the height (in {{units}}) of the triangle: ");
    {{type}} height = {{type}}.Parse(Console.ReadLine());
    {{type}} result = width * height / 2;
    Console.WriteLine($"{result} square {{units}}");
    """;
*/
//---------------------------------pg75(REPAIRING THE CLOCK TOWER)----------------------------------
/*
Console.Write("Enter a Number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool logic = number % 2 == 0;
if (logic)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}
*/
////////////////////////////////////////////////////////////////////////////////////
/*
Console.Write("Enter x Coordinate: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y Coordinate: ");
int yCoordinate = int.Parse(Console.ReadLine());

switch(yCoordinate)
{ 
   case >0:

    if (xCoordinate < 0)
    {
        Console.WriteLine("NW");
    }
    Console.WriteLine(xCoordinate == 0 ? "N" : " NE");
        break;
}
if ((yCoordinate == 0))
{
    if (xCoordinate < 0)
    {
        Console.WriteLine("W");
    }
    Console.WriteLine(xCoordinate == 0 ? "I" : "E");
}
if ((yCoordinate < 0))
{
    if (xCoordinate < 0)
    {
        Console.WriteLine("SW");
    }
    Console.WriteLine(xCoordinate == 0 ? "S" : "E");
}
*///////////////////////////----BUYING INVERTORY pg82-----///////////////////////////////
/*
Console.Write("""
    The following items are available:
    1 – Rope
    2 – Torches
    3 – Climbing Equipment
    4 – Clean Water
    5 – Machete
    6 – Canoe
    7 – Food Supplies
    What number do you want to see the price of? 
    """);

float prices = 1f;
int option = int.Parse(Console.ReadLine());
Console.Write("Enter Code: ");
string code = Console.ReadLine();
switch (code)
{
    case "Xae":
        Console.Clear();
        Console.WriteLine("Wohoo you got a 50% discount");
        prices =2;
        break;
    default:
        Console.Clear();
        break;
}
Console.WriteLine(option switch
{
    1 => $"Rope cost {10 / prices} gold",
    2 => $"Torches {15 / prices} gold",
    3 => $"Climbing Equipment {25 / prices} gold",
    4 => $"Clean Water {prices + 1} gold",
    5 => $"Machete {20 / prices} gold",
    6 => $"Canoe {200 / prices} gold",
    7 => $"Food Supplies {1 / prices} gold",
});
*/
/////////------------THE PROTOTYPE pg 88-----------------//////////////////
/*
int guess = 50;
Console.Write("Enter Your Pilot Code(b/w 0-100): ");
int code = int.Parse(Console.ReadLine());
while (code > 100 || 0 > code)
{
    Console.Write("""
                 Code Should be b/w 0 and 100 only
                 Enter Your Pilot Code(b/w 0-100): 
                 """);
    code = int.Parse(Console.ReadLine());
}
    Console.Clear();
Console.Write("Do You Want Computer to guess for you? ");
string choice = Console.ReadLine();
switch (choice)
{
    case "yes":
        while (code != guess)
        {
            if (code < guess)
            {
                guess = guess -1;
                Console.WriteLine(guess);
            }
            else
            {
                guess = guess +1;
                Console.WriteLine(guess);
            }
        }
        Console.WriteLine("Computer guessed the number!" + guess);
        break;

        case "no":
        {
            Console.Write("Enter Your Guess(b/w 0 to 100): ");
            guess = int.Parse(Console.ReadLine());
            while (code != guess)
            {
                {
                    if (guess > code)
                    {
                        Console.WriteLine($"""
            {guess} is too high!
            What is your next guess?: 
            """);
                        guess = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine($"""
            {guess} is too low!
            What is your next guess?: 
            """);
                        guess = int.Parse(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("You guessed the number!" + guess);
            break;
        }
}
*/
///////////////---------The Magic Cannon----------///////////////////
/*
for (int i = 0; i <= 100; i++)
{
     if (i % 3 == 0 && i % 5 == 0 && i != 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"""
            {i}: Mega Charge
            """);
    }
   else if (i % 3 == 0 && i != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"""
            {i}: Fire
            """);
    }
    else if (i % 5 == 0 && i != 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"""
            {i}: Electric
            """);
    }
    else
    {
        
        Console.WriteLine($"""
            {i}: Normal
            """);
    }
    Console.ForegroundColor = ConsoleColor.White;
}
*/
///////////////////--------The Replicator of D'To------------////////////////////
/*
int[] original = new int[5];
int[] copy = new int[5];
bool iss = false;
for (int i = 0; i < original.Length; i++)
{ 
    original[i] = int.Parse(Console.ReadLine());
    copy[i] = original[i];
}
for (int i = 0;i < copy.Length; i++)
{
    Console.WriteLine(copy[i]);
}
Console.WriteLine("-------------------------------");
for (int i = 0; i < copy.Length; i++)
{
    Console.WriteLine(original[i]);
}
*/
/////////////--------------the laws Of Freach pg95---------//////////////////////////
//**1
/*
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int i in array)
{
    total += i;
}
float average = (float)total / array.Length;
Console.WriteLine(average);
*/
//**2
/*
int[] array = [4, 51, -7, 13, -99, 15, -8, 45, 90];
int MinValue = int.MaxValue;
foreach (int i in array)
{
    if (MinValue > i) 
    { 
        MinValue = i;
    }
}
Console.WriteLine(MinValue);
*/
//////////---------Hunter--------//////////////////////
/*
 *1**For Loop
int[] destroy = [4, 8, 15, 16, 23, 42];
int[] copy = [.. destroy];
for (int i = 0; i < copy.Length-1; i++)
{
    Console.WriteLine(copy[i]);
    copy[i] = destroy[i + 1];
    copy[^1] = copy[0];
}
*/
/*
int[] destroy = [4, 8, 15, 16, 23, 42];
int[] copy = [.. destroy];
for (; ; )
{
    {
        Console.WriteLine(copy[0]);
        copy = [.. copy[1..],copy[0]];
        //Im saying "..copy" take all the elements but i only want elements from 1.. 
        // onwards so now when the new elemnts comes they would have all the elements  
        // exept the very first one 
        // so it would work but after the first itieration ( printing all the elements )
        // i would have no more elemnts inside!(for loop would break) so i make sure that my first element is equal to
        // my last element and hence i can run this loop forever
    }
}
*/
////////////-------------Taking A Number pg106--------------///////////////////////////

/*
int user = TakingUserInput("Ask For A Number: ");
int TakingUserInput(string value)
{   
    Console.Write(value);
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}

int choosenUser = user;
int userr = AskANuumber("", 0, 1000);
Console.WriteLine(userr + " Nice Number");
int AskANuumber(string value, int min, int max)
{
    for (; ; )
    {
        Console.Write(value);
        if (min < choosenUser && choosenUser < max)
        {
            return choosenUser;
        }
        Console.Write("Oops Try Again:" );
        choosenUser = int.Parse(Console.ReadLine());
    }

}
////////////////////----------CountDown (pg107)-----------//////////////////////////////
Console.WriteLine(CountDown(10)); // Prints the final value of 'factorial'(that is zero)
 int CountDown(int factorial)
{
    if (factorial == 0) 
        return  0;
    Console.WriteLine(factorial); // This line prints the current value of 'factorial'
    return CountDown(factorial-1);
}
*/
/*
string a, b;
a = "aa";
b = a;
b = "bb";
Console.WriteLine($"{a} {b}");
/////////////////////////////
int j, h;
j = 5;
h = j;
h = 6;
Console.WriteLine($"{j} {h}");
///////////////////////////////
int[] c, d;
c = [ 1, 2, 3 ];
d = c;
c = [2, 3, 4];
for ( int i = 0; i < d.Length; i++ )
{
    d[i] = i + 5;
}
Console.WriteLine($"{d[1]} {c[1]}");
*//////-----Hunted----(expansion)////////////
/*
int[] code = [4, 8, 15, 16, 23, 42];
for(; ; )
{
    Console.WriteLine(code[0]);
    code = [.. code[1..] , code[0]];
}
*/

//////////////------Hunting The Manticore------////////////////
/*
bool hitTarget = false; // to update the player score
int userRange; // input from user 
int cityHealth = 15 ;
int manticoreHealth = 10;
Console.Write("Enter the desired range From 0 to 100: ");
int enemyRange = int.Parse(Console.ReadLine());
{
    CheckForCorrectRange();
}
Console.Clear();
Console.WriteLine("Player 2 its Your turn..");

for (int i = 1; manticoreHealth > 0 && cityHealth > 0; i++)
{
    int fire = i, electric = i;
    if (fire % 3 == 0 && electric % 5 == 0) // for every 15 iteration
    {
        Repetation();
        Console.Write($"""
         Cannon is expected to hit 10 damage
         Enter the Desired Cannon range: 
         """);
        ChangeUserValue();
        ShipAttackLogic();
        if (hitTarget)
        {
            manticoreHealth -= 10;
            hitTarget = false;
        }
    }

    else if (fire % 3 == 0 || electric % 5 == 0) // Every 5 and 3 iteration
    {
        Repetation();
        Console.Write($"""
         Cannon is expected to hit 3 damage
         Enter the Desired Cannon range: 
         """);
        ChangeUserValue();
        ShipAttackLogic();
        if (hitTarget)
        {
            manticoreHealth -= 3;
            hitTarget = false;
        }
    }
    else
    {
        Repetation();   // FIRST to call
        Console.Write($"""
         Cannon is expected to hit 1 damage
         Enter the Desired Cannon range: 
         """);
        ChangeUserValue();
        ShipAttackLogic();
        if (hitTarget)
        {
            manticoreHealth -= 1;
            hitTarget = false;
        }
    }
    void Repetation()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"""
        --------------------------------------------------
        STATUS: Round {i} City: {cityHealth}/15 Maticore: {manticoreHealth}/10
        """);
        NutralizeColor();
    }
}
if (manticoreHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Consolas Won!");
    NutralizeColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Uncoded Won!");
    NutralizeColor();
}
//Methods.........
void CheckForCorrectRange()
{
    for (; ; )
        if (enemyRange > 100 || enemyRange < 0)
        {
            Console.Write("Enter the desired range From 0 to 100 ONLY!");
            enemyRange = int.Parse(Console.ReadLine());
        }
        else
        {
            break;
        }
} 
void ShipAttackLogic() //4th line 
{
           cityHealth--; 
        if (userRange != enemyRange) 
        {
        for (int i = 0; i <= 15; i++) // Check if the Number lies in a range (+-)15 
        {
            if ((userRange + i) == enemyRange || (userRange - i) == enemyRange)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                NutralizeColor();
                Console.WriteLine("That round FELL SHORT of the target");
                return;
            }
        }
        Console.WriteLine("That round OVERSHOT the target");
        }
        else 
        {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Direct Hit");
        NutralizeColor();
        hitTarget = true;
        }
} 
void ChangeUserValue()
{
    userRange = int.Parse(Console.ReadLine());
} 
void NutralizeColor()
{
    Console.ForegroundColor = ConsoleColor.White;
}
*/
/////////------ New Hunting the Manticore ( acc to RB) /////////////
/*int damage;
bool hitTarget = false; // to update the player score
int userRange = 0; // input from user 
int cityHealth = 15;
int manticoreHealth = 10;
Console.Write("Enter the desired range From 0 to 100: ");
int enemyRange = AskUserForNumber();
{
    enemyRange = CheckForCorrectRange(enemyRange);
}
Console.Clear();
Console.WriteLine("Player 2 its Your turn..");

for (int i = 1; manticoreHealth > 0 && cityHealth > 0; i++)
{
    int fire = i, electric = i;

    if (fire % 3 == 0 && electric % 5 == 0) damage = 10;
    else if (fire % 3 == 0 || electric % 5 == 0) damage = 3;
    else damage = 1;

    Repetation(i, cityHealth, manticoreHealth);
    userRange = AskUserForNumber(); // After asking for desired cannon range
    hitTarget = ShipAttackLogic(userRange, enemyRange); // If hit or no hit 
    if (hitTarget)
    {
        manticoreHealth -= damage;
        hitTarget = false;
    }
}

if (manticoreHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"""
             Consolas Won!
             """);
    NutralizeColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"""
             Uncoded Won!
             The range was: {enemyRange}
             """);
    NutralizeColor();
}

//Methods.........
int CheckForCorrectRange(int range)
{
    for (; ; )
    {
        if (range > 100 || range < 0)
        {
            Console.Write("Enter the desired range From 0 to 100 ONLY!");
            range = AskUserForNumber();
        }
        else
        {
            return range;
        }
    }
}

bool ShipAttackLogic(int userRange, int enemyRange)  
{
    cityHealth--;
    if (userRange != enemyRange)
    {
        for (int i = 0; i <= 15; i++) // Check if the Number lies in a range (+-)15 
        {
            if ((userRange + i) == enemyRange || (userRange - i) == enemyRange)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That round FELL SHORT of the target");
                NutralizeColor();
                return false;
            }
        }
        Console.WriteLine("That round OVERSHOT the target");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Direct Hit");
        NutralizeColor();
        return true;
    }
    return false;
}

int AskUserForNumber()
{
    return int.Parse(Console.ReadLine());
}

void Repetation(int currentRound, int cityHealth, int manticoreHealth)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"""
               --------------------------------------------------
               STATUS: Round {currentRound} City: {cityHealth}/15 Maticore: {manticoreHealth}/10    
               """);
    NutralizeColor();
    Console.Write($"""
             Cannon is expected to hit {damage} damage
             Enter the Desired Cannon range: 
             """);
}
void NutralizeColor()
{
    Console.ForegroundColor = ConsoleColor.White;
}
*/
//////////////////---------ENUM----------------//////////////////////
/*
Console.WriteLine(Enum.Parse<ElixirType>(Console.ReadLine()).ToString()); // convert Elexir type to stringConsole.WriteLine(Enum.Parse<ElixirType>(Console.ReadLine())); // converts string to Elixr typestring a = (Seasoning.Sweet.ToString()); // When you have given type givenenum ElixirType { Invisibility, Strength, Regeneration ,a}*/

/*
int[][] matrix = new int[2][];
{
    matrix[0] = [1, 2];
    matrix[1] = [2];
}
for (int coulmb = 0; coulmb < matrix[0].Length; coulmb++)
{
    for (int row = 0; row < matrix[0].Length; row++)
        Console.Write(matrix[coulmb][row] + " ");
}
*/
// For Jagged arrays//-----------------------
/*
int[][] matrix = new int[2][];
matrix[0] = [6 ,5];
matrix[1] = [2];

for (int column = 0; column < matrix.GetLength(0); column++)
{
    for (int row = 0; row < matrix[column].Length; row++)
    {
        Console.Write(matrix[column][row] + " ");
    }
    Console.WriteLine();
}
// For rectangular arrays //------------------------
int[,]dd = new int[2, 2]
{
    {1 ,2},
    {3 ,3}
};

for (int column = 0; column < 2; column++)
{
    for (int row = 0; row < dd.GetLength(1); row++)
        Console.Write(dd[column, row] + " ");
    Console.WriteLine();
}
*/
//////------------------The Map--------------------------///////////////////////
/*
Terrain[,] arrayLayout = new Terrain[4, 8]
{
    {Terrain.Water , Terrain.Plain , Terrain.Cities , Terrain.Plain , Terrain.Water , Terrain.Plain , Terrain.Water , Terrain.Water},
    {Terrain.Mountain , Terrain.Plain , Terrain.Plain , Terrain.Plain , Terrain.Water , Terrain.Plain , Terrain.Plain , Terrain.Water},
    {Terrain.Water , Terrain.Mountain , Terrain.Plain , Terrain.Plain , Terrain.Plain , Terrain.Plain , Terrain.Plain , Terrain.Plain},
    {Terrain.Water , Terrain.Water , Terrain.Mountain , Terrain.Cities , Terrain.Mountain , Terrain.Water , Terrain.Water , Terrain.Water},
};

 string TerrainToString (Terrain terrain) => terrain switch
{
    Terrain.Water => "~~",
    Terrain.Plain => "_",
    Terrain.Mountain => "^^",
    Terrain.Cities => "()"
};

void ActualRepresentation(Terrain[,] arrayLayout)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            Console.Write(TerrainToString(arrayLayout[i,j])); //Calls the method TerrainToString(in order based on the array "arrayLayout" is executed);
        }
        Console.WriteLine();
    }
}
ActualRepresentation(arrayLayout);
enum Terrain {Water,Plain,Mountain,Cities} 
*/
/*
///////////////-----Simula's Test----------/////////////////////
States[] states = [ States.Locked, States.Closed, States.Open, States.Closed]; //OCLC OCLC OCLC...
string[] switchingStates = [SwitchingStates.Unlock.ToString(), SwitchingStates.Open.ToString(), SwitchingStates.Close.ToString(), SwitchingStates.Lock.ToString()]; // String because want to lower the elements

for (int i = 0; true ; i++)
{
    if (i >= states.Length)
    {
        i = 0;
    }
    Console.Write($"The chest is {states[i]}. What you want to do? ");
    for(; ; ) // for loop until user type correct value 
    {
        string userValue = Console.ReadLine().ToLower();

         if (userValue == switchingStates[0].ToLower())//Implicit conversion To String before ToLower()
        {
            break;
        }
        else
        {
            Console.Write("Sorry That's Incorrect State..Choose anothor: ");
        }
    }
    switchingStates = [.. switchingStates[1..], switchingStates[0]]; // elements in array changes such that first comes last and so on..
}

enum SwitchingStates {Lock , Unlock , Open , Close} 
enum States { Open, Closed, Locked }
*/
/*

string[] states = ["Locked", "Closed", "Open", "Closed"]; //OCLC OCLC OCLC...
string[] switchingStates = ["Unlock" ,"Open", "Close", "Lock"]; // String because want to lower the elements

for (int i = 0; true; i++)
{
    if (i >= states.Length)
    {
        i = 0;
    }
    Console.Write($"The chest is {states[i]}. What you want to do? ");
    for (; ; ) // for loop until user type correct value 
    {
        string userValue = Console.ReadLine().ToLower();

        if (userValue == switchingStates[0].ToLower())//Implicit conversion To String before ToLower()
        {
            break;
        }
        else
        {
            Console.Write("Sorry That's Incorrect State..Choose anothor: ");
        }
    }
    switchingStates = [.. switchingStates[1..], switchingStates[0]]; // elements in array changes such that first comes last and so on..
}*/

/*
string[] happy = ["Locked", "Closed", "Open"];
int index = 0;
while (true)
{
    Console.Write($"The chest is {happy[0]}. What do you want to do? ");

    string input = Console.ReadLine();

    if (happy[index] == "Locked" && input == "unlock") happy[0] = happy[1];
    if (happy[index] == "Locked" && input == "open") happy[0] = happy[2];
    if (happy[index] == "Locked" && input == "close") happy[0] = happy[1];
    if (happy[index] == "Locked" && input == "lock") happy[0] = happy[0];
}

string[] currentState = ["Locked", "Closed", "Open"];
int index = 0;
while (true)
{
    Console.Write($"The chest is {currentState[index]}. What do you want to do? ");

    string input = Console.ReadLine();

    if (currentState[index] == "Locked" && input == "unlock") index = 1;
    if (currentState[index] == "Closed" && input == "open") index = 2;
    if (currentState[index] == "Open" && input == "close") index = 1;
    if (currentState[index] == "Closed" && input == "lock") index = 0;
}
*/
/*
string[] states = { "Locked", "Closed", "Open", "Closed" }; // OCLC OCLC OCLC...
string[] switchingStates = { "Unlock", "Open", "Close", "Lock" }; // String because I want to lower the elements

for (int i = 0; true; i++)
{
    if (i >= states.Length)
    {
        i = 0;
    }
    Console.Write($"The chest is {states[i]}. What do you want to do? ");
    for (; ; ) // loop until user types correct value
    {
        string userValue = Console.ReadLine().ToLower();

        if (userValue == switchingStates[0].ToLower()) // Implicit conversion to string before ToLower()
        {
            break;
        }
        else
        {
            Console.Write("Sorry, that's incorrect. Choose another state: ");
        }
    }
     // elements in array change such that first comes last and so on...
}

//IMP! refer tommorow ( names provided by your return type need not match those of your variables)

(string, int , int ) GetScore() => ("R2-D2", 12420, 15);
(string a, int b, int c) score = GetScore();
Console.WriteLine($"Name:{score.a} Level:{score.b} Score:{score.c}");



//////////////--------------Simula's Soup-------------------////////////////////////
for (int i = 0; i <= 2; i++)
    Console.Write($"{(Food)i} ");
Console.Write("(Soup Type): ");
Food food = Enum.Parse<Food>(Console.ReadLine()); // Converting user input to Enum 

for (int i = 0; i <= 3; i++)
    Console.Write($"{(MainEngredient)i} ");
Console.Write("(Main Engredient Type): ");
MainEngredient mainEngredient = Enum.Parse<MainEngredient>(Console.ReadLine()); // Converting user input to Enum 

for (int i = 0; i <= 2; i++)
    Console.Write($"{(Seasoning)i} ");
Console.Write("(Seasoning Type): ");
Seasoning seasoning = Enum.Parse<Seasoning>(Console.ReadLine()); // Converting user input to Enum 

var soup = (seasoning, mainEngredient, food);
Console.WriteLine(soup + " Is Ready :D");
enum Food { Soup, Stew, Gumbo }
enum MainEngredient { Mushroom, Chiken, Carrots, Potatoes }
enum Seasoning { Spicy, Sweet, Salty }

/////////////////////////////////

int alpha = 0;
string abc = Console.ReadLine();
ElixirType elixir = abc switch
{
    "shadow walking" => ElixirType.Invisibility
};
Console.WriteLine(ConvertToString(elixir));
string ConvertToString(ElixirType elixir) => elixir switch // takes elixrInput and return specic things depending on the enumeration
{
    ElixirType.Invisibility => "shadow walking",
    ElixirType.Strength => "strength",
    ElixirType.Regeneration => "regeneration",
    ElixirType.Coffee => "coffee"
};
enum ElixirType { Invisibility, Strength, Regeneration, Coffee }
*/

Arrow cost = new(); // Also calling methods from constructor 
Console.WriteLine($"Total Cost is: {cost.GetCost()} gold");
class Arrow
{
    public ArrowHead _currentArrowHead;
    public Fletching _currentFletching;
    public float _shaftlength;

    public int _arrowHeadcost;
    public int _fletchingCost;
    public float _shaftLengthcost;


    public ArrowHead CurrentArrowHead()
    {
        while (true)
        {
            Console.WriteLine("Enter Arrow Head (Steel, Wood, Obsidian)");
            string userArrowHead = UserInput();
            (ArrowHead currentArrowHead, int cost, bool success) = userArrowHead.ToLower() switch
            {
                "steel" => (ArrowHead.Steel, 10, true),
                "wood" => (ArrowHead.Wood, 3, true),
                "obsidian" => (ArrowHead.Obsidian, 5, true),
                _ => (ArrowHead.Obsidian, 5, false)
            };
            if (success)
            {
                _arrowHeadcost = cost;
                return currentArrowHead;
            }
        }
       
    }
    Fletching CurrentFletching()
    {
        while (true)
        {
            Console.WriteLine("Enter Fletching (Plastic,Turkey Feathers ,Goose Feathers)");
            string userfletching = UserInput();
            (Fletching currentFletching, int cost, bool success) = userfletching.ToLower() switch
            {
                "plastic" => (Fletching.Plastic, 10, true),
                "turkey feathers" => (Fletching.Turkey, 5, true),
                "goose feathers" => (Fletching.Goose_Feathers, 3, true),
                _ => (Fletching.Goose_Feathers, 3, false)
            };
            if (success)
            {
                _fletchingCost = cost;
                return currentFletching;
            }
        }
    }
    float ShaftLength()
    {
        for (; ; )
        {
            Console.WriteLine("Enter Shaft Length you want between (60 ~ 100)");
            float shaftLength = Userlength();
            if (shaftLength >= 60 && shaftLength <= 100)
            {
                _shaftLengthcost = shaftLength * 0.05f;
                return shaftLength;
            }
        }
    }
    public float GetCost()
    {
        return _arrowHeadcost + _fletchingCost + _shaftLengthcost;
    }

    string UserInput()
    {
        return Console.ReadLine();
    }
    float Userlength()
    {
        return Convert.ToSingle(Console.ReadLine());
    }
    public Arrow()
    {

        _currentArrowHead = CurrentArrowHead();
        _currentFletching = CurrentFletching();
        _shaftlength = ShaftLength();
    }
    public enum ArrowHead { Steel, Wood, Obsidian }
    public enum Fletching { Plastic, Turkey, Goose_Feathers }
}
