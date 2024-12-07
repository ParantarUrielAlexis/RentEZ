import "./layout.scss";
import Navbar from "./components/navbar/Navbar";
import SinglePage from "./routes/singlePage/singlePage";
import { useEffect } from "react";
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
    <div className="layout">
      <Navbar />
      <SinglePage />
    </div>
  );
}

export default App;
