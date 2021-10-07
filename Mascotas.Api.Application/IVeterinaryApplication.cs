using Mascotas.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas.Api.Application
{
    public interface IVeterinaryApplication
    {
        Task<ResponseEntityDto> AddNewVeterinary(VeterinaryDto veterinary);
        Task<IEnumerable<VeterinaryDto>> GetAllVeterinary();
        Task<VeterinaryDto> GetVeterinaryById(int id);
        Task<ResponseEntityDto> UpdateVeterinary(VeterinaryDto veterinary);
        Task DeleteVeterinary(int id);
    }
}
