import "./layout.scss";
import Navbar from "./components/navbar/Navbar";
import SinglePage from "./routes/singlePage/singlePage";
import { BrowserRouter } from 'react-router-dom';

function App() {
  return (
    <div className="layout">
      <BrowserRouter>
      <Navbar />
      </BrowserRouter>
      <SinglePage />
      
    </div>
  );
}

export default App;
