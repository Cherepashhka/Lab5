using Lab5;

List<IEquipment> EqList = new List<IEquipment>() 
{ 
    new Ski(400),
    new Snowboard(200),
    new Backpack(50),
    new Helmet(90),
    new RaceSki(300),
    new AlpineSki(600)
};
foreach (var item in EqList)
{
    item.ShowStats();
}
foreach (var item in EqList)
{
    if (item is Ski ski)
    {
        Console.WriteLine(ski.MaxSpeedCalculate());
    }
    else if (item is Snowboard snowboard)
    {
        Console.WriteLine(snowboard.MaxSpeedCalculate());
    }
}