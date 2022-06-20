using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Avalonia.Media;
using ReactiveUI.Fody.Helpers;

#nullable disable

namespace CanvasItemsSource.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Items = new List<Item>
            {
                new Item(this) {X = 100, Y = 200, Size=100, Color = Colors.Cyan, Text = "First"},
                new Item(this) {X = 500, Y = 300, Size=200, Color = Colors.Yellow, Text = "Second"},
                new Item(this) {X = 300, Y = 500, Size=150, Color = Colors.Red, Text = "Third"},
            };
        }

        public List<Item> Items { get; }

        public int Width => Items.Max(x => x.X + x.Size);

        public int Height => Items.Max(x => x.Y + x.Size);

        [Reactive] public string WindowTitle { get; set; } = "Avalonia window";
    }

    public class Item
    {
        private readonly MainWindowViewModel parent;

        public Item(MainWindowViewModel parent)
        {
            this.parent = parent;
        }

        public int X { get; init; }

        public int Y { get; init; }

        public int Size { get; init; }

        public Color Color { get; init; }

        public string Text { get; init; }

        public void Clicked()
        {
            parent.WindowTitle = $"{Text} button clicked";
        }
    }
}
