create schema if not exists tourism;

use tourism;

create table if not exists countryRequirements
(
	id int primary key auto_increment not null,
    countryName varchar(20) not null,
    visa boolean not null,
    greenCard boolean not null,
    pcrTest boolean not null,
    antigenTest boolean not null,
    vaccinated boolean not null    
) engine = InnoDB;

create table if not exists country
(
	id int primary key auto_increment,
    name varchar(20) not null,
    capitalCity varchar(20) not null,
    language varchar(20) not null,
    currency varchar(20) not null,
    area int not null,
    population int not null
) engine = InnoDB;

insert into countryRequirements(countryName, visa, greenCard, pcrTest, antigenTest, vaccinated) values
("Austria", false, true, true, true, true),
("Italy", true, false, true, true, true),
("Germany", false, true, true, true, true),
("France", true, false, true, true, true),
("Montenegro", false, false, false, false, false),
("Northern Macedonia", false, false, false, false, false);

insert into country(name, capitalCity, language, currency, area, population) values
("Austria","Vienna","German","Euro", 83879, 8935112),
("Italy","Rome","Italian","Euro", 301340, 60317116),
("Germany","Berlin","German","Euro", 357022, 83190556),
("France","Paris", "French", "Euro", 640679, 67413000),
("Montenegro", "Podgorica", "Montenegrin", "Euro", 13812, 621873),
("Northern Macedonia", "Skopje", "Macedonian", "Macedonian denar", 25713, 1832696);

select * from countryRequirements;
select * from country;