

using TSD.AccountingSoft.BusinessEntities.BusinessRules;


namespace TSD.AccountingSoft.BusinessEntities.Dictionary
{
    public class ElectricalWorkEntity : BusinessEntities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockEntity"/> class.
        /// </summary>
        public ElectricalWorkEntity()
        {
            AddRule(new ValidateId("ElectricalWorkId"));
        }


        public ElectricalWorkEntity(int electricalWorkId, string name, int postedDate)
        {
            ElectricalWorkId = electricalWorkId;
            Name = name;
            PostedDate = postedDate;
        }

        public int ElectricalWorkId { get; set; }
        public string Name { get; set; }
        public int PostedDate { get; set; }



    }
}
