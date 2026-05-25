# 🎬 ProjectLetterBoxd

Um programa de console em C# para gerenciar sua coleção pessoal de filmes, inspirado no [Letterboxd](https://letterboxd.com/).

---

## 📋 Funcionalidades

- ➕ **Adicionar filme** — registre nome, diretor, ano de lançamento e sua avaliação em estrelas
- 📃 **Listar filmes** — veja todos os filmes cadastrados, ordenados alfabeticamente
- 🗑️ **Remover filme** — exclua um filme da sua coleção pelo nome
- 🔍 **Pesquisar por filme** — encontre um filme específico pelo nome
- 🎥 **Pesquisar por diretor** — veja todos os filmes de um determinado diretor
- ⭐ **Ranking por estrelas** — liste seus filmes do melhor ao pior avaliado
- 💾 **Persistência de dados** — sua coleção é salva em arquivo e carregada automaticamente a cada execução

---

## ⭐ Sistema de Avaliação

As avaliações seguem o padrão de 1 a 5 estrelas:

| Valor | Estrelas |
|-------|----------|
| 1 | Uma |
| 2 | Duas |
| 3 | Três |
| 4 | Quatro |
| 5 | Cinco |

---

## 💾 Persistência de Dados

Os filmes são salvos automaticamente no arquivo `filmes.csv`, localizado em:

```
SeuProjeto/bin/Debug/net8.0/filmes.csv
```

O arquivo é criado automaticamente na primeira execução. Ao abrir o programa novamente, todos os filmes cadastrados anteriormente são carregados automaticamente.

**Formato do arquivo:**
```
Nome;Diretor;Ano;Estrelas
Inception;Christopher Nolan;2010;5
Parasita;Bong Joon-ho;2019;5
```

---

## 🗂️ Estrutura do Projeto

```
ProjectLetterBoxd/
│
├── Program.cs               # Ponto de entrada, menu principal
│
└── Filmes/
    ├── Filmes.cs            # Modelo de dados do filme
    ├── Estrelas.cs          # Enum de avaliação (1 a 5 estrelas)
    ├── MetodosDosFilmes.cs  # Lógica de negócio e persistência
    └── ExceptionFilmes.cs   # Exceção personalizada
```

---

## 🚀 Como Executar

**Pré-requisitos:**
- [.NET SDK](https://dotnet.microsoft.com/download) instalado (versão 6 ou superior)

**Passos:**

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/ProjectLetterBoxd.git

# Entre na pasta do projeto
cd ProjectLetterBoxd

# Execute o projeto
dotnet run
```

---

## 🖥️ Exemplo de Uso

```
COLEÇÃO DE FILMES DO USUÁRIO.

Digite o número correspondente a ação desejada:

1 - Adicionar filme
2 - Listar filmes
3 - Remover filme
4 - Pesquisar por filme
5 - Pesquisar por diretor
6 - Ranquear filmes por estrelas
0 - Sair

Opção: 1
Conte me mais sobre esse filme:
Digite o nome do filme: Duna
Qual seu diretor: Denis Villeneuve
Ano de lançamento: 2021
Quantas estrelas você daria para o filme (1 a 5): 5
Filme adicionado com sucesso.
```

---

## 🛠️ Tecnologias

- **Linguagem:** C#
- **Plataforma:** .NET
- **Interface:** Console
- **Armazenamento:** Arquivo CSV local

