﻿#pragma checksum "..\..\Image_slide.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "654B1E587CBAEDA908F2B3D2F4EE582D"
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
using System.Windows.Forms;
using System.Windows.Forms.Integration;
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


namespace practicemultifunzion {
    
    
    /// <summary>
    /// Image_slide
    /// </summary>
    public partial class Image_slide : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RotateImg;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_exit;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_minimize;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_home;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Forms.PictureBox pictureBox1;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_imgslide_stop;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_pre;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_next;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_openfolder;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_slide_exit;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_help;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\Image_slide.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_Help;
        
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
            System.Uri resourceLocater = new System.Uri("/practicemultifunzion;component/image_slide.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Image_slide.xaml"
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
            
            #line 5 "..\..\Image_slide.xaml"
            ((practicemultifunzion.Image_slide)(target)).Loaded += new System.Windows.RoutedEventHandler(this.load_window);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\Image_slide.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RotateImg = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.btn_exit = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\Image_slide.xaml"
            this.btn_exit.Click += new System.Windows.RoutedEventHandler(this.btn_exit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_minimize = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\Image_slide.xaml"
            this.btn_minimize.Click += new System.Windows.RoutedEventHandler(this.btn_minimize_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_home = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\Image_slide.xaml"
            this.btn_home.Click += new System.Windows.RoutedEventHandler(this.btn_home_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pictureBox1 = ((System.Windows.Forms.PictureBox)(target));
            return;
            case 8:
            this.btn_imgslide_stop = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\Image_slide.xaml"
            this.btn_imgslide_stop.Click += new System.Windows.RoutedEventHandler(this.btn_imgslide_stop_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_pre = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\Image_slide.xaml"
            this.btn_pre.Click += new System.Windows.RoutedEventHandler(this.btn_pre_click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_next = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\Image_slide.xaml"
            this.btn_next.Click += new System.Windows.RoutedEventHandler(this.btn_next_click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_openfolder = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\Image_slide.xaml"
            this.btn_openfolder.Click += new System.Windows.RoutedEventHandler(this.btn_open_click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_slide_exit = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\Image_slide.xaml"
            this.btn_slide_exit.Click += new System.Windows.RoutedEventHandler(this.btn_slide_exit_click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_help = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\Image_slide.xaml"
            this.btn_help.Click += new System.Windows.RoutedEventHandler(this.btn_helpImageSlide);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txt_Help = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
