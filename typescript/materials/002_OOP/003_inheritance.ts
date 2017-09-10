class Animal {
  readonly id: number;
  protected name: string;

  constructor(name: string) {
    this.name = name;
    this.id = 0;
  }

  move(distanceInMeters: number = 0) {
    console.log(`${this.name} moved ${distanceInMeters}m.`);
  }
}

class Snake extends Animal {
  constructor(name: string) {
    super(name);
  }

  move(distanceInMeters = 5) {
    console.log(this.name + " is slithering...");
    super.move(distanceInMeters);
  }
}

let sam = new Snake("Sammy the Python");

sam.move();
sam.move(5);

// Forbidden to set the readonly field
// can be set in place or in constructor
// sam.id = 8;