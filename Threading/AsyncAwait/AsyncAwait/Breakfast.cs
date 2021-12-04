using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait {
    public abstract class Breakfast {
        protected abstract void SendMessage(string text);

        #region COFFEE

        protected void MakeCoffee() {
            SendMessage("☕ Starting coffee");

            BrewCoffee();
            PourCoffee();
            AddMilkAndSugar();

            SendMessage("☕ Finished coffee");
        }

        protected void BrewCoffee() {
            Thread.Sleep(2000);
            SendMessage("☕ Coffee brewed");
        }

        protected void PourCoffee() {
            Thread.Sleep(500);
            SendMessage("☕ Coffee poured");
        }

        protected void AddMilkAndSugar() {
            Thread.Sleep(500);
            SendMessage("☕ Coffee flavored");
        }

        #endregion
        #region ORANGE JUICE

        protected void MakeOrangeJuice() {
            SendMessage("🥤 Starting orange juice");

            RemoveJuiceFromFridge();
            PourOrangeJuiceInCup();

            SendMessage("🥤 Finished orange juice");
        }

        protected void RemoveJuiceFromFridge() {
            Thread.Sleep(500);
            SendMessage("🥤 Got orange juice");
        }

        protected void PourOrangeJuiceInCup() {
            Thread.Sleep(500);
            SendMessage("🥤 Poured orange juice");
        }

        #endregion
        #region SANDWICH

        protected void MakeBreakfastSandwich() {
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

        protected void GetFoodFromFridge() {
            Thread.Sleep(2000);
            SendMessage("🥪 Got food");
        }

        protected void CookBacon() {
            SendMessage("🥓 Started bacon");
            PlaceBaconInPan();
            FryBacon();
            SendMessage("🥓 Finished bacon");
        }

        protected void PlaceBaconInPan() {
            Thread.Sleep(500);
            SendMessage("🥓 Placed bacon in pan");
        }

        protected void FryBacon() {
            Thread.Sleep(1000);
            SendMessage("🥓 Fried bacon");
        }

        protected void CookEggs() {
            SendMessage("🍳 Started eggs");

            CrackEggs();
            PlaceEggsInPan();
            FryEggs();

            SendMessage("🍳 Finished eggs");
        }

        protected void CrackEggs() {
            Thread.Sleep(1000);
            SendMessage("🍳 Cracked eggs");
        }

        protected void PlaceEggsInPan() {
            Thread.Sleep(500);
            SendMessage("🍳 Placed eggs in pan");
        }

        protected void FryEggs() {
            Thread.Sleep(2000);
            SendMessage("🍳 Fried eggs");
        }

        protected void ToastBread() {
            Thread.Sleep(2000);
            SendMessage("🍞 Toasted bread");
        }

        protected void RemoveCheeseFromPackage() {
            Thread.Sleep(250);
            SendMessage("🧀 Removed cheese from package");
        }

        protected void AssembleSandwich() {
            Thread.Sleep(2000);
            SendMessage("🥪 Assembled sandwich");
        }

        protected void SetFoodOnPlate() {
            Thread.Sleep(500);
            SendMessage("🥪 Placed sandwich on plate");
        }

        #endregion
        #region FINIS!
        protected void NomNomTime() {
            SendMessage("🍴 Enjoy!");
        }
        #endregion
    }
    public class BreakfastSingleThread : Breakfast {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Action<string> write;

        public BreakfastSingleThread(Action<string> write) {
            this.write = write;
        }

        public void MakeBreakfast() {
            stopwatch.Start();
            SendMessage("Making breakfast");

            MakeCoffee();
            MakeOrangeJuice();
            MakeBreakfastSandwich();
            NomNomTime();

            stopwatch.Stop();
        }

        protected override void SendMessage(string text) {
            write($"[{ stopwatch.ElapsedMilliseconds }] {text}");
        }
    }
    public class BreakfastMultipleThreads : Breakfast {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly IProgress<string> progress;

        public BreakfastMultipleThreads(IProgress<string> progress) {
            this.progress = progress;
        }

        public async Task MakeBreakfastAsync() {
            stopwatch.Start();

            await Task.Run(() => {
                SendMessage("Making breakfast");

                var tasks = new[]
                {
                    Task.Run(() => MakeCoffee()),
                    Task.Run(() => MakeOrangeJuice()),
                    Task.Run(() => MakeBreakfastSandwich()),
                };

                Task.WaitAll(tasks);

                NomNomTime();
            });

            stopwatch.Stop();
        }
        protected override void SendMessage(string text) {
            progress.Report($"[{ stopwatch.ElapsedMilliseconds }] {text}");
        }
    }
}
