
CREATE DATABASE StockBonBerger_DB
GO

USE StockBonBerger_DB
GO

--- CREATION DE TABLES ---

CREATE TABLE tFournisseur
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY,
	noms NVARCHAR(100) NOT NULL,
	phone NVARCHAR(30),
	email NVARCHAR(30),
	adresse NVARCHAR(100),
	date_maj DATETIME DEFAULT GETDATE(),
		CONSTRAINT unique_fss UNIQUE (noms)
)
GO

CREATE TABLE tCategClient
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY,
	designation NVARCHAR(100) NOT NULL,
	date_maj DATETIME DEFAULT GETDATE(),
		CONSTRAINT unique_categClient UNIQUE (designation)
)
GO

CREATE TABLE tClient
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY,
	code_categorie UNIQUEIDENTIFIER NOT NULL,
	noms NVARCHAR(100) NOT NULL,
	phone NVARCHAR(30),
	email NVARCHAR(30),
	adresse NVARCHAR(100),
	date_maj DATETIME DEFAULT GETDATE(),
		CONSTRAINT unique_client UNIQUE (noms),
		CONSTRAINT fk_client_categClient FOREIGN KEY (code_categorie)
			REFERENCES tCategClient(code_guid)
)
GO

CREATE TABLE tCategPiece
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY,
	designation NVARCHAR(100) NOT NULL,
	date_maj DATETIME DEFAULT GETDATE(),
		CONSTRAINT unique_categPiece UNIQUE (designation)
)
GO

CREATE TABLE tPiece
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY,
	designation NVARCHAR(100) NOT NULL,
	code_categorie UNIQUEIDENTIFIER NOT NULL,
	numero_serie NVARCHAR(100),
	lieu_fabrication NVARCHAR(100),
	usage NVARCHAR(100),
	en_stock INT DEFAULT 0,
		CONSTRAINT unique_piece UNIQUE (designation),
		CONSTRAINT fk_piece_categPiece FOREIGN KEY (code_categorie)
			REFERENCES tCategPiece(code_guid)
)
GO

CREATE TABLE tApprov
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY, 
	date_approv DATETIME DEFAULT GETDATE(),
	code_fss UNIQUEIDENTIFIER NOT NULL,
	agent NVARCHAR(20) NOT NULL,
		CONSTRAINT fk_approv_fss FOREIGN KEY (code_fss)
			REFERENCES tFournisseur(code_guid)
)
GO

CREATE TABLE tDetailApprov
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY, 
	code_approv UNIQUEIDENTIFIER NOT NULL,
	code_piece UNIQUEIDENTIFIER NOT NULL,
	quantite INT NOT NULL,
	prix FLOAT DEFAULT 0.0,
		CONSTRAINT fk_detailApprov_approv FOREIGN KEY (code_approv)
			REFERENCES tApprov(code_guid),
		CONSTRAINT fk_detailApprov_piece FOREIGN KEY (code_piece)
			REFERENCES tPiece(code_guid)
)
GO

CREATE TABLE tCommande 
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY, 
	date_cmd DATETIME DEFAULT GETDATE(),
	code_client UNIQUEIDENTIFIER NOT NULL,
	agent NVARCHAR(20) NOT NULL,
		CONSTRAINT fk_cmd_client FOREIGN KEY (code_client)
			REFERENCES tClient(code_guid)
)
GO

CREATE TABLE tDetailCommande
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY, 
	code_cmd UNIQUEIDENTIFIER NOT NULL,
	code_piece UNIQUEIDENTIFIER NOT NULL,
	quantite INT NOT NULL,
	prix FLOAT DEFAULT 0.0,
		CONSTRAINT fk_detailCmd_cmd FOREIGN KEY (code_cmd)
			REFERENCES tCommande(code_guid),
		CONSTRAINT fk_detailCmd_piece FOREIGN KEY (code_piece)
			REFERENCES tPiece(code_guid)
)
GO

CREATE TABLE tVente
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY, 
	date_vente DATETIME DEFAULT GETDATE(),
	code_client UNIQUEIDENTIFIER NOT NULL,
	agent NVARCHAR(20) NOT NULL,
		CONSTRAINT fk_vente_client FOREIGN KEY (code_client)
			REFERENCES tClient(code_guid)
)
GO

CREATE TABLE tDetailVente
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY, 
	code_vente UNIQUEIDENTIFIER NOT NULL,
	code_piece UNIQUEIDENTIFIER NOT NULL,
	quantite INT NOT NULL,
	prix FLOAT DEFAULT 0.0,
		CONSTRAINT fk_detailVente_vente FOREIGN KEY (code_vente)
			REFERENCES tVente(code_guid),
		CONSTRAINT fk_detailVente_piece FOREIGN KEY (code_piece)
			REFERENCES tPiece(code_guid)
)
GO

CREATE TABLE tModePaiement
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY,
	designation NVARCHAR(100) NOT NULL,
	date_maj DATETIME DEFAULT GETDATE(),
)
GO

CREATE TABLE tPaiement
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY,
	code_vente UNIQUEIDENTIFIER NOT NULL,
	montant_paye FLOAT DEFAULT 0.0,
	code_mode_pmt UNIQUEIDENTIFIER NOT NULL,
	agent NVARCHAR(20) NOT NULL,
		CONSTRAINT fk_pmt_mode_pmt FOREIGN KEY (code_mode_pmt)
			REFERENCES tModePaiement(code_guid),
		CONSTRAINT fk_pmt_vente FOREIGN KEY (code_vente)
			REFERENCES tVente(code_guid)
)
GO


--- PRECEDURES ---

CREATE PROCEDURE sp_merge_categorie_client
(
    @code BIGINT,
    @designation NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
    SELECT @current_code = code_guid FROM tCategClient WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tCategClient (code_guid, designation) VALUES (NEWID(), @designation)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tCategClient SET designation = @designation WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tCategClient WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_categorie_piece
(
    @code BIGINT,
    @designation NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
    SELECT @current_code = code_guid FROM tCategPiece WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tCategPiece (code_guid, designation) VALUES (NEWID(), @designation)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tCategPiece SET designation = @designation WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tCategPiece WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_fss
(
    @code BIGINT,
    @noms NVARCHAR(100),
	@phone NVARCHAR(30),
	@email NVARCHAR(30),
	@adresse NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
    SELECT @current_code = code_guid FROM tFournisseur WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tFournisseur (code_guid, noms, phone, email, adresse) 
			VALUES (NEWID(), @noms, @phone, @email, @adresse)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tFournisseur SET noms = @noms, phone = @phone, email = @email, adresse = @adresse
			WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tFournisseur WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_mode_pmt
(
    @code BIGINT,
    @designation NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
    SELECT @current_code = code_guid FROM tModePaiement WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tModePaiement (code_guid, designation) VALUES (NEWID(), @designation)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tModePaiement SET designation = @designation WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tModePaiement WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_client
(
    @code BIGINT,
	@code_categ INT,
    @noms NVARCHAR(100),
	@phone NVARCHAR(30),
	@email NVARCHAR(30),
	@adresse NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_categ UNIQUEIDENTIFIER;
    SELECT @current_code = code_guid FROM tClient WHERE id = @code;
	SELECT @code_guid_categ = code_guid FROM tCategClient WHERE id = @code_categ;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tClient (code_guid, code_categorie, noms, phone, email, adresse) 
			VALUES (NEWID(), @code_guid_categ, @noms, @phone, @email, @adresse)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tClient SET noms = @noms, code_categorie = @code_guid_categ, phone = @phone, email = @email, adresse = @adresse
			WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tClient WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_piece
(
    @code BIGINT,
    @designation NVARCHAR(100),
	@code_categ INT,
	@numero NVARCHAR(100),
	@lieu NVARCHAR(100),
	@usage NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_categ UNIQUEIDENTIFIER;
    SELECT @current_code = code_guid FROM tPiece WHERE id = @code;
	SELECT @code_guid_categ = code_guid FROM tCategPiece WHERE id = @code_categ;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tPiece (code_guid, code_categorie, designation, numero_serie, lieu_fabrication, usage) 
			VALUES (NEWID(), @code_guid_categ, @designation, @numero, @lieu, @usage)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tPiece SET designation = @designation, code_categorie = @code_guid_categ, numero_serie = @numero, 
			lieu_fabrication = @lieu, usage = @usage WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tPiece WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_vente
(
    @code BIGINT,
    @code_client BIGINT,
	@agent NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_client UNIQUEIDENTIFIER;
	SELECT @code_guid_client = code_guid FROM tClient WHERE id = @code_client;
    SELECT @current_code = code_guid FROM tVente WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tVente (code_guid, date_vente, code_client, agent) 
			VALUES (NEWID(), GETDATE() ,@code_guid_client, @agent)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tVente SET code_client = @code_guid_client,
			agent = @agent, date_vente = GETDATE() WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tVente WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_detail_vente
(
    @code BIGINT,
    @code_vente BIGINT,
	@code_piece BIGINT,
	@quantite INT,
	@prix FLOAT,
    @action INT
)
AS
	DECLARE @stock INT;
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_vente UNIQUEIDENTIFIER;
	DECLARE @code_guid_piece UNIQUEIDENTIFIER;

	SELECT @code_guid_vente = code_guid FROM tVente WHERE id = @code_vente;
	SELECT @code_guid_piece = code_guid FROM tPiece WHERE id = @code_piece;
    SELECT @current_code = code_guid FROM tVente WHERE id = @code;
	SELECT @stock = en_stock FROM tPiece WHERE code_guid = @code_guid_piece;
BEGIN
    IF (@action = 1)
    BEGIN
        IF (@stock != 0 AND @stock > @quantite)
		BEGIN
			INSERT INTO tDetailVente(code_guid, code_vente, code_piece, quantite, prix) 
			VALUES (NEWID(), @code_guid_vente, @code_guid_piece, @quantite, @prix);

			UPDATE tPiece SET en_stock = @stock - @quantite WHERE code_guid = @code_guid_piece;
		END
    END

    ELSE IF (@action = 2)       
    BEGIN
		IF (@stock != 0 AND @stock > @quantite)
		BEGIN
			UPDATE tDetailVente SET code_vente = @code_guid_vente,
			code_piece = @code_guid_piece, quantite = @quantite,
			prix = @prix WHERE code_guid = @current_code;

			UPDATE tPiece SET en_stock = @stock - @quantite  WHERE code_guid = @code_guid_piece;
		END
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tDetailVente WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_approv
(
    @code BIGINT,
    @code_fss BIGINT,
	@agent NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_fss UNIQUEIDENTIFIER;
	SELECT @code_guid_fss = code_guid FROM tFournisseur WHERE id = @code_fss;
    SELECT @current_code = code_guid FROM tApprov WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tApprov (code_guid, date_approv, code_fss, agent) 
			VALUES (NEWID(), GETDATE() ,@code_guid_fss, @agent)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tApprov SET code_fss = @code_guid_fss,
			agent = @agent, date_approv = GETDATE() WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tApprov WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_detail_approv
(
    @code BIGINT,
    @code_approv BIGINT,
	@code_piece BIGINT,
	@quantite INT,
	@prix FLOAT,
    @action INT
)
AS
	DECLARE @stock INT;
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_approv UNIQUEIDENTIFIER;
	DECLARE @code_guid_piece UNIQUEIDENTIFIER;
	
	SELECT @code_guid_approv = code_guid FROM tApprov WHERE id = @code_approv;
	SELECT @code_guid_piece = code_guid FROM tPiece WHERE id = @code_piece;
    SELECT @current_code = code_guid FROM tVente WHERE id = @code;
	SELECT @stock = en_stock FROM tPiece WHERE code_guid = @code_guid_piece;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tDetailApprov(code_guid, code_approv, code_piece, quantite, prix) 
			VALUES (NEWID(), @code_guid_approv, @code_guid_piece, @quantite + @stock, @prix)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tDetailApprov SET code_approv = @code_guid_approv,
			code_piece = @code_guid_piece, quantite = @quantite + @stock,
			prix = @prix WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tDetailApprov WHERE code_guid = @current_code
    END
END
GO

CREATE PROCEDURE sp_merge_paiement
(
    @code BIGINT,
    @code_vente BIGINT,
	@code_mode BIGINT,
	@montant FLOAT,
	@agent NVARCHAR(100),
    @action INT
)
AS
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_vente UNIQUEIDENTIFIER;
	DECLARE @code_guid_mode UNIQUEIDENTIFIER;

	SELECT @code_guid_vente = code_guid FROM tVente WHERE id = @code_vente;
	SELECT @code_guid_mode = code_guid FROM tModePaiement WHERE id = @code_mode;
    SELECT @current_code = code_guid FROM tVente WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tPaiement(code_guid, code_vente, montant_paye, code_mode_pmt, agent) 
			VALUES (NEWID(), @code_guid_vente, @montant, @code_guid_mode, @agent)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tPaiement SET code_vente = @code_guid_vente,
			montant_paye = @montant, code_mode_pmt = @code_guid_mode,
			@agent = @agent WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tPaiement WHERE code_guid = @current_code
    END
END
GO

