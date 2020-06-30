import { Component, OnInit } from '@angular/core';
import { DataServiceService } from '../../shared/data-service.service';

@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styles: [],
})
export class ListProductComponent implements OnInit {
  constructor(private data: DataServiceService) {
    this.products = data.products;
  }

  public products = [];

  ngOnInit(): void {
    this.data.loadProducts().subscribe((success) => {
      if (success) {
        this.products = this.data.products;
      }
    });
  }
}
