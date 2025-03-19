import axios from 'axios';

const API_URL = 'http://localhost:5282'; // Update with your API URL

export const getMedicalRecord = async (recordCode) => {
  try {
    const response = await axios.get(`${API_URL}/medical-record/${recordCode}`);
    return response.data;
  } catch (error) {
    console.error("Error fetching medical record:", error);
    throw error;
  }
};

export const updateMedicalRecord = async (recordDto) => {
  try {
    const response = await axios.put(`${API_URL}/medical-record`, recordDto);
    return response.data;
  } catch (error) {
    console.error("Error updating medical record:", error);
    throw error;
  }
};
