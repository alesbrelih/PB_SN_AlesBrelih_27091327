﻿#pragma checksum "..\..\..\Windows\NajemMain.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "16102D4E24D55B0E62EA07F65E016DD1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    /// NajemMain
    /// </summary>
    public partial class NajemMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Windows\NajemMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\NajemMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMinimize;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Windows\NajemMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBoxNajemi;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Windows\NajemMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUrediPodjetje;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Windows\NajemMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUrediProstor;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Windows\NajemMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUrediNajem;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Windows\NajemMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnIzbrisiNajem;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Windows\NajemMain.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PB_SN_AlesBrelih_27091327;component/windows/najemmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\NajemMain.xaml"
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
            
            #line 8 "..\..\..\Windows\NajemMain.xaml"
            ((PB_SN_AlesBrelih_27091327.Windows.NajemMain)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\NajemMain.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Windows\NajemMain.xaml"
            this.BtnMinimize.Click += new System.Windows.RoutedEventHandler(this.BtnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CBoxNajemi = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\Windows\NajemMain.xaml"
            this.CBoxNajemi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBoxNajemi_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnUrediPodjetje = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\Windows\NajemMain.xaml"
            this.BtnUrediPodjetje.Click += new System.Windows.RoutedEventHandler(this.BtnUrediPodjetje_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnUrediProstor = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\Windows\NajemMain.xaml"
            this.BtnUrediProstor.Click += new System.Windows.RoutedEventHandler(this.BtnUrediProstor_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnUrediNajem = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\Windows\NajemMain.xaml"
            this.BtnUrediNajem.Click += new System.Windows.RoutedEventHandler(this.BtnUrediNajem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnIzbrisiNajem = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\Windows\NajemMain.xaml"
            this.BtnIzbrisiNajem.Click += new System.Windows.RoutedEventHandler(this.BtnIzbrisiNajem_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\Windows\NajemMain.xaml"
            this.BtnOk.Click += new System.Windows.RoutedEventHandler(this.BtnOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

