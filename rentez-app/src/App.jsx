import "./layout.scss";
import Navbar from "./components/navbar/Navbar";
import SinglePage from "./routes/singlePage/singlePage";
import { BrowserRouter } from 'react-router-dom';
import EditContactCard from "./routes/contact_card/contact_card";
import { CratePost } from "./routes/create_post/create_post";
import { UpdateProfile } from "./routes/update_profile/update_profile";

function App() {
  return (
    <div className="layout">
      <BrowserRouter>
      <Navbar />
      </BrowserRouter>
      <SinglePage />
      <EditContactCard />
      <CreatePost />
      <UpdateProfile />
      
    </div>
  );
}

export default App;
