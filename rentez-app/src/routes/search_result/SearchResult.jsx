import React, { useState, useEffect } from "react";
import { useLocation, useNavigate } from "react-router-dom"; // Import useNavigate for navigation
import "./SearchResult.scss";

const SearchResult = () => {
  const [results, setResults] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const location = useLocation();
  const navigate = useNavigate(); // Hook for navigation

  useEffect(() => {
    const fetchData = async () => {
      const queryParams = new URLSearchParams(location.search);
      const city = queryParams.get("city");
      const minPrice = queryParams.get("minPrice");
      const maxPrice = queryParams.get("maxPrice");

      try {
        const response = await fetch("https://localhost:7183/api/Property");
        const data = await response.json();

        const filteredData = data.filter((property) => {
          let matches = true;
          if (
            city &&
            !property.city.toLowerCase().includes(city.toLowerCase())
          ) {
            matches = false;
          }
          if (minPrice && property.price < parseFloat(minPrice)) {
            matches = false;
          }
          if (maxPrice && property.price > parseFloat(maxPrice)) {
            matches = false;
          }
          return matches;
        });

        setResults(filteredData);
      } catch (error) {
        console.error("Error fetching properties:", error);
        setError("Error fetching properties. Please try again later.");
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [location.search]);

  const handleResultClick = (id) => {
    navigate(`/place/${id}`); // Redirect to SinglePage with the clicked item's id
  };

  if (loading) {
    return <div className="loading-message">Loading properties...</div>;
  }

  if (error) {
    return <div className="error-message">{error}</div>;
  }

  return (
    <div className="search-results">
      {results.length > 0 ? (
        results.map((item) => (
          <div
            className="result-card"
            key={item.propertyID}
            onClick={() => handleResultClick(item.propertyID)} // Handle click event
          >
            <img
              src={item.imageUrl || "https://via.placeholder.com/150"}
              alt={item.title || "Property"}
              className="result-image"
            />
            <div className="result-details">
              <h3 className="result-title">
                {item.name || "No title available"}
              </h3>
              <p className="result-address">
                {item.city || "No city available"},{" "}
                {item.street || "No street available"}
              </p>
              <p className="result-price">{`₱${item.price}`}</p>
              <div className="result-features">
                {item.features && item.features.length > 0 ? (
                  item.features.map((feature, index) => (
                    <span className="feature-badge" key={index}>
                      {feature}
                    </span>
                  ))
                ) : (
                  <span>No features listed</span>
                )}
              </div>
            </div>
          </div>
        ))
      ) : (
        <div className="no-results-message">No results found.</div>
      )}
    </div>
  );
};

export default SearchResult;
