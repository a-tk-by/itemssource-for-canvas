using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

#nullable disable

namespace CanvasItemsSource.WPF
{
    internal class ViewModel
    {
        public List<Item> Items { get; } = new List<Item>()
        {
            new Item {X = 100, Y = 200, Size=100, Color = Colors.Cyan, Text = "First"},
            new Item {X = 500, Y = 300, Size=200, Color = Colors.Yellow, Text = "Second"},
            new Item {X = 300, Y = 500, Size=150, Color = Colors.Red, Text = "Third"},
        };

        public int Width => Items.Max(x => x.X + x.Size);

        public int Height => Items.Max(x => x.Y + x.Size);
    }

    internal class Item
    {
        public int X { get; init; }

        public int Y { get; init; }

        public int Size { get; init; }

        public Color Color { get; init; }

        public string Text { get; init; }
    }
}
