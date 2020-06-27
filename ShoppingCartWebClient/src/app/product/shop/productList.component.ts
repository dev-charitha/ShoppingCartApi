import { Component, OnInit } from '@angular/core';
import { DataService } from './shared/dataService';
@Component({
  selector: 'product-list',
  templateUrl: 'productList.component.html',
  styles: [],
})
export class ProductList implements OnInit {
  //-------
  constructor(private data: DataService) {
    this.products = data.products;
    this.categories = data.categories;
  }

  public products = [];
  public categories = [];

  ngOnInit(): void {
    this.data.loadProducts().subscribe((success) => {
      if (success) {
        this.products = this.data.products;
      }
    });

    this.data.loadCategories().subscribe((success) => {
      if (success) {
        this.categories = this.data.categories;
      }
    });
  }
}
