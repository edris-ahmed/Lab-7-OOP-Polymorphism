namespace Lab_7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri geometriObj;

            Rektangel rektangel = new Rektangel();
            geometriObj = rektangel;
            double areaRektangel = Math.Round(geometriObj.Area(), 2);
            Console.WriteLine($"Area Rektangel: {areaRektangel}");

            Fyrkant fyrkant = new Fyrkant();
            geometriObj = fyrkant;
            double areaFyrkant = Math.Round(geometriObj.Area(), 2);
            Console.WriteLine($"Area Fyrkant: {areaFyrkant}");

            Cirkel cirkel = new Cirkel();
            geometriObj = cirkel;
            double areaCirkel = Math.Round(geometriObj.Area(), 2);
            Console.WriteLine($"Area Cirkel: {areaCirkel}");

            Parallellogram parallellogram = new Parallellogram();
            geometriObj = parallellogram;
            double areaParallellogram = Math.Round(geometriObj.Area(), 2);
            Console.WriteLine($"Area Parallellogramm: {areaParallellogram}");

            Ellips ellips = new Ellips();
            geometriObj = ellips;
            double areaEllips = Math.Round(geometriObj.Area(), 2);
            Console.WriteLine($"Area Ellips: {areaEllips}");
        }
    }
}