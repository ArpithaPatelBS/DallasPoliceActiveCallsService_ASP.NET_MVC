
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Arpitha,,Patel>
-- Create date: <12-19-2015>
-- Description:	<Delete the row>
-- =============================================
CREATE PROCEDURE DeleteData
	@IncidentNumber nvarchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statements for procedure here
	 DELETE dbo.Dallas_Police_Active_Calls
     FROM   dbo.Dallas_Police_Active_Calls
     WHERE  
     IncidentNumber = @IncidentNumber
END
GO
