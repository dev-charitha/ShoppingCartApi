import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class DataServiceService {
  constructor(private http: HttpClient) {}

  readonly BaseURI = 'http://localhost:5000/api';

  public categories = [];
  public products = [];

  loadCategories() {
    return this.http.get(this.BaseURI + '/categories').pipe(
      map((data: any[]) => {
        this.categories = data;
        return true;
      })
    );
  }

  loadProducts() {
    return this.http.get(this.BaseURI + '/products').pipe(
      map((data: any[]) => {
        this.products = data;
        return true;
      })
    );
  }
}
