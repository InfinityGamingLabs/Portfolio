﻿#pragma checksum "..\..\..\menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3076113FAA97DB7D7E7CAB3DB6AD1DD73917272E"
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
using project4;


namespace project4 {
    
    
    /// <summary>
    /// menu
    /// </summary>
    public partial class menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bestel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button crud;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button orders;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button afsluiten;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/project4;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\menu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.bestel = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\menu.xaml"
            this.bestel.Click += new System.Windows.RoutedEventHandler(this.bestel_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.crud = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\menu.xaml"
            this.crud.Click += new System.Windows.RoutedEventHandler(this.crud_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.orders = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\menu.xaml"
            this.orders.Click += new System.Windows.RoutedEventHandler(this.orders_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.afsluiten = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\menu.xaml"
            this.afsluiten.Click += new System.Windows.RoutedEventHandler(this.afsluiten_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

