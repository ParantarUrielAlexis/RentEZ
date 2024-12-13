import React from "react";
import { Link, useNavigate } from "react-router-dom";
import { useState } from "react";
function ProfilePage() {
  return (
    <div
      className="ProfilePage"
      style={{
        width: "1440px",
        minHeight: "1693px",
        position: "relative",
        background: "white",
      }}
    >
      {/* <div
        name="nav-bar"
        style={{
          display: "flex",
          width: "1440px",
          marginTop: "5px",
          alignItems: "center",
        }}
      >
        <div style={{ display: "flex" }}>
          <div
            className="Vector"
            style={{ width: 50, height: 50, background: "#DB4242" }}
          ></div>
          <div
            className="Rentez"
            style={{
              width: 177,
              top: 49,
              color: "#F4CE14",
              fontSize: 42,
              fontFamily: "Inter",
              fontWeight: "700",
              wordWrap: "break-word",
            }}
          >
            RentEz
          </div>
        </div>

        <button
          className="Home-btn"
          style={{
            width: "86px",
            height: "34px",
            color: "black",
            fontSize: "22px",
            fontFamily: "Inter, sans-serif",
            fontWeight: "400",
            backgroundColor: "transparent",
            border: "none",
            cursor: "pointer",
            marginLeft: "40px",
          }}
        >
          Home
        </button>
        <button
          className="Contact-btn"
          style={{
            width: "86px",
            height: "34px",
            color: "black",
            fontSize: "22px",
            fontFamily: "Inter, sans-serif",
            fontWeight: "400",
            backgroundColor: "transparent",
            border: "none",
            cursor: "pointer",
            marginLeft: "200px",
          }}
        >
          Contact
        </button>
        <button
          className="About-btn"
          style={{
            width: "86px",
            height: "34px",
            color: "black",
            fontSize: "22px",
            fontFamily: "Inter, sans-serif",
            fontWeight: "400",
            backgroundColor: "transparent",
            border: "none",
            cursor: "pointer",
            marginLeft: "200px",
          }}
        >
          About
        </button>

        <button
          className="logout-btn"
          style={{
            width: "86px",
            height: "34px",
            color: "black",
            fontSize: "22px",
            fontFamily: "Inter, sans-serif",
            marginLeft: "430px",
            fontWeight: "700",
            background: "#F44336",
            border: "none",
            borderRadius: "5px",
            cursor: "pointer",
            wordWrap: "break-word",
          }}
          onMouseEnter={(e) => {
            e.target.style.backgroundColor = "#D32F2F";
            e.target.style.transform = "scale(1.05)";
          }}
          onMouseLeave={(e) => {
            e.target.style.backgroundColor = "#F44336";
            e.target.style.transform = "scale(1)";
          }}
          onFocus={(e) => {
            e.target.style.outline = "none";
          }}
          onClick={(e) => {
            e.target.style.backgroundColor = "#C0392B";
            e.target.style.transform = "scale(1.02)";
          }}
          onAnimationEnd={(e) => {
            e.target.style.transform = "scale(1)";
          }}
        >
          Logout
        </button>
      </div> */}

      <div
        style={{ display: "flex", alignItems: "center", marginBottom: "60px" }}
      >
        <div name="left-portion" style={{ alignItems: "center" }}>
          <img
            className="Image"
            style={{
              width: 150,
              height: 150,
              borderRadius: 9999,
              margin: "15px",
            }}
            src="https://via.placeholder.com/150x150"
          />

          <div
            className="name"
            style={{
              width: 182,
              height: 26,
              textAlign: "center",
              color: "black",
              fontSize: 22,
              fontFamily: "Inter",
              marginBottom: "10px",
              fontWeight: "400",
              wordWrap: "break-word",
            }}
          >
            Roberto
          </div>

          <button
            className="UpdateProfile"
            style={{
              width: "178px",
              height: "46px",
              background: "#F4CE14",
              color: "black",
              fontSize: "22px",
              fontFamily: "Inter, sans-serif",
              fontWeight: "700",
              wordWrap: "break-word",
              border: "none",
              borderRadius: "5px",
              cursor: "pointer",
            }}
            onMouseEnter={(e) => {
              e.target.style.backgroundColor = "#E1B314";
              e.target.style.transform = "scale(1.05)";
            }}
            onMouseLeave={(e) => {
              e.target.style.backgroundColor = "#F4CE14";
              e.target.style.transform = "scale(1)";
            }}
            onFocus={(e) => {
              e.target.style.outline = "none";
            }}
            onClick={(e) => {
              e.target.style.backgroundColor = "#F4A900";
              e.target.style.transform = "scale(1.02)";
            }}
            onAnimationEnd={(e) => {
              e.target.style.transform = "scale(1)";
            }}
          >
            <Link to="/update-profile">Update Profile</Link>
          </button>
        </div>

        <div name="right-portion">
          <div
            className="PersonalInformation"
            style={{
              width: 252,
              height: 29,
              color: "black",
              fontSize: 24,
              fontFamily: "Inter, sans-serif",
              fontWeight: "600",
              wordWrap: "break-word",
              marginLeft: "100px",
              marginTop: "0px",
            }}
          >
            Personal information
          </div>
          <div
            className="firstname"
            style={{
              width: 237,
              height: 26,
              color: "black",
              fontSize: 22,
              fontFamily: "Inter",
              fontWeight: "400",
              wordWrap: "break-word",
              marginLeft: "100px",
              marginTop: "10px",
            }}
          >
            First name
          </div>
          <div
            className="lastname"
            style={{
              width: 216,
              height: 26,
              color: "black",
              fontSize: 22,
              fontFamily: "Inter",
              fontWeight: "400",
              wordWrap: "break-word",
              marginLeft: "100px",
              marginTop: "10px",
            }}
          >
            Last name
          </div>
          <div
            className="email"
            style={{
              width: 393,
              height: 26,
              color: "black",
              fontSize: 22,
              fontFamily: "Inter",
              fontWeight: "400",
              wordWrap: "break-word",
              marginLeft: "100px",
              marginTop: "10px",
            }}
          >
            Email{" "}
          </div>
        </div>
      </div>

      <div
        className="Line"
        style={{ width: "1440px", height: "1px", border: "1px black solid" }}
      ></div>

      <div style={{ display: "flex", marginTop: "60px" }}>
        <div name="left-part">
          <div style={{ display: "flex", marginBottom: "25px" }}>
            <div
              className="MyList"
              style={{
                width: 177,
                height: 47,
                left: 101,
                top: 548,
                color: "black",
                fontSize: 49,
                fontFamily: "Inter, sans-serif",
                fontWeight: "700",
                wordWrap: "break-word",
              }}
            >
              My List
            </div>

            <button
              className="CreatePostBtn"
              style={{
                width: "178px",
                height: "46px",
                left: "552px",
                top: "560px",
                backgroundColor: "#F4CE14",
                borderRadius: "50px",
                color: "black",
                fontSize: "22px",
                fontFamily: "Inter, sans-serif",
                fontWeight: "700",
                textAlign: "center",
                display: "flex",
                justifyContent: "center",
                alignItems: "center",
                cursor: "pointer",
                border: "none",
                transition: "all 0.3s ease",
                marginLeft: "370px",
              }}
              onMouseEnter={(e) => {
                e.target.style.backgroundColor = "#E1B314";
                e.target.style.transform = "scale(1.05)";
              }}
              onMouseLeave={(e) => {
                e.target.style.backgroundColor = "#F4CE14";
                e.target.style.transform = "scale(1)";
              }}
              onFocus={(e) => {
                e.target.style.outline = "none";
              }}
              onClick={(e) => {
                e.target.style.backgroundColor = "#F4A900";
                e.target.style.transform = "scale(1.02)";
              }}
              onAnimationEnd={(e) => {
                e.target.style.transform = "scale(1)";
              }}
            >
              Create Post
            </button>
          </div>

          <div
            style={{
              backgroundColor: "beige",
              width: 800,
              minHeight: 500,
              padding: "15px",
            }}
          >
            <div
              style={{ display: "flex", width: "770px", minHeight: "500px" }}
            >
              <div
                style={{
                  backgroundColor: "green",
                  width: "400px",
                  height: "400",
                }}
              >
                Property image
              </div>
              <div
                style={{
                  backgroundColor: "blue",
                  width: "370px",
                  height: "400",
                }}
              >
                <p>Property name</p>
                <p>Property address</p>
                <p>Price</p>
                <p>Tags</p>
              </div>
            </div>
          </div>
        </div>

        <div name="right-part" style={{ marginLeft: "100px" }}>
          <div
            style={{
              width: 532,
              height: 564,
              background: "#D9D9D9",
              borderRadius: 25,
              marginBottom: "30px",
              paddingTop: "15px",
              paddingBottom: "15px",
            }}
          >
            <div
              className="ContactCard"
              style={{
                width: 209,
                height: 38,
                color: "black",
                fontSize: 32,
                fontFamily: "Inter, sans-serif",
                fontWeight: "400",
                wordWrap: "break-word",
                marginLeft: "180px",
              }}
            >
              Contact Card
            </div>

            <div
              style={{ display: "flex", alignItems: "center", margin: "15px" }}
            >
              <div>
                <img
                  className="Image"
                  style={{
                    width: 150,
                    height: 150,
                    left: 854,
                    top: 614,
                    borderRadius: 9999,
                  }}
                  src="https://via.placeholder.com/150x150"
                />
              </div>

              <div
                className="RobertoAGinoo"
                style={{
                  width: 145,
                  height: 20,
                  left: 1022,
                  top: 679,
                  color: "black",
                  fontSize: 16,
                  fontFamily: "Inter",
                  fontWeight: "700",
                  wordWrap: "break-word",
                  marginLeft: "20px",
                }}
              >
                Roberto A. Ginoo
              </div>
            </div>

            <div style={{ display: "flex", marginLeft: "15px" }}>
              <img
                className="phone-icon"
                style={{ width: "16px", height: "16px" }}
                src="https://via.placeholder.com/16x16"
              />
              <div
                className="123456789"
                style={{
                  width: "200px",
                  height: "25px",
                  color: "black",
                  fontSize: "16px",
                  fontFamily: "Inter",
                  fontWeight: "700",
                  wordWrap: "break-word",
                }}
              >
                Phone number
              </div>
            </div>

            <div style={{ display: "flex", marginLeft: "15px" }}>
              <img
                className="facebook-icon"
                style={{ width: "16px", height: "16px" }}
                src="https://via.placeholder.com/16x16"
              />
              <div
                className="HttpsWwwFacebookComRobginoo"
                style={{
                  width: "200px",
                  height: "25px",
                  color: "black",
                  fontSize: "16px",
                  fontFamily: "Inter",
                  fontWeight: "700",
                  wordWrap: "break-word",
                }}
              >
                FaceBook link
              </div>
            </div>

            <div style={{ display: "flex", marginLeft: "15px" }}>
              <img
                className="intagram-icon"
                style={{ width: "16px", height: "16px" }}
                src="https://via.placeholder.com/16x16"
              />
              <div
                className="HttpsWwwInstagramComGinooRob"
                style={{
                  width: "200px",
                  height: "25px",
                  left: "880px",
                  top: "834px",
                  color: "black",
                  fontSize: "16px",
                  fontFamily: "Inter",
                  fontWeight: "700",
                  wordWrap: "break-word",
                }}
              >
                Intagram link
              </div>
            </div>

            <div
              className="Biography "
              style={{
                width: "500px",
                minHeight: "200px",
                left: "860px",
                top: "861px",
                color: "black",
                fontSize: "20px",
                fontFamily: "Inter",
                fontWeight: "400",
                wordWrap: "break-word",
                marginLeft: "15px",
                marginBottom: "5px",
              }}
            >
              Biography
            </div>

            <button
              className="edit-btn"
              style={{
                width: "151px",
                height: "34px",
                left: "858px",
                top: "1054px",
                background: "#F4CE14",
                borderRadius: "50px",
                border: "none",
                cursor: "pointer",
                padding: "0px",
                display: "flex",
                justifyContent: "center",
                alignItems: "center",
                color: "black",
                fontSize: "24px",
                fontFamily: "Inter, sans-serif",
                fontWeight: "700",
                wordWrap: "break-word",
                marginLeft: "15px",
              }}
              aria-label="Edit button"
              onMouseEnter={(e) => {
                e.target.style.backgroundColor = "#E1B314";
                e.target.style.transform = "scale(1.05)";
              }}
              onMouseLeave={(e) => {
                e.target.style.backgroundColor = "#F4CE14";
                e.target.style.transform = "scale(1)";
              }}
              onFocus={(e) => {
                e.target.style.outline = "none";
              }}
              onClick={(e) => {
                e.target.style.backgroundColor = "#F4A900";
                e.target.style.transform = "scale(1.02)";
              }}
              onAnimationEnd={(e) => {
                e.target.style.transform = "scale(1)";
              }}
            >
              Edit
              <img
                className="edit-icon"
                style={{ width: "24px", height: "24px", marginLeft: "10px" }}
                src="https://via.placeholder.com/24x24"
                alt="Edit Icon"
              />
            </button>
          </div>

          <div
            className="Advertisement"
            style={{
              width: "53s2px",
              height: "532px",
              border: "none",
              borderRadius: "25px",
              background: "grey",
            }}
          >
            {" "}
            advertisement
          </div>
        </div>
      </div>
    </div>
  );
}

export default ProfilePage;
