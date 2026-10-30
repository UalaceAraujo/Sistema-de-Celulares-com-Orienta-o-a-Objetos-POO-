# Sistema de Celulares com Orientação a Objetos (POO)

Projeto desenvolvido para o desafio da Trilha .NET da DIO. O sistema implementa os conceitos de Orientação a Objetos (Abstração, Herança e Polimorfismo) para simular o comportamento de diferentes marcas de smartphones.

## Tecnologias Utilizadas
- .NET 8
- C#
- Git e GitHub

## Estrutura do Projeto
- **Smartphone.cs**: Classe abstrata base contendo as propriedades comuns (Número, Modelo, IMEI, Memória) e métodos gerais (`Ligar`, `ReceberLigacao`).
- **Nokia.cs**: Classe filha que herda de `Smartphone` e implementa a instalação de aplicativos via Ovi Store.
- **Iphone.cs**: Classe filha que herda de `Smartphone` e implementa a instalação de aplicativos via App Store.
- **Program.cs**: Código de execução e simulação dos aparelhos via terminal.

## Como Executar
1. Clone o repositório:
   ```bash
   git clone [https://github.com/UalaceAraujo/Sistema-de-Celulares-com-Orienta-o-a-Objetos-POO-.git](https://github.com/UalaceAraujo/Sistema-de-Celulares-com-Orienta-o-a-Objetos-POO-.git)