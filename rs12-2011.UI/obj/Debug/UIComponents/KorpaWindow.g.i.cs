﻿#pragma checksum "..\..\..\UIComponents\KorpaWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42318B6555BC0AA36A951AA17A4BE611"
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
using rs12_2011.UI.UIComponents;
using rs12_2011.UI.ViewModel;


namespace rs12_2011.UI.UIComponents {
    
    
    /// <summary>
    /// KorpaWindow
    /// </summary>
    public partial class KorpaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid KorpaGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblTotal;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblTotalVrednost;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblTotalPopust;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblTotalPopustVrednost;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblGrandTotal;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblGrandTotalVrednost;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIzbaciIzKorpe;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UIComponents\KorpaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKupi;
        
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
            System.Uri resourceLocater = new System.Uri("/rs12-2011.UI;component/uicomponents/korpawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIComponents\KorpaWindow.xaml"
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
            this.KorpaGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.tblTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tblTotalVrednost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tblTotalPopust = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tblTotalPopustVrednost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tblGrandTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.tblGrandTotalVrednost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnIzbaciIzKorpe = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\UIComponents\KorpaWindow.xaml"
            this.btnIzbaciIzKorpe.Click += new System.Windows.RoutedEventHandler(this.btnIzbaciIzKorpe_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnKupi = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\UIComponents\KorpaWindow.xaml"
            this.btnKupi.Click += new System.Windows.RoutedEventHandler(this.btnKupi_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

