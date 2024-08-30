# C#: Exercícios de Lógica e Programação com Matrizes
**Este repositório contém soluções em C# para cinco desafios de programação utilizando matrizes:**

## 1. Armazenamento e Exibição de Valores em Matriz:
- **Desafio:** Crie um programa que armazena seis valores em uma matriz de ordem 3x2 e exibe os valores na tela.
- **Solução:** O programa declara uma matriz de inteiros de 3 linhas e 2 colunas. Através de um loop, o usuário insere os valores que serão armazenados na matriz. Em seguida, outro loop é utilizado para percorrer a matriz e exibir os valores armazenados na tela.

## 2. Multiplicação de Matriz por Constante:
- **Desafio:** Crie um programa que lê doze valores do usuário, armazena-os em uma matriz de ordem 3x4 e, após a digitação, solicita uma constante multiplicativa. A constante multiplica cada valor da matriz, armazenando o resultado na própria matriz.
- **Solução:** O programa declara uma matriz de inteiros de 3 linhas e 4 colunas e solicita ao usuário que digite os doze valores que serão armazenados na matriz. Em seguida, solicita uma constante multiplicativa e percorre a matriz, multiplicando cada valor da matriz pela constante e atualizando a matriz com os resultados.

## 3. Multiplicação de Matriz por Constante com Nova Matriz:
- **Desafio:** Crie um programa que lê doze valores do usuário, armazena-os em uma matriz de ordem 3x4 e, após a digitação, solicita uma constante multiplicativa. A constante multiplica cada valor da matriz, armazenando o resultado em uma nova matriz de mesma ordem. Ambas as matrizes são exibidas na tela.
- **Solução:** O programa declara duas matrizes de inteiros de 3 linhas e 4 colunas. A primeira matriz armazena os valores digitados pelo usuário. Em seguida, solicita uma constante multiplicativa e percorre a primeira matriz, multiplicando cada valor pela constante e armazenando o resultado na segunda matriz. Ambas as matrizes são exibidas na tela.

## 4. Matriz Transposta:
- **Desafio:** Crie um programa que recebe do usuário a ordem de uma matriz MxN (no máximo 10x10), lê os elementos da matriz e exibe a matriz transposta.
- **Solução:** O programa solicita ao usuário a ordem da matriz (M e N), valida se a ordem está dentro dos limites (máximo 10x10) e cria uma matriz de inteiros com a ordem fornecida. O programa então solicita ao usuário que digite os elementos da matriz. Em seguida, cria uma nova matriz (matriz transposta) com as dimensões trocadas (NxM). O programa percorre a matriz original e copia cada elemento para a matriz transposta, trocando as linhas e colunas. A matriz transposta é então exibida na tela.

## 5. Sistema de Reserva de Poltronas:
- **Desafio:** Crie um programa que controla as reservas de poltronas de uma peça teatral. O programa recebe do usuário o número de seções, fileiras e cadeiras por seção. O usuário pode reservar uma poltrona informando seu nome, seção, fileira e cadeira. Se a cadeira estiver livre, a reserva é realizada. Caso contrário, o programa informa que a cadeira está ocupada e solicita outro lugar. O sistema permite reservas até completar 4/5 da capacidade total do teatro. No final, o programa exibe um "mapa" com as cadeiras ocupadas e os nomes dos ocupantes.
- **Solução:** O programa declara uma matriz tridimensional para representar o teatro, com o número de seções, fileiras e cadeiras fornecidos pelo usuário. Cada posição da matriz representa uma poltrona, que inicialmente está livre. O programa solicita ao usuário informações para reserva, verifica se a cadeira está livre e atualiza a matriz com o nome do usuário e a reserva. O programa monitora o número de reservas e impede novas reservas quando atinge 4/5 da capacidade total do teatro. Ao final, o programa percorre a matriz e exibe um "mapa" do teatro, mostrando os nomes dos ocupantes das cadeiras reservadas ou "Livre" para cadeiras disponíveis.

## Como usar:
**Para utilizar cada um dos programas, você pode:**
- Criar um novo projeto C# no Visual Studio ou em sua IDE preferida.
- Copiar o código C# da solução desejada e colá-lo no arquivo Program.cs do seu projeto.
- Comentar os demais exercícios e testar somente o que desejar.
- Seguir as instruções na tela para inserir os dados necessários.

## Pontos de Aprendizagem:
**Esses exercícios exploram conceitos importantes da programação em C#, como:**
- **Matrizes:** Declaração, inicialização e acesso aos elementos de matrizes multidimensionais.
- **Loops:** Loops for e while para iterar sobre os elementos de uma matriz.
- **Condicionais:** Instruções if, else e else if para tomar decisões com base em condições, como a disponibilidade de uma cadeira ou a capacidade total do teatro.
- **Entrada e saída:** Como solicitar entrada do usuário e exibir resultados na tela, incluindo a formatação de matrizes.

## Contribuindo:
**Sinta-se à vontade para fazer o fork deste repositório, adicionar novos exercícios, melhorar as soluções existentes, e compartilhar suas contribuições!**
