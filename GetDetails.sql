USE [DallasPolice]
GO
/****** Object:  StoredProcedure [dbo].[GetData]    Script Date: 12/19/2015 3:26:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Arpitha,,Patel>
-- Create date: <dec 12, 2015,>
-- Description:	<Selects Details of the parameters from Dallas Active Calls>
-- =============================================
Create PROCEDURE [dbo].[GetDetails]
@IncidentNumber nvarchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.Dallas_Police_Active_Calls where  IncidentNumber = @IncidentNumber
END
