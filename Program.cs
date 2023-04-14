namespace ProgLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            InstrumentStore guitarCenter = new InstrumentStore();

            Brand bose = new Brand(Brand.Brands.Bose);

            Heaphones heaphones1 = new Heaphones(bose);

            guitarCenter.AddHeadphones(heaphones1);

            Heaphones bose500 = guitarCenter.Stock[0];

            Brand headPhoneBrand = bose500.Brand;

            Console.WriteLine(headPhoneBrand.ToString());
        }
    }
}