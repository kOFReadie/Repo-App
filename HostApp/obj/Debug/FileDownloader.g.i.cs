﻿#pragma checksum "..\..\FileDownloader.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7AC47FECA73AB4C0D5758DD97F02E11F58EEF217174B0D93EC9F94CCC127F2C"
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
    /// FileDownloader
    /// </summary>
    public partial class FileDownloader : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 110 "..\..\FileDownloader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid background;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\FileDownloader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid titleBar;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\FileDownloader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label applicationTitle;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\FileDownloader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel appControls;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\FileDownloader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closebtn;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\FileDownloader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar downloadprogress;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\FileDownloader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logs;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\FileDownloader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox body;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\FileDownloader.xaml"
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
            System.Uri resourceLocater = new System.Uri("/kOFRRepoApp;component/filedownloader.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FileDownloader.xaml"
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
            
            #line 111 "..\..\FileDownloader.xaml"
            this.titleBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.titleBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.applicationTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.appControls = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.closebtn = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\FileDownloader.xaml"
            this.closebtn.Click += new System.Windows.RoutedEventHandler(this.closebtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.downloadprogress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 7:
            this.logs = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.body = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.windowBorder = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

