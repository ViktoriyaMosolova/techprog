﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0E4CCA1DD336E120A6738E8A4AC6AAA585B9BAD3D3CD271949B416DFAC9DBB32"
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;
using lab1;


namespace lab1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblCursorPosition;
        
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
            System.Uri resourceLocater = new System.Uri("/lab1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 15 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Primitives.StatusBar)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.mousemove);
            
            #line default
            #line hidden
            
            #line 16 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Primitives.StatusBar)(target)).PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.mouseup);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblCursorPosition = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 27 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ComboBox)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.mouse);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ComboBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.mouseleave);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 39 "..\..\MainWindow.xaml"
            ((Xceed.Wpf.Toolkit.ColorPicker)(target)).SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.changecolor);
            
            #line default
            #line hidden
            
            #line 40 "..\..\MainWindow.xaml"
            ((Xceed.Wpf.Toolkit.ColorPicker)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.keyup);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 54 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.GridSplitter)(target)).DragCompleted += new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.completed);
            
            #line default
            #line hidden
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.GridSplitter)(target)).DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.delta);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

