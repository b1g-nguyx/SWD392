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
        
        public string RecordCode { get; set; }

        [Required(ErrorMessage = "Mã bệnh nhân không được để trống.")]
        public string PatientCode { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống.")]
        [MaxLength(100, ErrorMessage = "Họ và tên không được vượt quá 100 ký tự.")]
        public string FullName { get; set; }

        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống.")]
        [MaxLength(10, ErrorMessage = "Giới tính không được vượt quá 10 ký tự.")]
        public string Gender { get; set; }

        [MaxLength(200, ErrorMessage = "Địa chỉ không được vượt quá 200 ký tự.")]
        public string Address { get; set; }

        [MaxLength(15, ErrorMessage = "Số điện thoại không được vượt quá 15 ký tự.")]
        public string ContactNumber { get; set; }

        [MaxLength(12, ErrorMessage = "CCCD không được vượt quá 12 ký tự.")]
        public string CCCD { get; set; }

        [MaxLength(15, ErrorMessage = "BHYT không được vượt quá 15 ký tự.")]
        public string BHYT { get; set; }

        public List<MedicalRecordDetailDto> MedicalRecordDetails { get; set; }
    }
}
