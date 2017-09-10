// Interface Types

enum Color {
  Red,
  Green,
  Blue
}

interface ICar {
  mark: string;
  year: number;
  color?: Color;
}

let cars: ICar[] = [ { mark: "BMW", year: 2007 }, { mark: "VW", year: 2009, color: Color.Red } ];


// Interface indexers

interface ICarCollection {
  [index: number]: ICar;
}

let collection: ICarCollection = cars;