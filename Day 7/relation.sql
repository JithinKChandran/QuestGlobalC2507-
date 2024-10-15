CREATE TABLE categories(
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(25) NOT NULL UNIQUE,

)

INSERT INTO categories VALUES('uncategorized'),('Electronic'),('Phone')

CREATE TABLE product_categories(
    id bigint primary key identity,
    category_id int,
    product_id bigint,

    CONSTRAINT FK_category_id FOREIGN KEY (category_id) REFERENCES categories(id),
    CONSTRAINT FK_product_id FOREIGN KEY (product_id) REFERENCES products(id),
);

INSERT INTO product_categories VALUES
(2, 1), (3, 1)