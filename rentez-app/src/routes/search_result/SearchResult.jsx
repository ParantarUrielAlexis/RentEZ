import React from "react";
import "./SearchResult.scss";

const SearchResult = () => {
  const results = [
    {
      id: 1,
      image: "https://via.placeholder.com/150", // Temporary image URL
      title: "Flores Boarding House",
      address: "3rd Street, Tisa",
      price: "₱ 3000",
      features: ["2 Bedroom", "2 Bathroom"],
    },
    {
      id: 2,
      image: "https://via.placeholder.com/150", // Temporary image URL
      title: "Uriel's Cozy Nest",
      address: "Neneng's Compound, Tisa",
      price: "₱ 3500",
      features: ["1 Room", "Own C.R."],
    },
    {
      id: 3,
      image: "https://via.placeholder.com/150", // Temporary image URL
      title: "Ila Lilybeth",
      address: "Pacaña Street, Tisa",
      price: "₱ 4000",
      features: ["1 Bedroom", "1 Bathroom", "Air condition"],
    },
  ];

  return (
    <div className="search-results">
      {results.map((item) => (
        <div className="result-card" key={item.id}>
          <img src={item.image} alt={item.title} className="result-image" />
          <div className="result-details">
            <h3 className="result-title">{item.title}</h3>
            <p className="result-address">{item.address}</p>
            <p className="result-price">{item.price}</p>
            <div className="result-features">
              {item.features.map((feature, index) => (
                <span className="feature-badge" key={index}>
                  {feature}
                </span>
              ))}
            </div>
          </div>
        </div>
      ))}
    </div>
  );
};

export default SearchResult;
