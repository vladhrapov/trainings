namespace MyModule {
  export enum Color { White, Yellow, Black };

  class Car {}

  export class Vehicle {
    constructor(
      private mark: string,
      private year: number,
      private color: Color
    ) { }
  }

}

let vehicle = new MyModule.Vehicle("name", 2009, MyModule.Color.White);

// car is not available, need to export it as well
// MyModule.Car 