﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab09.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeDemo : ContentPage
    {
        public SwipeDemo()
        {
            InitializeComponent();
        }

        private void OnSwiped(object sender, SwipedEventArgs e)
        {
            string direction = e.Direction.ToString();

            if (direction == "Right")
            {
                ((BoxView)sender).BackgroundColor = Color.Red;
            }
            if (direction == "Left")
            {
                ((BoxView)sender).BackgroundColor = Color.Yellow;
            }
            if (direction == "Up")
            {
                ((BoxView)sender).BackgroundColor = Color.Green;
            }
            if (direction == "Down")
            {
                ((BoxView)sender).BackgroundColor = Color.Blue;
            }

            _label.Text = $"You swiped: {e.Direction.ToString()}";
        }
    }
}