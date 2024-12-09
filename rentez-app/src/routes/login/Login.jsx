import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import './Login.scss'; // Import your SCSS/CSS file
import rentezLogo from '../../assets/rentez_logo.png'; // Import your logo

function Login() {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [errorMessage, setErrorMessage] = useState("");
    const [successMessage, setSuccessMessage] = useState("");
    const navigate = useNavigate();

    const handleSubmit = async (e) => {
        e.preventDefault();

        setErrorMessage("");
        setSuccessMessage("");

        try {
            const response = await fetch("https://localhost:7183/api/User/login", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({ email, password }),
            });

            const result = await response.json();

            if (response.ok) {
                setSuccessMessage(result.message);
                setTimeout(() => {
                    navigate("/"); // Redirect to dashboard after successful login
                }, 2000);
            } else {
                setErrorMessage(result.message || "Login failed. Please try again.");
            }
        // eslint-disable-next-line no-unused-vars
        } catch (error) {
            setErrorMessage("An error occurred. Please try again later.");
        }
    };

    return (
        <div className="login-container">
            {/* Left Side: Illustration */}
            <div className="illustration-section">
                <img src={rentezLogo} alt="RentEZ Logo" className="logo-image" />
                <span className="brand-name">RENT <br /> EZ</span>
            </div>

            {/* Right Side: Form */}
            <div className="form-section">
                <h1>Welcome!</h1>
                <form onSubmit={handleSubmit}>
                    <input
                        type="email"
                        placeholder="Enter Email"
                        value={email}
                        onChange={(e) => setEmail(e.target.value)}
                        required
                    />
                    <input
                        type="password"
                        placeholder="Password"
                        value={password}
                        onChange={(e) => setPassword(e.target.value)}
                        required
                    />
                    {errorMessage && <p className="error-message">{errorMessage}</p>}
                    {successMessage && <p className="success-message">{successMessage}</p>}
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
