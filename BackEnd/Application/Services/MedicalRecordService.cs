using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IMedicalRecordRepository _repository;

        public MedicalRecordService(IMedicalRecordRepository repository)
        {
            _repository = repository;
        }

        public async Task<MedicalRecordDto> GetMedicalRecordByCodeAsync(string recordCode)
        {
            var record = await _repository.GetMedicalRecordByCodeAsync(recordCode);
            if (record == null) return null;

            return new MedicalRecordDto();
         //       new MedicalRecordDto
         //   {
         //       RecordCode = record.RecordCode,
         //       PatientCode = record.PatientCode,
         //       CreatedAt = record.CreatedAt?
         //       ,
         //       FullName = record.FullName,
         //       Dob = record.Dob,
         //       Gender = record.Gender,
         //       Address = record.Address,
         //       ContactNumber = record.ContactNumber,
         //       CCCD = record.CCCD,
         //       BHYT = record.BHYT,
         //       MedicalRecordDetails = record.MedicalRecordDetails?
         //.Select(d => new MedicalRecordDetailDto
         //{
         //    RecordDetailCode = d.RecordDetailCode,
         //    DoctorCode = d.DoctorCode,
         //    DoctorReport = d.DoctorReport,
         //    HealthcareResult = d.HealthcareResult,
         //    TreatmentPlan = d.TreatmentPlan
         //})
         //.ToList() 
         //   };

        }

        public async Task UpdateMedicalRecordAsync(MedicalRecordDto recordDto)
        {
            var record = new MedicalRecord();
            //{
            //    RecordCode = recordDto.RecordCode,
            //    PatientCode = recordDto.PatientCode,
            //    CreatedAt = recordDto.CreatedAt,
            //    FullName = recordDto.FullName,
            //    Dob = recordDto.Dob,
            //    Gender = recordDto.Gender,
            //    Address = recordDto.Address,
            //    ContactNumber = recordDto.ContactNumber,
            //    CCCD = recordDto.CCCD,
            //    BHYT = recordDto.BHYT
            //};

            await _repository.UpdateMedicalRecordAsync(record);
        }
    }
}
