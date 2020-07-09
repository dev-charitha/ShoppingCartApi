import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class DataServiceService {
  private REST_API_SERVER = 'http://localhost:5000/api';

  constructor(private httpClient: HttpClient) {}

  public loadCategories() {
    return this.httpClient.get(this.REST_API_SERVER + '/categories');
  }

  public loadProducts() {
    return this.httpClient.get(this.REST_API_SERVER + '/products');
  }
}
