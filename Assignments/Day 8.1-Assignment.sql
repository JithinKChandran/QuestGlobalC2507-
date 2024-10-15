create table account(
  acc_id varchar(100) primary key,
  acc_no varchar(100) unique NOT NULL,
  acc_holder_name varchar(100) not null,
  balance decimal(15, 2) not null,
  ph_no varchar(15),
  address varchar(100),
  acc_type varchar(100) not null,
  created datetime default current_datetime
);

create table transaction(
  transaction_id int primary key,
  acc_no varchar(100) not null,
  amount decimal(15, 2) not null,
  t_type varchar(25),
  transaction_date datetime default current_datetime,
  to_acc_id varchar(20),
  constraint fk_acc_id foreign key (acc_id) references account(acc_id)
);

insert into account(acc_id, acc_no, acc_holder_name, balance, ph_no, address, acc_type, created)
values (1, '1234567890', 'John Doe', '123-456-7890', '123 Main St, Anytown, USA', 1000.00, 'Savings', NOW()),
(2, '0987654321', 'Jane Smith', '987-654-3210', '456 Elm St, Othertown, USA', 1500.00, 'Checking', NOW()),
(3, '1122334455', 'Alice Johnson', '555-123-4567', '789 Oak St, Sometown, USA', 2000.00, 'Savings', NOW()),
(4, '6677889900', 'Bob Brown', '444-987-6543', '321 Pine St, Anycity, USA', 2500.00, 'Checking', NOW()),
(5, '2233445566', 'Charlie Davis', '333-456-7890', '654 Maple St, Othercity, USA', 3000.00, 'Savings', NOW());

-- delete account
delete from account where acc_no ='123456789';

-- update account
update account
set  acc_holder_name=' jithin', ph_no = '9656554213', address = ' mamatha, chala ,kannur', acc_type = 'saving' where acc_id='3';

-- deposit
update account
set balance = balance + 623.96
where acc_no = '1122334455';

insert into transaction (transaction_id, t_type, amount, transaction_date)
values(1, (SELECT acc_id FROM account WHERE acc_no = '1122334455'), 'Deposit', 623.96, NOW());

-- withdraw
update account
set balance = balance - 500.00
where acc_no = '1122334455' and balance >= 500.00 ;

insert into transaction (transaction_id, t_type, amount, transaction_date)
values(1, (SELECT acc_id FROM account WHERE acc_no = '1122334455'), 'withdraw', 500.00, NOW());

-- transaction to Other acc
start transaction

update account
set balance = balance + 1000.01
where acc_no = '1122334455';

insert into transaction(transaction_id, acc_id, t_type, amount, transaction_date, to_acc_id)
values(3, (SELECT acc_id FROM account WHERE acc_no = '1234567890'), 'Transfer ', 1000.01, NOW(), '1122334455');

-- view history
SELECT transaction, acc_id, t_type, amount, transaction_date, to_acc_id
FROM transaction
where acc_id = (select acc_id from account where acc_no = '1122334455')
order by transaction_date desc;