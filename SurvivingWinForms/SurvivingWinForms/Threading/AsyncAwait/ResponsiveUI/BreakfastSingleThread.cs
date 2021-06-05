using System;
using System.Diagnostics;
using System.Threading;

namespace SurvivingWinForms.Threading.AsyncAwait.ResponsiveUI
{
    public class BreakfastSingleThread
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Action<string> write;

        public BreakfastSingleThread(Action<string> write)
        {
            this.write = write;
        }

        public void MakeBreakfast()
        {
            stopwatch.Start();
            SendMessage("Making breakfast");

            MakeCoffee();
            MakeOrangeJuice();
            MakeBreakfastSandwich();
            NomNomTime();

            stopwatch.Stop();
        }

        /* COFFEE */

        private void MakeCoffee()
        {
            SendMessage("☕ Starting coffee");

            BrewCoffee();
            PourCoffee();
            AddMilkAndSugar();

            SendMessage("☕ Finished coffee");
        }

        private void BrewCoffee()
        {
            Thread.Sleep(2000);
            SendMessage("☕ Coffee brewed");
        }

        private void PourCoffee()
        {
            Thread.Sleep(500);
            SendMessage("☕ Coffee poured");
        }

        private void AddMilkAndSugar()
        {
            Thread.Sleep(500);
            SendMessage("☕ Coffee flavored");
        }

        /* ORANGE JUICE */

        private void MakeOrangeJuice()
        {
            SendMessage("🥤 Starting orange juice");

            RemoveJuiceFromFridge();
            PourOrangeJuiceInCup();

            SendMessage("🥤 Finished orange juice");
        }

        private void RemoveJuiceFromFridge()
        {
            Thread.Sleep(500);
            SendMessage("🥤 Got orange juice");
        }

        private void PourOrangeJuiceInCup()
        {
            Thread.Sleep(500);
            SendMessage("🥤 Poured orange juice");
        }

        /* SANDWICH */

        private void MakeBreakfastSandwich()
        {
            SendMessage("🥪 Starting breakfast sandwich");

            GetFoodFromFridge();
            CookBacon();
            CookEggs();
            ToastBread();
            RemoveCheeseFromPackage();
            AssembleSandwich();
            SetFoodOnPlate();

            SendMessage("🥪 Finished breakfast sandwich");
        }

        private void GetFoodFromFridge()
        {
            Thread.Sleep(2000);
            SendMessage("🥪 Got food");
        }

        private void CookBacon()
        {
            SendMessage("🥓 Started bacon");
            PlaceBaconInPan();
            FryBacon();
            SendMessage("🥓 Finished bacon");
        }

        private void PlaceBaconInPan()
        {
            Thread.Sleep(500);
            SendMessage("🥓 Placed bacon in pan");
        }

        private void FryBacon()
        {
            Thread.Sleep(1000);
            SendMessage("🥓 Fried bacon");
        }

        private void CookEggs()
        {
            SendMessage("🍳 Started eggs");

            CrackEggs();
            PlaceEggsInPan();
            FryEggs();

            SendMessage("🍳 Finished eggs");
        }

        private void CrackEggs()
        {
            Thread.Sleep(1000);
            SendMessage("🍳 Cracked eggs");
        }

        private void PlaceEggsInPan()
        {
            Thread.Sleep(500);
            SendMessage("🍳 Placed eggs in pan");
        }

        private void FryEggs()
        {
            Thread.Sleep(2000);
            SendMessage("🍳 Fried eggs");
        }

        private void ToastBread()
        {
            Thread.Sleep(2000);
            SendMessage("🍞 Toasted bread");
        }

        private void RemoveCheeseFromPackage()
        {
            Thread.Sleep(250);
            SendMessage("🧀 Removed cheese from package");
        }

        private void AssembleSandwich()
        {
            Thread.Sleep(2000);
            SendMessage("🥪 Assembled sandwich");
        }

        private void SetFoodOnPlate()
        {
            Thread.Sleep(500);
            SendMessage("🥪 Placed sandwich on plate");
        }

        /* FINIS! */

        private void NomNomTime()
        {
            SendMessage("🍴 Enjoy!");
        }

        private void SendMessage(string text)
        {
            write($"[{ stopwatch.ElapsedMilliseconds }] {text}");
        }
    }
}
