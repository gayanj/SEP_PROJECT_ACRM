create table alerts(
	id datetime default CURRENT_TIMESTAMP primary key,
	alert varchar(max),
	pname varchar(max)
);