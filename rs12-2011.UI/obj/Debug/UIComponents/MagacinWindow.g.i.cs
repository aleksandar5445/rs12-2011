﻿#pragma checksum "..\..\..\UIComponents\MagacinWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4EEBCBCE2E5971657EB3295A44D4E51B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using rs12_2011.UI.ViewModel;


namespace rs12_2011.UI.UIComponents {
    
    
    /// <summary>
    /// MagacinWindow
    /// </summary>
    public partial class MagacinWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\UIComponents\MagacinWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MagacinGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UIComponents\MagacinWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Kolicina;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UIComponents\MagacinWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajUKorpu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UIComponents\MagacinWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoviNamestaj;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UIComponents\MagacinWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ObrisiNamestaj;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UIComponents\MagacinWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IzmeniNamestaj;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UIComponents\MagacinWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TipNamestaja;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UIComponents\MagacinWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Izlaz;
        
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
            System.Uri resourceLocater = new System.Uri("/rs12-2011.UI;component/uicomponents/magacinwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIComponents\MagacinWindow.xaml"
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
            this.MagacinGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Kolicina = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DodajUKorpu = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UIComponents\MagacinWindow.xaml"
            this.DodajUKorpu.Click += new System.Windows.RoutedEventHandler(this.DodajUKorpu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NoviNamestaj = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\UIComponents\MagacinWindow.xaml"
            this.NoviNamestaj.Click += new System.Windows.RoutedEventHandler(this.NoviNamestaj_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ObrisiNamestaj = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\UIComponents\MagacinWindow.xaml"
            this.ObrisiNamestaj.Click += new System.Windows.RoutedEventHandler(this.ObrisiNamestaj_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.IzmeniNamestaj = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\UIComponents\MagacinWindow.xaml"
            this.IzmeniNamestaj.Click += new System.Windows.RoutedEventHandler(this.IzmeniNamestaj_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TipNamestaja = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\UIComponents\MagacinWindow.xaml"
            this.TipNamestaja.Click += new System.Windows.RoutedEventHandler(this.TipNamestaja_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Izlaz = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

