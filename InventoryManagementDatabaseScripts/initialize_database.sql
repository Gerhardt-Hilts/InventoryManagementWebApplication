CREATE DATABASE inventory_management;

CREATE TYPE ENUM_ITEM_CONDITION AS ENUM (
    'NEW',
    'PRISTINE',
    'GOOD',
    'OK',
    'POOR',
    'UNKNOWN'
);


CREATE TABLE item_models (
    id SERIAL,
    uniqueId VARCHAR(255) UNIQUE,
    modelName VARCHAR(255) NOT NULL,
    modelSerialNumber VARCHAR(255) NOT NULL,
    itemCount INTEGER NOT NULL
);

CREATE TABLE items (
    id SERIAL PRIMARY KEY,
    uniqueId VARCHAR(255) NOT NULL,
    itemModel VARCHAR(255) NOT NULL,
    itemCondition ENUM_ITEM_CONDITION NOT NULL,
    serialNumber VARCHAR(255) NOT NULL,
    lastMaintenance DATE NOT NULL,
    acquisitionDate DATE NOT NULL,
    manufacturer VARCHAR(255) NOT NULL,
    warranty BOOLEAN NOT NULL,
    inStock BOOLEAN NOT NULL
);

CREATE TABLE customers (
    id SERIAL PRIMARY KEY,
    uniqueId VARCHAR(255) UNIQUE,
    name VARCHAR(255) NOT NULL,
    active BOOLEAN NOT NULL,
    contactPhoneNumber VARCHAR(255) NOT NULL,
    contactEmail VARCHAR(255) NOT NULL
);

CREATE TABLE images (
    id SERIAL PRIMARY KEY,
    uniqueId VARCHAR(255) UNIQUE,
    description VARCHAR(255) NOT NULL,
    semVer VARCHAR(255) NOT NULL,
    lastUpdate DATE NOT NULL,
    scheduledUpdate DATE NOT NULL
);

CREATE TABLE machines (
    id SERIAL PRIMARY KEY,
    uniqueId VARCHAR(255) UNIQUE,
    description VARCHAR(255) NOT NULL,

);

CREATE TABLE machine_models (

);

CREATE TABLE internal_ledger (

);

