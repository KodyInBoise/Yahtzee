﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30C686185F1C42BEA79F1C9E4B56070DA08BCD73"
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
using Yahtzee;


namespace Yahtzee {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem gameTAB;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox diceLB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button holdBTN;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox heldLB;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startBTN;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock playerTB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock rollTB;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock turnTB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rollBTN;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image diceOneIMG;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image diceTwoIMG;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image diceThreeIMG;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image diceFourIMG;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image diceFiveIMG;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextTurnBTN;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox heldGB;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image heldOneIMG;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image heldTwoIMG;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image heldThreeIMG;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image heldFourIMG;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image heldFiveIMG;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button unholdBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/Yahtzee;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.gameTAB = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.diceLB = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.holdBTN = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.holdBTN.Click += new System.Windows.RoutedEventHandler(this.holdBTN_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.heldLB = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.startBTN = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\MainWindow.xaml"
            this.startBTN.Click += new System.Windows.RoutedEventHandler(this.startBTN_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.playerTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.rollTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.turnTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.rollBTN = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MainWindow.xaml"
            this.rollBTN.Click += new System.Windows.RoutedEventHandler(this.rollBTN_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.diceOneIMG = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\MainWindow.xaml"
            this.diceOneIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceOneIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.diceTwoIMG = ((System.Windows.Controls.Image)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.diceTwoIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceTwoIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.diceThreeIMG = ((System.Windows.Controls.Image)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.diceThreeIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceThreeIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            this.diceFourIMG = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.diceFourIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceFourIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 14:
            this.diceFiveIMG = ((System.Windows.Controls.Image)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.diceFiveIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceFiveIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 15:
            this.nextTurnBTN = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.nextTurnBTN.Click += new System.Windows.RoutedEventHandler(this.nextTurnBTN_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.heldGB = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 17:
            this.heldOneIMG = ((System.Windows.Controls.Image)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.heldOneIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceOneIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 18:
            this.heldTwoIMG = ((System.Windows.Controls.Image)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.heldTwoIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceOneIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 19:
            this.heldThreeIMG = ((System.Windows.Controls.Image)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.heldThreeIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceOneIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 20:
            this.heldFourIMG = ((System.Windows.Controls.Image)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.heldFourIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceOneIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 21:
            this.heldFiveIMG = ((System.Windows.Controls.Image)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.heldFiveIMG.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.diceOneIMG_MouseDown);
            
            #line default
            #line hidden
            return;
            case 22:
            this.unholdBTN = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.unholdBTN.Click += new System.Windows.RoutedEventHandler(this.unholdBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

