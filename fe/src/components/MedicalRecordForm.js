import React, { useState } from 'react';
import { updateMedicalRecord } from '../services/medicalRecordService';

const MedicalRecordForm = ({ record, onSuccess }) => {
  const [formData, setFormData] = useState(record);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value,
    });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await updateMedicalRecord(formData); // Call API to update record
      onSuccess(formData); // Callback to update the parent component with new data
    } catch (error) {
      console.error("Error updating medical record:", error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <div>
        <label>Full Name:</label>
        <input
          type="text"
          name="FullName"
          value={formData.FullName}
          onChange={handleChange}
        />
      </div>
      <div>
        <label>Date of Birth:</label>
        <input
          type="date"
          name="Dob"
          value={formData.Dob}
          onChange={handleChange}
        />
      </div>
      <div>
        <label>Contact Number:</label>
        <input
          type="text"
          name="ContactNumber"
          value={formData.ContactNumber}
          onChange={handleChange}
        />
      </div>
      <div>
        <label>Address:</label>
        <input
          type="text"
          name="Address"
          value={formData.Address}
          onChange={handleChange}
        />
      </div>
      <button type="submit">Update Record</button>
    </form>
  );
};

export default MedicalRecordForm;
