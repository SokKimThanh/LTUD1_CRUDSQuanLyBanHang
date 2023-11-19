-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_nhacungcap_cbo.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_nhacungcap_cbo
	-- Add the parameters for the stored procedure here
	--@ma varchar(11),@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select ma, ten from nhacungcap
END
GO
