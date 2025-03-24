import React, { useState } from 'react';
import { updateMedicalRecord } from '../services/medicalRecordService';

const MedicalRecordForm = ({ record, onSuccess }) => {
  const [formData, setFormData] = useState(record);
  const [error, setError] = useState(null);
  const [isLoading, setIsLoading] = useState(false);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value,
    });
  };

  const handleDetailChange = (e, index, field) => {
    const updatedDetails = [...formData.medicalRecordDetails];
    updatedDetails[index][field] = e.target.value;
    setFormData({ ...formData, medicalRecordDetails: updatedDetails });
  };

  const handleSubmit = async (e) => {
    console.log("Code: " + formData.recordCode)
    e.preventDefault();
    setError(null);
    setIsLoading(true);
    try {
      const { recordCode, ...recordDto } = formData;
      await updateMedicalRecord(recordCode, formData);
      onSuccess(formData);
    } catch (error) {
      console.error("Error updating medical record:", error);
      setError("Failed to update medical record. Please try again.");
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      {error && <p style={{ color: 'red' }}>{error}</p>}
      <div>
        <label>Record Code:</label>
        <input type="text" name="recordCode" value={formData.recordCode || ''} readOnly />
      </div>
      <div>
        <label>Patient Code:</label>
        <input type="text" name="patientCode" value={formData.patientCode || ''} readOnly />
      </div>
      <div>
        <label>Created At:</label>
        <input type="text" name="createdAt" value={formData.createdAt || ''} readOnly />
      </div>
      <div>
        <label>Full Name:</label>
        <input type="text" name="fullName" value={formData.fullName || ''} onChange={handleChange} required />
      </div>
      <div>
        <label>Date of Birth:</label>
        <input
          type="date"
          name="dob"
          value={formData.dob ? new Date(formData.dob).toISOString().split('T')[0] : ''}
          onChange={handleChange}
          required
        />
      </div>
      <div>
        <label>Gender:</label>
        <input type="text" name="gender" value={formData.gender || ''} readOnly />
      </div>
      <div>
        <label>Address:</label>
        <input type="text" name="address" value={formData.address || ''} onChange={handleChange} required />
      </div>
      <div>
        <label>Contact Number:</label>
        <input type="text" name="contactNumber" value={formData.contactNumber || ''} onChange={handleChange} required />
      </div>
      <div>
        <label>CCCD:</label>
        <input type="text" name="cccd" value={formData.cccd || ''} onChange={handleChange} required />
      </div>
      <div>
        <label>BHYT:</label>
        <input type="text" name="bhyt" value={formData.bhyt || ''} onChange={handleChange} required />
      </div>

      <h3>Medical Record Details:</h3>
      {formData.medicalRecordDetails?.map((detail, index) => (
        <div key={index}>
          <div>
            <label>Record Detail Code:</label>
            <input type="text" value={detail.recordDetailCode || ''} readOnly />
          </div>
          <div>
            <label>Doctor Code:</label>
            <input type="text" value={detail.doctorCode || ''} readOnly />
          </div>
          <div>
            <label>Doctor Report:</label>
            <input type="text" value={detail.doctorReport || ''} onChange={(e) => handleDetailChange(e, index, 'doctorReport')} required />
          </div>
          <div>
            <label>Healthcare Result:</label>
            <input type="text" value={detail.healthcareResult || ''} onChange={(e) => handleDetailChange(e, index, 'healthcareResult')} required />
          </div>
          <div>
            <label>Treatment Plan:</label>
            <input type="text" value={detail.treatmentPlan || ''} onChange={(e) => handleDetailChange(e, index, 'treatmentPlan')} required />
          </div>
        </div>
      ))}

      <button type="submit" disabled={isLoading}>
        {isLoading ? 'Updating...' : 'Update Record'}
      </button>
    </form>
  );
};

export default MedicalRecordForm;
