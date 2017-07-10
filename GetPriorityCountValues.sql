
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Arpitha,Patel>
-- Create date: <12-19-2015>
-- Description:	<Graph data>
-- =============================================
CREATE PROCEDURE GetPriorityCountValues
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	Select Priority , count(Priority) as Priority_Count from dbo.Dallas_Police_Active_Calls group by Priority

END
GO
