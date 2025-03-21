﻿namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new AppShell())) { Height=640, Width=360};
        }
    }
}