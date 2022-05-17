# CRUD PROJETO BAR DO ZÉ

Para a criação deste projeto utilizamos o Visual Studio para criação do layout e o código C# e o SQLServer para utilização do banco. O projeto se trata de uma tela de cadastro, onde será feito o cadastro de barman de um bar.

## Criação do banco de dados
No SQLServer iremos criar a tabela de funcionário com os campos Nome, e-mail, Senha, Endereço e ID, onde o ID será a chave primária abaixo está a tabela criada no SQL:

![Banco de Dados](https://user-images.githubusercontent.com/105616979/168860781-8671e2fd-4461-40a1-b8e7-16d18e51736f.jpg)


```
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbFuncionarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[Endereco] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbFuncionarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

## Visual Studio
Ao abrir o Visual Studio  criamos a tela de cadastro com as seguintes funções e campos NOME, E-MAIL, SENHA, ENDEREÇO e ID, os Botões CREATE, READ, UPDATE, DELETE, e incluir um DATAGRIDVIEW, está pronto o layout da tela de cadastro conforme a imagem abaixo:

![Tela de cadastro_1](https://user-images.githubusercontent.com/105616979/168852197-9f5a47ef-9c8c-4135-a6f0-183231c887a2.jpg)

## Fução Create.
Para que a função incluir esteja funcionando,é necessario fazer com que ao clicar no botão Create, os dados digitados nos campos sejam armazenados no banco de dados atravez dos codigos abaixo:

![criação de linha](https://user-images.githubusercontent.com/105616979/168923258-26c1edbe-5baf-49b7-b1fd-ecf1241be8d9.png)

## Função Read
Para função consultar no banco de dados, fizemos com que ao clicar no botão Read de o comando de consult pela chave primaria no banco, fazendo assim com que retorne o usuario de acordo com o ID(chave primaria) e nos mostre na tabela, os codigos para fazer a conexão com o banco e dar o comando a ele na imagem abaixo:

![leitura do banco](https://user-images.githubusercontent.com/105616979/168923496-ed2da6f4-3838-482b-8a59-1e152d636391.png)


## Função Update

Para fazer uma alteração de cadastro o botão Update basta colocar o numero do ID(chave primaria) e clicar Update. Para essa função funcionar é necessario que ao coloar o ID, apartir desse ID a informação do campo que deseja alterar foi utilizado os comandos abaixo:

![atualizar cadastro](https://user-images.githubusercontent.com/105616979/168923554-f3c68df9-439c-40b8-ac82-1aa773da2d7e.png)


## Função Delete

Para a função de deletar um cadastro dentro do banco de dados, foi necessario a utilização do codigo abaixo para que quando clicar em delete o comando seja executado no banco e remova o cadastro:

![deletar cadastro](https://user-images.githubusercontent.com/105616979/168923658-404fd7a5-b3c7-44d9-8b50-314428d0ec20.png)


Obrigado!

