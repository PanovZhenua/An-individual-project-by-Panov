﻿#pragma checksum "..\..\Отчёт об ошибках.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16608CE2C454BE951F1D81D8143BC2E3C17F8B98AD832AD7ACFC5AB360551393"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Индивидуальный_Проект;


namespace Индивидуальный_Проект {
    
    
    /// <summary>
    /// Отчёт_об_ошибках
    /// </summary>
    public partial class Отчёт_об_ошибках : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Отчёт об ошибках.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BugReportDataGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Отчёт об ошибках.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Column1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Отчёт об ошибках.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Column2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Отчёт об ошибках.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Column3;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Отчёт об ошибках.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Column4;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Отчёт об ошибках.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Column5;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Отчёт об ошибках.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridCheckBoxColumn Column6;
        
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
            System.Uri resourceLocater = new System.Uri("/Индивидуальный Проект;component/%d0%9e%d1%82%d1%87%d1%91%d1%82%20%d0%be%d0%b1%20" +
                    "%d0%be%d1%88%d0%b8%d0%b1%d0%ba%d0%b0%d1%85.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Отчёт об ошибках.xaml"
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
            this.BugReportDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Column1 = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.Column2 = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.Column3 = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.Column4 = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.Column5 = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.Column6 = ((System.Windows.Controls.DataGridCheckBoxColumn)(target));
            return;
            case 8:
            
            #line 62 "..\..\Отчёт об ошибках.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 63 "..\..\Отчёт об ошибках.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FixButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

