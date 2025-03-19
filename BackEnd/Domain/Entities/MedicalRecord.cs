using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MedicalRecord
    {
        [Key]
       
        public string RecordCode { get; set; } // Mã hồ sơ bệnh án

        [Required]
        public string PatientCode { get; set; } // Mã bệnh nhân

        public DateTime CreatedAt { get; set; } // Ngày tạo hồ sơ

        // Thông tin bệnh nhân
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string FullName { get; set; } // Họ và tên bệnh nhân

        [Required]
        public DateTime Dob { get; set; } // Ngày sinh

        [Column(TypeName = "nvarchar(10)")]
        [Required]
        public string Gender { get; set; } // Giới tính

        [Column(TypeName = "nvarchar(255)")]
        public string Address { get; set; } // Địa chỉ

        [Column(TypeName = "nvarchar(15)")]
        public string ContactNumber { get; set; } // Số điện thoại liên hệ

        // Thông tin hành chính
        [Column(TypeName = "nvarchar(20)")]
        public string CCCD { get; set; } // Mã căn cước công dân

        [Column(TypeName = "nvarchar(20)")]
        public string BHYT { get; set; } // Mã bảo hiểm y tế

        // Danh sách chi tiết hồ sơ bệnh án (1 - N)
        public ICollection<MedicalRecordDetail> MedicalRecordDetails { get; set; }
    }
}
