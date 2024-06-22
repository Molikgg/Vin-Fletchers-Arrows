
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
