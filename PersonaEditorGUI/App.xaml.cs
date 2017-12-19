﻿using System.Windows;

namespace PersonaEditorGUI
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindowVM VM;
            if (e.Args.Length > 0)
                VM = new MainWindowVM(e.Args[0]);
            else
                VM = new MainWindowVM();

            MainWindow window = new MainWindow() { DataContext = VM };
            MainWindow = window;
            window.Show();
        }
    }
}