
CREATE TABLE orders (
      id BIGINT PRIMARY KEY IDENTITY,
      quantity INT NOT NULL DEFAULT 1,
      product_id BIGINT NOT NULL,
      user_id BIGINT NOT NULL,
      
      CONSTRAINT FK_orders_product_id
      FOREIGN KEY (products_id) REFERENCES products(id)
      
      CONSTRAINT FK_orders_users_id
      FOREIGN KEY (users_id) REFERENCES users(id) ON DELETE CASCADE 
      
)

INSERT INTO orders, VALUES(1, 2, 1)
INSERT INTO orders, VALUES(1, 3 , 10)

DELETE FROM users where id = 2;

create table employees(
  id int primary key IDENTITY,
  name varchar(50),
  email varchar(100),
  manager_id int,
  
  CONSTRAINT FK_foo_bar_foo
  foreign key (manager_id) references employees()
)