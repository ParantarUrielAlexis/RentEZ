import React from 'react';
import './Login.scss'; // Import your SCSS/CSS file
import rentezLogo from '../../assets/rentez_logo.png'; // Import your logo
import { Link } from 'react-router-dom';

function Login() {
  return (
    <div className="login-container">
      {/* Left Side: Illustration */}
      <div className="illustration-section">
        <img src={rentezLogo} alt="RentEZ Logo" className="logo-image" />
        <span className="brand-name">RENT <br /> EZ</span>
      </div>

      {/* Right Side: Form */}
      <div className="form-section">
        <h1>Welcome !</h1>
        <form>
          <input type="text" placeholder="Enter Username" required />
          <input type="password" placeholder="Password" required />
          <button type="submit" className="login-btn">
            Login
          </button>
        </form>
        <p>
          Don't have an account? <Link to="/signup">Signup</Link>
        </p>
      </div>
    </div>
  );
}

export default Login;
