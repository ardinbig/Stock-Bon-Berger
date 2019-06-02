
USE master
GO

IF EXISTS(SELECT * FROM sys.databases where name='StockBonBerger_DB')
	DROP DATABASE StockBonBerger_DB
GO

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
		CONSTRAINT unique_fss UNIQUE (noms, adresse, phone, email)
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
	agent NVARCHAR(40) NOT NULL,
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
	etat NVARCHAR(10) DEFAULT 'false',
	date_livraison DATETIME NOT NULL,
	agent NVARCHAR(40) NOT NULL,
		CONSTRAINT fk_cmd_client FOREIGN KEY (code_client)
			REFERENCES tClient(code_guid),
		CONSTRAINT chk_date_livraison CHECK (date_livraison >= GETDATE())
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
	agent NVARCHAR(40) NOT NULL,
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
	agent NVARCHAR(40) NOT NULL,
		CONSTRAINT fk_pmt_mode_pmt FOREIGN KEY (code_mode_pmt)
			REFERENCES tModePaiement(code_guid),
		CONSTRAINT fk_pmt_vente FOREIGN KEY (code_vente)
			REFERENCES tVente(code_guid)
)
GO

--- Table Historique ---

CREATE TABLE tHistoriqueVente
(
	code_guid UNIQUEIDENTIFIER,
	date_vente DATETIME,
	code_client UNIQUEIDENTIFIER,
	agent NVARCHAR(40),
	utilisateur NVARCHAR(40),
	operation NVARCHAR(40),
	date_operation DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE tHistoriqueVenteDetail
(
	code_guid UNIQUEIDENTIFIER,
	code_vente UNIQUEIDENTIFIER,
	code_piece UNIQUEIDENTIFIER,
	quantite INT,
	prix FLOAT,
	utilisateur NVARCHAR(40),
	operation NVARCHAR(40),
	date_operation DATETIME DEFAULT GETDATE()
)
GO

CREATE TABLE tHistoriquePaiement
(
	code_guid UNIQUEIDENTIFIER,
	code_vente UNIQUEIDENTIFIER,
	montant_paye FLOAT,
	code_mode_pmt UNIQUEIDENTIFIER,
	agent NVARCHAR(40),
	utilisateur NVARCHAR(40),
	operation NVARCHAR(40),
	date_operation DATETIME DEFAULT GETDATE()
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
	DECLARE @current_quantite INT;
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_vente UNIQUEIDENTIFIER;
	DECLARE @code_guid_piece UNIQUEIDENTIFIER;

	SELECT @code_guid_vente = code_guid FROM tVente WHERE id = @code_vente;
	SELECT @code_guid_piece = code_guid FROM tPiece WHERE id = @code_piece;
    SELECT @current_code = code_guid FROM tVente WHERE id = @code;
	SELECT @stock = en_stock FROM tPiece WHERE code_guid = @code_guid_piece;
	SELECT @current_quantite = quantite FROM tDetailVente WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        IF (@stock != 0 AND @stock >= @quantite)
		BEGIN
			INSERT INTO tDetailVente(code_guid, code_vente, code_piece, quantite, prix) 
			VALUES (NEWID(), @code_guid_vente, @code_guid_piece, @quantite, @prix);

			UPDATE tPiece SET en_stock = @stock - @quantite WHERE code_guid = @code_guid_piece;
		END
    END

    ELSE IF (@action = 2)       
    BEGIN
		IF (@stock != 0 AND @stock >= @quantite)
		BEGIN
			UPDATE tDetailVente SET code_vente = @code_guid_vente,
			code_piece = @code_guid_piece, quantite = @quantite,
			prix = @prix WHERE code_guid = @current_code;

			UPDATE tPiece SET en_stock = (@stock + @current_quantite) - @quantite WHERE code_guid = @code_guid_piece;
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
	DECLARE @current_quantite INT;
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_approv UNIQUEIDENTIFIER;
	DECLARE @code_guid_piece UNIQUEIDENTIFIER;
	
	SELECT @code_guid_approv = code_guid FROM tApprov WHERE id = @code_approv;
	SELECT @code_guid_piece = code_guid FROM tPiece WHERE id = @code_piece;
    SELECT @current_code = code_guid FROM tDetailApprov WHERE id = @code;
	SELECT @stock = en_stock FROM tPiece WHERE code_guid = @code_guid_piece;
	SELECT @current_quantite = quantite FROM tDetailApprov WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        INSERT INTO tDetailApprov(code_guid, code_approv, code_piece, quantite, prix) 
			VALUES (NEWID(), @code_guid_approv, @code_guid_piece, @quantite, @prix);

		UPDATE tPiece SET en_stock = @quantite + @stock WHERE code_guid = @code_guid_piece;
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tDetailApprov SET code_approv = @code_guid_approv,
			code_piece = @code_guid_piece, quantite = @quantite,
			prix = @prix WHERE code_guid = @current_code;

		UPDATE tPiece SET en_stock = (@stock - @current_quantite) + @quantite WHERE code_guid = @code_guid_piece;
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

CREATE PROCEDURE sp_merge_cmd
(
    @code BIGINT,
    @code_client BIGINT,
	@agent NVARCHAR(100),
	@etat NVARCHAR(10),
	@date_livraison DATETIME,
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
        INSERT INTO tCommande (code_guid, date_cmd, code_client, agent, etat, date_livraison) 
			VALUES (NEWID(), GETDATE() ,@code_guid_client, @agent, @etat, @date_livraison)
    END

    ELSE IF (@action = 2)       
    BEGIN
		UPDATE tCommande SET code_client = @code_guid_client, etat = @etat, date_livraison = @date_livraison,
			agent = @agent, date_cmd = GETDATE() WHERE code_guid = @current_code
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tCommande WHERE code_guid = @current_code
    END
END
GO

-- TODO: Analyser le traitement

CREATE PROCEDURE sp_merge_detail_cmd
(
    @code BIGINT,
    @code_cmd BIGINT,
	@code_piece BIGINT,
	@quantite INT,
	@prix FLOAT,
    @action INT
)
AS
	DECLARE @stock INT;
	DECLARE @current_quantite INT;
    DECLARE @current_code UNIQUEIDENTIFIER;
	DECLARE @code_guid_cmd UNIQUEIDENTIFIER;
	DECLARE @code_guid_piece UNIQUEIDENTIFIER;

	SELECT @code_guid_cmd = code_guid FROM tVente WHERE id = @code_cmd;
	SELECT @code_guid_piece = code_guid FROM tPiece WHERE id = @code_piece;
    SELECT @current_code = code_guid FROM tVente WHERE id = @code;
	SELECT @stock = en_stock FROM tPiece WHERE code_guid = @code_guid_piece;
	SELECT @current_quantite = quantite FROM tDetailCommande WHERE id = @code;
BEGIN
    IF (@action = 1)
    BEGIN
        IF (@stock != 0 AND @stock >= @quantite)
		BEGIN
			INSERT INTO tDetailCommande(code_guid, code_cmd, code_piece, quantite, prix) 
			VALUES (NEWID(), @code_guid_cmd, @code_guid_piece, @quantite, @prix);

			UPDATE tPiece SET en_stock = @stock - @quantite WHERE code_guid = @code_guid_piece;
		END
    END

    ELSE IF (@action = 2)       
    BEGIN
		IF (@stock != 0 AND @stock >= @quantite)
		BEGIN
			UPDATE tDetailCommande SET code_cmd = @code_guid_cmd,
			code_piece = @code_guid_piece, quantite = @quantite,
			prix = @prix WHERE code_guid = @current_code;

			UPDATE tPiece SET en_stock = (@stock + @current_quantite) - @quantite WHERE code_guid = @code_guid_piece;
		END
    END

    ELSE IF (@action = 3)
    BEGIN
		DELETE FROM tDetailCommande WHERE code_guid = @current_code
    END
END
GO

--- TRIGGERS ---

CREATE TRIGGER tg_retreive_stock_delete_approv ON tDetailApprov AFTER DELETE
AS
	DECLARE @current_stock INT;
	DECLARE @quantity_deleted INT;
	DECLARE @current_piece_code UNIQUEIDENTIFIER;

	SELECT @current_piece_code = code_piece FROM deleted;
	SELECT @quantity_deleted = quantite FROM deleted;
	SELECT @current_stock = en_stock FROM tPiece WHERE code_guid = @current_piece_code;
BEGIN
	UPDATE tPiece SET en_stock = @current_stock - @quantity_deleted WHERE code_guid = @current_piece_code;
END
GO

CREATE TRIGGER tg_retreive_stock_delete_vente ON tDetailVente AFTER DELETE
AS
	DECLARE @current_stock INT;
	DECLARE @quantity_deleted INT;
	DECLARE @current_piece_code UNIQUEIDENTIFIER;

	SELECT @current_piece_code = code_piece FROM deleted;
	SELECT @quantity_deleted = quantite FROM deleted;
	SELECT @current_stock = en_stock FROM tPiece WHERE code_guid = @current_piece_code;
BEGIN
	UPDATE tPiece SET en_stock = @current_stock + @quantity_deleted WHERE code_guid = @current_piece_code;
END
GO

CREATE TRIGGER tg_historique_paiement_delete ON tPaiement AFTER DELETE
AS
BEGIN
	INSERT INTO tHistoriquePaiement (code_guid, code_vente, montant_paye, code_mode_pmt, agent, utilisateur, operation)
		(SELECT code_guid, code_vente, montant_paye, code_mode_pmt, agent, (SELECT SYSTEM_USER), 'DELETE' FROM deleted)
END
GO

CREATE TRIGGER tg_historique_paiement_update ON tPaiement AFTER UPDATE
AS
BEGIN
	INSERT INTO tHistoriquePaiement (code_guid, code_vente, montant_paye, code_mode_pmt, agent, utilisateur, operation)
		(SELECT code_guid, code_vente, montant_paye, code_mode_pmt, agent, (SELECT SYSTEM_USER), 'UPDATE' FROM deleted)
END
GO

CREATE TRIGGER tg_historique_vente_delete ON tVente AFTER DELETE
AS
BEGIN
	INSERT INTO tHistoriqueVente(code_guid, date_vente, code_client, agent, utilisateur, operation)
		(SELECT code_guid, date_vente, code_client, agent, (SELECT SYSTEM_USER), 'DELETE' FROM deleted)
END
GO

CREATE TRIGGER tg_historique_vente_update ON tVente AFTER UPDATE
AS
BEGIN
	INSERT INTO tHistoriqueVente(code_guid, date_vente, code_client, agent, utilisateur, operation)
		(SELECT code_guid, date_vente, code_client, agent, (SELECT SYSTEM_USER), 'UPDATE' FROM deleted)
END
GO

CREATE TRIGGER tg_historique_vente_detail_delete ON tDetailVente AFTER DELETE
AS
BEGIN
	INSERT INTO tHistoriqueVenteDetail(code_guid, code_vente, code_piece, quantite, prix, utilisateur, operation)
		(SELECT code_guid, code_vente, code_piece, quantite, prix, (SELECT SYSTEM_USER), 'DELETE' FROM deleted)
END
GO

CREATE TRIGGER tg_historique_vente_detail_update ON tDetailVente AFTER UPDATE
AS
BEGIN
	INSERT INTO tHistoriqueVenteDetail(code_guid, code_vente, code_piece, quantite, prix, utilisateur, operation)
		(SELECT code_guid, code_vente, code_piece, quantite, prix, (SELECT SYSTEM_USER), 'UPDATE' FROM deleted)
END
GO

--- AUTRES PROCEDURES ---

SELECT name FROM sys.tables


--- FONCTIONS ---

--CREATE FUNCTION func_get_code_guid(@table NVARCHAR(40), @id INT) RETURNS UNIQUEIDENTIFIER
--AS
--BEGIN
--	DECLARE @my_table 
--	DECLARE @code UNIQUEIDENTIFIER
--	SELECT @code = 'code_guid' FROM  WHERE @id = @code
--	RETURN @code
--END
--GO

--- VIEWS ---

CREATE VIEW v_list_clients AS
SELECT tClient.code_guid as code_client, tClient.id as idClient, noms, designation as categorie, phone, email, adresse FROM tClient
INNER JOIN tCategClient ON tCategClient.code_guid = tClient.code_categorie
GO

CREATE VIEW v_list_pieces AS
SELECT tPiece.code_guid as code_piece, tPiece.designation, tCategPiece.designation as categorie, numero_serie, lieu_fabrication, usage, en_stock as quantite FROM tPiece
INNER JOIN tCategPiece ON tCategPiece.code_guid = tPiece.code_categorie
GO

CREATE VIEW v_detail_paiement AS
SELECT code_vente, tPaiement.code_guid as numero_recu, noms, montant_paye, tModePaiement.designation as mode_paiement, tPaiement.agent 
	FROM tPaiement
INNER JOIN tVente ON tVente.code_guid = tPaiement.code_vente
INNER JOIN tModePaiement ON tModePaiement.code_guid = tPaiement.code_mode_pmt
INNER JOIN tClient ON tClient.code_guid = tVente.code_client
GO

CREATE VIEW v_amount_to_pay AS
SELECT tVente.code_guid, SUM(prix * quantite) AS dette FROM tVente
INNER JOIN tDetailVente on tDetailVente.code_vente = tVente.code_guid
GROUP BY tVente.code_guid
GO

CREATE VIEW v_amout_paid AS
SELECT tVente.code_guid, sum(montant_paye) as total_paye from tPaiement
INNER JOIN tVente on tVente.code_guid = tPaiement.code_vente
GROUP BY tVente.code_guid
GO

--- GESTION DES UTILISATEURS ---

CREATE TABLE tUtilisateur
(
	id BIGINT IDENTITY(1,1),
	code_guid UNIQUEIDENTIFIER PRIMARY KEY,
	noms_agent NVARCHAR(40) NOT NULL,
	nom_utilisateur NVARCHAR(40) NOT NULL,
	mot_de_passe NVARCHAR(1000) NOT NULL,
	droits NVARCHAR(300) DEFAULT 'Aucun',
	actif BIT,
		CONSTRAINT unique_user UNIQUE (noms_agent, nom_utilisateur)
)
GO

CREATE PROCEDURE sp_merge_utilisateur
(
	@code BIGINT,
	@noms_agent NVARCHAR(40),
	@nom_utilisateur  NVARCHAR(40),
	@mot_de_passe  NVARCHAR(1000),
	@droits  NVARCHAR(300),
	@actif BIT,
	@action INT
)
AS
	DECLARE @current_code UNIQUEIDENTIFIER;
	SELECT @current_code = code_guid FROM tUtilisateur WHERE id = @code;
BEGIN
	IF (@action = 1)
	BEGIN
		INSERT INTO tUtilisateur (code_guid, noms_agent, nom_utilisateur, mot_de_passe, droits, actif) VALUES
			(NEWID(), @noms_agent, @nom_utilisateur, @mot_de_passe, @droits, @actif)
	END
		
	ELSE IF (@action = 2)
	BEGIN
		UPDATE tUtilisateur SET noms_agent = @noms_agent, nom_utilisateur = @nom_utilisateur, mot_de_passe = @mot_de_passe, droits = @droits,
			actif = @actif WHERE code_guid = @current_code
	END

	ELSE IF(@action = 3)
	BEGIN
		DELETE FROM tUtilisateur WHERE code_guid = @current_code
	END
END	
GO










--- TEST ---

select numero_recu,v_detail_paiement.code_vente as codeVente,noms,montant_paye,
mode_paiement,agent,total_paye,dette,(dette-total_paye) as reste from v_detail_paiement
inner join v_amout_paid on v_amout_paid.code_guid=v_detail_paiement.code_vente
inner join v_amount_to_pay on v_amount_to_pay.code_guid=v_detail_paiement.code_vente

HASHBYTES('sha2_512', @motDePasse)

EXEC sp_merge_piece 2, 'Filtre à huile', 9, 'KLD08324', 'chine', 'piece de rechange', 2
SELECT * FROM tPiece

EXEC sp_merge_approv 2, 1, Pauline, 3
SELECT * FROM tPiece
SELECT * FROM tApprov

EXEC sp_merge_detail_approv 1, 2, 4, 40, 50, 1

SELECT * FROM tApprov
SELECT * FROM tPiece
SELECT * FROM tDetailApprov

TRUNCATE TABLE tDetailApprov

EXEC sp_merge_paiement 0,1,1,6, 'PAULINE', 1
SELECT * FROM tPaiement
SELECT * FROm tClient

EXEC sp_merge_vente 0, 1, 'DEVOTE',1
SELECT * FROM tVente
EXEC sp_merge_detail_vente 7, 3,1, 5, 40, 2
SELECT * FROM tDetailVente
SELECT * FROM tPiece

SELECT sum(quantite) FROM tDetailApprov WHERE code_approv = 'B50D10A3-4CA4-4362-B782-FF163854ADB9'



USE master
SELECT SYSTEM_USER


select * from v_list_clients

