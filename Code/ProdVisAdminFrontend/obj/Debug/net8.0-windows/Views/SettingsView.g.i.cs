﻿#pragma checksum "..\..\..\..\Views\SettingsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7B47B45A654BB6855DAFBE40B5AE735D9DB9ED9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProdVisAdminFrontend.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProdVisAdminFrontend.Views {
    
    
    /// <summary>
    /// SettingsView
    /// </summary>
    public partial class SettingsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 92 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup passwordAlert;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup resetAlert;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAP1Prod;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAP2Prod;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem swInt15Sec;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem swInt30Sec;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem swInt45Sec;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem swInt1Min;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popupInfo;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border btnIntervalInfo;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProductionGoal;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProdVisAdminFrontend;V1.0.0.0;component/views/settingsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\SettingsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\Views\SettingsView.xaml"
            ((ProdVisAdminFrontend.Views.SettingsView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.passwordAlert = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 3:
            this.resetAlert = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 4:
            this.lblAP1Prod = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblAP2Prod = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.swInt15Sec = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 7:
            this.swInt30Sec = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.swInt45Sec = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.swInt1Min = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 10:
            this.popupInfo = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 11:
            this.btnIntervalInfo = ((System.Windows.Controls.Border)(target));
            return;
            case 12:
            
            #line 165 "..\..\..\..\Views\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.IntervalInfo_Leave);
            
            #line default
            #line hidden
            
            #line 165 "..\..\..\..\Views\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.IntervalInfo_Entered);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 215 "..\..\..\..\Views\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Resest_Clicked);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txtProductionGoal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            
            #line 236 "..\..\..\..\Views\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConfirmGoal_Clicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

