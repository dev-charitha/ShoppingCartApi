import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable, from } from 'rxjs';
import { FormBuilder } from '@angular/forms';

export interface Category {
  id: number;
  categoryName: string;
  isActive: boolean;
  createdBy: string;
  createdDate: Date;
}

export interface Product {
  id: number;
  name: string;
  description: string;
  imagePath: string;
  qty: number;
  unitPrice: number;
  sellingPrice: number;
  discount: number;
  isActive: boolean;
  createdBy: string;
  createdDate: Date;
  categoryRefId: number;
}

@Injectable({
  providedIn: 'root',
})
export class DataServiceService {
  private REST_API_SERVER = 'http://localhost:5566/api';
  constructor(private httpClient: HttpClient, private fb: FormBuilder) {}

  formModel = this.fb.group({
    FirstName: [''],
    LastName: [''],
    Email: [''],
    HouseNo: [''],
    Street: [''],
    City: [''],
    Password: [''],
  });

  public register() {
    var body = {
      FirstName: this.formModel.value.FirstName,
      LastName: this.formModel.value.LastName,
      Email: this.formModel.value.Email,
      HouseNo: this.formModel.value.HouseNo,
      Street: this.formModel.value.Street,
      City: this.formModel.value.City,
      UserName: this.formModel.value.Email,
      Password: this.formModel.value.Password,
    };
    return this.httpClient.post(this.REST_API_SERVER + '/addcustomer', body);
  }

  //Return all category.
  public loadCategories(): Observable<Category[]> {
    return this.httpClient.get<Category[]>(
      this.REST_API_SERVER + '/getcategory'
    );
  }

  //Return all product.
  public loadProducts(): Observable<Product[]> {
    return this.httpClient.get<Product[]>(this.REST_API_SERVER + '/getproduct');
  }

  //return product by category.
  public loadProductsByCategory(id: number): Observable<Product[]> {
    return this.httpClient.get<Product[]>(
      this.REST_API_SERVER + '/getproductbycategory/' + id
    );
  }

  public loadProductsByCategoryId(id: any) {
    return this.httpClient.get<any>(
      this.REST_API_SERVER + '/getproductbycategoryid/' + id
    );
  }
}
