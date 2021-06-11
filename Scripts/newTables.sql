BEGIN
	DROP TABLE IF EXISTS Bookmarks;

	CREATE TABLE Bookmarks
	(
		id INT IDENTITY PRIMARY KEY,
		extId INT,
		username NVARCHAR(128),
		name NVARCHAR(128),
		fullName NVARCHAR(128),
		private bit,
		license NVARCHAR(128)
	);
END