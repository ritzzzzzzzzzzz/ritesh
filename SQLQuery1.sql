create table vehicle(id int identity(1,1) primary key,type varchar(30),num1 int)
create table booking(book_id int identity(1,1) primary key,id int references vehicle(id),vehicles int,address1 varchar(30) )
insert into vehicle values('scoda',20);
insert into vehicle values('tata',20);
insert into vehicle values('tvs',20);
insert into vehicle values('honda',20);
alter proc sp_details(@type varchar(30))
as
begin
select * from vehicle where type=@type
end
select* from vehicle
select* from booking
delete from booking where id=1
alter proc sp_add(@book_id int out,@id int, @vehicles int,@address1 varchar(30))
as
begin
insert into booking values(@id,@vehicles,@address1)
set @book_id=SCOPE_IDENTITY();
update vehicle set num1=num1-@vehicles where id=@id
end
alter vehicle set num1=num1-1 where id=1;

select v.* from booking b  cross join vehicle v  where v.id != b.id