import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import "./singlePage.scss";
import Slider from "../../components/slider/Slider";

const SinglePage = () => {
  const { id } = useParams();
  const [place, setPlace] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchPlace = async () => {
      try {
        const response = await fetch(
          `https://localhost:7183/api/Property/${id}`
        );
        const data = await response.json();
        setPlace(data);
      } catch (error) {
        console.error("Error fetching property details:", error);
        setError("Could not fetch property details.");
      } finally {
        setLoading(false);
      }
    };

    fetchPlace();
  }, [id]);

  if (loading) {
    return <div className="loading-message">Loading property details...</div>;
  }

  if (error) {
    return <div className="error-message">{error}</div>;
  }

  if (!place) {
    return <div className="error-message">No property found.</div>;
  }

  return (
    <div className="singlePage">
      <div className="details">
        <div className="wrapper">
          <Slider images={place.images || []} />
          <div className="info">
            <div className="top">
              <div className="post">
                <h1>{place.name}</h1>
                <div className="address">
                  <img src="/pin.png" alt="" />
                  <span>
                    {place.city}, {place.street}
                  </span>
                </div>
                <div className="address">
                  <img src="/bed.png" alt="" />
                  <span>{place.bedrooms} bedrooms</span>
                </div>
                <div className="address">
                  <img src="/bath.png" alt="" />
                  <span>{place.bathrooms} bathrooms</span>
                </div>
                <div className="price">${place.price}</div>
              </div>
              <div className="user">
                <img src={place.ownerImage || "/default-user.png"} alt="" />
                <span>{place.ownerName || "Unknown owner"}</span>
              </div>
            </div>
            <div className="bottom">{place.description}</div>
          </div>
        </div>
      </div>
      <div className="features">
        <div className="wrapper"></div>
      </div>
    </div>
  );
};

export default SinglePage;
