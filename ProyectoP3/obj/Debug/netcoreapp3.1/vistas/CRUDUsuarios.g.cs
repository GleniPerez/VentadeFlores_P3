﻿#pragma checksum "..\..\..\..\vistas\CRUDUsuarios.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0FF9B9D6189C1B36F10C8B538F4B849D43A71CD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoP3.vistas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ProyectoP3.vistas {
    
    
    /// <summary>
    /// CRUDUsuarios
    /// </summary>
    public partial class CRUDUsuarios : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 99 "..\..\..\..\vistas\CRUDUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Titulo;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\vistas\CRUDUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegresar;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\vistas\CRUDUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrear;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\vistas\CRUDUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEliminar;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\vistas\CRUDUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnActuliazar;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\vistas\CRUDUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUsername;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\..\vistas\CRUDUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNombre_Completo;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\..\vistas\CRUDUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbContrasena;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoP3;component/vistas/crudusuarios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\vistas\CRUDUsuarios.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BtnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\..\vistas\CRUDUsuarios.xaml"
            this.BtnRegresar.Click += new System.Windows.RoutedEventHandler(this.Regresar);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\..\vistas\CRUDUsuarios.xaml"
            this.BtnCrear.Click += new System.Windows.RoutedEventHandler(this.Crear);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 137 "..\..\..\..\vistas\CRUDUsuarios.xaml"
            this.BtnEliminar.Click += new System.Windows.RoutedEventHandler(this.Eliminar);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnActuliazar = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\..\vistas\CRUDUsuarios.xaml"
            this.BtnActuliazar.Click += new System.Windows.RoutedEventHandler(this.Actualizar);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbNombre_Completo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbContrasena = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

