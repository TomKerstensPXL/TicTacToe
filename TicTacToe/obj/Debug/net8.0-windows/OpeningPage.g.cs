﻿#pragma checksum "..\..\..\OpeningPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3739CE3F9EBB916E19B3B91181BE2B4ECE010F57"
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
using TicTacToe;


namespace TicTacToe {
    
    
    /// <summary>
    /// OpeningPage
    /// </summary>
    public partial class OpeningPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\OpeningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameXPlayerBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\OpeningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameYPlayerLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\OpeningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameYPlayerBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\OpeningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button readyButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\OpeningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton singlePlayerRadioButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\OpeningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton easyRadio;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\OpeningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton mediumRadio;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\OpeningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton hardRadio;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TicTacToe;component/openingpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OpeningPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nameXPlayerBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nameYPlayerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.nameYPlayerBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.readyButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\OpeningPage.xaml"
            this.readyButton.Click += new System.Windows.RoutedEventHandler(this.readyButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.singlePlayerRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 38 "..\..\..\OpeningPage.xaml"
            this.singlePlayerRadioButton.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\OpeningPage.xaml"
            this.singlePlayerRadioButton.Unchecked += new System.Windows.RoutedEventHandler(this.RadioButton_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.easyRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.mediumRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.hardRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

