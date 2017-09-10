class Animal {
  pows: number;
}

//Generic Collection

interface ICollection<T> {
  [index: number]: T;
}

let numbers: ICollection<number> = [1, 2, 3];
let animals: ICollection<Animal> = [new Animal(), new Animal()];