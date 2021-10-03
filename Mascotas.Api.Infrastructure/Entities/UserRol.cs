using System;
using System.Collections.Generic;
using System.Text;

namespace Mascotas.Api.Infrastructure.Entities
{
    public class UserRol
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RolId { get; set; }
    }
}
