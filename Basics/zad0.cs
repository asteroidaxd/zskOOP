Desk d1 = new Desk();

d1.Colour = "green";
d1.Height = 0.5m;
d1.Brand = "Auchan";

while(true)
{
    d1.Lift();
    Thread.Sleep(500);
}


class Desk(int Height, string Colour, string Brand)
{
    public const decimal MAX_HEIGHT = 2.0m;
    private decimal Height = 1.0m;         //zeby w tym programie cokolwiek dzialalo, trzeba zmienic private na public
    public string Colour = Colour;
    public string Brand = Brand;

    /* Constructor style 1
    public Desk(int height, string colour , string brand )
    {
        this.height = Height;
        this.colour = Colour;
        this.brand = Brand;
    } */

   /*  Primary Constructor
     class Desk (decimal height, string colour, string brand)
        {
        public const decimal MAX_HEIGHT = 2.0m;
        private decimal Height = 1.0m;  
        public string Colour = colour;
        public string Brand = brand;
        }
     */
   class Desk(string Colour, string Brand)
    {
        public const decimal max_height = 2.0m;
        public decimal Height { get; private set; } = 1.0m;
        public string Colour { get; private set; } = Colour;    
        public string Brand { get; private set; }  = Brand;
   public decimal getHeight() {  return Height; }
    public void Lift()
    {
        if (Height < MAX_HEIGHT)
        {
            Height += 0.1m;
        } else
        {
            Console.WriteLine($"Hey, it's too high. Max {MAX_HEIGHT}");
        }
        Console.WriteLine($"Desk is on {Height} height");
    }
}


// public, private, protected

