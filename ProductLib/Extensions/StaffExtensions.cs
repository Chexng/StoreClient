namespace ProductLib.Extensions
{
    public static class StaffExtensions
    {
        public static StaffResponse ToResponse(this Staff staff)
        {
            return new StaffResponse()
            {
                Id = staff.Id,
                StaffCode = staff.StaffId,
                SName = staff.SName,
                EffectedFrom = staff.EffectedFrom,
                Position = Enum.GetName<Position>(staff.Position)
            };
        }
        public static Staff ToEntity(this StaffCreateReq req)
        {
            var position = Position.None;
            Category.TryParse(req.Position, out position);
            return new Staff()
            {
                Id = Guid.NewGuid().ToString(),
                StaffId = req.StaffKey,
                SName = req.SName,
                Position = position,
                CreatedOn = DateTime.Now,
                LastUpdatedOn = null
            };
        }
        public static void Copy(this Staff staff, StaffUpdateReq req)
        {
            var position = Position.None;
            Position.TryParse(req.Position, out position);
            staff.SName = req.SName;
            staff.Position = position;
        }
    }
}
