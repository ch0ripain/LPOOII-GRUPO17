﻿#pragma checksum "..\..\..\ListadoDeVentas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2930E6B12BC8B95F364D86D5517617EFEEE14A28"
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
    /// ListadoDeVentas
    /// </summary>
    public partial class ListadoDeVentas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\ListadoDeVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitulo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\ListadoDeVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lsvVenta;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\ListadoDeVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFiltroFecha;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\ListadoDeVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpInicio;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\ListadoDeVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpFinal;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\ListadoDeVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVistaPrevia;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\ListadoDeVentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotal;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/listadodeventas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ListadoDeVentas.xaml"
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
            
            #line 6 "..\..\..\ListadoDeVentas.xaml"
            ((Vistas.ListadoDeVentas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\ListadoDeVentas.xaml"
            ((System.Windows.Data.CollectionViewSource)(target)).Filter += new System.Windows.Data.FilterEventHandler(this.eventVistaFecha_Filter);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblTitulo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lsvVenta = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.lblFiltroFecha = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.dtpInicio = ((System.Windows.Controls.DatePicker)(target));
            
            #line 49 "..\..\..\ListadoDeVentas.xaml"
            this.dtpInicio.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dtpRango_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dtpFinal = ((System.Windows.Controls.DatePicker)(target));
            
            #line 50 "..\..\..\ListadoDeVentas.xaml"
            this.dtpFinal.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dtpRango_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnVistaPrevia = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\ListadoDeVentas.xaml"
            this.btnVistaPrevia.Click += new System.Windows.RoutedEventHandler(this.btnVistaPrevia_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblTotal = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

