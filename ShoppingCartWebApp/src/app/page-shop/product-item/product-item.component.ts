import { Component, OnInit, Input } from '@angular/core';
import { Product } from 'src/app/shared/data-service.service';
import { MessengerService } from '../../shared/messenger.service';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styles: [],
})
export class ProductItemComponent implements OnInit {
  @Input() productItem: Product;

  constructor(private msg: MessengerService) {}

  ngOnInit(): void {}

  handleAddToCart() {
    this.msg.sendMsg(this.productItem);
  }
}
