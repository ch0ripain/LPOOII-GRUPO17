﻿#pragma checksum "..\..\..\ValidarCliente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86E03CFA3B5E6936FFF7777A7BF0F279441358BE"
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
    /// ValidarCliente
    /// </summary>
    public partial class ValidarCliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblClienteDNI;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblClienteNombre;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblClienteApellido;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblClienteTelefono;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtClienteDNI;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtClienteNombre;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtClienteApellido;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtClienteTelefono;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblClienteTitulo;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\ValidarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificarCliente;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/validarcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ValidarCliente.xaml"
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
            this.lblClienteDNI = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblClienteNombre = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblClienteApellido = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblClienteTelefono = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtClienteDNI = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\ValidarCliente.xaml"
            this.txtClienteDNI.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtClienteDNI_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtClienteNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtClienteApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtClienteTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.lblClienteTitulo = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btnModificarCliente = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\ValidarCliente.xaml"
            this.btnModificarCliente.Click += new System.Windows.RoutedEventHandler(this.btnModificarCliente_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
