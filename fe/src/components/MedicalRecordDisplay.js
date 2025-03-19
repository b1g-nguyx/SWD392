import React from 'react';

const MedicalRecordDisplay = ({ record }) => {
  return (
    <div className="medical-record">
      <h2>Medical Record: {record.FullName}</h2>
      <p><strong>Patient Code:</strong> {record.PatientCode}</p>
      <p><strong>Date of Birth:</strong> {new Date(record.Dob).toLocaleDateString()}</p>
      <p><strong>Gender:</strong> {record.Gender}</p>
      <p><strong>Contact Number:</strong> {record.ContactNumber}</p>
      <p><strong>CCCD:</strong> {record.CCCD}</p>
      <p><strong>BHYT:</strong> {record.BHYT}</p>

      <h3>Medical Record Details:</h3>
      <ul>
        {record.MedicalRecordDetails?.map(detail => (
          <li key={detail.RecordDetailCode}>
            <h4>Doctor: {detail.DoctorCode}</h4>
            <p><strong>Doctor Report:</strong> {detail.DoctorReport}</p>
            <p><strong>Healthcare Result:</strong> {detail.HealthcareResult}</p>
            <p><strong>Treatment Plan:</strong> {detail.TreatmentPlan}</p>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default MedicalRecordDisplay;
