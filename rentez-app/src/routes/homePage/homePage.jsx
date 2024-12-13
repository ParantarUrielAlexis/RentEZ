import React from "react";
import "./homePage.scss"; // Import the SCSS
import "@fortawesome/fontawesome-free/css/all.min.css"; // Font Awesome icons

function HomePage() {
  return (
    <div className="homepage">
      {/* Hero Section */}
      <section className="hero">
        <h1 className="hero-title">Find Real Estate & Get Your Dream Place</h1>
        <p className="hero-description">
          Searching for your perfect home or investment property can be an
          exciting journey. Whether you are looking for a cozy apartment, a
          family-friendly house, or a prime commercial space, we are here to
          help you every step of the way. Our team is dedicated to matching you
          with the best properties that fit your needs and budget. Let us turn
          your dream place into a reality!
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
          <p className="stat-text">Properties Ready</p>
        </div>
      </section>
      <br />
      <br />
      <br />
      <br />
      <br />
      <br />

      {/* Testimonials Section */}
      <section className="testimonials">
        <h2>What Our Clients Say</h2>
        <div className="testimonial-list">
          <div className="testimonial">
            <p>
              "The team helped me find my dream home! I couldn't be happier."
            </p>
            <h4>- Paula Floresa</h4>
          </div>
          <div className="testimonial">
            <p>"Professional, efficient, and reliable. Highly recommended!"</p>
            <h4>- Uriella Abuelita</h4>
          </div>
          <div className="testimonial">
            <p>"Professional, efficient, and reliable. Highly recommended!"</p>
            <h4>- Kenny Piase</h4>
          </div>
          <div className="testimonial">
            <p>"Professional, efficient, and reliable. Highly recommended!"</p>
            <h4>- Vance Notra</h4>
          </div>
        </div>
      </section>
      <br />
      <br />
      <br />
      <br />

      {/* Why Choose Us Section */}
      <section className="why-choose-us">
        <h2>Why Choose Us?</h2>
        <div className="reasons">
          <div className="reason">
            <i className="fas fa-cogs"></i>
            <h3>Expert Advice</h3>
            <p>
              Our team provides expert guidance in every step of your journey.
            </p>
          </div>
          <div className="reason">
            <i className="fas fa-thumbs-up"></i>
            <h3>Trusted by Clients</h3>
            <p>
              We have a proven track record of satisfied clients and successful
              deals.
            </p>
          </div>
          <div className="reason">
            <i className="fas fa-users"></i>
            <h3>Personalized Service</h3>
            <p>We understand your needs and offer tailor-made solutions.</p>
          </div>
          <div className="reason">
            <i className="fas fa-search"></i>
            <h3>Easy Search</h3>
            <p>Looking for places just became easy.</p>
          </div>
        </div>
      </section>
    </div>
  );
}

export default HomePage;
