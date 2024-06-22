Arrow cost = new(); // Also calling methods from constructor 
Console.WriteLine($"Total Cost is: {cost.GetTotalCost()} gold");
class Arrow
{
    
    public int _arrowHeadcost;
    public int _fletchingCost;
    public float _shaftLengthcost;


    public int ArrowHeadCost()
    {
        while (true)
        {
            Console.WriteLine("Enter Arrow Head (Steel, Wood, Obsidian)");
            string userArrowHead = UserInput();
            (int cost, bool success) = userArrowHead.ToLower() switch
            {
                "steel" => (10, true),
                "wood" => (3, true),
                "obsidian" => (5, true),
                _ => (5, false)
            };
            if (success)
            {
                return cost;
            }
        }

    }
     int FletchingCost()
    {
        while (true)
        {
            Console.WriteLine("Enter Fletching (Plastic,Turkey Feathers ,Goose Feathers)");
            string userfletching = UserInput();
            (int cost, bool success) = userfletching.ToLower() switch
            {
                "plastic" => (10, true),
                "turkey feathers" => (5, true),
                "goose feathers" => (3, true),
                _ => (3, false)
            };
            if (success)
            {
                return cost;
            }
        }
    }
    float LengthCost()
    {
        for (; ; )
        {
            Console.WriteLine("Enter Shaft Length you want between (60 ~ 100)");
            float shaftLength = Userlength();
            if (shaftLength >= 60 && shaftLength <= 100)
            {
                return shaftLength * 0.05f;
            }
        }
    }
    public float GetTotalCost()
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
        _arrowHeadcost = ArrowHeadCost();
        _fletchingCost = FletchingCost();
        _shaftLengthcost = LengthCost();
    }
}
