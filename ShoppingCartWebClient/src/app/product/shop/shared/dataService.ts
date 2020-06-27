import { HttpClientModule } from '@angular/common/http';

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { from } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class DataService {
  constructor(private http: HttpClient) {}
  public products = [];
  public categories = [];

  loadProducts() {
    return this.http.get('http://localhost:5000/api/products').pipe(
      map((data: any[]) => {
        this.products = data;
        return true;
      })
    );
  }

  loadCategories() {
    return this.http.get('http://localhost:5000/api/categories').pipe(
      map((data: any[]) => {
        this.categories = data;
        return true;
      })
    );
  }
}
