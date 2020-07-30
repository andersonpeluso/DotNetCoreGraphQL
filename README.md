# GraphQL vs REST

## REST: O que é, benefícios e limitações
REST é uma arquitetura de design de API usada para implementar serviços da web. Os serviços da web RESTful permitem que os sistemas acessem e manipulem as representações textuais dos recursos da web usando um conjunto predefinido de operações sem estado (incluindo GET, POST, PUT e DELETE).
Além disso, é que a implementação do cliente e do servidor geralmente é feita de forma independente. Isso significa que o código do lado do cliente pode ser alterado sem afetar a maneira como o servidor opera e vice-versa. Dessa forma, eles são mantidos modulares e separados.
A idéia principal do REST é que tudo é um recurso identificado por uma URL. Na sua forma mais simples, você recuperaria um recurso inserindo uma solicitação GET na URL do recurso e obteria uma resposta JSON (ou algo semelhante, dependendo da API).
Pode ser algo como isto: **GET/filmes/1**

É importante observar que, com o REST, o tipo (ou forma) do recurso e a maneira como você busca esse recurso específico são acoplados. Portanto, você pode se referir ao snippet acima como o ponto final do usuário.

## Benefícios do REST
Uma das principais vantagens do REST é que o REST é escalável. A arquitetura desacopla cliente e servidor, o que permite que os desenvolvedores escalem produtos e aplicativos indefinidamente, sem muita dificuldade.
Além disso, as APIs REST oferecem uma grande flexibilidade. Na prática, como os dados não estão vinculados a recursos ou métodos, o REST pode lidar com diferentes tipos de chamadas e retornar diferentes formatos de dados. Isso permite que os desenvolvedores criem APIs que atendam às necessidades específicas do usuário, atendendo às necessidades de uma base de usuários diversificada.

## Limitações do REST
A maioria dos aplicativos móveis e da Web desenvolvidos hoje exige grandes conjuntos de dados que normalmente combinam recursos relacionados. O problema é que acessar todos esses dados para obter tudo o que você precisa usando uma API baseada em REST requer várias viagens de ida e volta. Por exemplo, se você quiser recuperar dados de dois pontos de extremidade diferentes, precisará enviar duas solicitações separadas para a API REST.
Outro problema comum que os desenvolvedores enfrentam com o REST é a busca excessiva ou insuficiente. Isso ocorre porque os clientes podem solicitar dados apenas atingindo pontos de extremidade que retornam estruturas de dados fixas. Devido a isso, eles não conseguem obter exatamente o que precisam e se deparam com um cenário de busca excessiva ou insuficiente.

- A busca excessiva ocorre quando o cliente baixa mais informações do que o aplicativo realmente precisa.
- A busca insuficiente é quando o nó de extremidade não fornece todas as informações necessárias, portanto o cliente precisa fazer várias solicitações para obter tudo o que o aplicativo precisa.

Por exemplo, digamos que você esteja trabalhando em uma tela para um aplicativo que precise exibir uma lista de usuários com seus nomes e aniversários. O aplicativo acessaria o terminal / members e, por sua vez, receberia uma estrutura de dados JSON com os dados do usuário. No entanto, a estrutura de dados conteria mais informações sobre os usuários do que o exigido pelo aplicativo. Por exemplo, ele pode retornar o nome do usuário, data de nascimento, endereço de email e número de telefone.

## GraphQL: O que é, benefícios e limitações

O GraphQL é uma arquitetura de design de API que adota uma abordagem diferente e mais flexível. A principal diferença entre o GraphQL e o REST é que o GraphQL não lida com recursos dedicados. Em vez disso, tudo é considerado um gráfico que implica que está conectado.
O que isso significa em termos práticos é que você pode personalizar sua solicitação para atender exatamente aos seus requisitos usando a linguagem de consulta GraphQL. Além disso, permite combinar diferentes entidades em uma única consulta.

Uma consulta GraphQL para um aplicativo de listagens de filmes pode ser algo assim:
{
  usuario (id: 1) {
    id
    nome
  }
}

## Benefícios do GraphQL
Toda vez que você modifica a interface do usuário do aplicativo, há uma boa chance de que os requisitos de dados também sejam alterados, ou seja, você precisará buscar mais dados ou menos dados do que antes. **O GraphQL possibilita iterações rápidas de produtos no front-end**, pois permite que os desenvolvedores façam alterações no lado do cliente sem mexer com o servidor.
Além disso, com o GraphQL, os desenvolvedores podem **obter informações sobre os dados solicitados no back-end** e como os dados disponíveis estão sendo usados. Isso ocorre porque, com o GraphQL, cada cliente especifica exatamente quais informações eles precisam. Dessa forma, os desenvolvedores podem descontinuar os campos que os clientes não usam mais para melhorar o desempenho da API.
O GraphQL define os recursos das APIs usando um **sistema de tipos fortes** que essencialmente informa ao cliente como ele pode acessar dados. O principal benefício desse esquema é que as equipes de front-end e back-end conhecem a estrutura dos dados e, portanto, podem trabalhar independentemente.
Limitações do GraphQL
A principal desvantagem do GraphQL é que ele usa um único terminal em vez de seguir a especificação HTTP para armazenamento em cache. O armazenamento em cache no nível da rede é importante, pois pode reduzir a quantidade de tráfego para um servidor ou manter os dados acessados ​​com frequência perto do cliente via CDN.
Além disso, não é a melhor solução para aplicativos simples , pois agrega complexidade - com tipos, consultas, resolvedores - a coisas que poderiam ser feitas de maneira muito mais simples com o REST.

## Semelhanças e diferenças
GraphQL e REST são semelhantes em alguns aspectos. Mais especificamente:
- Ambos são baseados no conceito de um recurso e podem especificar IDs para recursos.
- Ambos podem ser buscados através de uma solicitação HTTP.
- Ambos podem retornar dados JSON na solicitação.
E aqui estão algumas das maneiras pelas quais o GraphQL e o REST são diferentes:
- A busca de dados com o REST causa problemas de sobrecuperação e subexecução, embora isso simplesmente não seja possível com o GraphQL.
- O ponto final que você chama no REST é a identidade desse objeto, enquanto no GraphQL, a identidade do objeto não tem nada a ver com a maneira como você o busca. Em outras palavras, no REST você define o objeto no Backend e no GraphQL você "define" esse objeto no Frontend.
- Com o REST, o servidor determina a forma e o tamanho do recurso, enquanto, no GraphQL, o servidor simplesmente declara os recursos disponíveis e o cliente pode solicitar exatamente o que precisa.
- O REST coloca o cache automaticamente em vigor, enquanto o GraphQL não possui um sistema de cache automático.
- O tratamento de erros no REST é muito mais simples quando comparado ao GraphQL, que normalmente fornece um código de status 200 OK .
