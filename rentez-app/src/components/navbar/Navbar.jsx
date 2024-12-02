import "./navbar.scss";
import { Link } from "react-router-dom";

function Navbar() {
  return (
    <nav>
      <div className="left">
        <a href="/" className="logo">
          <img src="/logo.png" alt="" />
          <span>RentEZ</span>
        </a>
        <a href="/">Home</a>
        <a href="/">About</a>
        <a href="/">Contact</a>
        <a href="/">Agents</a>
      </div>
      <div className="right">
        <Link to="/login">Login</Link>
        <Link to="/signup">SignUp</Link>
      </div>
    </nav>
  );
}

export default Navbar;
