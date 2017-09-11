import { Component } from '@angular/core';

@Component({
  selector: 'app',
  template: `<h1>This is {{name}} component</h1>`
})
export class AppComponent {
  name = 'Application';
}