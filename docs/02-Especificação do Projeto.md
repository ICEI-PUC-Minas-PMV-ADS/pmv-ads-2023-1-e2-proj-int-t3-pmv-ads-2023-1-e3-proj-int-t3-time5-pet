# Especificações do Projeto

A definição dos problemas e necessidades detectados para idealizar esse projeto foi consolidada através da pesquisa de artigos e notícias publicados na Internet, que abordam o assunto e evidenciam o problema. Os detalhes levantados durante este processo foram consolidados na forma de personas e histórias de usuários.
## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

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
|RF-007| O sistema deve permitir o responsável pela posse do pet ser responsável por mais de um pet | ALTA |

### Requisitos não Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RNF-001| O sistema deve ser responsivo com características de uso através de computadores, notebooks e telefones celulares; | ALTA | 
|RNF-002| O sistema deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge etc.) | ALTA |
|RNF-003| O sistema deve ser de fácil manuseio e de boa usabilidade no mercado;  | MÉDIA |
|RNF-004| O sistema deve ter uma boa e fácil manutenibilidade;  | MÉDIA |
|RNF-005| O sistema deve funcionar 24 horas por dia 7 dias por semana; | MÉDIA |
|RNF-006|O sistema deve ser seguro e permitir o acesso apenas a usuários cadastrados; | ALTA |

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

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




