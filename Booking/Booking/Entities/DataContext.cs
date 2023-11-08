namespace Booking.Entities
{
    public class DataContext
    {
        public List<Order> OrdersList { get; set; }
        public List<Zimmer> ZimmersList { get; set; }
        public List<Renter> RentersList { get; set; }
        public int CntOrder { get; set; }
        public int CntZimmer { get; set; }
        public int CntRenter { get; set; }
        public DataContext()
        {
            OrdersList = new List<Order>();
            ZimmersList = new List<Zimmer>();
            RentersList = new List<Renter>();
            CntOrder = 1;
            CntZimmer = 1;
            CntRenter = 1;
        }
    }
}
