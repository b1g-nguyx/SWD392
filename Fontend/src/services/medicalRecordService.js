import axios from 'axios';

const API_URL = 'http://localhost:5000/api';  // Update with your API URL

export const getMedicalRecord = async (recordCode) => {
  try {
    const response = await axios.get(`${API_URL}/MedicalRecord/${recordCode}`);
    return response.data;
  } catch (error) {
    console.error("Error fetching medical record:", error);
    throw error;
  }
};

export const updateMedicalRecord = async (recordCode, recordDto) => {
  try {
    const response = await axios.put(`${API_URL}/MedicalRecord/${recordCode}`, recordDto);
    return response.data;
  } catch (error) {
    console.error("Error updating medical record:", error);
    throw error;
  }
};
