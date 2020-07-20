import { Component, OnChanges, OnInit } from '@angular/core';
import {
  DataServiceService,
  Category,
  Product,
} from '../shared/data-service.service';
import * as CryptoJS from 'crypto-js';

@Component({
  selector: 'app-page-shop',
  templateUrl: './page-shop.component.html',
  styles: [],
})
export class PageShopComponent implements OnInit {
  public categories: Category[] = [];
  public products: Product[] = [];

  key: string = CryptoJS.enc.Utf8.parse('8080808080808080');
  iv: string = CryptoJS.enc.Utf8.parse('8080808080808080');

  constructor(private dataService: DataServiceService) {}

  ngOnInit() {
    this.getcategories();
    this.getproduct();
  }

  async getcategories() {
    this.dataService.loadCategories().subscribe((data: any[]) => {
      //console.log(data);
      this.categories = data;
    });
  }

  async getproduct() {
    this.dataService.loadProducts().subscribe((data: any[]) => {
      //console.log(data);
      this.products = data;
    });
  }

  async onClickCategory(event) {
    var target = event.target || event.srcElement || event.currentTarget;
    var idAttr = target.attributes.id;
    var id = idAttr.nodeValue;

    this.dataService.loadProductsByCategory(id).subscribe((data: any[]) => {
      console.log(data);
      this.products = data;
    });
  }

  async onClickCategory2(event) {
    var target = event.target || event.srcElement || event.currentTarget;
    var idAttr = target.attributes.id;
    var id = idAttr.nodeValue;

    var encryptedId = CryptoJS.AES.encrypt(
      CryptoJS.enc.Utf8.parse(id),
      this.key,
      {
        keySize: 128 / 8,
        iv: this.iv,
        mode: CryptoJS.mode.CBC,
        padding: CryptoJS.pad.Pkcs7,
      }
    );

    var encodedEncryptedId = btoa(encryptedId.toString());
    this.dataService
      .loadProductsByCategoryId(encodedEncryptedId)
      .subscribe((data) => {
        var decodeString = CryptoJS.AES.decrypt(data, this.key, {
          keySize: 128 / 8,
          iv: this.iv,
          mode: CryptoJS.mode.CBC,
          padding: CryptoJS.pad.Pkcs7,
        });

        var decodedData = JSON.parse(decodeString.toString(CryptoJS.enc.Utf8));
        this.products = decodedData.map((item: any) => ({
          id: item.Id,
          name: item.Name,
          description: item.Description,
          imagePath: item.ImagePath,
          qty: item.Qty,
          unitPrice: item.UnitPrice,
          sellingPrice: item.SellingPrice,
          discount: item.Discount,
          isActive: item.IsActive,
          createdBy: item.CreatedBy,
          createdDate: item.CreatedDate,
          categoryRefId: item.CategoryRefId,
        }));
        //console.log(this.products);
      });
  }
}
