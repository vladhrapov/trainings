class Vehicle {
  constructor(
    private mark: string,
    private year: number
  ) { }

  public open() {
    console.log("Car opened");
  }
}