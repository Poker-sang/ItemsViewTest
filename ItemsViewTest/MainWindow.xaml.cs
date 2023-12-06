using System;
using System.Collections.ObjectModel;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ItemsViewTest;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public ObservableCollection<object> MyItems { get; } = [200, 300, 250, 300, 250];

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        MyItems.Add(Random.Shared.Next(200, 400));
    }

    private void FrameworkElement_OnEffectiveViewportChanged(FrameworkElement sender, EffectiveViewportChangedEventArgs args)
    {
        
    }
}
