// Updated by XamlIntelliSenseFileGenerator 28/12/2021 12:50:11
#pragma checksum "..\..\ControlSocios.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9CC9828BF0E0E3D0504FC4A9B7C2FC239D7E6EFBA4064AB7C4891775D3FB7F71"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Eventos;
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


namespace Eventos
{


    /// <summary>
    /// ControlSocios
    /// </summary>
    public partial class ControlSocios : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 43 "..\..\ControlSocios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAñadirVoluntario;

#line default
#line hidden


#line 44 "..\..\ControlSocios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarVoluntario;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Eventos;component/controlsocios.xaml", System.UriKind.Relative);

#line 1 "..\..\ControlSocios.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Apellidos = ((System.Windows.Controls.ContextMenu)(target));

#line 30 "..\..\ControlSocios.xaml"
                    this.Apellidos.AddHandler(System.Windows.Controls.MenuItem.ClickEvent, new System.Windows.RoutedEventHandler(this.LastNameCM_Click));

#line default
#line hidden
                    return;
                case 2:
                    this.btnAñadirVoluntario = ((System.Windows.Controls.Button)(target));

#line 43 "..\..\ControlSocios.xaml"
                    this.btnAñadirVoluntario.Click += new System.Windows.RoutedEventHandler(this.btnAñadirVoluntario_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btnEliminarVoluntario = ((System.Windows.Controls.Button)(target));

#line 44 "..\..\ControlSocios.xaml"
                    this.btnEliminarVoluntario.Click += new System.Windows.RoutedEventHandler(this.btnEliminarVoluntario_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.ListBox lstSocios;
        internal System.Windows.Controls.StackPanel spDetallesSocios;
    }
}

