﻿#pragma checksum "..\..\..\Windows\ProstorMain.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C09457849EAFC0CAD966630B6C090F89"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
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


namespace PB_SN_AlesBrelih_27091327.Windows {
    
    
    /// <summary>
    /// ProstorMain
    /// </summary>
    public partial class ProstorMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Windows\ProstorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblMainProstorWindow;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\ProstorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\ProstorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMinimize;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Windows\ProstorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBoxProstori;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Windows\ProstorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUredi;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Windows\ProstorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnIzbrisi;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Windows\ProstorMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOk;
        
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
            System.Uri resourceLocater = new System.Uri("/PB_SN_AlesBrelih_27091327;component/windows/prostormain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ProstorMain.xaml"
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
            
            #line 7 "..\..\..\Windows\ProstorMain.xaml"
            ((PB_SN_AlesBrelih_27091327.Windows.ProstorMain)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ProstorMain_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LblMainProstorWindow = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Windows\ProstorMain.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\ProstorMain.xaml"
            this.BtnMinimize.Click += new System.Windows.RoutedEventHandler(this.BtnMinimize_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CBoxProstori = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\Windows\ProstorMain.xaml"
            this.CBoxProstori.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBoxProstori_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnUredi = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Windows\ProstorMain.xaml"
            this.BtnUredi.Click += new System.Windows.RoutedEventHandler(this.BtnUredi_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnIzbrisi = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Windows\ProstorMain.xaml"
            this.BtnIzbrisi.Click += new System.Windows.RoutedEventHandler(this.BtnIzbrisi_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Windows\ProstorMain.xaml"
            this.BtnOk.Click += new System.Windows.RoutedEventHandler(this.BtnOk_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
