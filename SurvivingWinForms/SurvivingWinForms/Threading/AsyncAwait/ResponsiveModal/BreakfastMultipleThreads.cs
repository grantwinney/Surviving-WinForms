using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SurvivingWinForms.Threading.AsyncAwait.ResponsiveModal
{
    public class BreakfastMultipleThreads
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Action<object> write;

        public BreakfastMultipleThreads(Action<object> write)
        {
            this.write = write;
        }

        public async Task MakeBreakfastAsync()
        {
            stopwatch.Start();

            await Task.Run(() =>
            {
                SendMessage("Making breakfast");

                var tasks = new[]
                {
                    Task.Run(() => MakeCoffeeAsync()),
                    Task.Run(() => MakeOrangeJuice()),
                    Task.Run(() => MakeBreakfastSandwich()),
                };

                Task.WaitAll(tasks);

                NomNomTime();
            });

            stopwatch.Stop();
        }

        /* COFFEE */

        private async Task MakeCoffeeAsync()
        {
            SendMessage("☕ Starting coffee");

            await BrewCoffee();
            await PourCoffee();
            await AddMilkAndSugar();

            SendMessage("☕ Finished coffee");
        }

        private async Task BrewCoffee()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            SendMessage("☕ Coffee brewed");
        }

        private async Task PourCoffee()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
            });
            SendMessage("☕ Coffee poured");
        }

        private async Task AddMilkAndSugar()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
            });
            SendMessage("☕ Coffee flavored");
        }

        /* ORANGE JUICE */

        private async Task MakeOrangeJuice()
        {
            SendMessage("🥤 Starting orange juice");

            await Task.Run(() =>
            {
                RemoveJuiceFromFridge();
                PourOrangeJuiceInCup();
            });

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

        private async Task MakeBreakfastSandwich()
        {
            SendMessage("🥪 Starting breakfast sandwich");

            await Task.Run(() => GetFoodFromFridge());

            var tasks = new[]
            {
                Task.Run(() => CookBacon()),
                Task.Run(() => CookEggs()),
                Task.Run(() => ToastBread()),
                Task.Run(() => RemoveCheeseFromPackage()),
            };
            Task.WaitAll(tasks);

            await AssembleSandwich();
            await SetFoodOnPlate();

            SendMessage("🥪 Finished breakfast sandwich");
        }

        private void GetFoodFromFridge()
        {
            Thread.Sleep(2000);
            SendMessage("🥪 Got food");
        }

        private async Task CookBacon()
        {
            SendMessage("🥓 Started bacon");

            await Task.Run(() =>
            {
                PlaceBaconInPan();
                FryBacon();
            });

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

        private async Task CookEggs()
        {
            SendMessage("🍳 Started eggs");

            await Task.Run(() =>
            {
                CrackEggs();
                PlaceEggsInPan();
                FryEggs();
            });

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

        private async Task ToastBread()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            SendMessage("🍞 Toasted bread");
        }

        private async Task RemoveCheeseFromPackage()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(250);
            });
            SendMessage("🧀 Removed cheese from package");
        }

        private async Task AssembleSandwich()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            SendMessage("🥪 Assembled sandwich");
        }

        private async Task SetFoodOnPlate()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
            });
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
