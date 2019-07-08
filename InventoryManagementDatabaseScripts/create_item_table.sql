CREATE TYPE ENUM_ITEM_CONDITION AS ENUM (
    'NEW',
    'PRISTINE',
    'GOOD',
    'OK',
    'POOR'
);

CREATE TABLE items (
    uniqueId VARCHAR(255),
    itemName VARCHAR(255),
    lastMaintenance DATE,
    serialNumber VARCHAR(255),
    acquisitionDate DATE,
    itemCondition ENUM_ITEM_CONDITION
);