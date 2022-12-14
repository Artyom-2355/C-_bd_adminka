USE [user84_db]
GO
/****** Object:  Table [dbo].[BD10_Аксессуары]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Аксессуары](
	[Код Аксессуара] [int] NOT NULL,
	[Название] [varchar](50) NULL,
	[Описание] [varchar](50) NULL,
	[Цена] [varchar](50) NULL,
	[НДС] [varchar](50) NULL,
	[Инвентарь] [varchar](50) NULL,
	[Уровень порядка] [varchar](50) NULL,
	[Набор заказов] [varchar](50) NULL,
	[Код партнера] [int] NULL,
 CONSTRAINT [PK_BD10_Аксессуары] PRIMARY KEY CLUSTERED 
(
	[Код Аксессуара] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Доставка]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Доставка](
	[Код доставки] [int] NOT NULL,
	[Дата] [varchar](50) NULL,
	[Код менеджера] [int] NULL,
	[Код клиента] [int] NULL,
	[Код лодки] [int] NULL,
	[Адрес доставки] [varchar](50) NULL,
	[Город] [varchar](50) NULL,
 CONSTRAINT [PK_BD10_Доставка] PRIMARY KEY CLUSTERED 
(
	[Код доставки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Заказ]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Заказ](
	[Код заказа] [int] NOT NULL,
	[Дата] [int] NULL,
	[Внесенный депозит] [date] NULL,
	[Код доставки] [int] NULL,
	[Общая сумма] [varchar](50) NULL,
	[Общая сумма с НДС] [varchar](max) NULL,
	[Разработка продукта] [datetime] NULL,
 CONSTRAINT [PK_BD10_Заказ] PRIMARY KEY CLUSTERED 
(
	[Код заказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Критерии_доставки]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Критерии_доставки](
	[Код критерии доставки] [int] NOT NULL,
	[Код аксессуара] [int] NULL,
	[Код доставки] [int] NULL,
 CONSTRAINT [PK_BD10_Критерии_доставки] PRIMARY KEY CLUSTERED 
(
	[Код критерии доставки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Лодка]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Лодка](
	[Код лодки] [int] NOT NULL,
	[Модель] [varchar](50) NULL,
	[Тип лодки] [varchar](50) NULL,
	[Количество мест дл грибунов] [varchar](50) NULL,
	[Мачта] [varchar](50) NULL,
	[Цвет] [varchar](50) NULL,
	[Дерево] [varchar](50) NULL,
	[Базовая цена] [varchar](50) NULL,
	[НДС] [varchar](50) NULL,
 CONSTRAINT [PK_BD10_Лодка] PRIMARY KEY CLUSTERED 
(
	[Код лодки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Лодочные_аксессуары]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Лодочные_аксессуары](
	[Код лодочных аксессуаров] [int] NOT NULL,
	[Код аксессуара] [int] NULL,
	[Код лодки] [int] NULL,
 CONSTRAINT [PK_BD10_Лодочные_аксессуары] PRIMARY KEY CLUSTERED 
(
	[Код лодочных аксессуаров] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Менеджеры]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Менеджеры](
	[Код менеджера] [int] IDENTITY(1,1) NOT NULL,
	[Имя] [varchar](50) NULL,
	[Фамилия] [varchar](50) NULL,
	[Код пользователя] [int] NULL,
 CONSTRAINT [PK_BD10_Менеджеры] PRIMARY KEY CLUSTERED 
(
	[Код менеджера] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Партнеры]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Партнеры](
	[Код партнера] [int] NOT NULL,
	[Имя] [varchar](50) NULL,
	[Адрес] [varchar](50) NULL,
	[город] [varchar](50) NULL,
 CONSTRAINT [PK_BD10_Партнеры] PRIMARY KEY CLUSTERED 
(
	[Код партнера] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Покупатель]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Покупатель](
	[Код покупателя] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [varchar](50) NOT NULL,
	[Имя] [varchar](50) NOT NULL,
	[Дата_рождения] [varchar](50) NULL,
	[Регистрационное имя] [varchar](50) NULL,
	[Адресс] [varchar](50) NULL,
	[город] [varchar](50) NULL,
	[email] [varchar](max) NULL,
	[Телефон] [varchar](50) NULL,
	[Серия паспорта] [varchar](50) NULL,
	[Имя документа] [varchar](50) NOT NULL,
	[Код пользователя] [int] NULL,
 CONSTRAINT [PK_BD10_Покупатель] PRIMARY KEY CLUSTERED 
(
	[Код покупателя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Пользователь]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Пользователь](
	[Код пользователя] [int] IDENTITY(1,1) NOT NULL,
	[Логин] [varchar](50) NULL,
	[Пароль] [varchar](50) NULL,
	[Роль] [varchar](50) NULL,
 CONSTRAINT [PK_BD1_Пользователь] PRIMARY KEY CLUSTERED 
(
	[Код пользователя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BD10_Счет]    Script Date: 12.08.2022 22:06:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BD10_Счет](
	[Код счета] [nchar](10) NOT NULL,
	[Код заказа] [int] NULL,
	[Settled] [nchar](10) NULL,
	[Сумма] [nchar](10) NULL,
	[Сумма НДС] [nchar](10) NULL,
	[Дата] [nchar](10) NULL,
 CONSTRAINT [PK_BD10_Счет] PRIMARY KEY CLUSTERED 
(
	[Код счета] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BD10_Аксессуары]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Аксессуары_BD10_Партнеры] FOREIGN KEY([Код партнера])
REFERENCES [dbo].[BD10_Партнеры] ([Код партнера])
GO
ALTER TABLE [dbo].[BD10_Аксессуары] CHECK CONSTRAINT [FK_BD10_Аксессуары_BD10_Партнеры]
GO
ALTER TABLE [dbo].[BD10_Доставка]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Доставка_BD10_Лодка] FOREIGN KEY([Код лодки])
REFERENCES [dbo].[BD10_Лодка] ([Код лодки])
GO
ALTER TABLE [dbo].[BD10_Доставка] CHECK CONSTRAINT [FK_BD10_Доставка_BD10_Лодка]
GO
ALTER TABLE [dbo].[BD10_Доставка]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Доставка_BD10_Менеджеры] FOREIGN KEY([Код менеджера])
REFERENCES [dbo].[BD10_Менеджеры] ([Код менеджера])
GO
ALTER TABLE [dbo].[BD10_Доставка] CHECK CONSTRAINT [FK_BD10_Доставка_BD10_Менеджеры]
GO
ALTER TABLE [dbo].[BD10_Доставка]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Доставка_BD10_Покупатель] FOREIGN KEY([Код клиента])
REFERENCES [dbo].[BD10_Покупатель] ([Код покупателя])
GO
ALTER TABLE [dbo].[BD10_Доставка] CHECK CONSTRAINT [FK_BD10_Доставка_BD10_Покупатель]
GO
ALTER TABLE [dbo].[BD10_Заказ]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Заказ_BD10_Доставка] FOREIGN KEY([Код доставки])
REFERENCES [dbo].[BD10_Доставка] ([Код доставки])
GO
ALTER TABLE [dbo].[BD10_Заказ] CHECK CONSTRAINT [FK_BD10_Заказ_BD10_Доставка]
GO
ALTER TABLE [dbo].[BD10_Критерии_доставки]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Критерии_доставки_BD10_Аксессуары] FOREIGN KEY([Код доставки])
REFERENCES [dbo].[BD10_Аксессуары] ([Код Аксессуара])
GO
ALTER TABLE [dbo].[BD10_Критерии_доставки] CHECK CONSTRAINT [FK_BD10_Критерии_доставки_BD10_Аксессуары]
GO
ALTER TABLE [dbo].[BD10_Критерии_доставки]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Критерии_доставки_BD10_Доставка] FOREIGN KEY([Код аксессуара])
REFERENCES [dbo].[BD10_Доставка] ([Код доставки])
GO
ALTER TABLE [dbo].[BD10_Критерии_доставки] CHECK CONSTRAINT [FK_BD10_Критерии_доставки_BD10_Доставка]
GO
ALTER TABLE [dbo].[BD10_Лодочные_аксессуары]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Лодочные_аксессуары_BD10_Аксессуары] FOREIGN KEY([Код аксессуара])
REFERENCES [dbo].[BD10_Аксессуары] ([Код Аксессуара])
GO
ALTER TABLE [dbo].[BD10_Лодочные_аксессуары] CHECK CONSTRAINT [FK_BD10_Лодочные_аксессуары_BD10_Аксессуары]
GO
ALTER TABLE [dbo].[BD10_Лодочные_аксессуары]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Лодочные_аксессуары_BD10_Лодка] FOREIGN KEY([Код лодки])
REFERENCES [dbo].[BD10_Лодка] ([Код лодки])
GO
ALTER TABLE [dbo].[BD10_Лодочные_аксессуары] CHECK CONSTRAINT [FK_BD10_Лодочные_аксессуары_BD10_Лодка]
GO
ALTER TABLE [dbo].[BD10_Покупатель]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Покупатель_BD1_Пользователь] FOREIGN KEY([Код пользователя])
REFERENCES [dbo].[BD10_Пользователь] ([Код пользователя])
GO
ALTER TABLE [dbo].[BD10_Покупатель] CHECK CONSTRAINT [FK_BD10_Покупатель_BD1_Пользователь]
GO
ALTER TABLE [dbo].[BD10_Счет]  WITH CHECK ADD  CONSTRAINT [FK_BD10_Счет_BD10_Заказ] FOREIGN KEY([Код заказа])
REFERENCES [dbo].[BD10_Заказ] ([Код заказа])
GO
ALTER TABLE [dbo].[BD10_Счет] CHECK CONSTRAINT [FK_BD10_Счет_BD10_Заказ]
GO
