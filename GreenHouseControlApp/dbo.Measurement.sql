CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TempeatureMeasured] FLOAT NOT NULL, 
    [TemperatureSet] FLOAT NOT NULL, 
    [HumidityMeasured] FLOAT NOT NULL, 
    [HumiditySet] FLOAT NOT NULL, 
    [TimeOfMeasurement] TIME NOT NULL
)
