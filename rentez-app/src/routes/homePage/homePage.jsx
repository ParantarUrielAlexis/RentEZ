import React from "react";
import "./homePage.scss"; // Import your SCSS/CSS file
import "../../layout.scss"; // Import your SCSS/CSS file
function HomePage() {
  return (
    <div className="homepage">
      {/* Hero Section */}
      <section className="hero">
        <h1 className="hero-title">Find Real Estate & Get Your Dream Place</h1>
        <p className="hero-description">
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Eos explicabo
          suscipit cum eius, iure est nulla animi consequatur facilis id
          pariatur fugit quos laudantium temporibus dolor ea repellat provident
          impedit!
        </p>
        <div className="search-bar">
          <div className="search-toggle">
            {/* <button className="search-btn active">Buy</button>
            <button className="search-btn">Rent</button> */}
          </div>
          <div className="search-fields">
            <input type="text" placeholder="City Location" />
            <input type="text" placeholder="Min Price" />
            <input type="text" placeholder="Max Price" />
            <button className="search-icon">
              <i className="fas fa-search"></i> {/* Use with Font Awesome */}
            </button>
          </div>
        </div>
      </section>

      {/* Statistics Section */}
      <section className="statistics">
        <div className="stat">
          <h2 className="stat-number">16+</h2>
          <p className="stat-text">Years of Experience</p>
        </div>
        <div className="stat">
          <h2 className="stat-number">200</h2>
          <p className="stat-text">Award Gained</p>
        </div>
        <div className="stat">
          <h2 className="stat-number">1200+</h2>
          <p className="stat-text">Property Ready</p>
        </div>
      </section>
    </div>
  );
}

export default HomePage;
