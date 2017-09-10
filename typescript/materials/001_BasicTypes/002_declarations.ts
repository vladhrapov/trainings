// var declaration

var a = 56;

// let

let b = "message...";

// type
type Person = { name: string, age?: number };

type FilterFunc = ([]: Person[], name: string) => Person[];

// Example

let peopleSortFunc: FilterFunc = (people: Person[] = [], name: string) => {
  return people.filter(person => person.name === name);
};

let otherSortFunc: ([]: Person[], name: string) => Person[] = peopleSortFunc;