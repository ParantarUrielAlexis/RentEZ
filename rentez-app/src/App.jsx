import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from './components/navbar/Navbar';
import Signup from './components/signup/Signup'; // Import the Signup component
import Login from './components/login/Login';
import './layout.scss';

function App() {
  return (
    <Router>
      <div className="layout">
        <Navbar />
        <Routes>
          <Route path="/" element={<h1>Home Page</h1>} />
          <Route path="/signup" element={<Signup />} /> {/* Define the route for Signup */}
          <Route path="/login" element={<Login />} />
          {/* You can add other routes here */}
        </Routes>
      </div>
    </Router>
  );
}

export default App;
