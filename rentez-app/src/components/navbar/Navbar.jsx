import "./navbar.scss";
import { Link, useNavigate } from "react-router-dom";
import { useContext } from "react";
import { AuthContext } from "../../context/AuthContext";

function Navbar() {
    const navigate = useNavigate();
    const { isLoggedIn, username, setIsLoggedIn, setUsername } = useContext(AuthContext);

    // Handle logout functionality
    const handleLogout = () => {
        setIsLoggedIn(false);
        setUsername("");
        // Remove token and username from localStorage
        localStorage.removeItem("authToken");
        localStorage.removeItem("username");
        navigate("/"); // Redirect to home page after logout
    };

    return (
        <nav className="navbar">
            <div className="left">
                <Link to="/" className="logo">
                    <span>RentEZ</span>
                </Link>
                <Link to="/">Home</Link>
                <Link to="/about">About</Link>
                <Link to="/contact">Contact</Link>
                <Link to="/agents">Agents</Link>
            </div>
            <div className="right">
                {isLoggedIn ? (
                    <div className="profile-menu">
                        <Link to="/profile">Profile</Link>
                        <div className="dropdown">
                            <button onClick={handleLogout}>Logout</button>
                        </div>
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
