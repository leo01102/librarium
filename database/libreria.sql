-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-10-2024 a las 02:03:33
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `libreria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(150) NOT NULL,
  `apellido` varchar(150) NOT NULL,
  `email` varchar(50) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `ciudad` varchar(100) NOT NULL,
  `provincia` varchar(100) NOT NULL,
  `codigoPostal` varchar(10) NOT NULL,
  `fechaNacimiento` date NOT NULL,
  `fechaRegistro` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id`, `nombre`, `apellido`, `email`, `telefono`, `direccion`, `ciudad`, `provincia`, `codigoPostal`, `fechaNacimiento`, `fechaRegistro`) VALUES
(1, 'Juan', 'Pérez', 'juan.perez@example.com', '0123456789', 'Calle 2', 'La Rioja', 'La Rioja', '01234', '2024-07-08', '2024-08-02'),
(2, 'Ana', 'García', 'ana.garcia@example.com', '987654321', 'Avenida Siempreviva 742', 'Ciudad B', 'Provincia B', '2000', '1985-05-15', '2024-07-02'),
(3, 'Luis', 'Martínez', 'luis.martinez@example.com', '555555555', 'Calle 456', 'Ciudad C', 'Provincia C', '3000', '1990-02-20', '2024-07-03'),
(4, 'María', 'López', 'maria.lopez@example.com', '666666666', 'Avenida 789', 'Ciudad D', 'Provincia D', '4000', '1995-03-30', '2024-07-04'),
(5, 'Carlos', 'Gómez', 'carlos.gomez@example.com', '777777777', 'Bulevar 1011', 'Ciudad E', 'Provincia E', '5000', '2000-04-10', '2024-07-05'),
(6, 'Ana', 'Martínez', 'ana.martinez@example.com', '666666666', 'Avenida de la Paz 56', 'Sevilla', 'Sevilla', '41001', '1985-03-22', '2022-03-15'),
(7, 'Laura', 'García', 'laura.garcia@example.com', '123456789', 'Calle Falsa 123', 'Madrid', 'Madrid', '28001', '1990-04-12', '2020-01-05'),
(8, 'Antonio', 'Martínez', 'antonio.martinez@example.com', '987654321', 'Avenida del Sol 456', 'Barcelona', 'Barcelona', '08001', '1985-06-22', '2020-02-15'),
(9, 'María', 'López', 'maria.lopez@example.com', '112233445', 'Calle Luna 789', 'Valencia', 'Valencia', '46001', '1992-11-30', '2020-03-20'),
(10, 'José', 'Hernández', 'jose.hernandez@example.com', '556677889', 'Paseo de la Reforma 321', 'Sevilla', 'Sevilla', '41001', '1988-09-01', '2020-04-10'),
(11, 'Carmen', 'Pérez', 'carmen.perez@example.com', '665544332', 'Calle de la Paz 654', 'Granada', 'Granada', '18001', '1995-12-25', '2020-05-18'),
(12, 'Pedro', 'Gómez', 'pedro.gomez@example.com', '223344556', 'Plaza Mayor 987', 'Bilbao', 'Vizcaya', '48001', '1982-07-17', '2020-06-22'),
(13, 'Ana', 'Ramírez', 'ana.ramirez@example.com', '334455667', 'Calle del Mar 543', 'Murcia', 'Murcia', '30001', '1991-10-05', '2020-07-30'),
(14, 'Luis', 'Sánchez', 'luis.sanchez@example.com', '445566778', 'Calle del Olmo 876', 'Palma', 'Baleares', '07001', '1987-03-14', '2020-08-15'),
(15, 'Isabel', 'Torres', 'isabel.torres@example.com', '556677889', 'Calle del Río 321', 'San Sebastián', 'Guipúzkoa', '20001', '1993-02-20', '2021-01-05'),
(16, 'Francisco', 'Cruz', 'francisco.cruz@example.com', '667788990', 'Avenida de la Libertad 654', 'Zaragoza', 'Zaragoza', '50001', '1989-04-30', '2021-02-15'),
(17, 'Patricia', 'Moreno', 'patricia.moreno@example.com', '778899001', 'Calle del Campo 987', 'Valladolid', 'Valladolid', '47001', '1984-08-12', '2021-03-20'),
(18, 'David', 'Serrano', 'david.serrano@example.com', '889900112', 'Calle del Viento 543', 'Almería', 'Almería', '04001', '1996-12-01', '2021-04-10'),
(19, 'Cristina', 'Jiménez', 'cristina.jimenez@example.com', '990011223', 'Calle del Cielo 876', 'Toledo', 'Toledo', '45001', '1981-11-25', '2021-05-18'),
(20, 'Javier', 'Cano', 'javier.cano@example.com', '100110220', 'Avenida de la Estrella 321', 'Alicante', 'Alicante', '03001', '1986-06-10', '2021-06-22'),
(21, 'Mónica', 'Gómez', 'monica.gomez@example.com', '111223344', 'Calle de la Esperanza 654', 'Gijón', 'Asturias', '33201', '1994-09-15', '2021-07-30'),
(22, 'Ramón', 'Suárez', 'ramon.suarez@example.com', '122334455', 'Plaza del Sol 987', 'Huelva', 'Huelva', '21001', '1983-05-21', '2021-08-15'),
(23, 'Elena', 'Morales', 'elena.morales@example.com', '233445566', 'Calle del Bosque 543', 'Córdoba', 'Córdoba', '14001', '1990-02-28', '2022-01-05'),
(24, 'Ricardo', 'Ruiz', 'ricardo.ruiz@example.com', '344556677', 'Calle del Castaño 876', 'Jaén', 'Jaén', '23001', '1987-07-14', '2022-02-15'),
(25, 'Laura', 'Paredes', 'laura.paredes@example.com', '455667788', 'Avenida de la Vega 321', 'Logroño', 'La Rioja', '26001', '1992-11-10', '2022-03-20'),
(26, 'Miguel', 'Gutiérrez', 'miguel.gutierrez@example.com', '566788899', 'Calle del Lirio 654', 'Albacete', 'Albacete', '02001', '1985-03-16', '2022-04-10'),
(27, 'Sofía', 'García', 'sofia.garcia@example.com', '677899900', 'Plaza del Árbol 987', 'Lleida', 'Lleida', '25001', '1994-10-05', '2022-05-18'),
(28, 'Manuel', 'Castro', 'manuel.castro@example.com', '788900011', 'Calle de los Cedros 876', 'Tarragona', 'Tarragona', '43001', '1989-09-22', '2022-06-22'),
(29, 'Beatriz', 'Serrano', 'beatriz.serrano@example.com', '899001122', 'Calle del Valle 543', 'Soria', 'Soria', '42001', '1981-12-18', '2022-07-30'),
(30, 'Óscar', 'Mendoza', 'oscar.mendoza@example.com', '900112233', 'Avenida de la Ría 321', 'Segovia', 'Segovia', '40001', '1993-01-05', '2022-08-15'),
(31, 'Patricia', 'López', 'patricia.lopez@example.com', '011223344', 'Calle del Puente 654', 'Burgos', 'Burgos', '09001', '1986-08-30', '2023-01-05'),
(32, 'Rafael', 'Alonso', 'rafael.alonso@example.com', '122334455', 'Calle de la Luna 987', 'Ponferrada', 'León', '24401', '1989-07-14', '2023-02-15'),
(33, 'Vanessa', 'Salazar', 'vanessa.salazar@example.com', '233445566', 'Plaza de la Iglesia 543', 'Ourense', 'Ourense', '32001', '1995-05-12', '2023-03-20'),
(34, 'Jorge', 'García', 'jorge.garcia@example.com', '344556677', 'Calle de los Tulipanes 876', 'Cuenca', 'Cuenca', '16001', '1983-06-24', '2023-04-10'),
(35, 'Silvia', 'Montes', 'silvia.montes@example.com', '455667788', 'Avenida de la Cruz 321', 'Jaén', 'Jaén', '23001', '1987-02-08', '2023-05-18'),
(36, 'Héctor', 'Vázquez', 'hector.vazquez@example.com', '566788899', 'Calle de la Nieve 654', 'Huesca', 'Huesca', '22001', '1992-10-11', '2023-06-22'),
(37, 'Gabriela', 'Morales', 'gabriela.morales@example.com', '677899900', 'Calle de la Rosa 987', 'Pontevedra', 'Pontevedra', '36001', '1984-04-30', '2023-07-30'),
(38, 'Álvaro', 'Navarro', 'alvaro.navarro@example.com', '788900011', 'Plaza de los Pinos 876', 'Ciudad Real', 'Ciudad Real', '13001', '1996-12-22', '2023-08-15'),
(39, 'Natalia', 'Ríos', 'natalia.rios@example.com', '899001122', 'Avenida del Bosque 321', 'Lugo', 'Lugo', '27001', '1990-01-12', '2024-01-05'),
(40, 'Fernando', 'Gómez', 'fernando.gomez@example.com', '900112233', 'Calle del Agua 654', 'Tarragona', 'Tarragona', '43001', '1988-11-07', '2024-02-15'),
(41, 'test', 'test', 'test@test.com', '+12456', 'test', 'test', 'test', '1000', '2024-08-01', '2024-08-07');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libros`
--

CREATE TABLE `libros` (
  `id` int(11) NOT NULL,
  `nombre` varchar(150) NOT NULL,
  `autor` varchar(150) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `editorial` varchar(100) NOT NULL,
  `fechaPublicacion` date NOT NULL,
  `fechaIngreso` date NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `stock` int(11) NOT NULL,
  `genero` varchar(100) NOT NULL,
  `numeroPaginas` int(11) NOT NULL,
  `formato` varchar(100) NOT NULL,
  `idProveedor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `libros`
--

INSERT INTO `libros` (`id`, `nombre`, `autor`, `descripcion`, `editorial`, `fechaPublicacion`, `fechaIngreso`, `precio`, `stock`, `genero`, `numeroPaginas`, `formato`, `idProveedor`) VALUES
(1, 'The Great Gatsby', 'F. Scott Fitzgerald', 'A story of the American Dream and its pitfalls.', 'Scribner', '2024-08-01', '2024-08-02', 197.99, 396, 'Novel', 182, 'Paperback', 1),
(2, 'To Kill a Mockingbird', 'Harper Lee', 'A novel about racial injustice in the American South.', 'J. B. Lippincott & Co.', '1960-07-11', '2024-07-13', 12.50, 177, 'Fiction', 280, 'Hardcover', 2),
(3, '1984', 'George Orwell', 'A dystopian novel about totalitarianism and surveillance.', 'Secker & Warburg', '1949-06-08', '2024-07-09', 20.99, 80, 'Science Fiction', 328, 'E-book', 2),
(4, 'The Catcher in the Rye', 'J. D. Salinger', 'A story about teenage angst and alienation.', 'Little, Brown and Company', '1951-07-16', '2023-07-10', 11.75, 91, 'Fiction', 224, 'Paperback', 4),
(5, 'Pride and Prejudice', 'Jane Austen', 'A romantic novel set in early 19th-century England.', 'T. Egerton', '1813-01-28', '2023-07-10', 18.25, 67, 'Romance', 432, 'Hardcover', 5),
(6, 'The Lord of the Rings', 'J. R. R. Tolkien', 'A fantasy epic about a quest to destroy a powerful ring.', 'George Allen & Unwin', '1954-07-29', '2023-07-10', 24.99, 144, 'Fantasy', 1178, 'Box set', 1),
(7, 'The Hobbit', 'J. R. R. Tolkien', 'A children\'s fantasy novel about Bilbo Baggins\'s adventures.', 'George Allen & Unwin', '1937-09-21', '2023-07-10', 10.50, 102, 'Fantasy', 310, 'Paperback', 2),
(8, 'The Alchemist', 'Paulo Coelho', 'A philosophical novel about finding one\'s destiny.', 'HarperCollins', '1988-01-01', '2023-07-10', 14.95, 79, 'Fiction', 197, 'E-book', 3),
(9, 'Harry Potter and the Philosopher\'s Stone', 'J. K. Rowling', 'The first book in the Harry Potter series.', 'Bloomsbury Publishing', '1997-06-26', '2023-07-10', 19.99, 197, 'Fantasy', 223, 'Hardcover', 4),
(10, 'Cien años de soledad', 'Gabriel García Márquez', 'Una historia épica sobre la familia Buendía en Macondo.', 'Editorial Sudamericana', '1967-05-30', '2024-06-13', 22.50, 6, 'Realismo Mágico', 417, 'Hardcover', 7),
(11, 'La sombra del viento', 'Carlos Ruiz Zafón', 'Un joven descubre un libro que cambiará su vida en la Barcelona de la posguerra.', 'Planeta', '2001-03-15', '2024-08-01', 18.95, 32, 'Thriller', 487, 'Paperback', 1),
(12, 'El nombre de la rosa', 'Umberto Eco', 'Una novela de misterio ambientada en una abadía medieval.', 'Ediciones Mondadori', '1980-03-01', '2024-07-02', 21.50, 49, 'Misterio', 500, 'Hardcover', 1),
(13, 'Los detectives salvajes', 'Roberto Bolaño', 'Una novela sobre dos poetas que buscan a una misteriosa figura literaria.', 'Anagrama', '1998-01-01', '2024-07-01', 19.75, 8, 'Novela', 428, 'Paperback', 11),
(14, 'El túnel', 'Ernesto Sabato', 'Un relato psicológico sobre la obsesión y la locura.', 'Editorial Sudamericana', '1948-01-01', '2024-07-02', 17.99, 8, 'Psicológica', 180, 'Paperback', 6),
(15, 'Rayuela', 'Julio Cortázar', 'Una novela innovadora que se puede leer de múltiples formas.', 'Editorial Sudamericana', '1963-06-01', '2024-07-01', 20.00, 97, 'Novel', 180, 'Paperback', 7),
(16, 'El amor en los tiempos del cólera', 'Gabriel García Márquez', 'Una historia de amor que perdura a través del tiempo.', 'Editorial Sudamericana', '1985-03-01', '2024-07-01', 1.00, 8, 'Romántico', 1, 'Paperback', 8),
(17, 'La casa de los espíritus', 'Isabel Allende', 'Una novela sobre la historia de una familia chilena y lo sobrenatural.', 'Editorial Sudamericana', '1982-11-01', '2024-06-15', 21.00, 19, 'Realismo Mágico', 1, 'Hardcover', 9),
(18, 'El principito', 'Antoine de Saint-Exupéry', 'Un cuento filosófico sobre un pequeño príncipe y sus aventuras.', 'Reynal & Hitchcock', '1943-04-06', '2024-07-10', 15.25, 138, 'Cuento', 96, 'Paperback', 10),
(19, '1984', 'George Orwell', 'Una novela distópica sobre un futuro totalitario.', 'Secker & Warburg', '1949-06-08', '2024-07-11', 20.99, 98, 'Ciencia Ficción', 328, 'E-book', 11),
(20, 'Fahrenheit 451', 'Ray Bradbury', 'Una novela sobre un futuro donde los libros están prohibidos.', 'Ballantine Books', '1953-10-19', '2024-07-12', 18.00, 83, 'Ciencia Ficción', 256, 'Hardcover', 12),
(21, 'Brave New World', 'Aldous Huxley', 'Una novela sobre un futuro distópico de control social.', 'Chatto & Windus', '1932-08-31', '2024-07-13', 19.50, 68, 'Ciencia Ficción', 311, 'Paperback', 13),
(22, 'La carretera', 'Cormac McCarthy', 'Una novela post-apocalíptica sobre un padre y su hijo en un mundo devastado.', 'Alfred A. Knopf', '2006-09-26', '2024-07-14', 22.00, 58, 'Post-apocalíptico', 287, 'Hardcover', 14),
(23, 'La chica del tren', 'Paula Hawkins', 'Un thriller psicológico sobre una mujer que se involucra en un misterio.', 'Riverhead Books', '2015-01-13', '2024-07-15', 17.75, 109, 'Thriller', 336, 'Paperback', 15),
(24, 'El diario de Ana Frank', 'Ana Frank', 'El diario de una niña judía escondida durante la Segunda Guerra Mundial.', 'Contact Publishing', '1947-06-25', '2024-07-16', 16.99, 94, 'Memorias', 283, 'Hardcover', 1),
(25, 'Matar a un ruiseñor', 'Harper Lee', 'Una novela sobre la injusticia racial en el sur de los Estados Unidos.', 'J.B. Lippincott & Co.', '1960-07-11', '2024-07-17', 14.50, 119, 'Ficción', 281, 'Paperback', 2),
(26, 'Los juegos del hambre', 'Suzanne Collins', 'Una novela distópica sobre una competencia mortal.', 'Scholastic Press', '2008-09-14', '2024-07-18', 18.25, 139, 'Distópico', 374, 'E-book', 3),
(27, 'Cumbres borrascosas', 'Emily Brontë', 'Una novela gótica sobre el amor y la venganza.', 'Thomas Cautley Newby', '1847-12-01', '2024-07-19', 20.50, 79, 'Gótico', 416, 'Hardcover', 4),
(28, 'Orgullo y prejuicio', 'Jane Austen', 'Una novela sobre el amor y el estatus social en la Inglaterra del siglo XIX.', 'T. Egerton', '1813-01-28', '2024-07-20', 19.95, 99, 'Romántico', 432, 'Paperback', 5),
(29, 'El gran Gatsby', 'F. Scott Fitzgerald', 'Una historia sobre el sueño americano y sus desilusiones.', 'Scribner', '1925-04-10', '2024-07-21', 22.99, 74, 'Novela', 180, 'Hardcover', 6),
(30, 'El Código Da Vinci', 'Dan Brown', 'Un thriller sobre una conspiración religiosa.', 'Doubleday', '2003-03-18', '2024-07-22', 23.50, 129, 'Thriller', 689, 'Paperback', 7),
(31, 'El alquimista', 'Paulo Coelho', 'Una novela sobre la búsqueda del destino y la realización personal.', 'HarperCollins', '1988-01-01', '2024-07-23', 16.75, 109, 'Ficción', 208, 'E-book', 8),
(32, 'El hombre en busca de sentido', 'Viktor E. Frankl', 'Una reflexión sobre la vida y la búsqueda de sentido tras el Holocausto.', 'Beacon Press', '1946-01-01', '2024-07-24', 18.50, 84, 'Psicología', 184, 'Hardcover', 9),
(33, 'La dama de blanco', 'Wilkie Collins', 'Una novela de misterio y suspense sobre una mujer en peligro.', 'R. Bentley', '1860-03-01', '2024-07-25', 20.25, 69, 'Misterio', 617, 'Paperback', 10),
(34, 'Un mundo feliz', 'Aldous Huxley', 'Una novela sobre un futuro en el que la felicidad es una obligación.', 'Chatto & Windus', '1932-08-31', '2024-07-26', 17.25, 89, 'Ciencia Ficción', 311, 'Hardcover', 11),
(35, 'Los pilares de la Tierra', 'Ken Follett', 'Una novela épica sobre la construcción de una catedral en la Edad Media.', 'Macmillan', '1989-08-01', '2024-07-27', 24.50, 129, 'Histórica', 1008, 'Paperback', 12),
(36, 'En busca del tiempo perdido', 'Marcel Proust', 'Una novela monumental sobre el tiempo y la memoria.', 'Grasset', '1913-01-01', '2024-07-28', 26.75, 49, 'Novela', 4215, 'Hardcover', 13),
(37, 'La niña de los fósforos', 'Hans Christian Andersen', 'Un cuento sobre la pobreza y la esperanza en una fría noche de invierno.', 'Copenhagen Publishing', '1845-12-21', '2024-07-29', 10.50, 80, 'Cuento', 32, 'Paperback', 1),
(38, 'El retrato de Dorian Gray', 'Oscar Wilde', 'Una novela sobre la juventud eterna y la decadencia moral.', 'Lippincott', '1890-07-01', '2024-05-30', 19.75, 95, 'Novela', 254, 'Hardcover', 2),
(39, 'Mujer en la arena', 'Kōbō Abe', 'Una novela sobre una mujer atrapada en una arena en el desierto.', 'Kodansha', '1962-02-01', '2024-05-31', 22.00, 70, 'Drama', 188, 'Paperback', 3),
(40, 'La muerte de Artemio Cruz', 'Carlos Fuentes', 'Una novela que explora la vida de un hombre en su lecho de muerte.', 'Editorial Farrar, Straus and Giroux', '1962-06-01', '2024-05-01', 21.50, 85, 'Novela', 300, 'Hardcover', 4),
(41, 'El hombre invisible', 'H.G. Wells', 'Una novela sobre un científico que se vuelve invisible.', 'Garden City Publishing', '1897-03-01', '2024-05-02', 18.75, 120, 'Ciencia Ficción', 188, 'Paperback', 5),
(42, 'La dama de la camelia', 'Alexandre Dumas', 'Una novela sobre una cortesana y su amor trágico.', 'Félix Juven', '1848-02-01', '2024-05-03', 20.00, 90, 'Romántico', 192, 'Hardcover', 6),
(43, 'La familia de Pascual Duarte', 'Camilo José Cela', 'Una novela que describe la vida de un hombre en la España rural.', 'Editorial Espasa Calpe', '1962-04-01', '2024-06-04', 23.00, 75, 'Novela', 256, 'Paperback', 7),
(44, 'Los tres mosqueteros', 'Alexandre Dumas', 'Una novela de aventuras sobre un grupo de mosqueteros.', 'P. F. Collier & Son', '1844-03-01', '2024-06-05', 19.95, 130, 'Aventura', 736, 'Hardcover', 8),
(45, 'El gran sueño', 'Raymond Chandler', 'Una novela de misterio protagonizada por el detective Philip Marlowe.', 'Hamish Hamilton', '1939-01-01', '2024-06-06', 17.50, 85, 'Misterio', 281, 'Paperback', 9),
(46, 'El seño del caos', 'Jorge Luis Borges', 'Una colección de cuentos que exploran temas filosóficos y metafísicos.', 'Editorial Sur', '1962-05-01', '2024-06-07', 20.25, 100, 'Cuentos', 232, 'Hardcover', 10),
(47, 'La primavera de los pueblos', 'Hermann Hesse', 'Una novela sobre la evolución espiritual y personal.', 'S. Fischer Verlag', '1919-03-01', '2024-06-08', 22.75, 90, 'Novela', 278, 'Paperback', 11),
(48, 'Los hermanos Karamazov', 'Fiódor Dostoyevski', 'Una novela sobre la moralidad y la fe en la Rusia zarista.', 'The Russian Messenger', '1880-01-01', '2024-06-09', 25.00, 70, 'Novela', 796, 'Hardcover', 12),
(49, 'El viaje al centro de la Tierra', 'Jules Verne', 'Una novela de ciencia ficción sobre un viaje subterráneo.', 'Pierre-Jules Hetzel', '1864-11-01', '2024-06-10', 18.50, 110, 'Aventura', 240, 'Paperback', 13),
(50, 'El secreto de sus ojos', 'Eduardo Sacheri', 'Una novela que mezcla el misterio con la reflexión sobre la justicia.', 'Editorial Planeta', '2005-06-01', '2024-06-11', 19.25, 95, 'Misterio', 335, 'Hardcover', 14),
(51, 'Pedro Páramo', 'Juan Rulfo', 'Una novela sobre la búsqueda de un padre en un pueblo fantasma.', 'Editorial Fondo de Cultura Económica', '1955-07-01', '2024-04-12', 21.00, 80, 'Realismo Mágico', 200, 'Paperback', 15),
(52, 'La catedral del mar', 'Ildefonso Falcones', 'Una novela histórica sobre la construcción de una catedral en la Barcelona medieval.', 'Editorial Grijalbo', '2006-10-10', '2024-08-01', 24.00, 110, 'Histórica', 688, 'Hardcover', 1),
(53, 'El poder del perro', 'Don Winslow', 'Una novela sobre el narcotráfico y la corrupción en la frontera entre México y Estados Unidos.', 'Editorial Anagrama', '2005-03-01', '2024-08-01', 22.50, 80, 'Thriller', 400, 'Paperback', 2),
(54, 'Los hombres que no amaban a las mujeres', 'Stieg Larsson', 'El primer libro de la trilogía Millennium, sobre una investigación de desaparición.', 'Editorial Planeta', '2005-08-27', '2024-08-01', 19.75, 130, 'Thriller', 465, 'Hardcover', 3),
(55, 'La vida de Pi', 'Yann Martel', 'Una novela sobre un joven que sobrevive a un naufragio con un tigre de Bengala.', 'Editorial Salamandra', '2001-09-11', '2024-07-16', 21.00, 90, 'Aventura', 319, 'Paperback', 4),
(56, 'El niño con el pijama de rayas', 'John Boyne', 'Una historia conmovedora sobre la amistad entre dos niños durante la Segunda Guerra Mundial.', 'Editorial Salamandra', '2006-01-01', '2020-08-17', 18.25, 100, 'Ficción', 216, 'Hardcover', 5),
(57, 'El arte de la guerra', 'Sun Tzu', 'Un antiguo tratado chino sobre estrategia militar y liderazgo.', 'Penguin Classics', '0500-01-01', '2020-01-18', 15.00, 120, 'Estrategia', 128, 'Paperback', 6),
(58, 'La casa en el confín de la tierra', 'William Hope Hodgson', 'Una novela de terror sobre una casa en una isla remota y sus secretos oscuros.', 'Hodder & Stoughton', '1908-01-01', '2024-08-19', 17.75, 75, 'Terror', 280, 'Hardcover', 7),
(59, 'El regreso del joven príncipe', 'A.G. Roemmers', 'Una continuación moderna del clásico \"El principito\".', 'Editorial Planeta', '2015-09-01', '2021-01-20', 16.50, 85, 'Ficción', 208, 'Paperback', 8),
(60, 'En el camino', 'Jack Kerouac', 'Una novela que captura el espíritu del viaje y la exploración en los años 50 en EE.UU.', 'Viking Press', '1957-09-05', '2022-02-21', 22.25, 100, 'Novela', 307, 'Hardcover', 9),
(61, 'El último lector', 'David Toscana', 'Una novela sobre la vida de un hombre en un pequeño pueblo y su obsesión con los libros.', 'Editorial Planeta', '2009-03-01', '2023-08-22', 19.50, 90, 'Ficción', 245, 'Paperback', 10),
(62, 'La verdad sobre el caso Harry Quebert', 'Joël Dicker', 'Un thriller literario sobre un escritor implicado en un caso de asesinato.', 'Editorial Alfaguara', '2012-08-30', '2022-08-23', 21.75, 80, 'Thriller', 460, 'Hardcover', 11),
(63, 'La canción de Aquiles', 'Madeline Miller', 'Una reimaginación de la historia de Aquiles y Patroclo.', 'Editorial Circe', '2011-09-20', '2024-08-24', 23.00, 70, 'Ficción', 371, 'Paperback', 12),
(64, 'La chica del tren', 'Paula Hawkins', 'Un thriller psicológico sobre una mujer involucrada en un misterio.', 'Riverhead Books', '2015-01-13', '2022-08-25', 18.00, 120, 'Thriller', 336, 'E-book', 13),
(65, 'Las chicas de la 305', 'Laura Esquivel', 'Una novela sobre la amistad y la superación en un internado para jóvenes.', 'Editorial Norma', '2004-05-01', '2022-08-26', 20.00, 95, 'Ficción', 278, 'Hardcover', 14),
(66, 'El corazón helado', 'Almudena Grandes', 'Una novela sobre la historia de una familia española y sus secretos.', 'Editorial Tusquets', '2007-10-01', '2022-08-27', 22.00, 100, 'Ficción', 560, 'Paperback', 15),
(67, 'Sapiens: De animales a dioses', 'Yuval Noah Harari', 'Una exploración sobre la historia de la humanidad desde los primeros humanos hasta la actualidad.', 'Editorial Debate', '2011-01-01', '2024-07-01', 24.50, 130, 'Historia', 464, 'Hardcover', 1),
(68, 'Educada', 'Tara Westover', 'Una memoria sobre la educación autodidacta de una joven en una familia mormona aislada.', 'Editorial HarperCollins', '2018-02-20', '2024-08-01', 22.00, 100, 'Memorias', 334, 'Paperback', 2),
(69, 'El hombre que amaba a los perros', 'Leonardo Padura', 'Una novela sobre la vida de un hombre que vivió en la sombra de la Revolución Cubana.', 'Editorial Tusquets', '2009-10-01', '2024-08-01', 20.75, 90, 'Ficción', 464, 'Hardcover', 3),
(70, 'Dulce de leche', 'Gonzalo Giner', 'Una novela histórica sobre la vida en la España de los siglos XVII y XVIII.', 'Editorial Planeta', '2020-05-05', '2024-08-01', 18.50, 120, 'Histórica', 400, 'Paperback', 4),
(71, 'El psicoanalista', 'John Katzenbach', 'Un thriller psicológico donde un psicoanalista es amenazado y debe descubrir al culpable.', 'Editorial Ediciones B', '2002-04-01', '2022-09-01', 21.00, 110, 'Thriller', 416, 'Hardcover', 5),
(72, 'La sombra del viento', 'Carlos Ruiz Zafón', 'Una historia misteriosa ambientada en la Barcelona de la posguerra.', 'Editorial Planeta', '2001-03-15', '2021-09-02', 19.00, 95, 'Misterio', 487, 'Paperback', 6),
(73, 'El secreto de la esfinge', 'Javier Sierra', 'Una novela que mezcla misterio, historia y aventuras sobre una antigua esfinge.', 'Editorial Planeta', '2007-05-15', '2023-09-03', 23.50, 85, 'Misterio', 380, 'Hardcover', 7),
(74, 'Los días del Venado', 'Liliana Bodoc', 'Una novela épica de fantasía sobre una guerra en un mundo imaginario.', 'Editorial Santillana', '2000-10-01', '2024-09-04', 22.00, 100, 'Fantasía', 704, 'Paperback', 8),
(75, 'El juego del ángel', 'Carlos Ruiz Zafón', 'La secuela de \"La sombra del viento\", que profundiza en el misterio del Cementerio de los Libros Olvidados.', 'Editorial Planeta', '2008-11-04', '2023-09-05', 21.75, 120, 'Misterio', 447, 'Hardcover', 9),
(76, 'El atlas de las nubes', 'David Mitchell', 'Una novela que entrelaza seis historias en diferentes épocas y lugares, mostrando cómo están conectadas.', 'Editorial Seix Barral', '2004-10-01', '2023-09-06', 24.00, 90, 'Ficción', 529, 'Paperback', 10),
(77, 'El club de los poetas muertos', 'Nancy H. Kleinbaum', 'Una novela sobre un profesor inspirador y su impacto en los estudiantes de una escuela privada.', 'Editorial RBA', '1990-05-01', '2023-09-07', 18.75, 110, 'Ficción', 192, 'Hardcover', 11),
(78, 'El huerto de las mujeres muertas', 'Ildefonso Falcones', 'Una novela que combina el suspense con la historia en la Barcelona del siglo XIX.', 'Editorial Grijalbo', '2019-10-01', '2023-09-08', 21.00, 95, 'Suspense', 544, 'Paperback', 12),
(79, 'El hombre que inventó el tren fantasma', 'Luis García Montero', 'Una novela sobre la vida de un hombre y sus obsesiones en la España del siglo XIX.', 'Editorial Espasa Calpe', '2014-05-01', '2023-09-09', 19.25, 85, 'Histórica', 392, 'Hardcover', 13),
(80, 'El cementerio de los libros olvidados', 'Carlos Ruiz Zafón', 'Una serie que explora el impacto de un misterioso libro en las vidas de quienes lo encuentran.', 'Editorial Planeta', '2004-10-05', '2023-09-10', 22.50, 120, 'Misterio', 528, 'E-book', 14),
(81, 'La noche más oscura', 'Juan Gómez-Jurado', 'Un thriller que sigue a un grupo de personas atrapadas en un lugar sin salida durante una noche peligrosa.', 'Editorial Ediciones B', '2018-09-25', '2020-09-11', 20.00, 80, 'Thriller', 400, 'Paperback', 15),
(82, 'test', 'test', 'test', 'test', '2024-08-01', '2024-08-01', 0.00, 0, 'test', 0, 'test', 1),
(83, 'test', 'test', 'test', 'test', '2024-08-01', '2024-08-01', 0.00, 0, 'test', 0, 'test', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `usuario` varchar(150) NOT NULL,
  `contrasena` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`id`, `usuario`, `contrasena`) VALUES
(1, 'admin', 'jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg='),
(2, 'test', 'n4bQgYhMfWWaL+qgxVrQFaO/TxsrC4Is0V1sFbDwCgg='),
(5, 'test4', 'pOYk1obgPtJ2fAq9hcFEJrCxFX0s6B0nu0/k9vAdaIo=');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `contactoPrincipal` varchar(150) NOT NULL,
  `estado` enum('Activo','Inactivo','Suspendido','') NOT NULL,
  `direccion` varchar(150) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `email` varchar(100) NOT NULL,
  `fechaRegistro` date NOT NULL,
  `provincia` varchar(100) NOT NULL,
  `ciudad` varchar(100) NOT NULL,
  `codigoPostal` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`id`, `nombre`, `contactoPrincipal`, `estado`, `direccion`, `telefono`, `email`, `fechaRegistro`, `provincia`, `ciudad`, `codigoPostal`) VALUES
(1, 'Proveedor A', 'Juan Pérez', 'Activo', 'Calle 12', '111-1111', 'proveedora@ejemplo.com', '2020-03-15', 'Buenos Aires', 'CABA', '1000'),
(2, 'Proveedor B', 'María López', 'Activo', 'Avenida XYZ', '222-2222', 'proveedorb@ejemplo.com', '2021-06-22', 'Córdoba', 'Córdoba', '5000'),
(3, 'Proveedor C', 'Carlos Gómez', 'Inactivo', 'Calle 456', '333-3333', 'proveedorc@ejemplo.com', '2022-09-30', 'Santa Fe', 'Rosario', 'S2000'),
(4, 'Proveedor D', 'Lucía Martínez', 'Activo', 'Calle Corrientes 789', '444-4444', 'proveedord@ejemplo.com', '2023-01-10', 'La Rioja', 'La Rioja', 'R5500'),
(5, 'Proveedor E', 'Jorge Fernández', 'Suspendido', 'Av. Libertador 456', '555-5555', 'proveedore@ejemplo.com', '2024-02-14', 'San Juan', 'San Juan', 'J5400'),
(6, 'Proveedor F', 'Ana Gutiérrez', 'Activo', 'Calle Mitre 567', '0291-6789-4321', 'contactoF@ejemplo.com', '2021-11-23', 'Chubut', 'Puerto Madryn', '9120'),
(7, 'Proveedor G', 'Ricardo Ramírez', 'Inactivo', 'Av. San Martín 321', '0294-4321-6789', 'contactoG@ejemplo.com', '2022-04-05', 'Neuquén', 'Neuquén', '8300'),
(8, 'Proveedor H', 'Sandra Suárez', 'Activo', 'Calle Rivadavia 654', '0387-5678-4321', 'contactoH@ejemplo.com', '2020-08-16', 'Salta', 'Salta', '4400'),
(9, 'Proveedor I', 'Gustavo Acosta', 'Suspendido', 'Av. Belgrano 789', '0379-8765-1234', 'contactoI@ejemplo.com', '2023-05-09', 'Corrientes', 'Corrientes', '3400'),
(10, 'Proveedor J', 'Elena Ponce', 'Activo', 'Calle Sarmiento 123', '0264-1234-5678', 'contactoJ@ejemplo.com', '2024-06-18', 'San Luis', 'San Luis', '5700'),
(11, 'Proveedor K', 'Roberto Castro', 'Inactivo', 'Av. Roca 456', '0342-6789-1234', 'contactoK@ejemplo.com', '2022-12-27', 'Tucumán', 'San Miguel de Tucumán', '4000'),
(12, 'Proveedor L', 'Patricia Torres', 'Activo', 'Calle Colón 321', '0378-4321-8765', 'contactoL@ejemplo.com', '2021-03-13', 'Misiones', 'Posadas', '3300'),
(13, 'Proveedor M', 'Andrés Pérez', 'Suspendido', 'Av. Alem 654', '0381-5678-8765', 'contactoM@ejemplo.com', '2023-07-25', 'Jujuy', 'San Salvador de Jujuy', '4600'),
(14, 'Proveedor N', 'Carolina Ríos', 'Activo', 'Calle Santa Fe 789', '0298-8765-4321', 'contactoN@ejemplo.com', '2020-05-11', 'Río Negro', 'Bariloche', '8400'),
(15, 'Proveedor O', 'Martín Díaz', 'Inactivo', 'Av. Alvear 123', '0343-1234-6789', 'contactoO@ejemplo.com', '2022-08-02', 'Entre Ríos', 'Paraná', '3100'),
(18, 'test', 'test', 'Activo', 'test', '12345687900', 'test2@test.com', '2024-08-07', 'test', 'test', 'test123'),
(19, 'test', 'test', 'Inactivo', 'test', '123456', 'test@test.com', '2024-08-09', 'test', 'test', 'test123');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `id` int(11) NOT NULL,
  `idCliente` int(11) DEFAULT NULL,
  `idLibro` int(11) DEFAULT NULL,
  `fechaVenta` date DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`id`, `idCliente`, `idLibro`, `fechaVenta`, `cantidad`, `precio`) VALUES
(1, 1, 1, '2024-07-01', 1, 197.99),
(2, 2, 2, '2024-07-01', 2, 12.50),
(3, 3, 3, '2024-07-01', 3, 56.85),
(4, 4, 4, '2024-07-02', 1, 21.50),
(5, 5, 5, '2024-07-02', 2, 39.50),
(6, 6, 6, '2024-07-02', 4, 71.96),
(7, 7, 7, '2024-07-03', 1, 20.00),
(8, 8, 8, '2024-07-03', 3, 70.50),
(9, 9, 9, '2024-07-04', 1, 23.50),
(10, 10, 10, '2024-07-04', 2, 30.50),
(11, 11, 11, '2024-07-05', 2, 37.90),
(12, 12, 12, '2024-07-05', 1, 18.00),
(13, 13, 13, '2024-07-06', 4, 40.00),
(14, 14, 14, '2024-07-06', 1, 20.00),
(15, 15, 15, '2024-07-07', 3, 53.25),
(16, 16, 16, '2024-07-07', 2, 45.50),
(17, 17, 17, '2024-07-08', 1, 22.99),
(18, 18, 18, '2024-07-08', 4, 60.00),
(19, 19, 19, '2024-07-09', 3, 55.75),
(20, 20, 20, '2024-07-09', 1, 17.75),
(21, 21, 21, '2024-07-10', 2, 37.50),
(22, 22, 22, '2024-07-10', 1, 19.00),
(23, 23, 23, '2024-07-11', 4, 82.00),
(24, 24, 24, '2024-07-11', 3, 54.95),
(25, 25, 25, '2024-07-12', 2, 41.50),
(26, 26, 26, '2024-07-12', 1, 20.00),
(27, 27, 27, '2024-07-13', 3, 60.00),
(28, 28, 28, '2024-06-15', 2, 51.50),
(29, 29, 29, '2024-06-20', 1, 22.50),
(30, 30, 30, '2024-06-25', 2, 30.00),
(31, 31, 31, '2024-05-10', 3, 56.85),
(32, 32, 32, '2024-05-15', 1, 18.90),
(33, 33, 33, '2024-05-20', 2, 28.00),
(34, 34, 34, '2024-04-10', 4, 65.75),
(35, 35, 35, '2024-04-15', 1, 33.00),
(36, 36, 36, '2024-03-25', 2, 20.75),
(37, 37, 37, '2024-03-30', 3, 45.00),
(38, 38, 38, '2024-02-10', 1, 15.00),
(39, 39, 39, '2024-02-15', 4, 72.00),
(40, 40, 40, '2024-01-05', 2, 25.50),
(41, 26, 26, '2024-07-13', 3, 60.00),
(42, 27, 27, '2024-07-14', 1, 22.50),
(43, 28, 28, '2024-07-15', 2, 28.75),
(44, 29, 29, '2024-07-16', 4, 35.00),
(45, 30, 30, '2024-07-17', 1, 30.00),
(46, 31, 31, '2024-07-18', 3, 40.50),
(47, 32, 32, '2024-07-19', 2, 25.00),
(48, 33, 33, '2024-07-20', 1, 18.90),
(49, 34, 34, '2024-07-21', 4, 50.00),
(50, 35, 35, '2024-07-22', 3, 65.25),
(51, 36, 36, '2024-07-23', 2, 27.75),
(52, 37, 37, '2024-07-24', 1, 22.00),
(53, 38, 38, '2024-07-25', 4, 42.99),
(54, 39, 39, '2024-07-26', 3, 54.00),
(55, 40, 40, '2024-07-27', 2, 31.50),
(56, 1, 1, '2024-07-28', 2, 46.00),
(57, 2, 2, '2024-07-29', 1, 27.00),
(58, 3, 3, '2024-07-30', 3, 59.90),
(59, 4, 4, '2024-07-31', 1, 24.50),
(60, 5, 5, '2024-08-01', 2, 41.75),
(61, 6, 6, '2024-08-02', 4, 73.00),
(62, 7, 7, '2024-08-03', 1, 19.75),
(63, 8, 8, '2024-08-04', 3, 67.50),
(64, 9, 9, '2024-08-05', 2, 33.25),
(65, 10, 10, '2024-08-06', 4, 47.00),
(66, 11, 11, '2024-08-07', 3, 52.00),
(67, 12, 12, '2024-08-08', 1, 21.00),
(68, 13, 13, '2024-08-09', 2, 29.50),
(69, 14, 14, '2024-08-10', 4, 58.00),
(70, 15, 15, '2024-08-11', 3, 45.75),
(71, 16, 16, '2024-08-12', 2, 26.50),
(72, 17, 17, '2024-08-13', 1, 23.99),
(73, 18, 18, '2024-08-14', 4, 70.00),
(74, 19, 19, '2024-08-15', 3, 61.50),
(75, 20, 20, '2024-08-16', 2, 28.25),
(76, 21, 21, '2024-08-17', 1, 20.50),
(77, 22, 22, '2024-08-18', 4, 63.00),
(78, 23, 23, '2024-08-19', 3, 50.00),
(79, 24, 24, '2024-08-20', 2, 35.00),
(80, 25, 25, '2024-08-21', 1, 18.75),
(81, 26, 26, '2024-08-22', 4, 55.50),
(82, 27, 27, '2024-08-23', 3, 49.00),
(83, 28, 28, '2024-08-24', 2, 32.75),
(84, 29, 29, '2024-08-25', 1, 22.25),
(85, 30, 30, '2024-08-26', 4, 60.00),
(86, 31, 31, '2024-08-27', 3, 46.75),
(87, 32, 32, '2024-08-28', 2, 29.00),
(88, 33, 33, '2024-08-29', 1, 21.50),
(89, 34, 34, '2024-08-30', 4, 72.00),
(90, 35, 35, '2024-08-31', 3, 51.25),
(91, 36, 36, '2024-08-01', 2, 27.50),
(92, 37, 37, '2024-08-02', 1, 25.00),
(93, 38, 38, '2024-08-03', 4, 68.00),
(94, 39, 39, '2024-08-04', 3, 43.50),
(95, 40, 40, '2024-08-05', 2, 34.75),
(96, 1, 1, '2020-01-10', 2, 50.00),
(97, 2, 2, '2020-01-15', 1, 22.75),
(98, 3, 3, '2020-02-01', 3, 60.00),
(99, 4, 4, '2020-02-20', 2, 35.00),
(100, 5, 5, '2020-03-05', 1, 28.50),
(101, 6, 6, '2020-03-15', 4, 75.00),
(102, 7, 7, '2020-04-01', 2, 20.00),
(103, 8, 8, '2020-04-10', 1, 18.00),
(104, 9, 9, '2020-05-01', 3, 45.00),
(105, 10, 10, '2020-05-10', 1, 25.00),
(106, 11, 11, '2020-06-01', 2, 30.00),
(108, 13, 13, '2021-01-05', 3, 55.00),
(109, 14, 14, '2021-01-20', 1, 20.50),
(110, 15, 15, '2021-02-15', 2, 33.75),
(111, 16, 16, '2021-03-01', 4, 85.00),
(112, 17, 17, '2021-03-20', 1, 22.00),
(113, 18, 18, '2021-04-10', 3, 48.00),
(114, 19, 19, '2021-05-01', 2, 27.50),
(115, 20, 20, '2021-05-15', 4, 65.00),
(116, 21, 21, '2021-06-01', 1, 18.25),
(117, 22, 22, '2021-06-15', 3, 53.00),
(118, 23, 23, '2022-01-05', 2, 32.00),
(119, 24, 24, '2022-01-20', 4, 77.00),
(120, 25, 25, '2022-02-10', 1, 26.00),
(121, 26, 26, '2022-03-01', 3, 57.00),
(122, 27, 27, '2022-03-20', 2, 29.75),
(123, 28, 28, '2022-04-01', 4, 62.00),
(124, 29, 29, '2022-05-01', 1, 21.75),
(125, 30, 30, '2022-05-15', 3, 49.00),
(126, 31, 31, '2022-06-01', 2, 31.50),
(127, 32, 32, '2022-06-15', 4, 68.00),
(128, 33, 33, '2023-01-10', 1, 23.50),
(129, 34, 34, '2023-02-01', 3, 61.00),
(130, 35, 35, '2023-02-20', 2, 28.25),
(131, 36, 36, '2023-03-01', 4, 80.00),
(132, 37, 37, '2023-04-01', 1, 20.00),
(133, 38, 38, '2023-04-15', 3, 54.00),
(134, 39, 39, '2023-05-01', 2, 30.75),
(135, 40, 40, '2023-05-15', 4, 67.00),
(136, 1, 1, '2023-06-01', 3, 50.00),
(137, 2, 2, '2023-06-15', 2, 25.00),
(138, 3, 3, '2023-06-25', 1, 18.50),
(139, 4, 4, '2024-01-10', 4, 70.00),
(140, 5, 5, '2024-02-01', 2, 32.00),
(141, 6, 6, '2024-02-15', 3, 48.00),
(142, 7, 7, '2024-03-01', 1, 20.00),
(143, 8, 8, '2024-03-15', 4, 55.00),
(144, 9, 9, '2024-04-01', 2, 27.50),
(145, 10, 10, '2024-04-15', 3, 62.00),
(146, 1, 7, '2024-08-06', 1, 30.00),
(147, 1, 82, '2024-08-06', 1, 5.30),
(148, 1, 3, '2024-08-06', 1, 1.00),
(149, 2, 1, '2024-08-08', 2, 197.99),
(151, 1, 3, '2024-08-08', 120, 20.99),
(152, 2, 3, '2024-08-08', 120, 20.99),
(153, 3, 3, '2024-08-08', 2, 20.99),
(154, 3, 3, '2024-08-08', 2, 20.99),
(155, 1, 7, '2024-08-08', 1, 10.50),
(159, 4, 14, '2024-08-08', 1, 17.99),
(160, 5, 8, '2024-08-08', 1, 14.95),
(161, 1, 3, '2024-08-08', 6, 20.99),
(162, 1, 3, '2024-08-10', 4, 20.99),
(163, 3, 3, '2024-08-27', 1, 20.99),
(174, 1, 1, '2024-09-05', 2, 197.99),
(175, 2, 2, '2024-09-10', 1, 12.50),
(176, 3, 3, '2024-09-15', 3, 20.99),
(177, 4, 4, '2024-09-20', 2, 11.75),
(178, 5, 5, '2024-09-25', 1, 18.25),
(179, 1, 6, '2024-10-01', 4, 24.99),
(180, 2, 7, '2024-10-05', 2, 10.50),
(181, 3, 8, '2024-10-10', 3, 14.95),
(182, 4, 9, '2024-10-15', 1, 19.99),
(183, 5, 10, '2024-10-20', 2, 22.50),
(242, 1, 1, '2020-01-01', 1, 197.99),
(243, 2, 2, '2020-02-01', 1, 12.50),
(244, 3, 3, '2020-03-01', 1, 20.99),
(245, 4, 4, '2020-04-01', 1, 11.75),
(246, 5, 5, '2020-05-01', 1, 18.25),
(247, 6, 6, '2020-06-01', 1, 24.99),
(248, 7, 7, '2020-07-01', 1, 10.50),
(249, 8, 8, '2020-08-01', 1, 14.95),
(250, 9, 9, '2020-09-01', 1, 19.99),
(251, 10, 10, '2020-10-01', 1, 22.50),
(252, 11, 11, '2020-11-01', 1, 18.95),
(253, 12, 12, '2020-12-01', 1, 21.50),
(254, 13, 13, '2021-01-01', 1, 19.75),
(255, 14, 14, '2021-02-01', 1, 17.99),
(256, 15, 15, '2021-03-01', 1, 20.00),
(257, 16, 16, '2021-04-01', 1, 1.00),
(258, 17, 17, '2021-05-01', 1, 21.00),
(259, 18, 18, '2021-06-01', 1, 15.25),
(260, 19, 19, '2021-07-01', 1, 20.99),
(261, 20, 20, '2021-08-01', 1, 18.00),
(262, 21, 21, '2021-09-01', 1, 19.50),
(263, 22, 22, '2021-10-01', 1, 22.00),
(264, 23, 23, '2021-11-01', 1, 17.75),
(265, 24, 24, '2021-12-01', 1, 16.99),
(266, 25, 25, '2022-01-01', 1, 14.50),
(267, 26, 26, '2022-02-01', 1, 18.25),
(268, 27, 27, '2022-03-01', 1, 20.50),
(269, 28, 28, '2022-04-01', 1, 19.95),
(270, 29, 29, '2022-05-01', 1, 22.99),
(271, 30, 30, '2022-06-01', 1, 23.50),
(272, 31, 31, '2022-07-01', 1, 16.75),
(273, 32, 32, '2022-08-01', 1, 18.50),
(274, 33, 33, '2022-09-01', 1, 20.25),
(275, 34, 34, '2022-10-01', 1, 17.25),
(276, 35, 35, '2022-11-01', 1, 24.50),
(277, 36, 36, '2022-12-01', 1, 26.75),
(278, 1, 1, '2023-01-01', 1, 197.99),
(279, 2, 2, '2023-02-01', 1, 12.50),
(280, 3, 3, '2023-03-01', 1, 20.99),
(281, 4, 4, '2023-04-01', 1, 11.75),
(282, 5, 5, '2023-05-01', 1, 18.25),
(283, 6, 6, '2023-06-01', 1, 24.99),
(284, 7, 7, '2023-07-01', 1, 10.50),
(285, 8, 8, '2023-08-01', 1, 14.95),
(286, 9, 9, '2023-09-01', 1, 19.99),
(287, 10, 10, '2023-10-01', 1, 22.50),
(288, 11, 11, '2023-11-01', 1, 18.95),
(289, 12, 12, '2023-12-01', 1, 21.50),
(290, 13, 13, '2024-01-01', 1, 19.75),
(291, 14, 14, '2024-02-01', 1, 17.99),
(292, 15, 15, '2024-03-01', 1, 20.00),
(293, 16, 16, '2024-04-01', 1, 1.00),
(294, 17, 17, '2024-05-01', 1, 21.00),
(295, 18, 18, '2024-06-01', 1, 15.25),
(296, 19, 19, '2024-07-01', 1, 20.99),
(297, 20, 20, '2024-08-01', 1, 18.00),
(298, 21, 21, '2024-09-01', 1, 19.50),
(299, 22, 22, '2024-10-01', 1, 22.00);

--
-- Disparadores `ventas`
--
DELIMITER $$
CREATE TRIGGER `after_insert_ventas` AFTER INSERT ON `ventas` FOR EACH ROW BEGIN
    -- Actualizar el stock del libro
    UPDATE libros
    SET stock = stock - NEW.cantidad
    WHERE id = NEW.idLibro;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `before_insert_ventas` BEFORE INSERT ON `ventas` FOR EACH ROW BEGIN
    DECLARE libro_stock INT;
    DECLARE libro_precio DECIMAL(10,2);

    -- Obtener el stock actual y el precio del libro
    SELECT stock, precio INTO libro_stock, libro_precio
    FROM libros
    WHERE id = NEW.idLibro;

    -- Verificar si la cantidad es mayor que el stock disponible
    IF NEW.cantidad > libro_stock THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'La cantidad a vender excede el stock disponible del libro.';
    END IF;

    -- Verificar si el precio es igual al precio del libro
    IF NEW.precio <> libro_precio THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'El precio de venta no coincide con el precio del libro.';
    END IF;
END
$$
DELIMITER ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `libros`
--
ALTER TABLE `libros`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_libros_proveedores` (`idProveedor`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idCliente` (`idCliente`),
  ADD KEY `idLibro` (`idLibro`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT de la tabla `libros`
--
ALTER TABLE `libros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=96;

--
-- AUTO_INCREMENT de la tabla `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=300;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `libros`
--
ALTER TABLE `libros`
  ADD CONSTRAINT `fk_libros_proveedores` FOREIGN KEY (`idProveedor`) REFERENCES `proveedores` (`id`);

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`idCliente`) REFERENCES `clientes` (`id`),
  ADD CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`idLibro`) REFERENCES `libros` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
