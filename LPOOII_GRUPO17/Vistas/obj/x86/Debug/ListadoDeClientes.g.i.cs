﻿#pragma checksum "..\..\..\ListadoDeClientes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1D87F9C57ADF8412D33C29FE90390B0B0CDE357F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClasesBase;
using System;
using System.ComponentModel;
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


namespace Vistas {
    
    
    /// <summary>
    /// ListadoDeClientes
    /// </summary>
    public partial class ListadoDeClientes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\ListadoDeClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblListaClientes;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\ListadoDeClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDNI;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ListadoDeClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lsvCliente;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ListadoDeClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFiltroCliente;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ListadoDeClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVistaPrevia;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/listadodeclientes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ListadoDeClientes.xaml"
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
            
            #line 19 "..\..\..\ListadoDeClientes.xaml"
            ((System.Windows.Data.CollectionViewSource)(target)).Filter += new System.Windows.Data.FilterEventHandler(this.eventVistaCliente_Filter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblListaClientes = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtDNI = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\ListadoDeClientes.xaml"
            this.txtDNI.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtDNI_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lsvCliente = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.lblFiltroCliente = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnVistaPrevia = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\ListadoDeClientes.xaml"
            this.btnVistaPrevia.Click += new System.Windows.RoutedEventHandler(this.btnVistaPrevia_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

