﻿#pragma checksum "..\..\..\Medewerker.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ACD142A524A9DF6075983B5E553FF4AA55D9400"
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
    /// Medewerker
    /// </summary>
    public partial class Medewerker : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mederwerkermenu;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbWoonplaats;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTelefoonnummer;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbwoon;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbtele;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvpizza;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Medewerker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteName;
        
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
            System.Uri resourceLocater = new System.Uri("/project4;component/medewerker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Medewerker.xaml"
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
            this.mederwerkermenu = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Medewerker.xaml"
            this.mederwerkermenu.Click += new System.Windows.RoutedEventHandler(this.mederwerkermenu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\..\Medewerker.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateName_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpdateName = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Medewerker.xaml"
            this.UpdateName.Click += new System.Windows.RoutedEventHandler(this.UpdateName_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\Medewerker.xaml"
            this.tbName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbName_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbWoonplaats = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\Medewerker.xaml"
            this.tbWoonplaats.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbWoonplaats_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbTelefoonnummer = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\Medewerker.xaml"
            this.tbTelefoonnummer.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbTelefoonnummer_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 63 "..\..\..\Medewerker.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbwoon = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\Medewerker.xaml"
            this.tbwoon.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbwoon_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbtele = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\Medewerker.xaml"
            this.tbtele.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbtele_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lvpizza = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.DeleteName = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\Medewerker.xaml"
            this.DeleteName.Click += new System.Windows.RoutedEventHandler(this.DeleteName_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

