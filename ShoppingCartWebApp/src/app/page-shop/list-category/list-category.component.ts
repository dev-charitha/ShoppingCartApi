import { Component, OnInit } from '@angular/core';
//import { DataServiceService } from 'src/app/shared/data-service.service';
import { DataServiceService } from '../../shared/data-service.service';

@Component({
  selector: 'app-list-category',
  templateUrl: './list-category.component.html',
  styles: [],
})
export class ListCategoryComponent implements OnInit {
  constructor(private data: DataServiceService) {
    this.categories = data.categories;
  }

  public categories = [];

  ngOnInit(): void {
    //alert('test');
    this.data.loadCategories().subscribe((success) => {
      if (success) {
        this.categories = this.data.categories;
      }
    });
  }
}
