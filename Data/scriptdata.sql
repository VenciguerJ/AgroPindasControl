USE [PINDUCAS_farm]
GO
SET IDENTITY_INSERT [dbo].[Cargos] ON 

INSERT [dbo].[Cargos] ([id_cargo], [cargo], [permissoes]) VALUES (1, N'MASTER', 1)
INSERT [dbo].[Cargos] ([id_cargo], [cargo], [permissoes]) VALUES (2, N'GERENTE', 2)
INSERT [dbo].[Cargos] ([id_cargo], [cargo], [permissoes]) VALUES (3, N'OPERADOR', 3)
SET IDENTITY_INSERT [dbo].[Cargos] OFF
GO
SET IDENTITY_INSERT [dbo].[Funcionarios] ON 

INSERT [dbo].[Funcionarios] ([id_usuario], [cpf], [senha], [nome], [telefone], [email], [id_cargo], [superior], [data_nascimento]) VALUES (1, N'47441293820', N'123', N'Jean', N'11953398867', N'jeanpedrosilva24@gmail.com', 1, NULL, CAST(N'2024-11-17T18:12:23.507' AS DateTime))
INSERT [dbo].[Funcionarios] ([id_usuario], [cpf], [senha], [nome], [telefone], [email], [id_cargo], [superior], [data_nascimento]) VALUES (2, N'36780921874', N'PINDAS21', N'Joao', N'11910789998', N'britojoao891@gmail.com', 1, NULL, CAST(N'2005-02-23T00:00:00.000' AS DateTime))
INSERT [dbo].[Funcionarios] ([id_usuario], [cpf], [senha], [nome], [telefone], [email], [id_cargo], [superior], [data_nascimento]) VALUES (3, N'72733274090', N'teamolula', N'Jair', N'99835229642', N'bolsonaro@gmail.com', 1, NULL, CAST(N'1970-11-20T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Funcionarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Fornecedor] ON 

INSERT [dbo].[Fornecedor] ([Id], [CNPJ], [RazaoSocial], [Endereco], [Fone], [Email]) VALUES (1, N'12342645346545', N'teste', N'sfddsfsadfasdfdsa', N'12312312312', N'jeanpedrosilva24@gmail.com')
SET IDENTITY_INSERT [dbo].[Fornecedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Compra] ON 

INSERT [dbo].[Compra] ([Id], [IdFornecedor], [ValorTotal], [DataCompra]) VALUES (1, 1, 2400.0000, CAST(N'2024-11-17' AS Date))
INSERT [dbo].[Compra] ([Id], [IdFornecedor], [ValorTotal], [DataCompra]) VALUES (2, 1, 240000.0000, CAST(N'2024-11-17' AS Date))
INSERT [dbo].[Compra] ([Id], [IdFornecedor], [ValorTotal], [DataCompra]) VALUES (3, 1, 1200.0000, CAST(N'2024-11-17' AS Date))
INSERT [dbo].[Compra] ([Id], [IdFornecedor], [ValorTotal], [DataCompra]) VALUES (4, 1, 12000.0000, CAST(N'2024-11-18' AS Date))
SET IDENTITY_INSERT [dbo].[Compra] OFF
GO
SET IDENTITY_INSERT [dbo].[UnidadeCadastro] ON 

INSERT [dbo].[UnidadeCadastro] ([Id], [Nome]) VALUES (1, N'Grama')
INSERT [dbo].[UnidadeCadastro] ([Id], [Nome]) VALUES (2, N'Quilo')
INSERT [dbo].[UnidadeCadastro] ([Id], [Nome]) VALUES (3, N'Unidade')
SET IDENTITY_INSERT [dbo].[UnidadeCadastro] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoProduto] ON 

INSERT [dbo].[TipoProduto] ([Id], [Nome]) VALUES (1, N'Embalagem')
INSERT [dbo].[TipoProduto] ([Id], [Nome]) VALUES (2, N'Materia Prima')
INSERT [dbo].[TipoProduto] ([Id], [Nome]) VALUES (3, N'Fertilizante')
SET IDENTITY_INSERT [dbo].[TipoProduto] OFF
GO
SET IDENTITY_INSERT [dbo].[Produto] ON 

INSERT [dbo].[Produto] ([Id], [Nome], [Descricao], [TemperaturaPlantio], [DiasColheita], [UnidadeCadastro], [TipoProduto], [ValorProduto]) VALUES (1, N'alface', N'Teste de valores', 10, 30, 1, 1, 12.0000)
INSERT [dbo].[Produto] ([Id], [Nome], [Descricao], [TemperaturaPlantio], [DiasColheita], [UnidadeCadastro], [TipoProduto], [ValorProduto]) VALUES (2, N'açúcar', N'Teste de valores', 10, 30, 1, 1, 12.0000)
INSERT [dbo].[Produto] ([Id], [Nome], [Descricao], [TemperaturaPlantio], [DiasColheita], [UnidadeCadastro], [TipoProduto], [ValorProduto]) VALUES (3, N'Agrião', N'Teste', 10, 30, 3, 2, 15.0000)
SET IDENTITY_INSERT [dbo].[Produto] OFF
GO
INSERT [dbo].[Lote] ([IdCompra], [IdProduto], [QuantidadeLote], [QuantidadeSaida]) VALUES (4, 1, 700, 200)
INSERT [dbo].[Lote] ([IdCompra], [IdProduto], [QuantidadeLote], [QuantidadeSaida]) VALUES (2, 2, 9900, 100)
GO
SET IDENTITY_INSERT [dbo].[Suporte_Calhas] ON 

INSERT [dbo].[Suporte_Calhas] ([Id], [CapacidadeMudas], [ocupada]) VALUES (1, 100, 1)
INSERT [dbo].[Suporte_Calhas] ([Id], [CapacidadeMudas], [ocupada]) VALUES (2, 150, 0)
SET IDENTITY_INSERT [dbo].[Suporte_Calhas] OFF
GO
SET IDENTITY_INSERT [dbo].[Producao] ON 

INSERT [dbo].[Producao] ([Id], [IdLoteUsado], [IdProdutoProduzido], [QuantidadeProduzido], [IdCalha], [DiaColheita], [finalizada]) VALUES (2, 2, 1, 100, 1, CAST(N'2024-12-17T18:25:18.763' AS DateTime), 1)
INSERT [dbo].[Producao] ([Id], [IdLoteUsado], [IdProdutoProduzido], [QuantidadeProduzido], [IdCalha], [DiaColheita], [finalizada]) VALUES (4, 4, 1, 100, 1, CAST(N'2024-12-18T22:54:52.397' AS DateTime), 1)
INSERT [dbo].[Producao] ([Id], [IdLoteUsado], [IdProdutoProduzido], [QuantidadeProduzido], [IdCalha], [DiaColheita], [finalizada]) VALUES (5, 4, 1, 100, 1, CAST(N'2024-12-19T20:38:02.590' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Producao] OFF
GO
SET IDENTITY_INSERT [dbo].[Estoque_Produto] ON 

INSERT [dbo].[Estoque_Produto] ([id], [id_estoque_produto], [id_producao], [quantidade_inicial], [quantidade_vendido]) VALUES (3, 1, 4, 100, 0)
SET IDENTITY_INSERT [dbo].[Estoque_Produto] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id], [Nome], [Email], [CPF], [Senha]) VALUES (1, N'trincas', N'britojoao891@gmail.com', N'36780921874', N'1234')
INSERT [dbo].[Clientes] ([Id], [Nome], [Email], [CPF], [Senha]) VALUES (6, N'teste-jena', N'britojoao891@gmail.com', N'11234567890', N'123')
INSERT [dbo].[Clientes] ([Id], [Nome], [Email], [CPF], [Senha]) VALUES (3, N'joao', N'britojoao891@gmail.com', N'36780921874', N'123')
INSERT [dbo].[Clientes] ([Id], [Nome], [Email], [CPF], [Senha]) VALUES (4, N'Jean Pedro Silva Vencigueri', N'jeanpedrosilva24@gmail.com', N'47441293820', N'123')
INSERT [dbo].[Clientes] ([Id], [Nome], [Email], [CPF], [Senha]) VALUES (5, N'jean', N'britojoao891@gmail.com', N'12345678911', N'1234')
INSERT [dbo].[Clientes] ([Id], [Nome], [Email], [CPF], [Senha]) VALUES (7, N'jeaaaa', N'britojoao891@gmail.com', N'09876543210', N'123')
INSERT [dbo].[Clientes] ([Id], [Nome], [Email], [CPF], [Senha]) VALUES (8, N'Jea', N'Jeanpedrosilva24@gmail.com', N'47441293820', N'123')
INSERT [dbo].[Clientes] ([Id], [Nome], [Email], [CPF], [Senha]) VALUES (9, N'Jea', N'Jeanpedrosilva24@gmail.com', N'47441293820', N'123')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedidos] ON 

INSERT [dbo].[Pedidos] ([Id], [CPF], [Produtos], [DataPedido]) VALUES (1, N'47441293820', N'teste de envio', CAST(N'2024-11-24T17:42:48.603' AS DateTime))
INSERT [dbo].[Pedidos] ([Id], [CPF], [Produtos], [DataPedido]) VALUES (2, N'47441293820', N'Alface e tomate patrão', CAST(N'2024-11-24T18:34:30.310' AS DateTime))
SET IDENTITY_INSERT [dbo].[Pedidos] OFF
GO
