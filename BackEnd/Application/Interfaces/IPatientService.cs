using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientDto>> GetAllBooksAsync();
        Task<PatientDto?> GetBookByIdAsync(int id);
        Task AddBookAsync(PatientDto patient);
        Task UpdateBookAsync(int id, PatientDto patient);
    }
}
