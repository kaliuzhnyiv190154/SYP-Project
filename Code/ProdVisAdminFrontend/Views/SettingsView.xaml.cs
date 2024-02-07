﻿using Org.OpenAPITools.Api;
using ProdVisAdminFrontend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ProdVisAdminFrontend.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        private const string baseUrl = "http://localhost:5501";
        private SettingsViewModel viewModel;
        private DispatcherTimer updateTimer;
        private APIApi api;
        
        public SettingsView()
        {
            InitializeComponent();
            

        }



        private void ConfirmGoal_Clicked(object sender, RoutedEventArgs e)
        {
            var api = new APIApi(baseUrl);
            var productionGoal = Int32.Parse(txtProductionGoal.Text);
            var response = api.GesamttubenanzZielPost(productionGoal);
            UpdateAllValues();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel = DataContext as SettingsViewModel;
            updateTimer = new DispatcherTimer();
            updateTimer.Interval = TimeSpan.FromMilliseconds(5000);
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
            api = new APIApi(baseUrl);
            UpdateAllValues();
        }

        private void UpdateTimer_Tick(object? sender, EventArgs e)
        {
            UpdateAllValues();
        }

        public void UpdateAllValues()
        {
            if (api == null) return;
            viewModel.ProductionGoal_AP1 = api.GesamttubenanzZielMachinePairsGet();
            viewModel.ProductionGoal_AP2 = api.GesamttubenanzZielMachinePairsGet();
            viewModel.CurrentAmount_AP1 = api.GesamttubenanzServer1Get();
            viewModel.CurrentAmount_AP2 = api.GesamttubenanzServer2Get();
        }

        private void Resest_Clicked(object sender, RoutedEventArgs e)
        {
            var alert = popupAlert.Child as CustomAlert;
            alert.CloseButtonClicked += CustomAlert_CloseButtonClicked;

            alert.Message = "Warnung!";
            alert.Details = "Bestätigen um fortzufahren";
            popupAlert.IsOpen = true;
        }

        private void CustomAlert_CloseButtonClicked(object sender, EventArgs e)
        {
            // This method will be called when the OK button is clicked in the CustomAlert
            // Hide the custom alert
            HideCustomAlert();
        }

        private void HideCustomAlert()
        {
            var customAlert = popupAlert.Child as CustomAlert;

            // Unsubscribe from the CloseButtonClicked event
            customAlert.CloseButtonClicked -= CustomAlert_CloseButtonClicked;

            popupAlert.IsOpen = false;
        }
    }
}
