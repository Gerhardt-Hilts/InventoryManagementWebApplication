CREATE TYPE ENUM_ITEM_CONDITION AS ENUM (
    'NEW',
    'PRISTINE',
    'GOOD',
    'OK',
    'POOR',
    'UNKNOWN'
);

CREATE TABLE items (
    id SERIAL PRIMARY KEY,
    uniqueId VARCHAR(255) NOT NULL,
    itemName VARCHAR(255) NOT NULL,
    itemCondition ENUM_ITEM_CONDITION NOT NULL,
    serialNumber VARCHAR(255) NOT NULL,
    lastMaintenance DATE NOT NULL,
    acquisitionDate DATE NOT NULL,
    manufacturer VARCHAR(255) NOT NULL,
    warranty BOOLEAN NOT NULL,
    inStock BOOLEAN NOT NULL
);