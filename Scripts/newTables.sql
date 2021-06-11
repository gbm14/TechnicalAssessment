BEGIN
	DROP TABLE IF EXISTS Users;

	CREATE TABLE Data
	(
		id INT IDENTITY PRIMARY KEY,
		extId INT NOT NULL,
		name NVARCHAR(128) NOT NULL,
		fullName NVARCHAR(128) NOT NULL,
		private bit NOT NULL,
		license NVARCHAR(128) NOT NULL
	);
END