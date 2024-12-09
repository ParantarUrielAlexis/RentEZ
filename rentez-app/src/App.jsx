import { useEffect } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./layout.scss";
import Navbar from "./components/navbar/Navbar";
import SinglePage from "./routes/singlePage/singlePage";
import ProfilePage from "./routes/profilePage/profilePage";
import { CreatePost } from "./routes/create_post/create_post";
import { EditContactCard } from "./routes/contact_card/contact_card";
import { UpdateProfile } from "./routes/update_profile/update_profile";
import SearchResult from "./routes/search_result/SearchResult";
import SignUp from "./routes/signup/Signup";
import Login from "./routes/login/Login";
import axios from "axios";

function App() {
  useEffect(() => {
    axios
      .get("https://localhost:7183/WeatherForecast")
      .then((response) => {
        console.log(response.data);
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
      });
  }, []);

  return (
    <Router>
      <div className="layout">
        <Navbar />
        <Routes>
          <Route path="/" element={<SinglePage />} />
          <Route path="/profile" element={<ProfilePage />} />
          <Route path="/create-post" element={<CreatePost />} />
          <Route path="/edit-contact-card" element={<EditContactCard />} />
          <Route path="/update-profile" element={<UpdateProfile />} />
          <Route path="/search-result" element={<SearchResult />} />
          <Route path="/sign-up" element={<SignUp />} />
          <Route path="/sign-in" element={<Login />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
