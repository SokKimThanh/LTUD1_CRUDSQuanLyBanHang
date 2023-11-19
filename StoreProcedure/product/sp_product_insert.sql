-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_insert.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- tạo lại procedure
drop procedure if exists sp_product_insert
go

CREATE PROCEDURE sp_product_insert
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
	insert into product(ma, ten, gia, soluong, loaisanpham, nhacungcap) Values(@ma, @ten, @gia, @soluong, @loaisanpham, @nhacungcap)
END
GO