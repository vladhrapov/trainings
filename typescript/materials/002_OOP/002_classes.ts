enum Color { White, Yellow, Black };

// Explicit creation

class Car {
  private mark: string;
  private year: number;
  private color: Color;

  constructor(
    mark: string,
    year: number,
    color: Color
  ) {
    this.mark = mark;
    this.color = color;
    this.year = year;
  }

  public open() {
    console.log("Car opened");
  }
}

// Implicit creation

class Vehicle {
  constructor(
    private mark: string,
    private year: number,
    private color: Color
  ) {}

  public open() {
    console.log("Car opened");
  }
}