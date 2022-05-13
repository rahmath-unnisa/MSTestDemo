namespace CoffeeMaker
{
    public interface IMakeACoffee
    {
        bool CheckIngridientAvailability();
        string CoffeeMaking(int sugerPerSpoon, int coffeePack);
    }
}