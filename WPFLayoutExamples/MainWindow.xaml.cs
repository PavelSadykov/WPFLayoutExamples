using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFLayoutExamples
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Создаем главную панель
            StackPanel mainPanel = new StackPanel();
            mainPanel.Orientation = Orientation.Vertical;

            // Пример компоновки с использованием StackPanel
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Margin = new Thickness(10);
            stackPanel.Children.Add(new Button() { Content = "Кнопка 1" });
            stackPanel.Children.Add(new Button() { Content = "Кнопка 2" });
            mainPanel.Children.Add(stackPanel);

            // Пример компоновки с использованием Grid
            Grid grid = new Grid();
            grid.Margin = new Thickness(10);
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.Children.Add(new Button() { Content = "Кнопка A", HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center });
            Grid.SetColumn((Button)grid.Children[0], 0);
            Grid.SetRow((Button)grid.Children[0], 0);
            grid.Children.Add(new Button() { Content = "Кнопка B", HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center });
            Grid.SetColumn((Button)grid.Children[1], 1);
            Grid.SetRow((Button)grid.Children[1], 0);
            mainPanel.Children.Add(grid);

            // Пример компоновки с использованием DockPanel
            DockPanel dockPanel = new DockPanel();
            dockPanel.Margin = new Thickness(10);
            dockPanel.Children.Add(new Button() { Content = "Вверх", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Top });
            dockPanel.Children.Add(new Button() { Content = "Вниз", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Bottom });
            dockPanel.Children.Add(new Button() { Content = "Слева", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Stretch });
            dockPanel.Children.Add(new Button() { Content = "Справа", HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Stretch });
            dockPanel.Children.Add(new Button() { Content = "Центр", HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center });
            mainPanel.Children.Add(dockPanel);

            // Добавляем главную панель в окно
            this.Content = mainPanel;
        }
    }
}
