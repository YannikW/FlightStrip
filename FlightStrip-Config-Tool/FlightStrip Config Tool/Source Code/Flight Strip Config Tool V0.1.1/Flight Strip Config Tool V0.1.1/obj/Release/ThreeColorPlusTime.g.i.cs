﻿#pragma checksum "..\..\ThreeColorPlusTime.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7CD1A1FD436BB55987649428E04D0185"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34014
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Flight_Strip_Config_Tool_WPF_V0._1 {
    
    
    /// <summary>
    /// ThreeColorPlusTime
    /// </summary>
    public partial class ThreeColorPlusTime : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\ThreeColorPlusTime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorCanvas color1;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\ThreeColorPlusTime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label effektLabel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\ThreeColorPlusTime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button savebtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ThreeColorPlusTime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelbtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ThreeColorPlusTime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox effectText;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ThreeColorPlusTime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorCanvas color2;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ThreeColorPlusTime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorCanvas color3;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ThreeColorPlusTime.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown time;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Flight Strip Config Tool WPF V0.1;component/threecolorplustime.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ThreeColorPlusTime.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.color1 = ((Xceed.Wpf.Toolkit.ColorCanvas)(target));
            return;
            case 2:
            this.effektLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.savebtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\ThreeColorPlusTime.xaml"
            this.savebtn.Click += new System.Windows.RoutedEventHandler(this.savebtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cancelbtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ThreeColorPlusTime.xaml"
            this.cancelbtn.Click += new System.Windows.RoutedEventHandler(this.cancelbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.effectText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.color2 = ((Xceed.Wpf.Toolkit.ColorCanvas)(target));
            return;
            case 7:
            this.color3 = ((Xceed.Wpf.Toolkit.ColorCanvas)(target));
            return;
            case 8:
            this.time = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

