import React from "react";

const Drzave = ({ dataa }) => {
  return (
    <div className="drzave">
      {dataa.map((podaciDrzave) => {
        const {
          id,
          countryName,
          visa,
          greenCard,
          pcrTest,
          antigentest,
          vaccinated,
        } = podaciDrzave;
        //const visaaa = visa.toString();
        return (
          <article key={id} className="drzava">
            <div className="drzava-info">
              <header>
                <h2>{countryName}</h2>
                <h4>{id}</h4>
                <h3>(visa ? 't' : 'f')</h3>
                <h3>((greenCard ? '2.00' : '10.00'))</h3>
              </header>
            </div>
          </article>
        );
      })}
    </div>
  );
};

export default Drzave;
