import { Component, OnInit } from '@angular/core';
import { DataServiceService } from '../shared/data-service.service';

@Component({
  selector: 'app-page-shop',
  templateUrl: './page-shop.component.html',
  styles: [],
})
export class PageShopComponent implements OnInit {
  public categories = [];
  public products = [];

  constructor(private dataService: DataServiceService) {}

  ngOnInit() {
    //this.getcategories();
    this.getproduct();
  }

  async getcategories() {
    this.dataService.loadCategories().subscribe((data: any[]) => {
      console.log(data);
      this.categories = data;
    });
  }

  async getproduct() {
    this.dataService.loadProducts().subscribe((data: any[]) => {
      console.log(data);
      this.products = data;
    });
  }
}
