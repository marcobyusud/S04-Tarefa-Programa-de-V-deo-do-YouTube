# Design dos Programas de Fundamentos

Este documento apresenta meu design individual para os dois programas. Os dados serão criados diretamente no `Program.cs`; não haverá menu nem entrada do usuário.

## Programa 1: Vídeos do YouTube

### O que o programa faz

O programa guarda informações sobre vídeos e comentários. Depois, percorre uma lista de vídeos e mostra os dados de cada vídeo, a quantidade de comentários e o texto de cada comentário. O programa não acessa o YouTube.

### Classes e responsabilidades

| Classe | Responsabilidade |
| --- | --- |
| `Video` | Guardar o título, autor, duração e comentários de um vídeo. Também informa quantos comentários existem. |
| `Comentario` | Guardar o nome da pessoa e o texto de um comentário. |

### Diagrama de classes

```mermaid
classDiagram
    class Video {
        -string titulo
        -string autor
        -int duracaoSegundos
        -List~Comentario~ comentarios
        +Video(titulo, autor, duracaoSegundos)
        +AdicionarComentario(comentario)
        +ObterQuantidadeComentarios() int
        +ObterComentarios() List~Comentario~
    }

    class Comentario {
        -string nomePessoa
        -string texto
        +Comentario(nomePessoa, texto)
        +ObterNomePessoa() string
        +ObterTexto() string
    }

    Video "1" *-- "0..*" Comentario : contém
```

### Como o programa será executado

1. `Program.cs` cria de 3 a 4 objetos `Video` com título, autor e duração.
2. Para cada vídeo, cria e adiciona de 3 a 4 objetos `Comentario`.
3. Coloca os vídeos em uma lista.
4. Percorre a lista e mostra título, autor, duração e quantidade de comentários.
5. Para cada vídeo, percorre seus comentários e mostra o nome e o texto de cada um.

```mermaid
flowchart TD
    A[Iniciar programa] --> B[Criar videos e comentarios]
    B --> C[Adicionar videos a uma lista]
    C --> D{Ainda ha videos?}
    D -- Sim --> E[Mostrar dados do video]
    E --> F[Mostrar cada comentario]
    F --> D
    D -- Nao --> G[Encerrar]
```

## Programa 2: Pedidos Online

### O que o programa faz

O programa guarda pedidos com produtos e clientes. Ele calcula o preço total, incluindo o envio, e cria uma etiqueta de embalagem e uma etiqueta de envio para cada pedido.

### Classes e responsabilidades

| Classe | Responsabilidade |
| --- | --- |
| `Produto` | Guardar nome, identificação, preço e quantidade. Calcular o custo total daquele produto. |
| `Endereco` | Guardar rua, cidade, estado e país. Informar se o endereço fica nos EUA e formatar o endereço completo. |
| `Cliente` | Guardar nome e endereço. Perguntar ao endereço se o cliente mora nos EUA. |
| `Pedido` | Guardar os produtos e o cliente. Calcular o total e criar as etiquetas de embalagem e envio. |

Todas as variáveis membro serão privadas. Os construtores inicializam os objetos e os métodos públicos permitem consultar os dados ou pedir que os cálculos sejam feitos.

### Diagrama de classes

```mermaid
classDiagram
    class Produto {
        -string nome
        -string identificacao
        -decimal preco
        -int quantidade
        +Produto(nome, identificacao, preco, quantidade)
        +CalcularCustoTotal() decimal
        +ObterNome() string
        +ObterIdentificacao() string
    }

    class Endereco {
        -string rua
        -string cidade
        -string estado
        -string pais
        +Endereco(rua, cidade, estado, pais)
        +EhDosEUA() bool
        +ObterEnderecoCompleto() string
    }

    class Cliente {
        -string nome
        -Endereco endereco
        +Cliente(nome, endereco)
        +EhDosEUA() bool
        +ObterNome() string
        +ObterEndereco() Endereco
    }

    class Pedido {
        -List~Produto~ produtos
        -Cliente cliente
        +Pedido(cliente)
        +AdicionarProduto(produto)
        +CalcularTotal() decimal
        -CalcularEnvio() decimal
        +CriarEtiquetaEmbalagem() string
        +CriarEtiquetaEnvio() string
    }

    Pedido "1" *-- "1..*" Produto : contém
    Pedido "1" --> "1" Cliente : pertence a
    Cliente "1" *-- "1" Endereco : tem
```

### Regras de cálculo e etiquetas

- O custo de cada produto é `preço × quantidade`.
- O envio custa `$5` se o cliente mora nos EUA e `$35` caso contrário.
- O total do pedido é a soma dos custos dos produtos mais uma cobrança de envio.
- A etiqueta de embalagem lista o nome e a identificação de cada produto.
- A etiqueta de envio mostra o nome do cliente e o endereço completo.

### Como o programa será executado

1. `Program.cs` cria objetos `Endereco` e `Cliente`.
2. Cria pelo menos dois objetos `Pedido`, cada um com 2 ou 3 produtos.
3. Para cada pedido, solicita o total, a etiqueta de embalagem e a etiqueta de envio.
4. Mostra esses resultados na tela.

```mermaid
flowchart TD
    A[Iniciar programa] --> B[Criar enderecos e clientes]
    B --> C[Criar pedidos e produtos]
    C --> D{Ainda ha pedidos?}
    D -- Sim --> E[Calcular total e envio]
    E --> F[Criar etiquetas]
    F --> G[Mostrar total e etiquetas]
    G --> D
    D -- Nao --> H[Encerrar]
```