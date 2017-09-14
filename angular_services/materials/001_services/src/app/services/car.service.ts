import { Injectable } from '@angular/core';
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import { ICar } from "app/declarations/car.model";


@Injectable()
export class CarService {

  constructor(private http: Http) { }

  get cars() {
    return this.http
      .get("/assets/cars.json")
      .map((res: Response): any => {
        if(res.status === 200) {
          return res.json() as ICar[];
        } else {
          throw new Error("Smth wrong on server");
        }
      })
      .catch((err) => { console.log(err); return Observable.of(err) });
  }

}
