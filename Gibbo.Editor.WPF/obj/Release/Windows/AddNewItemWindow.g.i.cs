﻿#pragma checksum "..\..\..\Windows\AddNewItemWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6997FE1570B763EB842F4963ECA8364A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
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
using System.Windows.Forms.Integration;
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


namespace Gibbo.Editor.WPF {
    
    
    /// <summary>
    /// AddNewItemWindow
    /// </summary>
    public partial class AddNewItemWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows\AddNewItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox itemListBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\AddNewItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock itemInfoTextBlock;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\AddNewItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Windows\AddNewItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox addToSelectedCheckBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Windows\AddNewItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Windows\AddNewItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Gibbo.Editor.WPF;component/windows/addnewitemwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddNewItemWindow.xaml"
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
            this.itemListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 15 "..\..\..\Windows\AddNewItemWindow.xaml"
            this.itemListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.itemListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.itemInfoTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\Windows\AddNewItemWindow.xaml"
            this.nameTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.nameTextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addToSelectedCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\Windows\AddNewItemWindow.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.cancelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Windows\AddNewItemWindow.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

