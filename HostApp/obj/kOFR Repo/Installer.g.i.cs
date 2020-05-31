﻿#pragma checksum "..\..\Installer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7948849AFA3CD8BAB46FE9B671581805B9B83A1BA6EE6D1A17E63FEC7B2250FA"
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
using kOFR_Repo;


namespace kOFR_Repo {
    
    
    /// <summary>
    /// Installer
    /// </summary>
    public partial class Installer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 145 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid background;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid titleBar;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label appTitle;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closebtn;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimisebtn;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox installDIR;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dir;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeDIR;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox downloadLogs;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button install;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar downloadProgress;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\Installer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border windowBorder;
        
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
            System.Uri resourceLocater = new System.Uri("/kOFR Repo;component/installer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Installer.xaml"
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
            this.background = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.titleBar = ((System.Windows.Controls.Grid)(target));
            
            #line 147 "..\..\Installer.xaml"
            this.titleBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.titleBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.appTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.closebtn = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\Installer.xaml"
            this.closebtn.Click += new System.Windows.RoutedEventHandler(this.closebtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.minimisebtn = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\Installer.xaml"
            this.minimisebtn.Click += new System.Windows.RoutedEventHandler(this.minimisebtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.installDIR = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dir = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.changeDIR = ((System.Windows.Controls.Button)(target));
            
            #line 155 "..\..\Installer.xaml"
            this.changeDIR.Click += new System.Windows.RoutedEventHandler(this.changeDIR_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.downloadLogs = ((System.Windows.Controls.TextBox)(target));
            
            #line 156 "..\..\Installer.xaml"
            this.downloadLogs.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.downloadLogs_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.install = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\Installer.xaml"
            this.install.Click += new System.Windows.RoutedEventHandler(this.install_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.downloadProgress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 12:
            this.windowBorder = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

