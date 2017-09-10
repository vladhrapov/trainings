class Car {
  private mark: string;
  private year: number;

  constructor(
    mark: string,
    year: number
  ) {
    this.mark = mark;
    this.year = year;
  }

  public open() {
    console.log("Car opened");
  }
}
