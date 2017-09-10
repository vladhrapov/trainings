// Base interface

interface IAnimal {
  name: string;
  age: number;
}

// Wide contract

interface IDog extends IAnimal {
  pows: number;
  bark: () => void;
}

class Dog implements IDog {
  public name;
  public age;
  public pows;

  constructor(name: string, age: number, pows: number) {
    this.name = name;
    this.age = age;
    this.pows = pows;
  }

  public bark() {
    console.log("bark, bark...");
  }
}

// Type inference
let animals: IAnimal[] = [ new Dog("Tom", 6, 4), { name: "Jerry", age: 3 } ];