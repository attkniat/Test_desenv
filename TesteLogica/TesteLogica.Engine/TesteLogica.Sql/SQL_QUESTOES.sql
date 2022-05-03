--1. Criar query que retorne CurrencyCode  e a soma de TotalCost agrupado 
-----por CurrencyCode onde o RecordLocator seja igual a string “ABC123”.

--Localização das informações:
	--RecordLocator – Tabela Booking
	--CurrencyCode – Tabela Booking
	--TotalCost – Tabela BookingPassenger

SELECT Booking.CurrencyCode, BookingPassenger.TotalCost
FROM Booking
WHERE RecordLocator = 'ABC123'
LEFT JOIN BookingPassenger

------------------------------------------------------------------------------------

--2. Criar uma query que retorne DepartureStation, ArrivalStation e quantidade 
--de Passageiros (PassengerID) agrupados por DepartureStation e ArrivalStation 
--filtrado de acordo com a coluna DepartureDate e FlightNumber

-----DepartureDate – Tabela PassengerJourneySegment
-----DepartureStation – Tabela PassengerJourneySegment
-----ArrivalStation – Tabela PassengerJourneySegment
-----FlightNumber – Tabela PassengerJourneySegment
-----PassengerID – Tabela PassengerJourneySegment


SELECT DepartureStation, ArrivalStation,
COUNT(DISTINCT PassengerID)

	FROM PassengerJourneySegment
GROUP BY DepartureStation
GROUP BY FlightNumber

------------------------------------------------------------------------------------

--3. Tranforme a query do item 2 em uma Stored Procedure que receba como parâmetro 
--DepartureDate (obrigatório) e FlightNumber (opcional)

CREATE PROCEDURE QdtPassageiros @DepartureStation CHAR(3), @ArrivalStation CHAR(3), @CountPassageiros BIGINT4
AS
SELECT @DepartureStation = DepartureStation, 
	   @ArrivalStation = ArrivalStation,
	   @CountPassageiros = COUNT(DISTINCT PassengerID)

	FROM PassengerJourneySegment
GROUP BY DepartureStation
GROUP BY FlightNumber;