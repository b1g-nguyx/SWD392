using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class MedicalRecordDto
    {

        public string RecordCode { get; set; } = string.Empty;
        public string PatientCode { get; set; }
        public DateTime CreatedAt { get; set; }

        public Patient Patient { get; set; } = null!;
    }
}
