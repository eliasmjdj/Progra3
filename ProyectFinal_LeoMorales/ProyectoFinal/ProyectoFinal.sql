CREATE DATABASE AeroPuerto_JSTM
GO

USE AeroPuerto_JSTM
GO
--Creacion de la tabla pasajero

CREATE TABLE Administ(
  ID INT IDENTITY(1,1) PRIMARY KEY,
  UserName VARCHAR(12) NOT NULL,
  Gmail VARCHAR(50) NOT NULL,
  PasswordUser VARCHAR(100) NOT NULL
)
GO
--Creacion de la tabla pasajero
CREATE TABLE Pasajero (
    PasajeroID INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Nacionalidad VARCHAR(50) NOT NULL,
    Destino VARCHAR(100) NOT NULL,
    NumeroPasaporte VARCHAR(20) NOT NULL,
    NumeroTiquete VARCHAR(20) NOT NULL,
    PrecioTiquete DECIMAL(10, 2) NOT NULL,
    HoraAtencion TIME NOT NULL,
    FechaSalida DATE NOT NULL,
);

--Creacion de las tablas para las posibles ventanillas
CREATE TABLE Ventanillas (
    VentanillaID INT PRIMARY KEY,
    EmpleadoNombre VARCHAR(100) NOT NULL,
    NumeroCedula INT NOT NULL,
    HoraApertura TIME NOT NULL,
    LineaAerea VARCHAR(100) NOT NULL,
    DestinoVuelo VARCHAR(100) NOT NULL,
    NumeroVuelo INT NOT NULL,
);
--Creacion de la tabla atencion de pasajeros
CREATE TABLE AtencionPasajero (
    AtencionID INT PRIMARY KEY,
    PasajeroID INT FOREIGN KEY REFERENCES Pasajero(PasajeroID),
    VentanillaID INT FOREIGN KEY REFERENCES Ventanillas(VentanillaID),
    NumeroAsiento INT NOT NULL,
    CiudadEscala VARCHAR(100) NOT NULL
);

--La tabla de creacion de aviones
CREATE TABLE Avion (
    AvionID INT PRIMARY KEY,
	NumeroSerie VARCHAR(50) NOT NULL,
    MarcaAvion VARCHAR(50) NOT NULL,
    LineaAerea VARCHAR(100) NOT NULL,
    Capacidad INT NOT NULL,
    NombrePiloto VARCHAR(100) NOT NULL,
    CiudadOrigen VARCHAR(100) NOT NULL,
    CiudadDestino VARCHAR(100) NOT NULL,
    HoraSalida DATETIME NOT NULL,
    HoraLlegada DATETIME NOT NULL,
    Escala BIT NOT NULL,
    CiudadesEscalas VARCHAR(200) -- Puedes ajustar según la cantidad de ciudades escalas
);
GO

--Procedimiento almacenado para los registro

--SP Para registro de Pasajero
CREATE PROCEDURE InsertarPasajero (
    @Nombre VARCHAR(100),
    @Nacionalidad VARCHAR(50),
    @Destino VARCHAR(100),
    @NumeroPasaporte VARCHAR(20),
    @NumeroTiquete VARCHAR(20),
    @PrecioTiquete DECIMAL(10, 2),
    @HoraAtencion TIME,
    @FechaSalida DATE
)
AS
BEGIN
    -- Verificar si ya existe un pasajero con el mismo número de pasaporte o número de tiquete
    IF NOT EXISTS (
        SELECT 1 FROM Pasajero 
        WHERE NumeroPasaporte = @NumeroPasaporte OR NumeroTiquete = @NumeroTiquete
    )
    BEGIN
        -- Si no existe, realizar la inserción
        INSERT INTO Pasajero (Nombre, Nacionalidad, Destino, NumeroPasaporte, NumeroTiquete, PrecioTiquete, HoraAtencion, FechaSalida)
        VALUES (@Nombre, @Nacionalidad, @Destino, @NumeroPasaporte, @NumeroTiquete, @PrecioTiquete, @HoraAtencion, @FechaSalida);

        PRINT 'Pasajero insertado correctamente.';
    END
    ELSE
    BEGIN
        -- Si ya existe, mostrar un mensaje de error
        PRINT 'Error: Ya existe un pasajero con el mismo número de pasaporte o número de tiquete.';
    END
END;
GO
CREATE PROCEDURE RegistrarAdmin (
    @NombreUsuario VARCHAR(50),
    @CorreoElectronico VARCHAR(100),
    @Contraseña VARCHAR(50)
)
AS
BEGIN
    -- Verificar si ya existe un usuario con el mismo correo electrónico
    IF NOT EXISTS (
        SELECT 1 FROM Administ
        WHERE Gmail = @CorreoElectronico
    )
    BEGIN
        -- Si no existe, realizar la inserción
        INSERT INTO Administ(UserName,Gmail,PasswordUser)
        VALUES (@NombreUsuario, @CorreoElectronico, @Contraseña);

        PRINT 'Administrador registrado correctamente.';
    END
    ELSE
    BEGIN
        -- Si ya existe, mostrar un mensaje de error
        PRINT 'Error: Ya existe un administrador con el mismo correo electrónico.';
    END
END;
GO
--SP que permite la creacion de solamente 4 ventanillas

CREATE PROCEDURE RegistrarVentanilla (
    @IDVentanilla INT,
    @EmpleadoNombre VARCHAR(100),
    @NumeroCedula VARCHAR(20),
    @HoraApertura TIME,
    @LineaAerea VARCHAR(100),
    @DestinoVuelo VARCHAR(100),
    @NumeroVuelo INT
)
AS
BEGIN
    -- Verificar si ya existen 4 ventanillas registradas
    IF (SELECT COUNT(*) FROM Ventanillas) < 4
    BEGIN
        -- Si no se excede el límite, realizar la inserción
        INSERT INTO Ventanillas (VentanillaID,EmpleadoNombre, NumeroCedula, HoraApertura, LineaAerea, DestinoVuelo, NumeroVuelo)
        VALUES (@IDVentanilla,@EmpleadoNombre, @NumeroCedula, @HoraApertura, @LineaAerea, @DestinoVuelo, @NumeroVuelo);

        PRINT 'Ventanilla registrada correctamente.';
    END
    ELSE
    BEGIN
        -- Si ya existen 4 ventanillas, mostrar un mensaje de error
        PRINT 'Error: No se pueden registrar más de 4 ventanillas.';
    END
END;
GO
---Este procedimiento almacenado permite registrar aviones, pero tambien verificando que este no se encuentre resgitrado
CREATE PROCEDURE RegistrarAvion (
    @NumeroSerie VARCHAR(50),
    @MarcaAvion VARCHAR(50),
    @LineaAerea VARCHAR(100),
    @Capacidad INT,
    @NombrePiloto VARCHAR(100),
    @CiudadOrigen VARCHAR(100),
    @CiudadDestino VARCHAR(100),
    @HoraSalida DATETIME,
    @HoraLlegada DATETIME,
    @Escala BIT,
    @CiudadesEscalas VARCHAR(200)
)
AS
BEGIN
    -- Verificar si ya existe un avión con el mismo número de serie
    IF NOT EXISTS (
        SELECT 1 FROM Avion
        WHERE NumeroSerie = @NumeroSerie
    )
    BEGIN
        -- Si no existe, realizar la inserción
        INSERT INTO Avion (
            NumeroSerie, MarcaAvion, LineaAerea, Capacidad, NombrePiloto,
            CiudadOrigen, CiudadDestino, HoraSalida, HoraLlegada, Escala, CiudadesEscalas
        )
        VALUES (
            @NumeroSerie, @MarcaAvion, @LineaAerea, @Capacidad, @NombrePiloto,
            @CiudadOrigen, @CiudadDestino, @HoraSalida, @HoraLlegada, @Escala, @CiudadesEscalas
        );

        PRINT 'Avión registrado correctamente.';
    END
    ELSE
    BEGIN
        -- Si ya existe un avión con el mismo número de serie, mostrar un mensaje de error
        PRINT 'Error: Ya existe un avión con el mismo número de serie.';
    END
END;
GO
--Funciones PARA EL ADMINISTRADOR

--Función para obtener la cantidad de vuelos y destinos atendidos por una ventanilla hasta una hora determinada
CREATE FUNCTION ObtenerInfoVuelosDestinos (
    @VentanillaID INT,
    @HoraLimite TIME
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        COUNT(DISTINCT v.NumeroVuelo) AS CantidadVuelos,
        COUNT(DISTINCT v.DestinoVuelo) AS CantidadDestinos
    FROM Ventanillas v
	  

    WHERE v.VentanillaID = @VentanillaID
        AND v.HoraApertura <= @HoraLimite
);
GO

--Función para calcular la cantidad monetaria recolectada en un determinado vuelo o
--en todos los vuelos atendidos por una ventanilla hasta cierto momento

CREATE FUNCTION ObtenerRecaudacionMonetaria (
    @VentanillaID INT,
    @NumeroVuelo INT = NULL,
    @HoraCorte TIME = NULL
)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @Recaudacion DECIMAL(10, 2);

    SELECT @Recaudacion = SUM(PrecioTiquete)
    FROM AtencionPasajero a
         INNER JOIN Ventanillas v ON a.VentanillaID = v.VentanillaID
         INNER JOIN Pasajero p ON a.PasajeroID = p.PasajeroID
    WHERE v.VentanillaID = @VentanillaID
        AND (@NumeroVuelo IS NULL OR v.NumeroVuelo = @NumeroVuelo)
        AND (@HoraCorte IS NULL OR v.HoraApertura <= @HoraCorte);

    RETURN ISNULL(@Recaudacion, 0);
END;
GO
--Función para obtener cortes de vuelos, destinos y económicos para una ventanilla, todas o algunas
CREATE FUNCTION ObtenerCortes (
    @VentanillaID INT = NULL,
    @NumeroVuelo INT = NULL,
    @HoraLimite TIME = NULL
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        v.VentanillaID,
        v.NumeroVuelo,
        v.DestinoVuelo,
        SUM(PrecioTiquete) AS Recaudacion
    FROM AtencionPasajero a
	INNER JOIN Ventanillas v ON a.VentanillaID=v.VentanillaID
	INNER JOIN Pasajero p ON a.PasajeroID=p.PasajeroID
    WHERE (@VentanillaID IS NULL OR a.VentanillaID = @VentanillaID)
        AND (@NumeroVuelo IS NULL OR v.NumeroVuelo = @NumeroVuelo)
        AND (@HoraLimite IS NULL OR v.HoraApertura <= @HoraLimite)
    GROUP BY v.VentanillaID, v.NumeroVuelo, v.DestinoVuelo
);
GO

--Función para obtener la cantidad y nombres de pasajeros que abordaron un vuelo (avión)
CREATE FUNCTION ObtenerInfoPasajerosVuelo (
    @NumeroVuelo INT 
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        COUNT(*) AS CantidadPasajeros,
        STRING_AGG(Nombre, ', ') AS NombresPasajeros
    FROM AtencionPasajero a
	INNER JOIN Pasajero p ON a.PasajeroID=p.PasajeroID
	INNER JOIN Ventanillas v ON a.VentanillaID=v.VentanillaID
    WHERE NumeroVuelo = @NumeroVuelo
);
GO
-- Función para obtener pasajeros que se bajaron en una escala
CREATE FUNCTION ObtenerPasajerosEnEscala (
    @CiudadEscala VARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        p.*,
        ap.NumeroAsiento
    FROM 
        Pasajero p
    JOIN 
        AtencionPasajero ap ON p.PasajeroID = ap.PasajeroID
    WHERE 
        ap.CiudadEscala = @CiudadEscala
);
GO

--Función para obtener pasajeros que llegaron al destino original del vuelo
CREATE FUNCTION ObtenerPasajerosDestinoOriginal (
    @CiudadDestino VARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        p.*,
        ap.NumeroAsiento
    FROM 
        Pasajero p
    JOIN 
        AtencionPasajero ap ON p.PasajeroID = ap.PasajeroID
    WHERE 
        ap.CiudadEscala IS NULL  -- Sin escala, llegaron al destino original
        AND P.Destino = @CiudadDestino
);
GO
--Prueba de uso de las funciones 

-- 1
DECLARE @Resultado TABLE (CantidadVuelos INT, CantidadDestinos INT);

INSERT INTO @Resultado
SELECT * FROM ObtenerInfoVuelosDestinos(2, '12:00:00');

SELECT * FROM @Resultado;

--2
SELECT dbo.ObtenerRecaudacionMonetaria(1, 101, '15:30:00') AS Recaudacion;
-- 3
SELECT * FROM ObtenerCortes(1, NULL, '15:00:00');

-- 4
DECLARE @InfoPasajeros TABLE (CantidadPasajeros INT, NombresPasajeros VARCHAR(MAX));

INSERT INTO @InfoPasajeros
SELECT * FROM ObtenerInfoPasajerosVuelo(101);

SELECT * FROM @InfoPasajeros;
-- 5
SELECT * FROM ObtenerPasajerosEnEscala('Ciudad B');

-- 6
SELECT * FROM ObtenerPasajerosDestinoOriginal('Ciudad Y');
GO
---SP para login de Administrador
CREATE PROCEDURE LoginAdminist (
    @NombreUsuario VARCHAR(50),
    @Contraseña VARCHAR(50)
)
AS
BEGIN
    -- Verificar si el administrador existe y las credenciales son correctas
    IF EXISTS (
        SELECT 1
        FROM Administ
        WHERE UserName = @NombreUsuario AND PasswordUser = @Contraseña
    )
    BEGIN
        PRINT 'Inicio de sesión exitoso para el administrador.';
        -- Puedes agregar lógica adicional aquí, como registrar la hora de inicio de sesión, etc.
    END
    ELSE
    BEGIN
        PRINT 'Error: Nombre de usuario o contraseña incorrectos.';
        -- Puedes manejar la lógica de errores de acuerdo a tus necesidades
    END
END;
GO



EXEC RegistrarAdmin 'Juan','Juan123@gmail.com','123ghjK456'