# CasaDoSaber

				                                                                Sistema de Gestão Escolar

A escola casa do saber que utilizava planilhas para gestionar seus professores, turmas e alunos decidiu se informatizar e requisitou a construção de um sistema para fazê-lo.


Para este sistemas teremos duas entidades que estarão presentes no banco de dados (portanto existirão por enquanto duas tabelas):


Professor
 - código de funcionário (PK)
 - nome
 - telefone
 - nivel de graduação
 - salário
 - disciplina


 Aluno 

 - matricula (PK)
 - nome
 - série
 - data de nascimento


A primeira tarefa é modelar um cadastro completo (Criar, Remover, Consultar e Listar) para essas duas entidades, incluindo a interface de usuário necessária para fazê-la. Além disso, deveremos ter uma listagem de professores por disciplina, e uma listagem de alunos por série, além da funcionalidade de promover o aluno de série (modificar sua série).


Por fim teremos uma entidade que (ainda) não será guardada no nosso banco de dados, portanto deverá ser guardada em memória. As Turmas.

Cada turma deverá conter uma lista de alunos e um professor como atributos, o seu código e a sala (String) onde ela ocorre.

Você deverá modelar em seu sistema um menu (e todas as classes que julgar necessário) para gerir as turmas, através dos quais nós seremos capazes de 
- criar uma turma, 
- adicionar um professor à uma turma, 
- adicionar um aluno à uma turma (só deverá ser possível caso a turma já possua um professor), 
- imprimir a lista de chamada (gerar um arquivo TXT com o nome do professor e dos alunos daquela turma), 
EX: 
Turma XPTO Sala X
Professor: <Nome do Professor>
  Nome               Matrícula
<Nome Aluno1>    <Matricula aluno1>
<Nome Aluno2>    <Matricula aluno2>


- listar as turmas (mostrar somente código e sala) 
- e excluir uma turma. 
