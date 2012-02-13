using System;
using Composite.BaseClasses;
using Composite.Classes;
using Composite.Interfaces;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var badDistrict = (IAssetComposite)BadDistrict.Generate();
            badDistrict.ShowProfit();

            Console.WriteLine();

            var californiaHotel = badDistrict.FindChild("California Hotel");
            if (californiaHotel != null)
                californiaHotel.ShowProfit();

            Console.ReadLine();
        }

        public class BadDistrict
        {
            // factory method with parameters
            public static IAsset MakeAsset(AssetType assetType, String title, Double charge = 0)
            {
                switch (assetType)
                {
                    case AssetType.District:
                        return new District(title);
                        break;

                    case AssetType.Whore:
                        return new Whore(title, charge);
                        break;

                    case AssetType.DrugDealer:
                        return new DrugDealer(title, charge);
                        break;

                    case AssetType.Club:
                        return new Club(title);
                        break;

                    case AssetType.Hotel:
                        return new Hotel(title);
                        break;

                    default:
                        throw new NotImplementedException("There is no such asset type in the system.");
                }
            }

            public static IAsset Generate()
            {
                var district13 = (IAssetComposite)BadDistrict.MakeAsset(AssetType.District, "District 13");

                var whoreAlice = BadDistrict.MakeAsset(AssetType.Whore, "Alice", 20);
                var dealerJoe = BadDistrict.MakeAsset(AssetType.DrugDealer, "Joe", 50);
                var clubNeo = (IAssetComposite)BadDistrict.MakeAsset(AssetType.Club, "Neo");
                var whoreMarry = BadDistrict.MakeAsset(AssetType.Whore, "Marry", 35);
                var dealerStan = BadDistrict.MakeAsset(AssetType.DrugDealer, "Stan", 42);
                var hotelCalifornia = (IAssetComposite)BadDistrict.MakeAsset(AssetType.Hotel, "California Hotel");
                var whoreViki = BadDistrict.MakeAsset(AssetType.Whore, "Viki", 15);
                var whoreChristina = BadDistrict.MakeAsset(AssetType.Whore, "Christina", 15);
                var whoreBarselona = BadDistrict.MakeAsset(AssetType.Whore, "Barselona", 15);

                hotelCalifornia.Add(whoreViki, whoreChristina, whoreBarselona);
                clubNeo.Add(whoreMarry, dealerStan);
                district13.Add(whoreAlice, dealerJoe, hotelCalifornia, clubNeo);

                return district13;
            }
        }

        internal enum AssetType
        {
            District,
            Whore,
            DrugDealer,
            Club,
            Hotel,
        }
    }

}
