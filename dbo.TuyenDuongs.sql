CREATE TABLE [dbo].[TuyenDuongs] (
    [ID]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [HienThi]       BIT            NOT NULL,
    [MaTuyen]       NVARCHAR (50)  NULL,
    [TenTuyenDuong] NVARCHAR (250) NULL,
    [NoiDi]         NVARCHAR (50)  NULL,
    [NoiDen]        NVARCHAR (50)  NULL,
    [DauDM]         NVARCHAR (50)  NULL,
    [ChieuDai]      NVARCHAR (50)  NULL,
    [DienDan]       NVARCHAR (250) NULL,
    CONSTRAINT [PK_dbo.TuyenDuongs] PRIMARY KEY CLUSTERED ([ID] ASC)
);

