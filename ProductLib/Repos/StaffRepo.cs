using Microsoft.EntityFrameworkCore;
using ProductLib.Extensions;
using System;

namespace ProductLib;
public class StaffRepo
    : Repo<Staff>
    , IStaffRepo
{
    public StaffRepo(IDbContext context) : base(context) { }
}
