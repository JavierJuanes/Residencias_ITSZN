-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-11-2024 a las 00:12:42
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `gestionresidenciastecnm`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documentos`
--

CREATE TABLE `documentos` (
  `DocumentoID` int(11) NOT NULL,
  `NombreDocumento` varchar(255) NOT NULL,
  `TipoDocumento` varchar(50) NOT NULL,
  `RutaArchivo` varchar(255) NOT NULL,
  `FechaSubida` date NOT NULL,
  `EstudianteID` int(11) DEFAULT NULL,
  `ProyectoID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `evaluaciones`
--

CREATE TABLE `evaluaciones` (
  `EvaluacionID` int(11) NOT NULL,
  `TipoEvaluacion` varchar(50) NOT NULL,
  `FechaEvaluacion` date NOT NULL,
  `Calificacion` decimal(3,2) DEFAULT NULL,
  `Observaciones` text DEFAULT NULL,
  `EstudianteID` int(11) DEFAULT NULL,
  `ProyectoID` int(11) DEFAULT NULL,
  `DocenteID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proyectos`
--

CREATE TABLE `proyectos` (
  `ProyectoID` int(11) NOT NULL,
  `Titulo` varchar(255) NOT NULL,
  `Descripcion` text DEFAULT NULL,
  `Estado` varchar(50) NOT NULL,
  `FechaRegistro` date NOT NULL,
  `JefeDivisionID` int(11) DEFAULT NULL,
  `DocenteAsesorID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roles`
--

CREATE TABLE `roles` (
  `RolID` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `UsuarioID` int(11) NOT NULL,
  `NombreCompleto` varchar(100) NOT NULL,
  `Usuario` varchar(50) NOT NULL,
  `Contrasena` varchar(255) NOT NULL,
  `CorreoElectronico` varchar(100) NOT NULL,
  `RolID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `documentos`
--
ALTER TABLE `documentos`
  ADD PRIMARY KEY (`DocumentoID`),
  ADD KEY `EstudianteID` (`EstudianteID`),
  ADD KEY `ProyectoID` (`ProyectoID`);

--
-- Indices de la tabla `evaluaciones`
--
ALTER TABLE `evaluaciones`
  ADD PRIMARY KEY (`EvaluacionID`),
  ADD KEY `EstudianteID` (`EstudianteID`),
  ADD KEY `ProyectoID` (`ProyectoID`),
  ADD KEY `DocenteID` (`DocenteID`);

--
-- Indices de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  ADD PRIMARY KEY (`ProyectoID`),
  ADD KEY `JefeDivisionID` (`JefeDivisionID`),
  ADD KEY `DocenteAsesorID` (`DocenteAsesorID`);

--
-- Indices de la tabla `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`RolID`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`UsuarioID`),
  ADD UNIQUE KEY `Usuario` (`Usuario`),
  ADD UNIQUE KEY `CorreoElectronico` (`CorreoElectronico`),
  ADD KEY `RolID` (`RolID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `documentos`
--
ALTER TABLE `documentos`
  MODIFY `DocumentoID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `evaluaciones`
--
ALTER TABLE `evaluaciones`
  MODIFY `EvaluacionID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `proyectos`
--
ALTER TABLE `proyectos`
  MODIFY `ProyectoID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `roles`
--
ALTER TABLE `roles`
  MODIFY `RolID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `UsuarioID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `documentos`
--
ALTER TABLE `documentos`
  ADD CONSTRAINT `documentos_ibfk_1` FOREIGN KEY (`EstudianteID`) REFERENCES `usuarios` (`UsuarioID`),
  ADD CONSTRAINT `documentos_ibfk_2` FOREIGN KEY (`ProyectoID`) REFERENCES `proyectos` (`ProyectoID`);

--
-- Filtros para la tabla `evaluaciones`
--
ALTER TABLE `evaluaciones`
  ADD CONSTRAINT `evaluaciones_ibfk_1` FOREIGN KEY (`EstudianteID`) REFERENCES `usuarios` (`UsuarioID`),
  ADD CONSTRAINT `evaluaciones_ibfk_2` FOREIGN KEY (`ProyectoID`) REFERENCES `proyectos` (`ProyectoID`),
  ADD CONSTRAINT `evaluaciones_ibfk_3` FOREIGN KEY (`DocenteID`) REFERENCES `usuarios` (`UsuarioID`);

--
-- Filtros para la tabla `proyectos`
--
ALTER TABLE `proyectos`
  ADD CONSTRAINT `proyectos_ibfk_1` FOREIGN KEY (`JefeDivisionID`) REFERENCES `usuarios` (`UsuarioID`),
  ADD CONSTRAINT `proyectos_ibfk_2` FOREIGN KEY (`DocenteAsesorID`) REFERENCES `usuarios` (`UsuarioID`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`RolID`) REFERENCES `roles` (`RolID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
