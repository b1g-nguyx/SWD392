import React, { useState, useEffect } from 'react';
import './styles.css'; // Import CSS styles
import MedicalRecordDisplay from './components/MedicalRecordDisplay';
import MedicalRecordForm from './components/MedicalRecordForm';
import { getMedicalRecord } from './services/medicalRecordService';

const App = () => {
  const [recordCode] = useState('12345'); // Example record code
  const [record, setRecord] = useState(null);
  const [isEditing, setIsEditing] = useState(false);

  useEffect(() => {
    // Fetch medical record on component mount
    const fetchMedicalRecord = async () => {
      try {
        const data = await getMedicalRecord(recordCode);
        setRecord(data);
      } catch (error) {
        console.error("Error fetching medical record:", error);
      }
    };

    fetchMedicalRecord();
  }, [recordCode]);

  const handleUpdateSuccess = (updatedRecord) => {
    // After updating the record, display the new record
    setRecord(updatedRecord);
    setIsEditing(false); // Return to displaying mode
  };

  const handleEditClick = () => {
    // Switch to edit mode
    setIsEditing(true);
  };

  if (!record) {
    return <div>Loading...</div>;
  }

  return (
    <div className="container">
      <h1>Medical Record Management</h1>
      {isEditing ? (
        <MedicalRecordForm record={record} onSuccess={handleUpdateSuccess} />
      ) : (
        <>
          <MedicalRecordDisplay record={record} />
          <button onClick={handleEditClick} className="edit-btn">
            Edit Record
          </button>
        </>
      )}
    </div>
  );
};

export default App;
