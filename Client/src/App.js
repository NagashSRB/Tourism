import React, { useState, useEffect } from "react";
import "./App.css";

var resp;

function getCities() {
  return fetch("https://localhost:44379/api/CountryRequirements")
    .then((response) => response.json())
    .then((responseJson) => {
      //console.log(responseJson);
      return responseJson;
    })
    .catch((error) => {
      console.error(error);
    });
}

//const drzavee = JSON.parse(JSON.stringify(getCities()));

//console.log(drzavee);

function Ispisi(jsonn) {
  return (
    <div className="App">
      <h1> Tourist attractions</h1>
      <div className="form">
        <label> {jsonn} </label>
        <input className="input-drzava" type="text" name="drzava"></input>
        <label> Pasos: </label>
        <input type="text" name="pasos"></input>
        <label> Zeleni karton: </label>
        <input type="text" name="zeleni-karton"></input>
        <button onClick={click()} />
      </div>
    </div>
  );
}

function click() {
  getCities().then((response) => Ispisi(response));
}

function App() {
  getCities().then((response) => Ispisi(response));
  //const [drzave, setDrzave] = useState(drzavee); //drzave su sad objekat
  //return Ispisi("null");
  console.log();
}

export default App;
