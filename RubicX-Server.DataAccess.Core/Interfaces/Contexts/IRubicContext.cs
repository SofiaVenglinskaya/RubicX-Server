using RubicX_Server.DataAccess.Core.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RubicX_Server.DataAccess.Core.Interfaces.Contexts
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<UserRoleRto> UserRoles { get; set; }
        Task<int> SaveCahangesAsynk(CancellationToken cancellationToken = default);
    }

  
