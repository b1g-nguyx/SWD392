using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class MedicalRecordDetailDto
    {
        public string RecordDetailCode { get; set; } = string.Empty;
        public string RecordCode { get; set; }
        public string AppointmentCode { get; set; }
        public string DoctorCode { get; set; }
        public string? Result { get; set; }

        public MedicalRecord MedicalRecord { get; set; } = null!;
        public Appointment Appointment { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
    }
}
