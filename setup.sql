CREATE TABLE books (
    id INT NOT NULL AUTO_INCREMENT,
    title VARCHAR(255) NOT NULL,
    author VARCHAR(255),
    isAvailable TINYINT NOT NULL
    
    PRIMARY KEY (id)
)