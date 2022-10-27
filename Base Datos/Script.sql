-- MySQL Script generated by MySQL Workbench
-- Tue Oct 25 21:15:37 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema MiFactura
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema MiFactura
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `MiFactura` DEFAULT CHARACTER SET utf8 ;
USE `MiFactura` ;

-- -----------------------------------------------------
-- Table `MiFactura`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `MiFactura`.`Usuario` (
  `idUsuario` NVARCHAR(20) NOT NULL,
  `Nombre` NVARCHAR(50) NOT NULL,
  `Clave` NVARCHAR(120) NOT NULL,
  `Correo` NVARCHAR(45) NULL,
  `ROL` NVARCHAR(20) NOT NULL,
  `EstaActivo` TINYINT NOT NULL,
  PRIMARY KEY (`idUsuario`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `MiFactura`.`Producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `MiFactura`.`Producto` (
  `Codigo` INT NOT NULL,
  `Descripcion` NVARCHAR(50) NOT NULL,
  `Existencia` VARCHAR(45) NOT NULL,
  `Precio` DECIMAL NOT NULL,
  `FechaCreacion` DATETIME NOT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;