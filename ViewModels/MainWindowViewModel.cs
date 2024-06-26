﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MenuProject.ViewModels.Base;
using MenuProject.ViewModels.SchoolCitizens;

namespace MenuProject.ViewModels
{
    partial class  MainWindowViewModel : BaseViewModel
    {
        [ObservableProperty]
        private BaseViewModel _childViewModel;

        [ObservableProperty]
        private string _statusBarText="A program betölödött...";

        public MainWindowViewModel()
        {
            _childViewModel = new WelcomeViewModel();
        }

        [RelayCommand]
        private void ShowStudentView()
        {
            ChildViewModel=new StudentViewModel();
            StatusBarText = "Diák adatok kezelése";
        }

        [RelayCommand]
        private void ShowTeacherView()
        {
            ChildViewModel = new TeacherViewModel();
            StatusBarText = "Tanár adatok kezelése";
        }

        [RelayCommand]
        private void ShowParantView()
        {
            ChildViewModel = new ParentViewModel();
            StatusBarText = "Szülői adatok kezelése";
        }

        [RelayCommand]
        private void ShowSubjectView() 
        {
            ChildViewModel = new SubjectViewModel();
            StatusBarText = "Tantárgyak kezelése";
        }

        [RelayCommand]
        private void ShowSchoolClassView()
        {
            ChildViewModel = new SchoolClassViewModel();
            StatusBarText = "Osztályok kezelése";
        }
    }
}
