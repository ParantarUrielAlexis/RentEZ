import { createContext, useState, useEffect } from "react";

// Create Context
export const AuthContext = createContext();

export const AuthProvider = ({ children }) => {
    const [isLoggedIn, setIsLoggedIn] = useState(false);
    const [username, setUsername] = useState("");

    useEffect(() => {
        // Retrieve from localStorage and set state if authToken exists
        const authToken = localStorage.getItem("authToken");
        const storedUsername = localStorage.getItem("username");

        if (authToken) {
            setIsLoggedIn(true);
            setUsername(storedUsername);
        } else {
            setIsLoggedIn(false);
            setUsername("");
        }
    }, []); // Run only once on mount

    return (
        <AuthContext.Provider value={{ isLoggedIn, setIsLoggedIn, username, setUsername }}>
            {children}
        </AuthContext.Provider>
    );
};
