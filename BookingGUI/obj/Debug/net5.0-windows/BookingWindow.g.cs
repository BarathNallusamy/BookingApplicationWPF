﻿#pragma checksum "..\..\..\BookingWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840AE7CB348B9360EDE0F34806FE07AE19F33BAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookingGUI;
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


namespace BookingGUI {
    
    
    /// <summary>
    /// BookingWindow
    /// </summary>
    public partial class BookingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid bookingList;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid courseList;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelStuId;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelCourseId;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Calendar;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedDate;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StudentID;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CourseID;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar CalenderBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSelectedDate;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateBooking;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\BookingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBooking;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BookingGUI;component/bookingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookingWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.bookingList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.courseList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.LabelStuId = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LabelCourseId = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Calendar = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.SelectedDate = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.StudentID = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\BookingWindow.xaml"
            this.StudentID.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.StuId_selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CourseID = ((System.Windows.Controls.ComboBox)(target));
            
            #line 49 "..\..\..\BookingWindow.xaml"
            this.CourseID.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CourseId_selected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CalenderBox = ((System.Windows.Controls.Calendar)(target));
            
            #line 52 "..\..\..\BookingWindow.xaml"
            this.CalenderBox.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Calendar_SelectedDatesChanged);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\BookingWindow.xaml"
            this.CalenderBox.DisplayDateChanged += new System.EventHandler<System.Windows.Controls.CalendarDateChangedEventArgs>(this.Calendar_DisplayDateChanged);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\BookingWindow.xaml"
            this.CalenderBox.DisplayModeChanged += new System.EventHandler<System.Windows.Controls.CalendarModeChangedEventArgs>(this.Calendar_DisplayModeChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lblSelectedDate = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.CreateBooking = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\BookingWindow.xaml"
            this.CreateBooking.Click += new System.Windows.RoutedEventHandler(this.ButtonBook_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CancelBooking = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\BookingWindow.xaml"
            this.CancelBooking.Click += new System.Windows.RoutedEventHandler(this.ButtonExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

