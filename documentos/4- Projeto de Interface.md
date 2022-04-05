#  Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e interação interativa das telas com as funcionalidades fazem parte do sistema (wireframes).

Apresente como principais interfaces da plataforma. Discuta ela foi elaborada de forma a atender os funcionais, não funcional e histórias de usuário-Especificação nas exigências de projeto2. Especificad"> Documentação.

##  Diagrama de Fluxo

O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design seja de qualidade que não seja planejado bem e gerencie o design do wireframe que será desenvolvido em seguida.

O diagrama de fluxo pode ser desenvolvido com “boxes” que contêm internamente uma indicação dos principais elementos de interface - tais como menus e acessos - e funcionalidades, tais como editar, pesquisar, filtrar, configurar - e a conexão entre essas caixas a partir do processo de interação. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.



<br/>

![ padrao ](https://github.com/ICEI-PUC-Minas-PMV-ADS/Adote-pet/blob/main/docs/img/fluxo.png)



##  Estruturas de arame

Conforme tela de fluxo do projeto do projeto, conforme amostrado no item anterior, são mostrados em detalhes como as telas que seguem são exibidas. Essas telas têm uma estrutura comum que é apresentada na imagem. Nesta estrutura existem 3 grandes blocos, descritos a seguir. São eles:

-  **Casa de usuário fixos de identidade** - local onde são objetos de identificação (identidade fixa) e ícone;  
-  **Conteúdo** - apresenta o conteúdo da tela em questão, com informações e foto dos animais, filtro para busca;  
-  **Rodapé**  - apresenta um mapa do site e informações adicionais.


<br/>

![ padrao ](https://github.com/ICEI-PUC-Minas-PMV-ADS/Adote-pet/blob/main/docs/img/tela-padrao.png)



##  Tela - Página inicial   

A tela de homepage tem como principal objetivo fazer as buscas pelos animais de estimação que estão disponíveis para adoção

Com base na estrutura padrão, o bloco de conteúdo traz um filtro para facilitar a busca, um carrossel de imagem dos animais de estimação que está disponível para adoção e ao passar o mouse sobre a imagem do animal de estimação, a imagem será ampliada e ao lada da imagem as características dos animais de estimação.  

- Caso o usuário seja logado, ao clicar no botão DOAR ele será redirecionado para a tela CADAS PET, para que ele faça o cadastro do animal de estimação que será doado. Se o usuário não estiver logado, ele poderá redirecionar para a tela de login.
- O ícone do cachorro filtrará somente os cachorros disponíveis;
- O ícone do gato filtrará apenas os gatos disponíveis;
- Para uma localização avançada temos um componente para fazer a busca por localização e porte.  

<br/>

![ home ](https://github.com/ICEI-PUC-Minas-PMV-ADS/Adote-pet/blob/main/docs/img/home-tela.png)



##  Tela - Entrar

A tela de login apresenta o cabeçalho padrão, no bloco de conteúdo temos um formulário que solicita e-mail e senha para que o usuário efetue o login no sistema. Há também a opção para cadastro de novos usuários .

<br/>

![ login ](https://github.com/ICEI-PUC-Minas-PMV-ADS/Adote-pet/blob/main/docs/img/login.png)


##  Tela - Cadastro

O usuário poderá redirecionar para a tela de cadastro caso não possua cadastro ou queira editar as informações do perfil.  

- Nesta mesma tela o componente CADASTRO DE PET redireciona para a tela CADASTRO PET.  

- O usuário CRIAR UMA SENHA / REPITA SENHA só visível quando for componente de seu perfil ou perfil de usuário, não visível para edição.   

  <br/>

![ cadastro ](https://github.com/ICEI-PUC-Minas-PMV-ADS/Adote-pet/blob/main/docs/img/cadastro-tela.png)


##  Tela – Cadastro Pet

A tela de cadastro do animal de estimação, no bloco de conteúdo do animal de estimação, temos um formulário para que seja inserido como informações do animal de estimação.

- O ícone cachorro e gato deve ser selecionado de acordo com o animal que será feito.
- O componente FOTO DO PET permite que o doador insira uma foto do animal;
- Não é possível que o componente descritivo adicionado informações adicionais seja possível.
- É possível que as informações do pet sejam editadas no componente EDITAR INFORMAÇÕES

<br/>

![ cadastro-pet ](https://github.com/ICEI-PUC-Minas-PMV-ADS/Adote-pet/blob/main/docs/img/tela-cad-pet.png)
