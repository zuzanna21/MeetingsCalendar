﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2CCE1B61098FFF41BC20632A74CAFBC57D42F0A6F4019024544E671EFEE96FE9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Calendar;
using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
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


namespace Calendar {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 460 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogOut_button;
        
        #line default
        #line hidden
        
        
        #line 488 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimize_button;
        
        #line default
        #line hidden
        
        
        #line 547 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calendar;
        
        #line default
        #line hidden
        
        
        #line 550 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox EventsList;
        
        #line default
        #line hidden
        
        
        #line 563 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 568 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FriendTextBox;
        
        #line default
        #line hidden
        
        
        #line 574 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListOfFriends;
        
        #line default
        #line hidden
        
        
        #line 588 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MeetingsDays;
        
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
            System.Uri resourceLocater = new System.Uri("/Calendar;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            
            #line 9 "..\..\..\Views\MainWindow.xaml"
            ((Calendar.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_Funcionality);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LogOut_button = ((System.Windows.Controls.Button)(target));
            
            #line 469 "..\..\..\Views\MainWindow.xaml"
            this.LogOut_button.Click += new System.Windows.RoutedEventHandler(this.LogOut_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Minimize_button = ((System.Windows.Controls.Button)(target));
            
            #line 497 "..\..\..\Views\MainWindow.xaml"
            this.Minimize_button.Click += new System.Windows.RoutedEventHandler(this.Minimize_Window);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 523 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Window);
            
            #line default
            #line hidden
            return;
            case 5:
            this.calendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 547 "..\..\..\Views\MainWindow.xaml"
            this.calendar.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Kalendarz_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EventsList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.EventNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 563 "..\..\..\Views\MainWindow.xaml"
            this.EventNameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MyTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 563 "..\..\..\Views\MainWindow.xaml"
            this.EventNameTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.MyTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 565 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddEvent_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 566 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DropEvent_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FriendTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 568 "..\..\..\Views\MainWindow.xaml"
            this.FriendTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.FriendTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 568 "..\..\..\Views\MainWindow.xaml"
            this.FriendTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.FriendTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 570 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddFriend_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 571 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DropFriend_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ListOfFriends = ((System.Windows.Controls.ListBox)(target));
            return;
            case 14:
            
            #line 586 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowFreeDays_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.MeetingsDays = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

