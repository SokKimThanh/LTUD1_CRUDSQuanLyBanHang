-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_update.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_update
	-- Add the parameters for the stored procedure here
	@ma varchar(11), 
	@ten varchar(255), 
	@gia decimal, 
	@soluong int,
	@loaisanpham varchar(11),
	@nhacungcap varchar(11)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update product set ten = @ten, gia=@gia,soluong=@soluong, loaisanpham = @loaisanpham, nhacungcap=@nhacungcap where ma=@ma
END
GO
