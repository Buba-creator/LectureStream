﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LectureStream.ViewModel
{
    public class BaseViewModel:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName= null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
