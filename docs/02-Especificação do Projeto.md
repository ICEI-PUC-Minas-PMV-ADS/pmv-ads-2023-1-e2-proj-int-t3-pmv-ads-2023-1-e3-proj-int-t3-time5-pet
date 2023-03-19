# Especificações do Projeto

A definição dos problemas e necessidades detectados para idealizar esse projeto foi consolidada através da pesquisa de artigos e notícias publicados na Internet, que abordam o assunto e evidenciam o problema. Os detalhes levantados durante este processo foram consolidados na forma de personas e histórias de usuários.  

## Personas
As personas levantadas durante o processo são representadas nas figuras que se seguem:  

![image](https://user-images.githubusercontent.com/112135999/226174924-c7b248e0-d581-4dfd-a267-1025d5e1f3d1.png)

![image](https://user-images.githubusercontent.com/112135999/226174955-f88ef1f9-3cec-4dc5-842f-329ef64a32d9.png)

![image](https://user-images.githubusercontent.com/112135999/226174975-71f3c364-59cc-4750-bc6b-87f729fba55f.png)

![image](https://user-images.githubusercontent.com/112135999/226174998-3c7d4845-bfd1-4fcf-9140-4ae789bc7342.png)

![image](https://user-images.githubusercontent.com/112135999/226175012-9bafd70b-6e81-4d36-9d87-a94e88e46e26.png)

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.  

![Captura de Tela (292)](https://user-images.githubusercontent.com/117127986/225786513-984ca7ad-d71e-4ab3-8187-dca4ea8ded59.png)


## Requisitos

<!-- As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.
 -->
 Os requisitos funcionais descrevem as possibilidades de interação dos usuários
 
### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve possibilitar o cadastro do requerente a adoção, do responsável pela posse do pet em situação de adoção, com as seguintes informações: responsável (nome, endereço, telefone), pet (raça, sexo, nome e foto) e requerente (nome, endereço, telefone tipo de pet a adotar) | ALTA | 
|RF-002| O sistema deve fornecer os tipos de animais que o sistema irá disponibilizar para adoção. Por exemplo: Cachorro, Gato, Coelho etc.   | ALTA |
|RF-003| O sistema deve possibilitar o filtro dos pets, para que o adotante encontre o pet de sua preferência  | MÉDIA |
|RF-004| O sistema deve permitir aos usuários o acesso via login e senha | MÉDIA |
|RF-005| O sistema deve ser capaz de efetuar a adoção através do responsável pela posse do pet | MÉDIA |
|RF-006| O sistema deve apresentar uma página individual dos usuários com as informações cadastradas e no caso dos adotantes, sugestões de adoção a partir das preferências que o usuário cadastrou.  | BAIXA |
|RF-007| O sistema deve permitir o responsável pela posse do pet possa cadastrar mais de um pet | ALTA |

### Requisitos Não Funcionais
Os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RNF-001| O sistema deve ser responsivo com características de uso através de computadores, notebooks e telefones celulares; | ALTA | 
|RNF-002| O sistema deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge etc.) | ALTA |
|RNF-003| O sistema deve ser de fácil manuseio e de boa usabilidade no mercado;  | MÉDIA |
|RNF-004| O sistema deve ter uma boa e fácil manutenibilidade;  | MÉDIA |
|RNF-005| O sistema deve funcionar 24 horas por dia 7 dias por semana; | MÉDIA |
|RNF-006|O sistema deve ser seguro e permitir o acesso apenas a usuários cadastrados; | ALTA |

## Restrições

As questões que limitam a execução do sistema e que se configuram como obrigações claras para o desenvolvimento do projeto são:

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RE-001| O site não deve fornecer informações cadastrais dos responsáveis pela posse do pet, a pessoas que não tem interesse na adoção de pets; 
|RE-002| O aplicativo deve ser construído no back-end através da linguagem C#;
|RE-003| O aplicativo não deve conter API;
|RE-004| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 30/06/2023;
|RE-005| A equipe não pode subcontratar o desenvolvimento do trabalho;
|RE-006| O sistema deve se restringir ao uso de Entity Framework;
|RE-007| O sistema deverá se conectar com o Microsoft SQL Server ou MySQL;


## Diagrama de Casos de Uso

 Caso de Uso
 
O responsável pela adoção se cadastra inicialmente através do nome, endereço (Cidade e Estado),
telefone de contato, login e senha. Depois cadastra o(s) pet(s) em situação de adoção com o 
tipo de pet, raça, sexo, nome e uma foto. Alguns responsáveis são ONG’s ou Petshops.

Os responsáveis pela posse dos pets podem ser responsáveis por mais de um pet.
O adotante se cadastra através do nome, endereço (Cidade e Estado), telefone, login e senha e já 
define quais as preferências em relação ao tipo de pet a adotar. O requerente não encontrando 
um pet de seu interesse para adoção na sua página inicial, acessa o painel de pets disponíveis para 
efetuar um filtro com todas as características disponíveis dos pets em situação de adoção, como: tipo, 
foto, raça, nome etc. Quando o adotante encontra o pet para adoção, ele sinaliza no sistema o interesse 
no pet, e o sistema disponibiliza o contato do responsável pela adoção, quando o mesmo concordar, para 
que ajustem as condições e finalizem o processo de adoção.

Finalizado o processo de adoção, o responsável acessa o sistema e conclui a adoção, retirando o 
pet adotado dos demais em situação de adoção.

![image](https://user-images.githubusercontent.com/104168502/225792939-2e857404-40c2-40fd-b954-bd475673ed9b.png)




