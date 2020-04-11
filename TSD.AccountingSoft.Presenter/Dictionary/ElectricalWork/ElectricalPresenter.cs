

using TSD.AccountingSoft.Model.BusinessObjects.Dictionary;
using TSD.AccountingSoft.View.Dictionary;


namespace TSD.AccountingSoft.Presenter.Dictionary.ElectricalWork
{
    public class ElectricalWorkPresenter : Presenter<IElectricalWorkView>
    {
        public ElectricalWorkPresenter(IElectricalWorkView view)
            : base(view)
        {

        }

        public void Display(int postedDate)
        {
            var obj = Model.GetElectricalWork(postedDate);
            if (obj == null) return;
            View.ElectricalWorkId = obj.ElectricalWorkId;
            View.ElectricalWorName = obj.Name;
            View.PostedDate = obj.PostedDate;

        }


        public int Save()
        {
            var obj = new ElectricalWorkModel
                {
                    ElectricalWorkId=View.ElectricalWorkId,
                    Name=View.ElectricalWorName,
                    PostedDate=View.PostedDate
                };
            return View.ElectricalWorkId = Model.UpdateInsertElectricalWork(obj);
        }


    }
}
