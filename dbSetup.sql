CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
    name varchar(255) COMMENT 'User Name',
    email varchar(255) COMMENT 'User Email',
    picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE chores (
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    description VARCHAR(255),
    isComplete BOOLEAN DEFAULT false
);

INSERT INTO
    chores (name, description)
VALUES (
        "Do the dishes",
        "Unload the dishes and put them away, load the dishwasher and start it."
    ),
    (
        "Do the laundry",
        "Fold the clean laundry, load the washer with dirty laundry and start it"
    ),
    (
        "Mow the lawn",
        "Mow and edge the front and back yards"
    ),
    (
        "Vacuum",
        "Vacuum all of the rugs and the carpet in all of the rooms"
    );

SELECT * FROM chores;