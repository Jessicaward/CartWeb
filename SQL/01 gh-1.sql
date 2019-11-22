create table Account
(
    ID int primary key identity(1,1) not null,
    [FirstName] varchar(max) not null,
    [LastName] varchar(max) not null,
    Username varchar(max) not null,
    [Password] varchar(max) not null,
    [Status] int not null,
    EmailAddress varchar(max) not null,
    EmailConfirmed bit not null
);

create table Family
(
    ID int primary key identity(1,1) not null,
    [Name] varchar(max) not null,
    [Status] int not null
);

create table AccountFamily
(
    ID int primary key identity(1,1) not null,
    IsAdmin bit not null,
    AccountId int not null,
    FamilyId int not null,
    FOREIGN KEY (AccountId) REFERENCES Account(Id),
    FOREIGN KEY (FamilyId) REFERENCES Family(Id)
);

create table ShoppingList
(
    ID int primary key identity(1,1) not null,
    [Name] varchar(max) not null,
    Colour varchar(10) not null,
    FamilyId int not null,
    foreign key (FamilyId) references Family(Id)
);

create table ShoppingListItem
(
    ID int primary key identity (1,1) not null,
    ShoppingListId int not null,
    [Name] varchar(max) not null,
    CheckedState bit not null,
    foreign key (ShoppingListId) references ShoppingList(id)
);