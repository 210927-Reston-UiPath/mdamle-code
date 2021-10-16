create table associates (
    associateName varchar(100) not null,
    associateLocate varchar(2) not null,
    revaPoints int not null,
    id serial primary key
);

create table trainers (
    id serial primary key,
    trainerName varchar(100) not null,
    campus varchar(3) not null,
    caffeineLevel int not null
);

create table batch(
    id serial primary key,
    associateId int references associates(id),
    trainerId int references trainers(id)
)

insert into associates (associateName, associateLocate, revaPoints) 
    values ('Robbie', 'GA', 50), 
        ('Alex', 'MN', 50), 
        ('Jacob', 'FL', 0), 
        ('Juniper', 'WA', 197), 
        ('Janel', 'AZ', 50), 
        ('James', 'PA', 18), 
        ('Phoebe', 'WA', 199);

insert into trainers (trainerName, campus, caffeineLevel) 
    values ('Marielle', 'USF', 60),
        ('Pushpinder', 'UTA', 50),
        ('Nick', 'UTA', 75),
        ('Mark', 'WVU', 16),
        ('Fred', 'UTA', 25);

insert into batch (associateID, trainerID)
    values (3,3),
        (1,4),
        (2,2),
        (4,1),
        (6,3),
        (7,1);

select * from batch;

select * from trainers;

--insert into batch (associateId, trainerId) values (10,10);
--^ insert or update on table "batch" violates foreign key constraint "batch_associateid_fkey"

select count(id), associateLocate
    from associates
    group by associateLocale
    order by count(id) desc;