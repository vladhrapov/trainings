import { Color } from "./colors";

export default class Car {
  constructor(
    private mark: string,
    private year: number,
    private color: Color
  ) {}

  public open() {
    console.log("Car opened");
  }
}


