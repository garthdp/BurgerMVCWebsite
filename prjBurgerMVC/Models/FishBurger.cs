namespace prjFactoryConsole
{
    internal class FishBurger : IBurger
    {
        public string Name = "Fish Burger";
        public string Patty = "Fish";
        public string Condiments = "Tomato, lettace";
        public string Sauce = "Tata Sauce";
        public string Price = "R105";
        public string Link = "https://www.thedinnerbite.com/wp-content/uploads/2021/04/fish-burger-filet-recipe-img-12-500x500.jpg";
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