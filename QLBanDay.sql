use master 
go

create database QLBanGiay

use QLBanGiay
go

create table categories 
(
	id int identity primary key,
	name nvarchar(255),
	avatar nvarchar(255),
	description ntext,
	status bit,
	created_at date Default CURRENT_TIMESTAMP,
	updated_at date default null
);
go
create table products
(
	id int identity primary key,
	name nvarchar(255),
	avatar nvarchar(255),
	price int,
	size int,
	brand nvarchar(255),
	color int,
	gender bit,
	amount int,
	summary nvarchar(255),
	description ntext,
	status bit,
	created_at date Default CURRENT_TIMESTAMP,
	updated_at date default null,
	category_id int foreign key references categories(id)
);
go

create table users
(
	id int identity primary key,
	username nvarchar(255) not null,
	password nvarchar(255) not null,
	fullname nvarchar(255),
	phone int,
	address nvarchar(255),
	email nvarchar(255),
	avatar nvarchar(255),
	roles int,
	status bit,
	created_at date Default CURRENT_TIMESTAMP,
	updated_at date default null,
);
go

create table customers
(
	id int identity primary key,
	fullname nvarchar(255),
	phone int,
	address nvarchar(255),
	email nvarchar(255),
	avatar nvarchar(255),
	created_at date Default CURRENT_TIMESTAMP,
	updated_at date default null,
);
go

create table orders
(
	id int identity primary key,
	note nvarchar(255),
	price_total int,
	payment_status int,
	created_at date Default CURRENT_TIMESTAMP,
	updated_at date default null,
	user_id int foreign key references users(id),
	customer_id int foreign key references customers(id)
);
go

create table order_details
(
	order_id int not null foreign key references orders(id),
	product_id int not null foreign key references products(id),
	primary key (order_id, product_id),
	price int,
	amount int
);
go