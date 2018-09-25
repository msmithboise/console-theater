namespace console_theater.Interfaces
{


    public interface IPurchasable
    {
        decimal Price { get; set; }
        string Type { get; set; }

        // everything purchasable has to have the method, printName()
        void PrintName();

    }
}