/*
*   Basic Types in typescript
*
*   1) Boolean
*   2) Number
*   3) String
*   4) Array
*   5) Tuple
*   6) Enum
*   7) Null
*   8) Undefined
*   9) Void
*   10) Never
*   11) Any
*/

let isFinished: boolean = true;

let count: number = 10;

let message: string = "Hello guys";

let animals: Array<string> = [ "dog", "cat" ];
let cars: string[] = [ "BMW", "VW" ];

let guy: [ string, number ] = [ "Tom", 25 ];

enum Money {
  UAH,
  Dollar,
  Euro
};

enum Color {
  Red = 1,
  Green,
  Blue
}

let empty: null = null;

let nothing: undefined = undefined;

function func(): void {}

function func2(): never { throw new Error(""); }

function infiniteLoop(): never {
  while (true) {
  }
}

let dynamic: any = 67;
dynamic = "some string";
dynamic = func;