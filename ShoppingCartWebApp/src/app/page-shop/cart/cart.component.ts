import { Component, OnInit } from '@angular/core';
import { MessengerService } from '../../shared/messenger.service';
import { from } from 'rxjs';
import { Product } from 'src/app/shared/data-service.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styles: [],
})
export class CartComponent implements OnInit {
  cartItems = [];

  cartTotal = 0;

  constructor(private msg: MessengerService) {}

  ngOnInit() {
    this.msg.getMsg().subscribe((product: Product) => {
      this.addProductToCart(product);
    });
  }

  addProductToCart(product: Product) {
    let productExists = false;

    for (let i in this.cartItems) {
      if (this.cartItems[i].id === product.id) {
        this.cartItems[i].qty++;
        productExists = true;
        break;
      }
    }

    if (!productExists) {
      this.cartItems.push({
        id: product.id,
        name: product.name,
        qty: 1,
        sellingPrice: product.sellingPrice,
      });
    }

    // if(this.cartItems.length===0)
    // {
    //   this.cartItems.push({
    //     id: product.id,
    //     name: product.name,
    //     qty: 1,
    //     sellingPrice: product.sellingPrice,
    //   });
    // }else{
    //   for (let i in this.cartItems) {
    //     if (this.cartItems[i].id === product.id) {
    //       this.cartItems[i].qty++;
    //     } else {
    //       this.cartItems.push({
    //         id: product.id,
    //         name: product.name,
    //         qty: 1,
    //         sellingPrice: product.sellingPrice,
    //       });
    //     }
    //   }
    // }

    this.cartTotal = 0;
    this.cartItems.forEach((item) => {
      this.cartTotal += item.qty * item.sellingPrice;
    });
  }
}
