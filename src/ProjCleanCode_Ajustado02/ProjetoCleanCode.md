# 🧹 Clean Code

___

#  🏷️ Alguns itens para ajustar:
## **Números mágicos**
- Números mágicos são valores numéricos que aparecem no código sem contexto ou explicação, tornando o código difícil de entender e manter. Eles podem ser substituídos por constantes com nomes significativos para melhorar a legibilidade do código.


### ✅ Boas práticas
- Use constantes para representar valores fixos e imutáveis, dando-lhes nomes descritivos que expliquem seu propósito. Exemplo: `const decimal TAXA_DE_DESCONTO = 0.1m;` ou `const int TIPO_DESCONTO_PADRAO = 1;`
- Centralizar as constantes em uma classe ou arquivo específico para facilitar a manutenção e evitar a duplicação de valores. Exemplo: 
```csharp
public static class Constantes
{
    public const decimal TAXA_DE_DESCONTO = 0.1m;
    public const int TIPO_DESCONTO_PADRAO = 1;
}
```
- Use enumerações para representar conjuntos de valores relacionados, como tipos de desconto. Exemplo: 
```csharp
public enum TipoDesconto
{
    Comum,
    Premium,
    VIP
}  
```

-- Criar funções e/ou métodos para cálculos específicos, evitando o uso de números mágicos diretamente na lógica do código. Exemplo: 
```csharp
    private decimal CalcularDesconto(decimal preco, int tipo, int anos)
    {
        // Lógica de cálculo do desconto
    }
```