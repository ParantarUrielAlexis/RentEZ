import "./Signup.scss";
import rentezLogo from "../../assets/rentez_logo.png";
import { Link, useNavigate } from "react-router-dom";
import { useState } from "react";

function Signup() {
    // State hooks to manage form input values
    const [username, setUsername] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [confirmPassword, setConfirmPassword] = useState("");
    const [errorMessage, setErrorMessage] = useState(""); // To display any error messages
    const [successMessage, setSuccessMessage] = useState(""); // To display success message
    const navigate = useNavigate(); // To redirect after successful registration

    const handleSubmit = async (e) => {
        e.preventDefault();

        // Clear any previous error or success messages
        setErrorMessage("");
        setSuccessMessage("");

        // Check if passwords match
        if (password !== confirmPassword) {
            setErrorMessage("Passwords do not match.");
            return;
        }

        // Prepare the data to send in the request
        const userData = {
            username,
            email,
            password,
        };

        try {
            // Sending POST request to the backend API
            const response = await fetch("https://localhost:7183/api/User/register", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify(userData),
            });

            if (response.ok) {
                const result = await response.json();
                setSuccessMessage(result.message); // Show success message
                setTimeout(() => {
                    navigate("/sign-in"); // Redirect to login page after successful registration
                }, 2000);
            } else {
                const result = await response.json();
                setErrorMessage(result.message || "Registration failed. Please try again.");
            }
        // eslint-disable-next-line no-unused-vars
        } catch (error) {
            setErrorMessage("An error occurred. Please try again later.");
        }
    };

    return (
        <div className="signup-container">
            {/* Left Side: Form */}
            <div className="form-section">
                <h1>Create Account</h1>
                <form onSubmit={handleSubmit}>
                    <input
                        type="text"
                        placeholder="Enter Username"
                        value={username}
                        onChange={(e) => setUsername(e.target.value)}
                        required
                    />
                    <input
                        type="email"
                        placeholder="Email"
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
                    <input
                        type="password"
                        placeholder="Confirm Password"
                        value={confirmPassword}
                        onChange={(e) => setConfirmPassword(e.target.value)}
                        required
                    />
                    {errorMessage && <p className="error-message">{errorMessage}</p>}
                    {successMessage && <p className="success-message">{successMessage}</p>}
                    <button type="submit" className="register-btn">
                        Register
                    </button>
                </form>
                <p>
                    Already have an account? <Link to="/sign-in">Login</Link>
                </p>
            </div>

            {/* Right Side: Illustration */}
            <div className="illustration-section">
                <img src={rentezLogo} alt="RentEZ Logo" className="logo-image" />
                <span className="brand-name">
                    RENT <br /> EZ
                </span>
            </div>
        </div>
    );
}

export default Signup;
