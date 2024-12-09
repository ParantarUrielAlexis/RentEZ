import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import './Navbar.scss';

function Navbar() {
    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const [username, setUsername] = useState("");

    useEffect(() => {
        // Check if user is logged in by reading from localStorage
        const loginStatus = localStorage.getItem("isLoggedIn");
        const storedUsername = localStorage.getItem("username");

        if (loginStatus === "true") {
            setIsLoggedIn(true);
            setUsername(storedUsername);
        }
    }, []);

    const handleLogout = () => {
        // Remove from localStorage on logout
        localStorage.removeItem("isLoggedIn");
        localStorage.removeItem("username");
        setIsLoggedIn(false);
        setUsername("");
    };

    return (
        <nav>
            <div className="left">
                <Link to="/">Home</Link>
                <Link to="/about">About</Link>
                <Link to="/contact">Contact</Link>
                <Link to="/agents">Agents</Link>
            </div>
            <div className="right">
                {isLoggedIn ? (
                    <div className="logged-in">
                        <span className="username">{username}</span>
                        <Link to="/profile" className="profile-btn">
                            Profile
                        </Link>
                        <button className="logout" onClick={handleLogout}>
                            Logout
                        </button>
                    </div>
                ) : (
                    <>
                        <Link to="/sign-in">Sign-In</Link>
                        <Link to="/sign-up" className="register">Sign-Up</Link>
                    </>
                )}
            </div>
        </nav>
    );
}

export default Navbar;
