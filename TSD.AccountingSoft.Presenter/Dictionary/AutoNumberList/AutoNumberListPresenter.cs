

using TSD.AccountingSoft.View.Dictionary;

namespace TSD.AccountingSoft.Presenter.Dictionary.AutoNumberList
{
    public class AutoNumberListPresenter :Presenter<IAutoNumberListView>
    {
        public AutoNumberListPresenter(IAutoNumberListView view)
            : base(view)
        {
        }

        public void DisplayByTableCode(string tableCode)
        {

            var autoId = Model.GetAutoNumberList(tableCode);
            if (autoId == null) return;
            View.TableCode = autoId.TableCode;
            View.TableName = autoId.TableName;
            View.Value = autoId.Value;
            View.LengthOfValue = autoId.LengthOfValue;
            View.Suffix = autoId.Suffix;
            View.Prefix = autoId.Prefix;
            
        }

    }
}
