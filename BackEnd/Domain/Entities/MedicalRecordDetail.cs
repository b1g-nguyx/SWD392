using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MedicalRecordDetail
    {
        [Key]
        public string RecordDetailCode { get; set; } // Mã chi tiết hồ sơ

        public string RecordCode { get; set; } // Mã hồ sơ

        [Required]
        public string DoctorCode { get; set; } // Mã bác sĩ

        // Báo cáo y tế
        [Column(TypeName = "nvarchar(max)")]
        public string DoctorReport { get; set; } // Báo cáo bác sĩ

        [Column(TypeName = "nvarchar(max)")]
        public string HealthcareResult { get; set; } // Kết quả chăm sóc sức khỏe

        [Column(TypeName = "nvarchar(max)")]
        public string TreatmentPlan { get; set; } // Kế hoạch điều trị
    }
}
