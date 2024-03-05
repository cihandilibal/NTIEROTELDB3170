using Project.ENTITIES.Models;

namespace Project.CONF.Options
{
	public class RoomReservationConfiguration : BaseConfiguration<RoomReservation>
	{
		public RoomReservationConfiguration()
		{
			Ignore(x => x.ID);
			HasKey(x => new
			{
				x.RoomID,
				x.ReservationID
			});

		}
	}
}
