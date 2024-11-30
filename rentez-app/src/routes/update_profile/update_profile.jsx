import React from "react";
import image from "./image.png";
import rectangle5 from "./rectangle-5.svg";
import "./style.css";
import tablerHomeFilled from "./tabler-home-filled.svg";

export const UpdateProfile = () => {
  return (
    <div className="update-profile">
      <div className="div">
        <div className="overlap">
          <div className="text-wrapper">Update</div>
        </div>

        <div className="overlap-group">
          <img className="rectangle" alt="Rectangle" src={rectangle5} />

          <div className="text-wrapper-2">Upload Photo</div>
        </div>

        <div className="overlap-2">
          <div className="rectangle-2" />

          <div className="text-wrapper-3">Profile</div>
        </div>

        <img
          className="tabler-home-filled"
          alt="Tabler home filled"
          src={tablerHomeFilled}
        />

        <div className="text-wrapper-4">Update Profile</div>

        <div className="text-wrapper-5">RentEz</div>

        <div className="text-wrapper-6">Home</div>

        <div className="text-wrapper-7">Contact</div>

        <div className="text-wrapper-8">About</div>

        <div className="text-wrapper-9">Roberto</div>

        <div className="email-form">
          <div className="div-wrapper">
            <div className="text-wrapper-10">Enter new Username</div>
          </div>
        </div>

        <div className="overlap-wrapper">
          <div className="div-wrapper">
            <div className="text-wrapper-11">Enter new Email</div>
          </div>
        </div>

        <div className="overlap-group-wrapper">
          <div className="div-wrapper">
            <div className="text-wrapper-10">Enter new Password</div>
          </div>
        </div>

        <div className="email-form-2">
          <div className="div-wrapper">
            <div className="text-wrapper-11">Confirm Password</div>
          </div>
        </div>

        <div className="text-wrapper-12">Profile Picture</div>

        <img className="image" alt="Image" src={image} />
      </div>
    </div>
  );
};
