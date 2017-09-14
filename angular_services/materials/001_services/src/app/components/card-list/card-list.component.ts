import { Component, OnInit } from '@angular/core';
import { Observable } from "rxjs/Observable";
import { CarService } from "../../services/car.service";

@Component({
  selector: 'card-list',
  templateUrl: './card-list.component.html',
  styleUrls: ['./card-list.component.css']
})
export class CardListComponent implements OnInit {
  cars: Observable<any>;

  constructor(private carService: CarService) { }

  ngOnInit() {
    this.cars = this.carService.cars;
  }
}
