﻿using UM_Consultation_App_MAUI.Views;
using UM_Consultation_App_MAUI.Views.Common;
using UM_Consultation_App_MAUI.Views.FacultyView;
using UM_Consultation_App_MAUI.Views.StudentView;

namespace UM_Consultation_App_MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //naka set ni to AppShell, kay nag base ang bottom navigation sa AppShell.xaml
            //change lng ninyo ang structure ani para sa loginpage (if dli mag function ang navigation) kay dili na nko to hilabtan ang login
            MainPage = new CreateAccountPage(); //change lng ni if need ninyo i debug or polish ang uban pages (pasagdi lng ug naa error sa initialize component)
        }
    }
}
