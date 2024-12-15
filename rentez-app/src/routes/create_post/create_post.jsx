import React, { useState } from "react";
import "./create_post.scss"; // You'll need to create this CSS file
import { Link, useNavigate } from "react-router-dom";

export const CreatePost = () => {
  const [formData, setFormData] = useState({
    userID: "1",
    propertyName: "",
    city: "",
    street: "",
    province: "",
    description: "",
    price: "100",
    bedroom: "",
    person: "",
    bathroom: "",
    type: "",
    proximity: "",
    imageurl1: "",
    imageurl2: "",
    imageurl3: "",
    imageurl4: "",
  });
  const [errorMessage, setErrorMessage] = useState("");
  const [successMessage, setSuccessMessage] = useState("");

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setErrorMessage("");
    setSuccessMessage("");

    try {
      const response = await fetch("https://localhost:7183/api/Property", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(formData), // Use formData directly
      });

      if (response.ok) {
        const result = await response.json();
        setSuccessMessage(result.message || "Property created successfully!");
        // Optionally reset the form after successful submission
        setFormData({
            userID: "1",
            propertyName: "",
            city: "",
            street: "",
            province: "",
            description: "",
            price: "100",
            bedroom: "",
            person: "",
            bathroom: "",
            type: "",
            proximity: "",
            imageurl1: "",
            imageurl2: "",
            imageurl3: "",
            imageurl4: "",
          });
      } else {
        const result = await response.json();
        setErrorMessage(result.message || "Creation Failed");
      }
    } catch (error) {
      console.error("Error during property creation:", error); // Log the error for debugging
      setErrorMessage("An error occurred.");
    }
  };

  return (
    <div className="create-post-container"> {/* Add a container for styling */}
      <h2>Create a Property Listing</h2>
      {errorMessage && <div className="error-message">{errorMessage}</div>}
      {successMessage && <div className="success-message">{successMessage}</div>}
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          name="propertyName"
          placeholder="Property Name"
          value={formData.propertyName}
          onChange={handleChange}
          required
        />
        <input
          type="text"
          name="street"
          placeholder="Street Address"
          value={formData.street}
          onChange={handleChange}
          required
        />
        <input
          type="text"
          name="city"
          placeholder="City"
          value={formData.city}
          onChange={handleChange}
          required
        />
        <input
          type="text"
          name="province"
          placeholder="Province"
          value={formData.province}
          onChange={handleChange}
          required
        />
        <textarea
          name="description"
          placeholder="Description"
          value={formData.description}
          onChange={handleChange}
          required
        />
        <input
          type="number"
          name="price"
          placeholder="Price"
          value={formData.price}
          onChange={handleChange}
          required
        />
        <input
          type="text"
          name="bedroom"
          placeholder="no of bedroom"
          value={formData.bedroom}
          onChange={handleChange}
          required
        />
        <input
          type="text"
          name="person"
          placeholder="no of person"
          value={formData.person}
          onChange={handleChange}
          required
        />
        <input
          type="text"
          name="bathroom"
          placeholder="no of bathroom"
          value={formData.bathroom}
          onChange={handleChange}
          required
        />
        <input
          type="text"
          name="type"
          placeholder="type"
          value={formData.type}
          onChange={handleChange}
          required
        />
        <input
          type="text"
          name="proximity"
          placeholder="proximity"
          value={formData.proximity}
          onChange={handleChange}
          required
        />

        <input
          type="file"
          name="imageurl1"
          placeholder="imageurl1"
          accept="image/*"
          value={formData.imageurl1}
          onChange={handleChange}
          required
        />

        <input
          type="file"
          name="imageurl2"
          placeholder="imageurl2"
          accept="image/*"
          value={formData.imageurl2}
          onChange={handleChange}
          required
        />

        <input
          type="file"
          name="imageurl3"
          placeholder="imageurl3"
          accept="image/*"
          value={formData.imageurl3}
          onChange={handleChange}
          required
        />
        
        <input
          type="file"
          name="imageurl4"
          placeholder="imageurl4"
          accept="image/*"
          value={formData.imageurl4}
          onChange={handleChange}
          required
        />

        <button type="submit">Create Post</button>
      </form>
    </div>
  );
};

export default CreatePost;