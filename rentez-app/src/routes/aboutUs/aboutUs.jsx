import React from "react";
import "./aboutUs.scss";

function AboutUsPage() {
  return (
    <div className="about-us-container">
      <header className="about-us-header">
        <h1>About Us</h1>
        <p>Your trusted partner in delivering innovative solutions.</p>
      </header>

      <section className="about-us-mission">
        <div className="content-wrapper">
          <h2>Our Mission</h2>
          <p>
            At RentEZ, our mission is to empower businesses and individuals with
            cutting-edge technology and unparalleled service.
          </p>
        </div>
      </section>

      <section className="about-us-values">
        <div className="content-wrapper">
          <h2>Our Values</h2>
          <ul>
            <li>
              <strong>Innovation:</strong> We constantly strive to push
              boundaries and bring new ideas to life.
            </li>
            <li>
              <strong>Integrity:</strong> Honesty and transparency are at the
              core of everything we do.
            </li>
            <li>
              <strong>Collaboration:</strong> Teamwork drives our success.
            </li>
          </ul>
        </div>
      </section>

      <section className="about-us-team">
        <div className="content-wrapper">
          <h2>Meet the Team</h2>
          <div className="team-members">
            <div className="team-member">
              <img src="/uriel.jpg" alt="Team Member 1" />
              <h3>Uriel Parantar</h3>
              <p>Project Manager</p>
            </div>
            <div className="team-member">
              <img src="/kent.jpg" alt="Team Member 2" />
              <h3>Kent Espia</h3>
              <p>Developer</p>
            </div>
            <div className="team-member">
              <img src="/paul.jpg" alt="Team Member 3" />
              <h3>Paul Flores</h3>
              <p>Developer</p>
            </div>
            <div className="team-member">
              <img src="/lance.png" alt="Team Member 3" />
              <h3>Lance Antor</h3>
              <p>Developer</p>
            </div>
          </div>
        </div>
      </section>

      <footer className="about-us-footer">
        <div className="content-wrapper">
          <p>&copy; {new Date().getFullYear()} RentEZ. All rights reserved.</p>
        </div>
      </footer>
    </div>
  );
}

export default AboutUsPage;
