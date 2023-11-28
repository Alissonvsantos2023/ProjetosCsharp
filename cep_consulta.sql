-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 17/11/2023 às 11:43
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cep_consulta`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarioscep`
--

CREATE TABLE `usuarioscep` (
  `id_usuario` int(255) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `cpf` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuarioscep`
--

INSERT INTO `usuarioscep` (`id_usuario`, `nome`, `cpf`, `email`, `senha`) VALUES
(2, 'alisson', '46869929823', 'avitorap@gmail.com', '123'),
(3, 'Angela', '38105189801', 'angelabronetti@gmail.com', '1234'),
(4, 'zé', '1234', 'zé@sad.com', '123'),
(5, 'Angela', '38105189801', 'angelabronetti@gmail.com', 'lalala'),
(6, 'Liz Torres', '12311341', 'LizT@gmail.com', '123'),
(7, 'Roberscleiso', '1234567', 'Roberscleiso@rober.com', '123'),
(8, 'Adalgisa', '234593376', 'ziza051@gmail.com', '123');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `usuarioscep`
--
ALTER TABLE `usuarioscep`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `usuarioscep`
--
ALTER TABLE `usuarioscep`
  MODIFY `id_usuario` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
