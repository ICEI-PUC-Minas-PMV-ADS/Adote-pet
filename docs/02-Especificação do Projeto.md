# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Patricia Amaral tem 20 anos, solteira, é analista de marketing, trabalha em tempo integral e está focada no seu crescimento profissional. É apaixonada por animais e está sempre acompanhando pelas redes sociais.

Maria Aparecida tem 62 anos, viuva, aposentada e tem uma vida financeiramente tranquila, pois adora animais, plantas e está sempre ajudando a ONG próximo sua casa. Gosta de postar fotos de suas plantas e trabalhos na ONG em suas redes sociais.

Francisca Santos tem 37 anos, casada e tem 2 filhos, trabalha em casa como cabeleleira e divulga seu trabalho pelas redes socias. Pensa futuramente em adotar um pet para seus filhos, gosta de ir ao parque com a família aos finais de semana.

Lúcio Sabino tem 42 anos, solteiro, trabalha como veterinário é especialista em animais de pequeno porte. Faz parte de uma ONG onde acolhe animais de ruas.Em sua folga gosta estudar sobre animais e ir ao parque com seu pet.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`|          QUERO/PRECISO ... `FUNCIONALIDADE`                    |                 PARA ... `MOTIVO/VALOR`                                        |
______________________________________________________________________________________________________________________________________________________________________
| Patricia Amaral    | Adotar um animal de pequeno porte pois mora em apartamento     | Adoro animais e me fará companhia quando eu estiver em casa                    |
_______________________________________________________________________________________________________________________________________________________________________
| Maria Aparecida    | Um site onde eu possa escolher qual pet adotar sem sair de casa| Pelas minhas limitações não posso sair de casa pra encontrar um animal         |
_______________________________________________________________________________________________________________________________________________________________________
| Francisca Santos   | Um pet para ajudar no desenvolvimento dos filhos               |  Os filhos terem uma ocupação a mais em casa enquanto ela está no trabalho     |
_______________________________________________________________________________________________________________________________________________________________________
| Lúcio Sabino       |Divulgar os animais que são abandonados que precisam de ajuda   |  Encontrar um lar para os animais que foram abandonados                        |
_______________________________________________________________________________________________________________________________________________________________________

|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir. 

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues. 

| **ID** | **Descrição**                                                | **Prioridade** |
| ------ | ------------------------------------------------------------ | -------------- |
| RF-01  | O site deve permitir que o usuário crie perfil               | Alta           |
| RF-02  | O site deve permitir que o usuário poste foto dos animais que precisam de adoção | Alta           |
| RF-03  | O site deve possibilitar fazer uma descrição das características e da localização dos animais que será adotado no momento da postagem | Alta           |
| RF-04  | O site deve permitir que com um único perfil o usuário possa adotar ou postar um animal para adoção | Média          |
| RF-05  | O site de permitir o usuário editar o perfil                 | Alta           |
| RF-06  | O site deve permitir que o usuário edite fotos dos animais que precisam de adoção | Media          |
| RF-07  | O site deve permitir a edição da descrição das características e localização do dos animais | Media          |
| RF-08  | O site deve permitir que o perfil que postou fotos, dados ou características dos animais posso exclui-la ou colocar com adotado. | Media          |
| RF-09  | O site deve permitir ao usuário pesquisar animais.           | Alta           |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender. 

| **ID** | **Descrição**                                                | **Prioridade** |
| ------ | ------------------------------------------------------------ | -------------- |
| RNF-01 | O site deverá ser responsivo permitindo a visualização em um celular de forma adequada | Alta           |
| RNF-02 | O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge, Safari) | Alta           |
|        |                                                              |                |
|        |                                                              |                |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
