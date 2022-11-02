import React, { useState } from "react";
import { Link } from "react-router-dom";

function CBooKingTable(props) {
  return (
    <div>
      <table className="table table-striped table-hover">
        <thead>
          <tr>
            <td>User Id</td>
            <td>Book Id</td>
            <td>Hotel Name</td>
            <td>No of Table</td>
          </tr>
        </thead>
        <tbody>
          {props.map((value) => {
            return (
              <tr>
                <td>{value.UId}</td>
                <td>{value.Id}</td>
                <td>{value.Name}</td>
                <td>{value.No_Of_Table}</td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </div>
  );
}

const CancelReservation = (props) => {
  const [UId, setUId] = useState();
  const [Id, setId] = useState();
  const [Name, setName] = useState();
  const [No_Of_Table, setNo_Of_Table] = useState();
  const [array, setArray] = useState([...props.canceledbookingData]);

  function onClick() {
    const object = { UId, Id, Name, No_Of_Table };
    setArray([...array, object]);
    setId("");
  }

  return (
    <div>
      <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <h5 className="navbar-brand text-white">The Hotel Piece </h5>
        <Link to="/">
          <h5 className="navbar-brand text-white">Home </h5>
        </Link>
        <Link to="/UserHome">
          <h5 className="navbar-brand text-white">User Home </h5>
        </Link>
        <Link to="/HotelList">
          <h5 className="navbar-brand text-white">Hotel List </h5>
        </Link>
        <Link to="/BookTable">
          <h5 className="navbar-brand text-white">Booking </h5>
        </Link>
      </nav>

      <div className="text-center m-5"><h1>Cancel Reserved Table</h1></div>
      <div className="inputBody m-5">
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>User ID </b>
            </label>
          </span>
          <input
            id="uid"
            onChange={(e) => setUId(e.target.value)}
            className="form-control"
            placeholder="Enter User Id"
            aria-label="With input"
          ></input>
        </div>
        <br />
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Booking Id </b>
            </label>
          </span>
          <input
            id="id"
            onChange={(e) => setId(e.target.value)}
            className="form-control"
            placeholder="Enter id"
            aria-label="With input"
          ></input>
        </div>
        <br />
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Hotel Name</b>
            </label>
          </span>
          <input
            id="name"
            onChange={(e) => setName(e.target.value)}
            className="form-control"
            placeholder="name"
            aria-label="With input"
          ></input>
        </div>
        <br />
        <div className="input-group">
          <span className="input-group-text">
            <label>
              <b>Number of Tables</b>
            </label>
          </span>
          <input
            id="no_of_tb"
            onChange={(e) => setNo_Of_Table(e.target.value)}
            className="form-control"
            placeholder="No of Tables"
            aria-label="With input"
          ></input>
        </div>
        <div className="successButton mt-3">
          <button onClick={onClick} type="button" className="btn btn-success">
            SUBMIT
          </button>
        </div>
      </div>
      <div className="text-center m-5"><h1>Canceled Reservation List</h1></div>
      <div className="m-3">{CBooKingTable(array)}</div>
    </div>
  );
};

export default CancelReservation;
