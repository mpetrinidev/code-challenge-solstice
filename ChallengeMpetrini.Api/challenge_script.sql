USE ContactDb

INSERT INTO State ([Name]) VALUES ('AZ'), ('CA'), ('IL'), ('TX'), ('NY')

GO

INSERT INTO City (State_Id, [Name])
VALUES (1, 'Phoenix'), (2, 'Los Angeles'), (2, 'West Sacramento'), (2, 'Anaheim'), (3, 'Chicago'), (3, 'Loves Park'), (4, 'EL Paso'), (5, 'New York')