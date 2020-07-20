import { Component, OnInit } from '@angular/core';
import { DataServiceService } from '../shared/data-service.service';

@Component({
  selector: 'app-page-register',
  templateUrl: './page-register.component.html',
  styles: [],
})
export class PageRegisterComponent implements OnInit {
  constructor(public service: DataServiceService) {}

  ngOnInit(): void {}

  onSubmit() {
    this.service.register().subscribe(
      (res) => {},
      (err) => {
        console.log(err);
      }
    );
  }
}
