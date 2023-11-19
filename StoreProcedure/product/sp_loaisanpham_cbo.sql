-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_loaisanpham_cbo.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_loaisanpham_cbo
	-- Add the parameters for the stored procedure here
	--@ma varchar(11),@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select ma, ten from loaisanpham
END
GO
﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_delete.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_delete
	-- Add the parameters for the stored procedure here
	@ma varchar(11)
	--,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from product where ma = @ma; 
END
GO
﻿-- =============================================
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
GO﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_all.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_all
	-- Add the parameters for the stored procedure here
	--@ma varchar(11),@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product
END
GO
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_one.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_one
	-- Add the parameters for the stored procedure here
	@ma varchar(11) --,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product where ma = @ma

END
GO
﻿-- =============================================
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
﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_delete.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_delete
	-- Add the parameters for the stored procedure here
	@ma varchar(11)
	--,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from product where ma = @ma; 
END
GO
﻿-- =============================================
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
GO﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_all.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_all
	-- Add the parameters for the stored procedure here
	--@ma varchar(11),@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product
END
GO
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_one.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_one
	-- Add the parameters for the stored procedure here
	@ma varchar(11) --,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product where ma = @ma

END
GO
﻿-- =============================================
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
﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_delete.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_delete
	-- Add the parameters for the stored procedure here
	@ma varchar(11)
	--,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from product where ma = @ma; 
END
GO
﻿-- =============================================
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
GO﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_all.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_all
	-- Add the parameters for the stored procedure here
	--@ma varchar(11),@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product
END
GO
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_one.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_one
	-- Add the parameters for the stored procedure here
	@ma varchar(11) --,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product where ma = @ma

END
GO
﻿-- =============================================
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
﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_delete.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_delete
	-- Add the parameters for the stored procedure here
	@ma varchar(11)
	--,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from product where ma = @ma; 
END
GO
﻿-- =============================================
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
GO﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_all.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_all
	-- Add the parameters for the stored procedure here
	--@ma varchar(11),@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product
END
GO
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_one.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_one
	-- Add the parameters for the stored procedure here
	@ma varchar(11) --,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product where ma = @ma

END
GO
﻿-- =============================================
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
﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_delete.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_delete
	-- Add the parameters for the stored procedure here
	@ma varchar(11)
	--,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from product where ma = @ma; 
END
GO
﻿-- =============================================
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
GO﻿-- =============================================
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
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_all.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_all
	-- Add the parameters for the stored procedure here
	--@ma varchar(11),@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product
END
GO
﻿-- =============================================
-- Author:		<Sok Kim Thanh>
-- Create date: <18/11/2023>
-- Description:	<sp_product_select_one.sql>
-- =============================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_product_select_one
	-- Add the parameters for the stored procedure here
	@ma varchar(11) --,@ten varchar(255),@gia decimal,@soluong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from product where ma = @ma

END
GO
﻿-- =============================================
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
