<h1>Composite-Pattern</h1>
<img src="https://refactoring.guru/images/patterns/content/composite/composite.png?id=73bcf0d94db360b636cd745f710d19db" width="200px"/>
<p>Objetivo desse pequeno projeto é mostrar como se implementação de um Design Pattern.</p>
<h3>Tecnologias Ultilizadas</h3>
<div><img width="40" height="40" src="https://img.icons8.com/color/48/net-framework.png" alt="net-framework"/> <img width="40" height="40" src="https://img.icons8.com/?size=256&id=Fycm8TUhWmFU&format=png" alt="C SHARP"/> <img width="40" height="40" src="https://img.icons8.com/?size=256&id=ezj3zaVtImPg&format=png" alt="VSCODE COMUNITY"/></div>
<h3>Explicação</h3>
<p>Fala devs, beleza? Hoje vou tentar explicar Design Patterns de uma maneira bem introdutória. usarei como exemplo um Pattern conhecido como Composite para mostrar como funciona a implementação de um Pattern na prática. 
Lembrando que um Padrão visa resolver um problema especifico, ou seja é importante pensar primeiro no problema a ser resolvido antes de usar determinado padrão.
O Composite é um padrão de projeto estrutural que permite tratar de maneira uniforme os objetos individuais e composições de objetos, formando uma estrutura hierárquica. Por Exemplo:
Em um estabelecimento você possui duas formas de comprar um produto, sendo ela por unidade desse produto ou um agregado com vários produtos (estrutura). Essa estrutura se comporta como um produto, ela pode dizer seu preço delegando o seu valor, somando assim os custos das unidades filhas e utilizando como seu próprio. 
Definimos uma interface IProduct que será herdada tanto pela unidade (Class Product) quanto pela estrutura ( Class combo). Os métodos em comum que serão implementado por elas são: GetProductDetails() e o GetProductPrice() .
A unidade (Class Product) por sua vez possui a implementação dos métodos definidos pela interface, por ser uma única unidade, apenas retorna o seu próprio valor e detalhes, já a estrutura (Class Combo), atuando como Composite, seu valor é delegado para as unidades que há dentro dela. Ou seja, se houver 5 unidades de produtos, cada uma com um valor “5”o valor total da estrutura será de 25.
Como a classe Combo possui uma lista dentro de si do tipo IProduct, ela pode suportar até mesmo outros combos dentro dela. Com isso, a classe que está consumindo o produto sabe de forma mais transparente se é um combo ou uma agregação de combos.</p>

