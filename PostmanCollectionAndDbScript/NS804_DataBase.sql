USE [master]
GO
/****** Object:  Database [NS804Test]    Script Date: 08/29/2021 6:19:25 PM ******/
CREATE DATABASE [NS804Test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NS804Test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\NS804Test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NS804Test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\NS804Test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [NS804Test] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NS804Test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NS804Test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NS804Test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NS804Test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NS804Test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NS804Test] SET ARITHABORT OFF 
GO
ALTER DATABASE [NS804Test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NS804Test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NS804Test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NS804Test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NS804Test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NS804Test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NS804Test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NS804Test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NS804Test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NS804Test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NS804Test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NS804Test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NS804Test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NS804Test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NS804Test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NS804Test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NS804Test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NS804Test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NS804Test] SET  MULTI_USER 
GO
ALTER DATABASE [NS804Test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NS804Test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NS804Test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NS804Test] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NS804Test] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NS804Test] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [NS804Test] SET QUERY_STORE = OFF
GO
USE [NS804Test]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/29/2021 6:19:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Phone] [varchar](15) NOT NULL,
	[Email] [varchar](150) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Address] [varchar](200) NOT NULL,
	[CountryState] [varchar](50) NOT NULL,
	[ZipCode] [varchar](5) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [NS804Test] SET  READ_WRITE 
GO
