import React, { useState, useEffect } from "react";
import "./App.css";
import Drzave from "./Drzave";
import menu from "./dataaa";

//function getCities() {
//return fetch("https://localhost:44379/api/CountryRequirements")
//.then((response) => response.json())
//.then((responseJson) => {
//return responseJson.countryRequirements;
//})
//.catch((error) => {
//console.error(error);
//});
//}

//const drzavee = JSON.parse(JSON.stringify(getCities()));

function App() {
  const textData =
    '{ "" : [' +
    '{ "id":"1" , "countryName":"Doe", "visa":"da" },' +
    '{ "id":"2" , "countryName":"Smith",  "visa":"d"},' +
    '{ "id":"3" , "countryName":"Jones", "visa":"da" } ]}';
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetch("https://localhost:44379/api/CountryRequirements")
      .then((response) => {
        if (response.ok) {
          console.log(data);
          return response.json();
        }
        throw response;
      })
      .then((data) => {
        setData(data);
      })
      .catch((error) => {
        console.error("Error fetch", error);
        setError(error);
      })
      .finally(() => {
        setLoading(false);
      });
  }, []);

  return (
    <div className="App">
      <h1> Tourist attractions</h1>
      <div className="form">
        <label> daw </label>
        <input className="input-drzava" type="text" name="drzava"></input>
        <label> nesto </label>
        <input type="text" name="pasos"></input>
        <label> Zeleni karton: </label>
        <input type="text" name="zeleni-karton"></input>

        <button> b </button>
      </div>
      <Drzave dataa={data} />
    </div>
  );
}

export default App;
