import { Component, OnInit, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {
  @Input() mark: string;
  @Input() year: string;
  @Input() color: string;
  @Input() i: number;
  @Output() onBought = new EventEmitter<number>();

  constructor() { }

  ngOnInit() {
  }

  buyCar(i) {
    this.onBought.emit(i);
  }

}
