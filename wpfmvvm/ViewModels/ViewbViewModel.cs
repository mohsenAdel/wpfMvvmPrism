using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfmvvm.Envents;

namespace wpfmvvm.ViewModels
{
    class ViewbViewModel:BindableBase
    {
        private string _message="viewb";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }


        public ViewbViewModel(IEventAggregator EventAggregator)
        {
            EventAggregator.GetEvent<updateEvent>().Subscribe(updated);
        }

        private void updated(string obj)
        {
            Message = obj;
        }
    }
}
