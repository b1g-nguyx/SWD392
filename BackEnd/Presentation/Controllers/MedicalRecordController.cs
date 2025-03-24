using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordController : ControllerBase
    {
        private readonly IMedicalRecordService _service;
        public MedicalRecordController(IMedicalRecordService service)
        {
            _service = service;
        }

        [HttpGet("{recordCode}")]
        public async Task<IActionResult> GetMedicalRecordDetails(string recordCode)
        {
            
            var record = await _service.GetMedicalRecordByCodeAsync(recordCode);
            if (record == null)
                return NotFound("Medical record not found");

            return Ok(record);
        }

        [HttpPut("{recordCode}")]
        public async Task<IActionResult> UpdateMedicalRecord(string recordCode, [FromBody] MedicalRecordDto recordDto)
        {

            if (recordCode != recordDto.RecordCode)
                return BadRequest("Record code mismatch");

            await _service.UpdateMedicalRecordAsync(recordDto);
            return Ok("Medical record updated successfully");
        }
    }
}
