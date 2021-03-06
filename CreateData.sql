USE [DallasPolice]
GO
/****** Object:  StoredProcedure [dbo].[CreateData]    Script Date: 12/19/2015 2:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Arpitha,,Patel>
-- Create date: <12-9-2015,,>
-- Description:	<Create Procedre for entering data>
-- =============================================
CREATE PROCEDURE [dbo].[CreateData]
	@IncidentNumber nvarchar(255),
	@Division nvarchar(255),
	@NatureOfCall nvarchar(255),
	@Priority nvarchar(255),
	@DateTime datetime,
	@UnitNumber nvarchar(255),
	@Block nvarchar(255),
	@Location nvarchar(255),
	@Beat nvarchar(255),
	@ReportingArea nvarchar(255),
	@Status nvarchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Dallas_Police_Active_Calls
          ( 
		  IncidentNumber,
	Division,
	NatureOfCall,
	Priority,
	DateTime,
	UnitNumber,
	Block,
	Location,
	Beat,
	ReportingArea,
	Status
		  )
		   VALUES 
          ( 
		  @IncidentNumber,
	@Division,
	@NatureOfCall,
	@Priority,
	@DateTime,
	@UnitNumber,
	@Block,
	@Location,
	@Beat,
	@ReportingArea,
	@Status
		  )
END
