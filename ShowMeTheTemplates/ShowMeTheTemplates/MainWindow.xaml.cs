using System;
using System.Windows;
using MahApps.Metro.Controls;

namespace ShowMeTheTemplates
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : MetroWindow
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void LaunchOnGitHub(object sender, RoutedEventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/punker76/Show-Me-The-Templates-v2");
    }

    private void BookHyperlink_OnClick(object sender, RoutedEventArgs e)
    {
      System.Diagnostics.Process.Start("http://sellsbrothers.com/writing/wpfbook/");
    }

    private void OriginalHyperlink_OnClick(object sender, RoutedEventArgs e)
    {
      System.Diagnostics.Process.Start("http://www.sellsbrothers.com/posts/details/2091");
    }
  }
}
