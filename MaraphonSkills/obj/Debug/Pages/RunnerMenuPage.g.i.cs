﻿#pragma checksum "..\..\..\Pages\RunnerMenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A28FB8B023C4BE8E2DAD8E7288BEAF986EA228A72091791D941DE1FB1CF8DEB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaraphonSkills.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace MaraphonSkills.Pages {
    
    
    /// <summary>
    /// RunnerMenuPage
    /// </summary>
    public partial class RunnerMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\RunnerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ProfileEditButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\RunnerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MyCharityButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\RunnerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ContactsButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\RunnerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ContactsBorder;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\RunnerMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Cross;
        
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
            System.Uri resourceLocater = new System.Uri("/MaraphonSkills;component/pages/runnermenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RunnerMenuPage.xaml"
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
            
            #line 14 "..\..\..\Pages\RunnerMenuPage.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RegistationMarathonEditButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 17 "..\..\..\Pages\RunnerMenuPage.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MyResultEditButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ProfileEditButton = ((System.Windows.Controls.Border)(target));
            
            #line 20 "..\..\..\Pages\RunnerMenuPage.xaml"
            this.ProfileEditButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ProfileEditButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MyCharityButton = ((System.Windows.Controls.Border)(target));
            
            #line 23 "..\..\..\Pages\RunnerMenuPage.xaml"
            this.MyCharityButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MyCharityButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ContactsButton = ((System.Windows.Controls.Border)(target));
            
            #line 26 "..\..\..\Pages\RunnerMenuPage.xaml"
            this.ContactsButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ContactsButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ContactsBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.Cross = ((System.Windows.Controls.Image)(target));
            
            #line 33 "..\..\..\Pages\RunnerMenuPage.xaml"
            this.Cross.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Cross_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
