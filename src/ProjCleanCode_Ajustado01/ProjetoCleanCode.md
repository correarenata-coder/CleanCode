# 🧹 Clean Code

___

#  🏷️ Alguns itens para ajustar:

## **Identificadores** 
É um nome atribuído a variáveis, funções, classes, etc. Eles devem ser claros e descritivos para facilitar a compreensão do código.

### ✅ Boas práticas
Utilize nomes que representem claramente o propósito do elemento. Exemplo: Cliente, nomeCliente, valorTotal, CalcularTotalPedido(), codigoDoProduto

### ❌ Evite nomes genéricos ou sem significado
Exemplo : a, s, i , val, temp, x, data, calc, etc

### ⚠️ Atenção com diferenças apenas de maiúsculas/minúsculas
Evitar usa identificadores com o mesmo nome alternando entre maiúsculas e minúsculas (ex: cliente, Cliente, CLIENTE) para evitar confusão.

# 📌 Regras Gerais para Identificadores	
- Use nomes significativos e descritivos.
- Use a notação PascalCase para classes e métodos (ex: Cliente, CalcularTotalPedido).
- Use a notação camelCase para variáveis e parâmetros (ex: nomeCliente, valorTotal).
- Evite abreviações confusas ou genéricas.
- Devem começar com uma letra ou um sublinhado (_), e não podem conter espaços ou caracteres especiais.
- Não usar palavras reservadas da linguagem de programação como identificadores (ex: class,int, double, class, public, if, etc).

### 🔒 Para constantes:
Usar todas as letras maiúsculas e separar as palavras com sublinhados (ex: TAXA_DE_DESCONTO, VALOR_MAXIMO).

### 🔹 Sublinhado (_):
Usado no início do nome de variáveis privadas em algumas convenções de codificação (ex: _nomeCliente) para indicar que são membros privados da classe.


# 📋 Resumo das Convenções
| Elemento      | Convenção                                                                 | Exemplo |
|---------------|----------------------------------------------------------------------------|----------|
| **Classe**    | Substantivos descritivos em **PascalCase**, representando o que a classe é ou faz | `CalculadoraDeDesconto` |
| **Métodos**   | Verbos descritivos em **PascalCase**, indicando a ação que o método realiza | `CalcularDesconto()` |
| **Variáveis** | Substantivos descritivos em **camelCase**, representando o que a variável armazena | `precoDoProduto` |
| **Parâmetros**| Substantivos descritivos em **camelCase**, indicando o que o parâmetro representa | `tempoDaContaEmAnos` |
| **Constantes**| Substantivos descritivos em letras maiúsculas, separados por `_`, representando valores fixos e imutáveis | `TAXA_DE_DESCONTO` |

## Classe

| Antes | Depois |
|---|---|
| `calc1` | `CalculadoraDeDesconto` |

---

## Método

| Antes | Depois |
|---|---|
| `calculos` | `CalcularDesconto` |

---
## Parâmetros

| Antes | Depois |
|---|---|
| `val` | `precoDoProduto` |
| `tip` | `statusDaConta` |
| `anos` | `tempoDaContaEmAnos` |

---

## Variáveis

| Antes | Depois |
|---|---|
| `res` | `precoDepoisDoDesconto` |
| `desc` | `percentualDeDescontoPorFidelidade` |

---		
## 

---

# ✅ Resultado

Com nomes melhores, o código fica:

- 📖 Mais legível
- 🧠 Mais fácil de entender
- 🔧 Mais simples de manter
- 👥 Melhor para trabalhar em equipe

O código deve explicar sozinho o que está acontecendo.