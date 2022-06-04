<h1 align="center">Ride It :bike: </h1>

 <div align="center"> 
    <img src="https://img.shields.io/github/repo-size/jhonrmelo/RideItService"> 
    <img src="https://img.shields.io/github/commit-activity/w/jhonrmelo/RideItService">    
</div>

## :information_source: Descrição

### Repositório contendo o back-end do projeto RideIt, usado como trabalho de conclusão de curso de Ciência da computação.

O projeto tem como principal função o controle de informações do usuário, controle de rotas feitas anteriormente pelo usuário e construção baseado em feedbacks do melhor caminho entre uma rota escolhida pelo usuário, usando como base parametros personalizados como <b> Iluminação, Ciclovia, Estrada ou uma média dos 3 </b>


## :computer: Tecnologias e ferramental utilizados
### Framework
+ <b> .Net </b> - Framework utilizado para toda construção do código do projeto.
### Cloud

+ <b> AWS </b> - Utilizado como plataforma cloud para deploy do projeto e controle de arquivos como imagens e documentos.

### Database
+ <b> MongoDB </b> - Banco de dados NoSql utilizado neste projeto para o salvamento das rotas feitas pelos usuários.
+ <b> SqlServer </b> - Utilizado para o salvamento de informações relacionadas ao usuário, dados, caminhos de imagem e etc.
+ <b> ArangoDB </b> - Banco de dados em Grafos, principal ferramenta do projeto, utilizado para guardar o mapa que será percorrido pelo usuário, e também para o calculo de melhor caminho das rotas.

## 📘 Como Usar?

+ O projeto foi inteiramente construído utilizando o Visual Studio 2019, para a utilização é necessário usar esta versão ou uma superior.
+ Clone o repositório do projeto e abra-o com o Visual Studio.
+ Todas as configurações de conexões com ferramentas como Aws, MongoDB, ArangoDB, SqlServer e etc. estão no arquivo [AppSettings.json](https://github.com/jhonrmelo/RideItService/blob/main/tcc-service.Api/appsettings.json), para rodar o projeto atualize-o conforme a descrição do mesmo.


