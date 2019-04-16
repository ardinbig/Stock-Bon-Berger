
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
		CONSTRAINT unique_categClient UNIQUE (designation)
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
	prix DOUBLE,
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
	prix DOUBLE,
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
	prix DOUBLE,
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
	mode_paiement UNIQUEIDENTIFIER NOT NULL
	montant_paye DOUBLE,
	agent agent NVARCHAR(20) NOT NULL,
		CONSTRAINT fk_pmt_vente FOREIGN KEY (code_vente)
			REFERENCES tVente(code_guid),
		CONSTRAINT fk_pmt_modePmt FOREIGN KEY (mode_paiement)
			REFERENCES tModePaiement(code_guid)
)
GO





