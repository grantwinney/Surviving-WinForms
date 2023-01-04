using System;
using System.Windows.Forms;

namespace TupleDeconstruction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            void Write(string text) => txtOutput.AppendText($"{text}\r\n");
            void WriteHeader(string text) => txtOutput.AppendText($"\r\n============================\r\n{text}\r\n============================\r\n");


            // Access each tuple element individually
            WriteHeader("Access each tuple element individually");
            
            var circle = GetCircle(3);

            Write($"Diameter: {circle.diameter}");               // 6
            Write($"Circumference: {circle.circumference:N2}");  // 18.85
            Write($"Area: {circle.area:N2}");                    // 28.27

            // Deconstruct the tuple elements into separate local variables
            WriteHeader("Deconstruct the tuple elements into separate local variables");
            
            var (diameter, circumference, area) = GetCircle(3);

            Write($"Diameter: {diameter}");                      // 6
            Write($"Circumference: {circumference:N2}");         // 18.85
            Write($"Area: {area:N2}");                           // 28.27

            // You can even compare tuples...
            Write($"\r\nAre these equal? {circle == (diameter, circumference, area)}");  // true

            // Deconstruct the tuple elements and discard the ones you don't need
            WriteHeader("Deconstruct the tuple elements and discard the ones you don't need");
            
            var (_, _, area2) = GetCircle(5);

            Write($"Area: {area2:N2}");                          // 78.54

            // Or just access the tuple element directly if that's all you need
            WriteHeader("Access the tuple element directly");

            Write($"Diameter: {GetCircle(10).diameter}");        // 20

            // Using 'out' variables instead of tuples
            WriteHeader("Using 'out' variables instead of tuples");
            
            GetCircle(6, out var diameter3, out var circumference3, out var area3);

            Write($"Diameter: {diameter3}");                     // 12
            Write($"Circumference: {circumference3:N2}");        // 37.70
            Write($"Area: {area3:N2}");                          // 113.10
        }

        private (int diameter, double circumference, double area) GetCircle(int radius)
        {
            var diameter = radius * 2;
            var circumference = Math.PI * diameter;
            var area = Math.PI * Math.Pow(radius, 2);

            return (diameter, circumference, area);
        }

        private void GetCircle(int radius, out int diameter, out double circumference, out double area)
        {
            diameter = radius * 2;
            circumference = Math.PI * diameter;
            area = Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Circle
    {
        int radius;

        public Circle(int radius) => this.radius = radius;

        public int Diameter => radius * 2;
        public double Circumference => Math.PI * Diameter;
        public double Area => Math.PI * Math.Pow(radius, 2);
    }
}
