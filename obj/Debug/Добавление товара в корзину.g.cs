﻿#pragma checksum "..\..\Добавление товара в корзину.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8DC94350D9E91F6829C46AA9CA3C082A02F55EDEF0D6598E38910E95BF336493"
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
    /// Добавление_товара_в_корзину
    /// </summary>
    public partial class Добавление_товара_в_корзину : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Добавление товара в корзину.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProductImage;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Добавление товара в корзину.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Добавление товара в корзину.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductDescription;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Добавление товара в корзину.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DecreaseQuantityButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Добавление товара в корзину.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuantityTextBlock;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Добавление товара в корзину.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IncreaseQuantityButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Добавление товара в корзину.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ExistingCartItemMessage;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Добавление товара в корзину.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddToCartButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Индивидуальный Проект;component/%d0%94%d0%be%d0%b1%d0%b0%d0%b2%d0%bb%d0%b5%d0%bd" +
                    "%d0%b8%d0%b5%20%d1%82%d0%be%d0%b2%d0%b0%d1%80%d0%b0%20%d0%b2%20%d0%ba%d0%be%d1%8" +
                    "0%d0%b7%d0%b8%d0%bd%d1%83.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Добавление товара в корзину.xaml"
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
            this.ProductImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.ProductName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ProductDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DecreaseQuantityButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Добавление товара в корзину.xaml"
            this.DecreaseQuantityButton.Click += new System.Windows.RoutedEventHandler(this.DecreaseQuantityButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.QuantityTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.IncreaseQuantityButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Добавление товара в корзину.xaml"
            this.IncreaseQuantityButton.Click += new System.Windows.RoutedEventHandler(this.IncreaseQuantityButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ExistingCartItemMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.AddToCartButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Добавление товара в корзину.xaml"
            this.AddToCartButton.Click += new System.Windows.RoutedEventHandler(this.AddToCartButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

