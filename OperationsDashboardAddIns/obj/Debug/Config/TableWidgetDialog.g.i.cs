﻿#pragma checksum "..\..\..\Config\TableWidgetDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "693C9D4435FA30B3ED1C0A5EAE863142"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ESRI.ArcGIS.OperationsDashboard;
using ESRI.ArcGIS.OperationsDashboard.Controls;
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


namespace OperationsDashboardAddIns.Config {
    
    
    /// <summary>
    /// TableWidgetDialog
    /// </summary>
    public partial class TableWidgetDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Config\TableWidgetDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CaptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Config\TableWidgetDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ESRI.ArcGIS.OperationsDashboard.Controls.DataSourceSelector DataSourceSelector;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Config\TableWidgetDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ESRI.ArcGIS.OperationsDashboard.Controls.FeatureActionList FeatureActionList;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Config\TableWidgetDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OKButton;
        
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
            System.Uri resourceLocater = new System.Uri("/OperationsDashboardAddIns;component/config/tablewidgetdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Config\TableWidgetDialog.xaml"
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
            this.CaptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DataSourceSelector = ((ESRI.ArcGIS.OperationsDashboard.Controls.DataSourceSelector)(target));
            
            #line 48 "..\..\..\Config\TableWidgetDialog.xaml"
            this.DataSourceSelector.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FeatureActionList = ((ESRI.ArcGIS.OperationsDashboard.Controls.FeatureActionList)(target));
            return;
            case 4:
            this.OKButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Config\TableWidgetDialog.xaml"
            this.OKButton.Click += new System.Windows.RoutedEventHandler(this.OnOkButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
