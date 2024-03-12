namespace prjFactoryConsole
{
    internal class ChickenBurger : IBurger
    {
        public string Name = "Chicken Burger";
        public string Patty = "Chicken";
        public string Condiments = "Onion, tomato, lettace";
        public string Sauce = "Mayo Sauce";
        public string Price = "R110";
        public string Link = "https://www.familychicken.nl/wp-content/uploads/2019/12/549-Royal-Crunchy-Filetburger-Los-500x500-1.png";

        public string getImage()
        {
            return Link;
        }
        public string getCondiments()
        {
            return Condiments;
        }
        public string getName()
        {
            return Name;
        }

        public string getPatty()
        {
            return Patty;
        }

        public string getSauce()
        {
            return Sauce;
        }
        public string getPrice()
        {
            return Price;
        }
    }
}