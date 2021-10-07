using Mascotas.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.Domain
{
    public interface IVeterinaryDomain
    {
        Task<ResponseEntityDto> AddNewVeterinary(VeterinaryDto veterinary);
        Task<IEnumerable<VeterinaryDto>> GetAllVeterinary();
        Task<VeterinaryDto> GetVeterinaryById(int id);
        Task<ResponseEntityDto> UpdateVeterinary(VeterinaryDto veterinary);
        Task DeleteVeterinary(int id);
    }
}
