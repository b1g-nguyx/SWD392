using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IMedicalRecordRepository
    {
        Task<MedicalRecord> GetMedicalRecordByCodeAsync(string recordCode);
        Task UpdateMedicalRecordAsync(MedicalRecord record);
    }
}
