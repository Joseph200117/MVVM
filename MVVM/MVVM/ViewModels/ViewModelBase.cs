﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM.ViewModels
{
	public class ViewModelBase: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(
			[CallerMemberName] string propertyName = null)
        {
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
            {
				handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

