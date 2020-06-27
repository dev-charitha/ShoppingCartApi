import { Component, OnInit } from '@angular/core';
import { title } from 'process';
import {} from './shop/productList.component';
import { from } from 'rxjs';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styles: [],
})
export class ProductComponent implements OnInit {
  title = 'Product List';
  constructor() {}

  ngOnInit(): void {}
}
