# Intenção

**Separar a construção de um objeto complexo da sua representação de modo que o mesmo processo de construção possa criar diferentes representações.**

## Visao Geral

- O padrão sugere a separação do codigo que cria e o código que usa o objeto
- Trata da cricação de objetos complexos
  - Construtores muito complexos
  - Composição de vários objetos
  - Algoritmo de criação do objeto complexo
- Permite a crição de um objeto em etapas
- Permite method chaining
- O objeto final pode varias de acordo com a necessidade

## Exemplo

```ts
export class PersonBuilder {
  private person = new Person();

  newPerson(): void {
    this.person = new Person();
  }

  setName(name: string): PersonBuilder {
    this.person.name = name;
    return this;
  }

  setAge(age: number): PersonBuilder {
    this.person.age = age;
    return this;
  }

  getPerson(): Person {
    return this.person;
  }
}

const personBuilder = new PersonBuilder();
const person = personBuilder.setName("John").setAge(20).getPerson();
personBuilder.newPerson();
const person2 = personBuilder.setName("Mary").setAge(30).getPerson();
```

## Pros e Contras

| Pros                                                       | Contras           |
| ---------------------------------------------------------- | ----------------- |
| Separa a construção do objeto da sua representação         | Pode ser complexo |
| Permite a criação de objetos em etapas                     |                   |
| Permite a criação de objetos com diferentes representações |                   |
| Permite method chaining                                    |                   |
| Ajuda na aplicação do SRP e do OCP                         |                   |
