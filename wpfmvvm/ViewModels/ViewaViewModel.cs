using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpfmvvm.ViewModels
{
    class ViewaViewModel:BindableBase
    {
        private string _FirstName;
            public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
               
               
                SetProperty(ref _FirstName, value);
                updateCommand.RaiseCanExecuteChanged();
            }
        }


        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {

                SetProperty(ref _LastName, value);
                updateCommand.RaiseCanExecuteChanged();
            }
        }


        private DateTime? _LastUpdate;
        public DateTime? LastUpdate
        {
            get
            {
                return _LastUpdate;
            }

            set
            {

                SetProperty(ref _LastUpdate, value);
            }
        }

        public DelegateCommand updateCommand { get; set; }

        public ViewaViewModel()
        {
            updateCommand = new DelegateCommand(execute, CanExcute);
        }

        private bool CanExcute()
        {
            return !string.IsNullOrWhiteSpace(FirstName) &&!string.IsNullOrWhiteSpace(LastName);
        }

        private void execute()
        {
            LastUpdate = DateTime.Now;
        }
    }
}
