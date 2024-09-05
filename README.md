# Projeto - Cálculo de Raízes com Bhaskara em C# e xUnit

## Descrição do Projeto

Este projeto implementa a fórmula de **Bhaskara** para calcular as raízes de equações quadráticas da forma \( ax^2 + bx + c = 0 \). O cálculo das raízes é feito utilizando uma biblioteca de classes em C#, e o comportamento da aplicação é testado com **xUnit**, cobrindo os principais cenários de cálculo.

### Estrutura do Projeto

- **BhaskaraApp**: Biblioteca de classes que contém a implementação da fórmula de Bhaskara.
- **BhaskaraTests**: Projeto de testes unitários, utilizando xUnit para verificar o comportamento da função de cálculo.

### Lógica de Cálculo

A fórmula de Bhaskara para calcular as raízes reais de uma equação quadrática é:

x1, x2 = (-b ± √(b^2 - 4ac)) / (2a)

### Tecnologias Utilizadas

- **C#**
- **xUnit** (para testes unitários)

## Clonando o Projeto

Para clonar o repositório e rodar o projeto localmente, siga os passos abaixo:

```bash
git clone https://github.com/usuario/repo-bhaskara.git
cd repo-bhaskara
