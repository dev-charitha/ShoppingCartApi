import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/shared/category.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styles: [],
})
export class AddComponent implements OnInit {
  constructor(public service: CategoryService) {}

  ngOnInit() {
    this.service.formModel.reset();
  }

  onSubmit() {
    this.service.registerCategory().subscribe(
      (res: any) => {
        if (res.succeded) {
          this.service.formModel.reset();
        }
      },
      (err) => {}
    );
  }
}
