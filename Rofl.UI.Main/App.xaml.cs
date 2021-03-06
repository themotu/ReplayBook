﻿using Rofl.UI.Main.Views;
using System.Windows;

namespace Rofl.UI.Main
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length == 1)
            {
                var selectedFile = e.Args[0];
                StartSingleReplayWindow(selectedFile);
            }
            else
            {
                StartMainWindow();
            }
        }

        private static void StartMainWindow()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private static void StartSingleReplayWindow(string path)
        {
            var singleWindow = new SingleReplayWindow
            {
                ReplayFileLocation = path
            };
            singleWindow.Show();
        }
    }
}
