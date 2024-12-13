import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import "./update_profile.scss";

export const UpdateProfile = () => {
  const [username, setUsername] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [errorMessage, setErrorMessage] = useState("");
  const [successMessage, setSuccessMessage] = useState("");
  const [profileImage, setProfileImage] = useState(null); // For profile image
  const navigate = useNavigate();

  useEffect(() => {
    // Fetch user data when the component mounts
    const fetchUserData = async () => {
      try {
        const response = await fetch("https://localhost:7183/api/User/profile", {
          method: "GET",
          headers: {
            "Content-Type": "application/json",
            // Assuming you have a token for authentication
            Authorization: `Bearer ${localStorage.getItem("authToken")}`, // Example token
          },
        });

        if (response.ok) {
          const result = await response.json();
          // Set the fetched user data to state
          setUsername(result.username);
          setEmail(result.email);
          // Optionally set the profile image URL if available
          setProfileImage(result.profileImageUrl);
        } else {
          setErrorMessage("Failed to fetch user data.");
        }
      } catch (error) {
        setErrorMessage("An error occurred while fetching user data.");
      }
    };

    fetchUserData();
  }, []);

  // Handle image upload (same as before)
  const handleImageUpload = (file) => {
    if (file) {
      setProfileImage(URL.createObjectURL(file)); // Temporarily show the image
    }
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setErrorMessage("");
    setSuccessMessage("");

    if (password !== confirmPassword) {
      setErrorMessage("Passwords do not match.");
      return;
    }

    const userData = { username, email, password };

    try {
      const response = await fetch("https://localhost:7183/api/User/update", {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(userData),
      });

      if (response.ok) {
        const result = await response.json();
        setSuccessMessage(result.message);
        setTimeout(() => {
          navigate("/profile"); // Redirect after successful update
        }, 2000);
      } else {
        const result = await response.json();
        setErrorMessage(result.message || "Update failed. Please try again.");
      }
    } catch (error) {
      setErrorMessage("An error occurred. Please try again later.");
    }
  };

  return (
    <form onSubmit={handleSubmit} className="update-profile">

      <div className="left-div">
        <div className="profile-picture text-wrapper-12">Profile Picture</div>
        <div className="image-container">
          {profileImage ? (
            <img src={profileImage} alt="Profile Preview" className="profile-preview" />
          ) : (
            <p>No image selected</p>
          )}
        </div>

        <input
          type="file"
          id="file-input"
          accept="image/*"
          onChange={(e) => handleImageUpload(e.target.files[0])}
          style={{ display: "none" }} // Hide the file input
        />
        <button
          type="button"
          className="upload-image-btn"
          onClick={() => document.getElementById("file-input").click()}
        >
          Upload Photo
        </button>
      </div>
      
      <div className="right-div">
        <div className="user-info text-wrapper-12">User Information</div>
        <div>
          <input
            className="div-wrapper text-wrapper-11"
            type="text"
            placeholder="Enter new Username"
            value={username} // Default value is set from state
            onChange={(e) => setUsername(e.target.value)}
            required
          />
        </div>
        <div>
          <input
            className="div-wrapper text-wrapper-11"
            type="email"
            placeholder="Enter new Email"
            value={email} // Default value is set from state
            onChange={(e) => setEmail(e.target.value)}
            required
          />
        </div>
        <div>
          <input
            className="div-wrapper text-wrapper-11"
            type="password"
            placeholder="Enter new Password"
            value={password} // Default value is set from state
            onChange={(e) => setPassword(e.target.value)}
          />
        </div>
        <div>
          <input
            className="div-wrapper text-wrapper-11"
            type="password"
            placeholder="Confirm new Password"
            value={confirmPassword} // Default value is set from state
            onChange={(e) => setConfirmPassword(e.target.value)}
          />
        </div>

        {errorMessage && <p className="error-message">{errorMessage}</p>}
        {successMessage && <p className="success-message">{successMessage}</p>}

        <button className="submit-btn">Update</button>
      </div>


    </form>
  );
};
