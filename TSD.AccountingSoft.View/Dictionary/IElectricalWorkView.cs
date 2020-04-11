

namespace TSD.AccountingSoft.View.Dictionary
{
    /// <summary>
    /// Interface IStockView
    /// </summary>
    public interface IElectricalWorkView : IView
    {

        int ElectricalWorkId { get; set; }
        int  PostedDate { get; set; }
        string ElectricalWorName { get; set; }


    }
}
