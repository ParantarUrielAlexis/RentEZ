import React from "react";
import "./contactUs.scss";

function ContactUsPage() {
  return (
    <div className="contact-us-container">
      <header className="contact-us-header">
        <h1>Contact Us</h1>
        <p>We'd love to hear from you. Reach out to us anytime!</p>
      </header>

      <section className="contact-us-form">
        <div className="form-wrapper">
          <h2>Get in Touch</h2>
          <form>
            <div className="form-group">
              <label htmlFor="name">Name</label>
              <input type="text" id="name" placeholder="Your Name" required />
            </div>
            <div className="form-group">
              <label htmlFor="email">Email</label>
              <input
                type="email"
                id="email"
                placeholder="Your Email"
                required
              />
            </div>
            <div className="form-group">
              <label htmlFor="message">Message</label>
              <textarea
                id="message"
                rows="5"
                placeholder="Your Message"
                required
              ></textarea>
            </div>
            <button type="submit" className="submit-button">
              Send Message
            </button>
          </form>
        </div>
      </section>

      <section className="contact-us-info">
        <div className="info-wrapper">
          <h2>Contact Information</h2>
          <ul>
            <li>
              <strong>Email:</strong> rentez@gmail.com
            </li>
            <li>
              <strong>Phone:</strong> 0956-123-456
            </li>
            <li>
              <strong>Address:</strong> 1234 Argao St, Liloan 100, Pardo City,
              Samar 56789
            </li>
          </ul>
        </div>
      </section>

      <footer className="contact-us-footer">
        <p>
          &copy; {new Date().getFullYear()} [Your Company Name]. All rights
          reserved.
        </p>
      </footer>
    </div>
  );
}

export default ContactUsPage;
