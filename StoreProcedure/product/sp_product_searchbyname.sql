-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_searchbyname.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- tạo lại procedure
drop procedure if exists sp_product_searchbyname
go

CREATE PROCEDURE sp_product_searchbyname
	-- Add the parameters for the stored procedure here
	--@ma varchar(11) --,
	@ten varchar(255) --,@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product where ten like N'%' + @ten + '%'

END
GO
