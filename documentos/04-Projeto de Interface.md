
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

 Apresente as principais interfaces da plataforma. Discuta como ela foi elaborada de forma a atender os requisitos funcionais, não funcionais e histórias de usuário abordados nas <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a>.

## Diagrama de Fluxo

O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.

O diagrama de fluxo pode ser desenvolvido com “boxes” que possuem internamente a indicação dos principais elementos de interface - tais como menus e acessos - e funcionalidades, tais como editar, pesquisar, filtrar, configurar - e a conexão entre esses boxes a partir do processo de interação. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.



p><img *src*="https://github.com/ICEI-PUC-Minas-PMV-ADS/Adote-pet/blob/main/docs/img/fluxo.png" *alt*=""> </p>





## Wireframes

Conforme fluxo de telas do projeto amostrado no item anterior, as telas do sistema são apresentadas em detalhes nos itens que se seguem. Todas essas telas têm uma estrutura comum que é apresentada na imagem. Nesta estrutura existem 3 grandes blocos, descritos a seguir. São eles:

- **Cabeçalho** - local onde são dispostos elementos fixos de identidade (logo) e ícone de usuário;  
- **Conteúdo** - apresenta o conteúdo da tela em questão, com informações e foto dos animais, filtro para busca;  
- **Rodapé** - apresenta um mapa do site e informações adicionais.

![padrao](https://github.com/ICEI-PUC-Minas-PMV-ADS/Adote-pet/blob/main/docs/img/tela-padrao.png)



## Tela - Home Page   

A tela de home-page tem como principal objetivo fazer as buscas pelos pets que estão disponíveis para adoção 

Com base na estrutura padrão, o bloco de conteúdo traz um filtro para facilitar a busca, um carrossel de imagem dos pets que estão disponíveis para adoção e ao passar o mouse sobre a imagem do pet, a imagem será ampliada e ao lada da imagem terá as descrições das características dos pets.  

- Caso o usuário esteja logado, ao clicar no botão DOAR ele será redirecionado para a tela CADASTRO PET, para que ele faça o cadastro do pet que será doado. Se o usuário não estiver logado ele será redirecionado para a tela login. 
- O ícone do cachorro filtrará somente os cachorros disponíveis; 
- O ícone do gato filtrará somente os gatos disponíveis; 
- Para uma filtragem avançada temos um componente para fazer busca por localização e porte.  



## Tela - Login

A tela de login apresenta o cabeçalho padrão, no bloco de conteúdo temos um formulário que solicita e-mail e senha para que o usuário efetue o login no sistema. Há também a opção para cadastro de novos usuários.



## Tela - Cadastro 

O usuário será redirecionado para a tela de cadastro caso não possua cadastro ou queira editar as informações do perfil.  

- Nesta mesma tela o componente CADASTRO DE PET redireciona para a tela CADASTRO PET.  

- O componente CRIAR UMA SENHA / REPITA SENHA só ficará visível quando o usuário estiver criando o perfil, para edição de perfil esse componente não ficará visível.   

  

## Tela – Cadastro Pet 

A tela cadastro pet, no bloco de conteúdo temos um formulário para que seja inserido as informações do pet. 

- O ícone cachorro e gato deverá ser selecionado de acordo com o animal que será doado. 
- O componente FOTO DO PET permite que o doador insira uma foto do animal; 
- No componente DESCRIÇÃO é possível que o doador adicione informações adicionais. 
- É possível que as informações do pet sejam editadas no componente EDITAR INFORMAÇÕES 
