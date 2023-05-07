using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp.DAL.Interfaces
{
    public interface IMongoBaseEntity
    {
        Guid Id { get; }
    }
}