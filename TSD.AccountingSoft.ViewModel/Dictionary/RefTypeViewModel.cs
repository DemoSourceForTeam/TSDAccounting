using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSD.AccountingSoft.Models;
using TSD.AccountingSoft.Models.BusinessObject.Dictionary;

namespace TSD.AccountingSoft.ViewModel.Dictionary
{
    public class RefTypeViewModel :ViewModelBase
    {
        private IProvider provider;
        public bool IsLoaded { private set; get; }
        public ObservableCollection<RefTypeModel> RefTypes { private set; get; }

        public RefTypeViewModel(IProvider provider) //map model ->view
        {
            this.provider = provider;

            RefTypes = new ObservableCollection<RefTypeModel>();

           
        }
       
        public ObservableCollection<RefTypeModel> Display()
        {
            RefTypes = provider.GetRefTypeModels()?? new ObservableCollection<RefTypeModel>();
            IsLoaded = true;
            return RefTypes;
        }


    }
}
