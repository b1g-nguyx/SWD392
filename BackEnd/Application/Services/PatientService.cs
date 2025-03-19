using Application.DTOs;
using Application.Interfaces;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Task AddBookAsync(PatientDto patient)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatientDto>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PatientDto?> GetBookByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookAsync(int id, PatientDto patient)
        {
            throw new NotImplementedException();
        }
    }
}
