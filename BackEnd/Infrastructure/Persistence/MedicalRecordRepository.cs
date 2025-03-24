using Domain.Entities;
using Domain.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
namespace Infrastructure.Persistence
{
    public class MedicalRecordRepository : IMedicalRecordRepository
    {

        private readonly ApplicationDbContext _context;

        public MedicalRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<MedicalRecord> GetMedicalRecordByCodeAsync(string recordCode)
        {
            return await _context.MedicalRecords

               .FirstOrDefaultAsync();
        }

        public async Task UpdateMedicalRecordAsync(MedicalRecord record)
        {
            _context.MedicalRecords.Update(record);
            await _context.SaveChangesAsync();
        }
    }
}
