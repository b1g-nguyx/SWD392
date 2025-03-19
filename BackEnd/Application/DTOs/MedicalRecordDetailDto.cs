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
        [Required(ErrorMessage = "Mã chi tiết hồ sơ không được để trống.")]
        public string RecordDetailCode { get; set; }
        [Required(ErrorMessage = "Mã bác sĩ không được để trống.")]
        public string DoctorCode { get; set; }

        [MaxLength(1000, ErrorMessage = "Báo cáo bác sĩ không được vượt quá 1000 ký tự.")]
        public string DoctorReport { get; set; }

        [MaxLength(1000, ErrorMessage = "Kết quả chăm sóc sức khỏe không được vượt quá 1000 ký tự.")]
        public string HealthcareResult { get; set; }

        [MaxLength(1000, ErrorMessage = "Kế hoạch điều trị không được vượt quá 1000 ký tự.")]
        public string TreatmentPlan { get; set; }
    }
}
