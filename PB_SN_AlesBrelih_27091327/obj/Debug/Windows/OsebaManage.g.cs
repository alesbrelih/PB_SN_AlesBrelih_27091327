﻿#pragma checksum "..\..\..\Windows\OsebaManage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F473908A65CD044BA76A599F5BAD6B22"
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
    /// OsebaManage
    /// </summary>
    public partial class OsebaManage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ManageOsebaLabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMinimiye;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxIme;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxPriimek;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxEmail;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TboxTelefon;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOk;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Windows\OsebaManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/PB_SN_AlesBrelih_27091327;component/windows/osebamanage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\OsebaManage.xaml"
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
            
            #line 6 "..\..\..\Windows\OsebaManage.xaml"
            ((PB_SN_AlesBrelih_27091327.Windows.OsebaManage)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OsebaManage_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ManageOsebaLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Windows\OsebaManage.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnMinimiye = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\OsebaManage.xaml"
            this.BtnMinimiye.Click += new System.Windows.RoutedEventHandler(this.BtnMinimiye_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TboxIme = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TboxPriimek = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TboxEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TboxTelefon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

