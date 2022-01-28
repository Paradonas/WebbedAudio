﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A13BD3074C46DA3BD109D9F6E40A9D85F95CDC30"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WebbedAudio.Core;


namespace WebbedAudio.Core {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 143 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleText;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AlbumText;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement MainPlayer;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider TrackTimeSlider;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TrackTimeDisplay;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VolumeSlider;
        
        #line default
        #line hidden
        
        
        #line 230 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AuthorText;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock YearText;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GenreText;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NumberText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WebbedAudio.Core;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 80 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 84 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TitleText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.AlbumText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.MainPlayer = ((System.Windows.Controls.MediaElement)(target));
            
            #line 157 "..\..\..\MainWindow.xaml"
            this.MainPlayer.Loaded += new System.Windows.RoutedEventHandler(this.MediaElement_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 158 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 166 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TrackTimeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 180 "..\..\..\MainWindow.xaml"
            this.TrackTimeSlider.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TrackTimeSlider_MouseDown);
            
            #line default
            #line hidden
            
            #line 180 "..\..\..\MainWindow.xaml"
            this.TrackTimeSlider.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TrackTimeSlider_MouseUp);
            
            #line default
            #line hidden
            
            #line 180 "..\..\..\MainWindow.xaml"
            this.TrackTimeSlider.AddHandler(System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new System.Windows.Controls.Primitives.DragStartedEventHandler(this.TrackTimeSlider_DragStarted));
            
            #line default
            #line hidden
            
            #line 180 "..\..\..\MainWindow.xaml"
            this.TrackTimeSlider.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.TrackTimeSlider_DragCompleted));
            
            #line default
            #line hidden
            
            #line 180 "..\..\..\MainWindow.xaml"
            this.TrackTimeSlider.KeyDown += new System.Windows.Input.KeyEventHandler(this.TrackTimeSlider_KeyDown);
            
            #line default
            #line hidden
            
            #line 180 "..\..\..\MainWindow.xaml"
            this.TrackTimeSlider.KeyUp += new System.Windows.Input.KeyEventHandler(this.TrackTimeSlider_KeyUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TrackTimeDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.VolumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 216 "..\..\..\MainWindow.xaml"
            this.VolumeSlider.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Slider_MouseUp);
            
            #line default
            #line hidden
            
            #line 216 "..\..\..\MainWindow.xaml"
            this.VolumeSlider.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.VolumeSlider_DragCompleted));
            
            #line default
            #line hidden
            return;
            case 11:
            this.AuthorText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.YearText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.GenreText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.NumberText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
