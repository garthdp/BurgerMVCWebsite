namespace prjFactoryConsole
{
    internal class PlainBurger : IBurger
    {
        public string Name = "Plain Burger";
        public string Patty = "Beef";
        public string Condiments = "Bacon, tomato, lettace";
        public string Sauce = "BBQ Sauce";
        public string Price = "R80";
        public string Link = "https://www.provisioneronline.com/ext/resources/2022/03/0322NP_burgerreport_openimage.jpg?height=418&t=1647884382&width=800";

        public string getCondiments()
        {
            return Condiments;
        }

        public string getImage()
        {
            return Link;
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