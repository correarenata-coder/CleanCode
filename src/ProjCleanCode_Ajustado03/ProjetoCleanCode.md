# 🧹 Clean Code

___

#  🏷️ Alguns itens para ajustar:
- Classe CalcularDeDesconto: Tem mais de uma responsábilidade, pois além de calcular o desconto, também tem a responsabilidade de determinar o tipo de desconto com base nos anos de fidelidade do cliente. Isso viola o princípio da responsabilidade única (SRP) do SOLID.
- Classe CalcularDeDesconto: Não está aberta para extensão
- Classe CalcularDeDesconto: Depende de valores específicos (números mágicos) para determinar o tipo de desconto
- Classe CalcularDeDesconto: Pode ser melhorada para testar.

___

# Resumo dos principios SOLID:
- **S**: Single Responsibility Principle (SRP) - Princípio da Responsabilidade Única, diz que uma classe deve ter apenas uma tarefa ou responsabilidade.
A classe deve ter apenas um motivo para ser alterada, ou seja, deve ser responsável por apenas uma parte do funcionamento do sistema.
- **O**: Open/Closed Principle (OCP) - Princípio Aberto/Fechado -afirma que o código deve ser aberto para extensão , mas fechado para modificação.
- Isso significa que você pode adicionar novos comportamentos sem alterar o código existente.
- **L**: Liskov Substitution Principle (LSP) - Princípio da Substituição de Liskov -afirma que objetos de uma classe derivada deve pode substituir obejtos da classe base sem alterar o comportamento
- correto do programa
- **I**: Interface Segregation Principle (ISP) - Princípio da Segregação de Interface - Afirma que não uam classe não deve ser forçada a implementar interfaces que não usa.
- **D**: Dependency Inversion Principle (DIP) - Princípio da Inversão de Dependência - diz que as classes de alto nivel não devem depender de classes de baixo nível, mas sim de abstrações.

___
# Resumo de padrões de projeto:
São soluçoes reutilizaveis para problemas comuns que ocorrem durente no desenvolvimento de software.
___

# Quais padrões iremos aplicar no projeto ?
- Strategy: O padrão Strategy é um padrão de design comportamental que permite definir uma família de algoritmos, encapsulá-los e torná-los intercambiáveis. Ele permite que o algoritmo varie independentemente dos clientes que o utilizam. No contexto do projeto, o padrão Strategy pode ser aplicado para calcular diferentes tipos de desconto com base no tipo de cliente ou na quantidade de anos de fidelidade.
- Factory Method: O padrão Factory Method é um padrão de design criacional que define uma interface para criar objetos, mas permite que as subclasses decidam qual classe instanciar. Ele promove a flexibilidade e a extensibilidade do código, permitindo que novas classes sejam adicionadas sem modificar o código existente. No contexto do projeto, o padrão Factory Method pode ser aplicado para criar diferentes tipos de desconto com base no tipo de cliente ou na quantidade de anos de fidelidade, encapsulando a lógica de criação dos objetos de desconto em uma fábrica.

___

# O que vamos resolver ?
A responsabilidade de aplicar diferente tipos de descontos e a responsabilidade de calculcar o percentual de desconto por fidelidade estão misturadas na mesma classe.

___

## Solução:
- Criar uma interface `ICalculadoraDescontoPorFidelidade` que define o percentual do desconto com base na fidelidade.
- Criar uma interface `ICalculadoraDesconto` O papel dessa interface é facilitar a criação de diferentes estratégias de desconto (Strategy)
- Criar uma interface `ICalculadoraDescontoStatusContaFactory` calcular opreço depois do desconto com base no status da conta.

