import React from "react";
import image19 from "./image-19.png";
import image20 from "./image-20.png";
import image21 from "./image-21.png";
import image23 from "./image-23.png";
import image from "./image.png";
import line2 from "./line-2.svg";
import { BrowserRouter, Routes, Route, Link } from 'react-router-dom';
import "./contact_card.scss";
import tablerHomeFilled from "./tabler-home-filled.svg";

export const EditContactCard = () => {
  return (
    <div className="edit-contact-card">
      <div className="div">
        <div className="roberto-a-ginoo">Roberto A.&nbsp;&nbsp;Ginoo</div>

        <div className="text-wrapper">09-123-456-789</div>

        <img className="image" alt="Image" src={image19} />

        <img className="img" alt="Image" src={image20} />

        <img className="image-2" alt="Image" src={image21} />

        <div className="text-wrapper-2">https://www.facebook.com/RobGinoo</div>

        <div className="text-wrapper-3">
          https://www.instagram.com/Ginoo_Rob
        </div>

        <img className="line" alt="Line" src={line2} />

        <p className="p">
          Hello! I’m an enthusiastic property owner dedicated to providing
          comfortable and welcoming spaces for tenants. With a focus on creating
          a positive living environment, I ensure each room is well-maintained
          and thoughtfully furnished. I love connecting with people and helping
          them find their perfect home away from home!
        </p>

        <img className="image-3" alt="Image" src={image} />

        <div className="group">
          <div className="overlap-group">
            <div className="text-wrapper-4">Save</div>
          </div>
        </div>

        <img
          className="tabler-home-filled"
          alt="Tabler home filled"
          src={tablerHomeFilled}
        />

        <div className="text-wrapper-5">RentEz</div>

        <div className="image-wrapper">
          <img className="image-4" alt="Image" src={image23} />
        </div>
      </div>
    </div>
  );
}

export default EditContactCard;
