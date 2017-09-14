import { Component, Input, Output } from '@angular/core';

@Component({
  selector: 'card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent {
  @Input() mark: string;
  @Input() year: string;
  @Input() color: string;
  @Input() i: number;

  constructor() { }
}
