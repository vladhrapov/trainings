import { Component, OnChanges, OnInit, DoCheck, AfterContentInit, AfterContentChecked, AfterViewInit, AfterViewChecked, OnDestroy } from '@angular/core';

@Component({
  selector: 'card-list',
  templateUrl: './card-list.component.html',
  styleUrls: ['./card-list.component.css']
})
export class CardListComponent implements OnChanges, OnInit, DoCheck, AfterContentInit, AfterContentChecked, AfterViewInit, AfterViewChecked, OnDestroy {

  constructor() { }

  ngOnChanges() {
    console.log("ngOnChanges()");
  }

  ngOnInit() {
    console.log("ngOnInit()");
  }

  ngDoCheck() {
    console.log("ngDoCheck()");
  }

  ngAfterContentInit() {
    console.log("ngAfterContentInit()");
  }

  ngAfterContentChecked() {
    console.log("ngAfterContentChecked()");
  }

  ngAfterViewInit() {
    console.log("ngAfterViewInit()");
  }

  ngAfterViewChecked() {
    console.log("ngAfterViewChecked()");
  }

  ngOnDestroy() {
    console.log("ngOnDestroy()");
  }

  cars = [
    {
      id: 0,
      mark: "BMW",
      year: 2009,
      color: "red"
    },
    {
      id: 1,
      mark: "BMW",
      year: 2009,
      color: "red"
    },
    {
      id: 2,
      mark: "BMW",
      year: 2009,
      color: "red"
    },
    {
      id: 3,
      mark: "BMW",
      year: 2009,
      color: "red"
    },
    {
      id: 4,
      mark: "BMW",
      year: 2009,
      color: "red"
    }
  ];

  onCarBought(i) {
    console.log("---------");
    this.cars = this.cars.filter(car => car.id !== i);
  }

}
