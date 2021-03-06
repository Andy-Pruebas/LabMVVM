﻿using Lab11.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab11
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InteractiveDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SimpleDemo());

            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CommandDemo());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Operaciones());

            };
        }
    }
}