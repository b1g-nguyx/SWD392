import React from 'react';

const MedicalRecordDisplay = ({ record }) => {
  return (
    <div className="medical-record">
      <h2>Medical Record: {record.fullName}</h2>
      <p><strong>Record Code:</strong> {record.recordCode}</p>
      <p><strong>Patient Code:</strong> {record.patientCode}</p>
      <p><strong>Created At:</strong> {new Date(record.createdAt).toLocaleString()}</p>
      <p><strong>Date of Birth:</strong> {new Date(record.dob).toLocaleDateString()}</p>
      <p><strong>Gender:</strong> {record.gender}</p>
      <p><strong>Address:</strong> {record.address}</p>
      <p><strong>Contact Number:</strong> {record.contactNumber}</p>
      <p><strong>CCCD:</strong> {record.cccd}</p>
      <p><strong>BHYT:</strong> {record.bhyt}</p>

      <h3>Medical Record Details:</h3>
      <ul>
        {record.medicalRecordDetails?.map(detail => (
          <li key={detail.recordDetailCode}>
            <p><strong>Record Detail Code:</strong> {detail.recordDetailCode}</p>
            <p><strong>Doctor Code:</strong> {detail.doctorCode}</p>
            <p><strong>Doctor Report:</strong> {detail.doctorReport}</p>
            <p><strong>Healthcare Result:</strong> {detail.healthcareResult}</p>
            <p><strong>Treatment Plan:</strong> {detail.treatmentPlan}</p>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default MedicalRecordDisplay;
