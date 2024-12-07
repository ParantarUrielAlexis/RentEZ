import React from 'react';
import './Signup.scss'; 
import rentezLogo from '../../assets/rentez_logo.png'; 
import { Link } from 'react-router-dom';

function Signup() {
  return (
    <div className="signup-container">
      {/* Left Side: Form */}
      <div className="form-section">
        <h1>Create Account</h1>
        <form>
          <input type="text" placeholder="Enter Username" required />
          <input type="email" placeholder="Email" required />
          <input type="password" placeholder="Password" required />
          <input type="password" placeholder="Confirm Password" required />
          <button type="submit" className="register-btn">
            Register
          </button>
        </form>
        <p>
          Already Have an account? <Link to="/login">Login</Link>
        </p>
      </div>

      {/* Right Side: Illustration */}
      
      <div className="illustration-section">
        <img src={rentezLogo} alt="RentEZ Logo" className="logo-image" />
        <span className="brand-name">RENT <br></br> EZ</span>
        
      </div>
    </div>
  );
}

export default Signup;
