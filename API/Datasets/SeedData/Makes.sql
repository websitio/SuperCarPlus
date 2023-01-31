USE [Keycost]
GO
/****** Object:  Table [Make]   Script Date: 15/12/2022 18:54:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [kc_admin].[maBrand](
	[pkid] [int] NOT NULL,
	[brandname] [varchar](50) NOT NULL,
	[fkcategoryID] [int] NOT NULL,
	[fkbrandtypo] [int] NULL
) ON [PRIMARY]
GO
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (1, N'Aston Martin', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (2, N'Audi', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (3, N'Austin', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (4, N'Bentley', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (5, N'BMW', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (6, N'Cadillac', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (7, N'Chevrolet', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (8, N'Chrysler', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (9, N'Citroen', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (10, N'Dacia', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (11, N'Daewoo', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (12, N'Daihatsu', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (13, N'Dodge', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (14, N'Ferrari', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (15, N'Fiat', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (16, N'Ford', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (17, N'Galloper', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (18, N'Honda', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (19, N'Hummer', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (20, N'Hyundai', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (21, N'Infiniti', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (22, N'Isuzu', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (23, N'Jaguar', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (24, N'Jeep', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (25, N'Kia', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (26, N'Lada', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (27, N'Lamborghini', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (28, N'Lancia', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (29, N'Land-Rover', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (30, N'Lexus', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (31, N'Lotus', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (32, N'Maserati', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (33, N'Mazda', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (34, N'Mercedes-Benz', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (35, N'MG', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (36, N'Mini', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (37, N'Mitsubishi', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (38, N'Nissan', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (39, N'Opel', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (40, N'Peugeot', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (41, N'Pontiac', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (42, N'Porsche', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (43, N'Renault', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (44, N'Rolls-Royce', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (45, N'Rover', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (46, N'Saab', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (47, N'Seat', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (48, N'Skoda', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (49, N'Smart', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (50, N'Ssangyong', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (51, N'Subaru', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (52, N'Suzuki', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (53, N'Talbot', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (54, N'Tata', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (55, N'Toyota', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (56, N'Volkswagen', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (57, N'Volvo', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (58, N'Otra marca', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (59, N'Aeon', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (60, N'Adly', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (61, N'Alfer', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (62, N'Aprilia', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (63, N'Atala', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (64, N'Bajaj', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (65, N'Benelli', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (66, N'Beta', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (67, N'Bimota', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (68, N'BJR', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (69, N'BMW', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (70, N'Bombardier', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (71, N'Buell', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (72, N'Bultaco', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (73, N'Cagiva', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (74, N'CSR', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (75, N'Daelim', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (76, N'Derbi', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (77, N'DKW', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (78, N'Ducati', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (79, N'FactoryBike', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (80, N'Fantic', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (81, N'Gasgas', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (82, N'Gilera', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (83, N'Hanway', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (84, N'HarleyDavidson', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (85, N'HM', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (86, N'Honda', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (87, N'HRD', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (88, N'Husaberg', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (89, N'Husqvarna', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (90, N'Hyosung', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (91, N'Indian', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (92, N'Italjet', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (93, N'Kawasaki', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (94, N'Keeway', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (95, N'KTM', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (96, N'Kymco', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (97, N'Lambretta', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (98, N'Laverda', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (99, N'Leonart', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (100, N'LML', 4)
GO
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (101, N'Malaguti', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (102, N'MBK', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (103, N'Mecatecno', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (104, N'Merlin', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (105, N'Mobylette', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (106, N'Mondial', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (107, N'Montesa', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (108, N'Morini', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (109, N'Moto Guzzi', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (110, N'Motogac', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (111, N'MotorHispania', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (112, N'Muz', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (113, N'MV Agusta', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (114, N'Ossa', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (115, N'Peugeot', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (116, N'PGO', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (117, N'Piaggio', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (118, N'Polaris', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (119, N'Puch', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (120, N'Renault', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (121, N'Rieju', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (122, N'Riya', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (123, N'RoyalEnfield', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (124, N'Sanglas', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (125, N'Scomadi', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (126, N'Scorpa', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (127, N'Sherco', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (128, N'Siam', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (129, N'Sumco', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (130, N'Suzuki', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (131, N'Sym', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (132, N'TGB', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (133, N'TM', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (134, N'Triumph', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (135, N'UniversalMotor', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (136, N'Vem', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (137, N'Vespa', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (138, N'Vespino', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (139, N'Victory', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (140, N'Yamaha', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (141, N'Alfa Romeo', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (142, N'Marcos', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (143, N'McLaren', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (144, N'Morgan', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (145, N'Noble', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (146, N'Pagini', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (147, N'Panther', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (148, N'AC', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (149, N'Arash', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (150, N'Ariel', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (151, N'Ascari', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (152, N'BAC', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (153, N'Bristol', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (154, N'Ultima', 4)
INSERT [Make]([Id],[Name], [CategoryId]) VALUES (155, N'Bugatti', 4)
