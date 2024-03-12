namespace prjFactoryConsole
{
    public class CheeseBurger : IBurger
    {
        public string Name = "Cheese Burger";
        public string Patty = "Beef";
        public string Condiments = "Bacon, tomato, lettace";
        public string Sauce = "Cheese Sauce";
        public string Price = "R98";
        public string Link = "https://popmenucloud.com/cdn-cgi/image/width%3D1200%2Cheight%3D1200%2Cfit%3Dscale-down%2Cformat%3Dauto%2Cquality%3D60/tgpbaezf/8cd1627b-621a-4155-858f-d9c8e69a81fa.gif";

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