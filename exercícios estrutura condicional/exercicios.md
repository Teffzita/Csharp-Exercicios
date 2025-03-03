# Curso C# Completo
http://educandoweb.com.br

**Prof. Dr. Nelio Alves**

Capítulo: Recapitulação de Lógica de Programação usando C# como linguagem

**Exercícios sobre Estrutura Condicional (if-else)**
Exercícios obtidos do URI Online Judge: www.urionlinejudge.com.br

##  Exercícios propostos

**Exercício 1**

Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

**Exemplos:**
Entrada: | Saída:
:---: | :---: 
-10 | NEGATIVO

Entrada: | Saída:
:---: | :---: 
8 | NAO NEGATIVO

Entrada: | Saída:
:---: | :---: 
0 | NAO NEGATIVO

[**Resolução**](https://github.com/Teffzita/Csharp-Exercicios/blob/main/exercícios%20estrutura%20condicional/Ex1/Ex1/Program.cs)

***

**Exercício 2**

Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

**Exemplos:**
Entrada: | Saída:
:---: | :---: 
12 | PAR

Entrada: | Saída:
:---: | :---: 
-27 | ÍMPAR

Entrada: | Saída:
:---: | :---: 
0 | PAR

[**Resolução**](https://github.com/Teffzita/Csharp-Exercicios/blob/main/exercícios%20estrutura%20condicional/Ex2/Ex2/Program.cs)

***

**Exercício 3**

Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

**Exemplos:**
Entrada: | Saída:
:---: | :---: 
6 24 | São múltiplos

Entrada: | Saída:
:---: | :---: 
6 25 | Não são múltiplos

Entrada: | Saída:
:---: | :---: 
24 6  | São múltiplos


[**Resolução**](https://github.com/Teffzita/Csharp-Exercicios/blob/main/exercícios%20estrutura%20condicional/Ex3/Ex3/Program.cs)

***

**Exercício 4**

Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

**Exemplos:**
Entrada: | Saída:
:---: | :---: 
16 2  | O jogo durou 10 hora(s)

Entrada: | Saída:
:---: | :---: 
0 0 | O jogo durou 24 hora(s)

Entrada: | Saída:
:---: | :---: 
2 16 | O jogo durou 14 hora(s)

[**Resolução**](https://github.com/Teffzita/Csharp-Exercicios/blob/main/exercícios%20estrutura%20condicional/Ex4/Ex4/Program.cs)

***

**Exercício 5**

Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

Código | Especificação | Preço
:---: | :---: | :---:
1 | Cachorro Quente | R$ 4.00
2 | X-Salada | R$ 4.50
3 | X-Bacon | R$ 5.00
4 | Torrada Simples | R$ 2.00
5 | Refrigerante | R$ 1.50

**Exemplos:**
Entrada: | Saída:
:---: | :---: 
3 2 | Total: R$ 10.00

Entrada: | Saída:
:---: | :---: 
2 3 | Total: R$ 13.50


[**Resolução**](https://github.com/Teffzita/Csharp-Exercicios/blob/main/exercícios%20estrutura%20condicional/Ex5/Ex5/Program.cs)

***

**Exercício 6**

Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

**Exemplos:**
Entrada: | Saída:
:---: | :---: 
25.01 | Intervalo (25,50]

Entrada: | Saída:
:---: | :---: 
25.00 | Intervalo [0,25]

Entrada: | Saída:
:---: | :---: 
100.00 | Intervalo (75,100]

Entrada: | Saída:
:---: | :---: 
-25.02 | Fora de intervalo

[**Resolução**](https://github.com/Teffzita/Csharp-Exercicios/blob/main/exercícios%20estrutura%20condicional/Ex6/Ex6/Program.cs)

***

**Exercício 7**

ia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”. 
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

Q2 | Q1
:---: | :---:
Q3 | Q4

**Exemplos:**
Entrada: | Saída:
:---: | :---: 
4.5 -2.2 | Q4

Entrada: | Saída:
:---: | :---: 
0.1 0.1 | Q1

Entrada: | Saída:
:---: | :---: 
0.0 0.0 | Origem

[**Resolução**](https://github.com/Teffzita/Csharp-Exercicios/blob/main/exercícios%20estrutura%20condicional/Ex7/Ex7/Program.cs)

***

**Exercício 8**

Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

**Renda** | **Imposto de Renda**
:---: | :---: 
de 0.00 até R$ 2000.00 | Isento
de R$ 2000.01 até R$ 3000.00| 8%
de R$ 3000.01 até R$ 4500.00 | 18%
acima de R$ 4500.00 | 28%

Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.

**Exemplos:**
Entrada: | Saída:
:---: | :---: 
3002.00 | R$ 80.36

Entrada: | Saída:
:---: | :---: 
1701.12 | Isento

Entrada: | Saída:
:---: | :---: 
4520.00 | R$ 355.60

[**Resolução**](https://github.com/Teffzita/Csharp-Exercicios/blob/main/exercícios%20estrutura%20condicional/Ex8/Ex8/Program.cs)
