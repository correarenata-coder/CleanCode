# 🧹 Clean Code

**Clean Code** (ou “código limpo”) é um conceito da programação que se refere à escrita de códigos simples, claros, organizados e fáceis de entender — tanto para você quanto para outras pessoas.

Mais do que apenas “funcionar”, um código limpo deve ser:

- 📖 Fácil de ler
- 🔧 Fácil de manter
- 🚀 Fácil de evoluir
- 🧪 Fácil de testar

---
# 📌 Regras Básicas para Escrever Código Limpo

1. **Nomes significativos**: Use nomes de variáveis, funções e classes que descrevam claramente o que elas fazem ou representam. Evite abreviações confusas.
2. **Funções pequenas**: Mantenha as funções curtas e focadas em uma única tarefa. Se uma função fizer muitas coisas, considere dividi-la em funções menores.
3. **Evite comentários desnecessários**: O código deve ser autoexplicativo. Se você precisar de um comentário para explicar o que o código faz, talvez seja melhor reescrever o código para torná-lo mais claro.
4. **Consistência**: Siga um estilo de codificação consistente em todo o projeto. Isso inclui a formatação, a nomenclatura e a estrutura do código.
5. **Evite código duplicado**: (DRY - Don´t Repeat Yourself) Se você encontrar o mesmo código repetido em vários lugares, considere criar uma função ou classe para reutilizá-lo.
6. **Regra do Escoteiro**: Deixe o código mais limpo do que você o encontrou. Se você precisar modificar o código, aproveite a oportunidade para melhorá-lo.

# ✅ Benefícios do Clean Code

| Benefício | Descrição |
|---|---|
| 🔧 Facilidade de manutenção | Código limpo é mais fácil de entender e modificar, o que torna a manutenção mais rápida e menos propensa a erros. |
| 🐞 Redução de bugs | Código limpo é mais fácil de testar e depurar, o que pode ajudar a reduzir o número de bugs. |
| 👥 Melhor colaboração | Equipes entendem o código com mais facilidade |
| 🚀 Maior produtividade | Desenvolvedores trabalham mais rápido, o que pode aumentar a confiança dos desenvolvedores no código e reduzir o risco de erros. |
| 🔒 Mais confiança | Código previsível e seguro para evoluções |

---



# ❌ Exemplo de Código Sujo
```csharp
public class calc1
        {
            public decimal calculos(decimal val, int tip, int anos)
            {
                decimal res = 0;
                decimal desc = (anos > 5) ? (decimal)5 / 100 : (decimal)anos / 100;

                if (tip == 1) { res = val; }
                else if (tip == 2)
                {
                    res = (val - (0.1m * val)) - desc * (val - (0.1m * val));
                }
                else if (tip == 3)
                {
                    res = (0.7m * val) - desc * (0.7m * val);
                }
                else if (tip == 4)
                {
                    res = (val - (0.5m * val)) - desc * (val - (0.5m * val));
                }
                return res;
            }
        }
```
___

#  📚 Fontes de Estudo Possibilidades de mudança:
1- Nome da classe  "calc1 e do método "calculos" não são descritivos e não seguem a notação **PascalCase**. Poderíamos renomear a classe para algo como "CalculadoraDescontos" e o método para "CalcularValorFinal".
2- O método "calculos" tem muitos parâmetros e uma lógica complexa. Poderíamos dividir a lógica em métodos menores, cada um responsável por um tipo de cálculo específico.
3- O uso de números mágicos (como 1,2,3, 4, 0.1m, 0.7m, etc.) torna o código difícil de entender. Poderíamos usar constantes para dar nomes significativos a esses valores.
4- O método "calculos" tem uma estrutura de controle complexa (if-else) que pode ser difícil de seguir. Poderíamos usar um switch-case ou um dicionário para mapear os tipos de cálculo a funções específicas.
5- Falta significado nos nomes da classe, métodos e variáveis (calc1, calculos, tip, anos, res, desc). Poderíamos usar nomes mais descritivos para melhorar a legibilidade do código.


# 📚 Fontes de Estudo
- [Clean Code - Robert C. Martin](https://www.amazon.com.br/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882)
- [Clean Code - YouTube](https://www.youtube.com/watch?v=7EmboKQH8lM)
- [Macorati](https://www.youtube.com/watch?v=658YoSfpqJs&list=PLJ4k1IC8GhW3bLk1ElNmuHMTyLRwkZA7U&index=5)
