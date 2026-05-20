# Clean Code
Clean Code (ou “código limpo”) é um conceito da programação que se refere a escrever código simples, claro, organizado e fácil de entender, tanto por você quanto por outras pessoas.

Em vez de só “funcionar”, o código limpo também é fácil de ler, manter e melhorar.

___

## Regras básicas para escrever código limpo:

1. **Nomes significativos**: Use nomes de variáveis, funções e classes que descrevam claramente o que elas fazem ou representam. Evite abreviações confusas.
2. **Funções pequenas**: Mantenha as funções curtas e focadas em uma única tarefa. Se uma função fizer muitas coisas, considere dividi-la em funções menores.
3. **Evite comentários desnecessários**: O código deve ser autoexplicativo. Se você precisar de um comentário para explicar o que o código faz, talvez seja melhor reescrever o código para torná-lo mais claro.
4. **Consistência**: Siga um estilo de codificação consistente em todo o projeto. Isso inclui a formatação, a nomenclatura e a estrutura do código.
5. **Evite código duplicado**: (DRY - Don´t Repeat Yourself) Se você encontrar o mesmo código repetido em vários lugares, considere criar uma função ou classe para reutilizá-lo.
6. **Regra do Escoteiro**: Deixe o código mais limpo do que você o encontrou. Se você precisar modificar o código, aproveite a oportunidade para melhorá-lo.

## Benefícios:
1. Facilidade de manutenção: Código limpo é mais fácil de entender e modificar, o que torna a manutenção mais rápida e menos propensa a erros.
2. Redução de bugs: Código limpo é mais fácil de testar e depurar, o que pode ajudar a reduzir o número de bugs.
3. Melhoria na coloboração: Código limpo é mais fácil de ler e entender, o que facilita a colaboração entre os membros da equipe.
4. Aumento da produtividade: Código limpo é mais fácil de trabalhar, o que pode aumentar a produtividade dos desenvolvedores.
5. Maior confiança e segurança : Código limpo é mais fácil de entender e testar, o que pode aumentar a confiança dos desenvolvedores no código e reduzir o risco de erros.

## Exemplo de código sujo:
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

## Possibilidades de mudança:
1- Nome da classe  "calc1 e do método "calculos" não são descritivos e não seguem a notação **PascalCase**. Poderíamos renomear a classe para algo como "CalculadoraDescontos" e o método para "CalcularValorFinal".
2- O método "calculos" tem muitos parâmetros e uma lógica complexa. Poderíamos dividir a lógica em métodos menores, cada um responsável por um tipo de cálculo específico.
3- O uso de números mágicos (como 1,2,3, 4, 0.1m, 0.7m, etc.) torna o código difícil de entender. Poderíamos usar constantes para dar nomes significativos a esses valores.
4- O método "calculos" tem uma estrutura de controle complexa (if-else) que pode ser difícil de seguir. Poderíamos usar um switch-case ou um dicionário para mapear os tipos de cálculo a funções específicas.
5- Falta significado nos nomes da classe, métodos e variáveis (calc1, calculos, tip, anos, res, desc). Poderíamos usar nomes mais descritivos para melhorar a legibilidade do código.


Fonte :
- [Clean Code - Robert C. Martin](https://www.amazon.com.br/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882)
- [Clean Code - YouTube](https://www.youtube.com/watch?v=7EmboKQH8lM)
- [Macorati](https://www.youtube.com/watch?v=658YoSfpqJs&list=PLJ4k1IC8GhW3bLk1ElNmuHMTyLRwkZA7U&index=5)
