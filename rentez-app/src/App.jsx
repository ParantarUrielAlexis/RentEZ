import "./layout.scss";
import Navbar from "./components/navbar/Navbar";
import SinglePage from "./routes/singlePage/singlePage";

function App() {
  return (
    <div className="layout">
      <Navbar />
      <SinglePage />
    </div>
  );
}

export default App;
